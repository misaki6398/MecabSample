import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-japanesenlp',
  templateUrl: './japanesenlp.component.html',
  styleUrls: ['./japanesenlp.component.css']
})
export class JapanesenlpComponent implements OnInit {
  public models: JapaneseNlpModel[] = [];
  public data: dataModel = {
    sentence: "7 時から"
  };
  public http: HttpClient;
  public baseUrl: string;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
    http.post<JapaneseNlpModel[]>(baseUrl + 'api/jpnlp', this.data).subscribe(result => {
      this.models = result;
    }, error => console.error(error));
  }

  ngOnInit(): void {
  }

  /**
   * postData
   */
  public postData() {
    this.http.post<JapaneseNlpModel[]>(this.baseUrl + 'api/jpnlp', this.data).subscribe(result => {
      this.models = result;
    }, error => console.error(error));
  }

}
interface dataModel {
  sentence: string;
}

interface JapaneseNlpModel {
  keyword: string;
  hinshi: string;
  hinshiHosoBunrui: string;
  feature3: string;
  feature4: string;
  katsuyogata: string;
  katsuyoKatachi: string;
  genKei: string;
  kana: string;
  hatsuon: string;
  jackNoteUrl: string;
  jackNoteText: string;
}
