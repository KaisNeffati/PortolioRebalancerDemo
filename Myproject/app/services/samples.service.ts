import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/throw';

import { ISample } from '../sample/sample';

@Injectable()
export class SamplesService {
    
    private _ISampleUrl = 'http://localhost:5000/api/Sample/';

    constructor(private _http: Http) { }

    getSamples(): Observable<ISample[]> {
        return this._http.get(this._ISampleUrl)
            .map((response: Response) => <ISample[]> response.json())
            .catch(this.handleError);
    }

    private handleError(error: Response) {
        // in a real world app, we may send the server to some remote logging infrastructure
        // instead of just logging it to the console
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}