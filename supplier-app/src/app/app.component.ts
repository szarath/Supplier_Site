import { Component, OnInit } from '@angular/core';
import { Supplier } from './supplier';
import { SupplierService } from './supplier.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent implements OnInit {
  pagedSuppliers: Supplier[] = [];
  suppliers: Supplier[] = [];
  newSupplier: Supplier = { id: 0, code: 0, name: '', telephoneNo: '' };
  selectedSupplier: Supplier | null = null;
  selectedSupplierNames: Supplier[] | null = null;
  title = 'Supplier view';
  pageSize = 10;
  currentPage = 1;
  totalData = 0;
  Math = Math;

  constructor(private supplierService: SupplierService) {}

  get pageNumbers() {
    return Array(Math.ceil(this.totalData / this.pageSize)).fill(0).map((x, i) => i + 1);
  }

  setCurrentPage(pageNumber: number) {
    this.currentPage = pageNumber;
    this.getSuppliers();
  }

  ngOnInit(): void {
    this.getSuppliers();
  }

  getSuppliers() {
    const startIndex = (this.currentPage - 1) * this.pageSize;
    const endIndex = startIndex + this.pageSize;
    this.supplierService.getSuppliers().subscribe(suppliers => {
      this.suppliers = suppliers;
      this.totalData = this.suppliers.length;
      this.pagedSuppliers = this.suppliers.slice(startIndex, endIndex);
    });
  }

  addSupplier(): void {
    this.supplierService.addSupplier(this.newSupplier).subscribe(supplier => {
      this.suppliers.push(supplier);
      this.newSupplier = { id: 0, code: 0, name: '', telephoneNo: '' };
      this.totalData += 1; 
      this.getSuppliers(); 
    });
  }
  
  deleteSupplier(id: number): void {
    this.supplierService.deleteSupplier(id).subscribe(() => {
      this.suppliers = this.suppliers.filter(supplier => supplier.id !== id);
      this.getSuppliers();
    });
  }
  

  getSupplierById(id: number): void {
    this.supplierService.getSupplier(id).subscribe(supplier => {
      this.selectedSupplier = supplier;
    });
  }

  getSupplierByName(name: string): void {
    this.supplierService.getSupplierName(name).subscribe(supplier => {
      this.selectedSupplierNames = supplier;
    });
  }

  updateSupplier(): void {
    if (this.selectedSupplier) {
      this.supplierService.updateSupplier(this.selectedSupplier).subscribe(supplier => {
        const index = this.suppliers.findIndex(s => s.id === supplier.id);
        this.suppliers[index] = supplier;
        this.selectedSupplier = null;
      });
    }
  }
}
