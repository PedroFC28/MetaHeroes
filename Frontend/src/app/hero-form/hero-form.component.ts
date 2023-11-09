import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { HeroService } from '../hero.service';
import { Hero } from '../hero';

@Component({
  selector: 'app-hero-form',
  templateUrl: './hero-form.component.html',
  styleUrls: ['./hero-form.component.css']
})
export class HeroFormComponent implements OnInit {

  heroForm!: FormGroup;
  submitted = false;
  powers = ['Really Smart', 'Super Flexible', 'Super Hot', 'Weather Changer'];


  constructor(private fb: FormBuilder, private heroService: HeroService) { }

  ngOnInit() {
    this.heroForm = this.fb.group({
      name: ['', Validators.required],
      alterEgo: [''],
      power: ['', Validators.required]
    });
  }

  get f() { return this.heroForm.controls; }

  onSubmit() {
    if (this.heroForm.valid) {
      // Cria uma nova instância de Hero com os dados do formulário
      const formModel = this.heroForm.value;
      const hero = new Hero(
        0,
        formModel['name'],
        formModel['power'],
        formModel['alterEgo']
      );

      // Use o serviço para enviar os dados
      this.heroService.addHero(hero).subscribe(data => {
        console.log('Hero submitted:', data);
      });

      this.submitted = true;
    }
  }

}