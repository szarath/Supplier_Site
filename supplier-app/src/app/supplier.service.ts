
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Supplier } from './supplier';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {
  private apiUrl = 'https://localhost:7257/api/Supplier';

  constructor(private http: HttpClient) { }

  getSuppliers(): Observable<Supplier[]> {
    return this.http.get<Supplier[]>(this.apiUrl);
  }

  getSupplier(id: number): Observable<Supplier> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.get<Supplier>(url);
  }
  getSupplierName(name: string): Observable<Supplier[]> {
    const url = `${this.apiUrl+"/name"}/${name}`;
    return this.http.get<Supplier[]>(url);
  }
  addSupplier(supplier: Supplier): Observable<Supplier> {
    return this.http.post<Supplier>(this.apiUrl, supplier);
  }

  updateSupplier(supplier: Supplier): Observable<Supplier> {
    const url = `${this.apiUrl}/${supplier.id}`;
    return this.http.put<Supplier>(url, supplier);
  }

  deleteSupplier(id: number): Observable<Supplier> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.delete<Supplier>(url);
  }
}