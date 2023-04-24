let burger = document.querySelector('.burger');
let menu = document.querySelector('.header-nav');
let menuLinks = menu.querySelectorAll('.item-header-link')

burger.addEventListener('click',
function() {
  burger.classList.toggle('burger-active');

  menu.classList.toggle('header-nav-active');

  document.body.classList.toggle('stopscr');
});

menuLinks.forEach(function(el){
  el.addEventListener('click', function(){

    burger.classList.remove('burger-active');
    menu.classList.remove('header-nav-active');
    document.body.classList.remove('stopscr');
  })
});

// const swiper = new Swiper('.swiper', {
//   // Optional parameters
//   direction: 'vertical',
//   loop: true,

//   // If we need pagination
//   pagination: {
//     el: '.swiper-pagination',
//   },

//   // Navigation arrows
//   navigation: {
//     nextEl: '.swiper-button-next',
//     prevEl: '.swiper-button-prev',
//   },

//   // And if we need scrollbar
//   scrollbar: {
//     el: '.swiper-scrollbar',
//   },
// });

let swiper = new Swiper ('.swiper', {

  navigation: {
    nextEl: '.swiper-button-next',
    prevEl: '.swiper-button-prev',
  },
  loop: true,

  pagination: {
    el: '.swiper-pagination',
    type: 'bullets',
    clickable: true
  },
  // spaseBetween: 30,
});

let tabsBth = document.querySelectorAll('.tabs-nav-bth');
let tabsItem = document.querySelectorAll('.tabs-item');

tabsBth.forEach(function(element){
  element.addEventListener('click', function(e){
    const path = e.currentTarget.dataset.path;

    tabsBth.forEach(function(bth){bth.classList.remove('tabs-nav-bth-active')});
    e.currentTarget.classList.add('tabs-nav-bth-active');

    tabsItem.forEach(function(element){ element.classList.remove('tabs-item-active')});
    document.querySelector(`[data-target="${path}"]`).classList.add('tabs-item-active');
  });
});

document.addEventListener('DOMContentLoaded', () =>{
  const accordion = document.querySelectorAll('.accordion');

  accordion.forEach(el => {
    el.addEventListener('click', (e) => {
      const self = e.currentTarget;
      const control = self.querySelector('.accordion-control');
      const content = self.querySelector('.accordion-content');

      self.classList.toggle('open');

      if (self.classList.contains('open')){
        content.style.maxHeight = content.scrollHeight + 'px';
      } else {
        content.style.maxHeight = null;
      }
    });
  });
});


 let search = document.querySelector('.search-control');
 let searchContent = document.querySelector('.search-content');
 let searchClose = document.querySelector('.search-close');
 let openbord = document.querySelector('.search');

 search.addEventListener('click', () => {
  searchContent.classList.add('search-open');
  searchClose.classList.add('search-close-open')
  openbord.classList.add('openbord')
 });


 searchClose.addEventListener('click', () => {
  searchContent.classList.remove('search-open');
  searchClose.classList.remove('search-close-open')
  openbord.classList.remove('openbord');
 });



// let search = document.querySelectorAll('.search');

// search.forEach(el => {
//   el.addEventListener('click', (e) =>{
//     const self = e.currentTarget;
//     const sercontrol = self.querySelector('.search-control');
//     const sercontent = self.querySelector('.search-content');
//     self.classList.add('open');
//   })
// })


// document.addEventListener('DOMContentLoaded', () =>{
//   const search = document.querySelectorAll('.search');

//   search.forEach(el => {
//     el.addEventListener('click', (e) => {
//       const self = e.currentTarget;
//       const sercontrol = self.querySelector('.search-control');
//       const sercontent = self.querySelector('.search-content');

//       self.classList.toggle('open');


//     });
//   });
// });

