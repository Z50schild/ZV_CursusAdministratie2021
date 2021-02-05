import { HttpEvent } from "@angular/common/http";
import { Component, ElementRef, HostListener, Input, OnInit, ViewChild } from "@angular/core";
import { FormBuilder, FormGroup } from "@angular/forms";
import { UploadService } from '../api/services/upload.service';



@Component({
    selector: 'upload-file',
    templateUrl: './file-upload.component.html',
    styleUrls: ['./file-upload.component.css']
})

export class UploadFileComponent implements OnInit {

    constructor(private uploadService: UploadService, private formBuilder: FormBuilder) { }
    fileUpload: File = new File([], '');
    form!: FormGroup;
    error = { message: ''};
    response = { message: '' };

    ngOnInit() {
        this.form = this.formBuilder.group({ file: File });
    }


    // onFileChange(files: FileList) {

    
    //     this.fileUpload = files.item(0) as File;
    // }

    onFileChange(event: any) {
        this.response.message = '';
        this.error.message = '';
        this.fileUpload = event.target.files[0]
    }


    submit() {
        this.response.message = '';
        this.error.message = '';

        if (this.fileUpload) {
            this.uploadService.upload(this.fileUpload).subscribe(
                data => { this.response.message = `Bestand ${this.fileUpload.name} is verstuurd.` },
                error => { this.error.message = `Fout bij versturen bestand ${this.fileUpload.name}.`}
            );
        }
    }
}
