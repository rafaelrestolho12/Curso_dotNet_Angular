import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  public eventos: any = [{
    Tema: 'Angular',
    Local: 'Belo horizonte'
  },
  {
    Tema: '.NET',
    Local: 'São Paulo'
  },
  {
    Tema: 'C#',
    Local: 'Londrina'
  },
]
  constructor() { }

  ngOnInit() {
  }

}
