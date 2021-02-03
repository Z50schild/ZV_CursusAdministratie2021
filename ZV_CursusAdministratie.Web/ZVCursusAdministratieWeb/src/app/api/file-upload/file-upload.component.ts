import { componentFactoryName } from "@angular/compiler";
import { Component } from "@angular/core";
import { Component, Input, OnInit } from '@angular/core';
import { UploadService } from "../services/upload.service";


@Component({
    selector: 'upload-file',
    templateUrl: './upload-file.component.html'
})

export class UploadFileComponent{
    fileUpload!: File;

    constructor(private fileUploadService: UploadService){}


    handleFileInput(file: File) {
        this.fileUpload = file;
    }

    UploadFile(){
        this.fileUploadService.uploadFile(this.fileUpload)
       
    }
}