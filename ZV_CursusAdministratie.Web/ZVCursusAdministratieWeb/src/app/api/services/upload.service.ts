import { HttpClient, HttpErrorResponse, HttpEventType } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs/';
import { catchError, map } from 'rxjs/operators'

@Injectable({
    providedIn: 'root'
})

export class UploadService {
    constructor(private httpClient: HttpClient) { }


    public upload(file: File): Observable<boolean> {
        let postUrl = 'https://localhost:44347/api/UploadFile';
        let formData: FormData = new FormData();
        formData.append('file', file, file.name);
        return this.httpClient
        .post(postUrl, formData)
        .pipe(
            map(()=> {return true;}), 
            catchError((e)=> this.handleError(e)))
    }


    private handleError(error: HttpErrorResponse) {
        if (error.error instanceof ErrorEvent) {
            console.error('An error occurred:', error.error.message);
        }
        else {
            console.error('Backend returned code ${error.status} ' +
                'Body was: ${error.error}')
        }
        return throwError('An error occurred, try again later.')
    }
}

