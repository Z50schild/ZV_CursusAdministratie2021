import {HttpClient} from '@angular/common/http'
import { Injectable } from '@angular/core';
import {Observable} from 'rxjs'

@Injectable({
    providedIn: 'root'
})

export class UploadService{
    constructor(private httpClient: HttpClient){}
    

    public uploadFile(file: File): Observable<any>{
         let postUrl = '/api/UploadFile';

        let formData = new FormData();
        formData.append('cursusFile', file, file.name);
        return this.httpClient.post<any>(postUrl, formData, {
            reportProgress: true,
            observe: 'events'
        });
    }
}
