import { Component } from "@angular/core";
import { UploadService } from '../api/services/upload.service';


@Component({
    selector: 'upload-file',
    templateUrl: './file-upload.component.html',
    styleUrls:['./file-upload.component.css']
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