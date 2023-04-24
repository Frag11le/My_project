document.querySelectorAll(".dropdown__simplebar").forEach(dropdown => {
  new SimpleBar(dropdown, {
  /* чтобы изначально ползунок был виден */
  autoHide: false,
  /* с помощью этого значения вы можете управлять высотой ползунка*/
  scrollbarMaxSize: 25,
});
})


const btns = document.querySelectorAll(".menu__btn");
const dropdowns = document.querySelectorAll(".dropdown");
const activeClassdropdowns = "dropdown__active";
const activeClassbtns = "btn__active";

btns.forEach(item => {
  item.addEventListener("click", function() {
    let DropThis = this.parentElement.querySelector(".dropdown");
    dropdowns.forEach(el => {
      if (el != DropThis) {
        el.classList.remove(activeClassdropdowns)
      }
    });
    btns.forEach(el => {
      if (el != this) {
        el.classList.remove(activeClassbtns)
      }
    });
    DropThis.classList.toggle(activeClassdropdowns);
    this.classList.toggle(activeClassbtns);
  })
})

const container = document.querySelector(".container")
const swiper = new Swiper('.swiper', {
  // Default parameters
  slidesPerView: 1,
  spaceBetween: 10,
  speed: 2000,
  autoplay: {
    delay: 2000
  },
  effect: "fade",
  allowTouchMove: false,
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev"
  },
  pagination: {
    el: '.swiper-bullet-pagination',
    type: 'bullets',
    clickable: true
  }

})

const element = document.querySelector('.select');
  const choices = new Choices(element,{
    duplicateItemsAllowed: false,
    allowHTML: true,
    searchEnabled: false,
    placeholder: false,
    itemSelectText: '',
    shouldSort: false,
});

document.addEventListener("DOMContentLoaded", () => {
  let gallerySlider = new Swiper(".slides-container", {
    slidesPerView: 1,
    grid: {
      rows: 1,
      fill: "row"
    },
    spaceBetween: 20,
    pagination: {
      el: ".test-section .test-pagination",
      type: "fraction"
    },
    navigation: {
      nextEl: ".test-next",
      prevEl: ".test-prev"
    },

    breakpoints: {
      441: {
        slidesPerGroup: 2,
        slidesPerView: 2,
        spaceBetween: 30
      },

      1200: {
        slidesPerGroup: 3,
        slidesPerView: 3,
        spaceBetween: 50
      }
    },

    a11y: false,
    keyboard: {
      enabled: true,
      onlyInViewport: true
    }, // можно управлять с клавиатуры стрелками влево/вправо

    // Дальнейшие надстройки делают слайды вне области видимости не фокусируемыми
    watchSlidesProgress: true,
    watchSlidesVisibility: true,
    slideVisibleClass: "slide-visible",

    on: {
      init: function () {
        this.slides.forEach((slide) => {
          if (!slide.classList.contains("slide-visible")) {
            slide.tabIndex = "-1";
          } else {
            slide.tabIndex = "";
          }
        });
      },
      slideChange: function () {
        this.slides.forEach((slide) => {
          if (!slide.classList.contains("slide-visible")) {
            slide.tabIndex = "-1";
          } else {
            slide.tabIndex = "";
          }
        });
      }
    }

    // on: {
    //   /* исправляет баг с margin-top остающимся при смене брейкпоинта, это было нужно в 6-й версии свайпера */
    //   beforeResize: function () {
    //     this.slides.forEach((el) => {
    //       el.style.marginTop = "";
    //     });
    //   }
    // }
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

document.addEventListener("DOMContentLoaded", () => {
  let eventSlider = new Swiper(".swiper-event", {

    breakpoints: {

      1200: {
        slidesPerGroup: 3,
        slidesPerView: 3,
        spaceBetween: 50
      }
    },
  
    navigation: {
      nextEl: ".swiper-button-next",
      prevEl: ".swiper-button-prev"
    },
  });
});

document.addEventListener("DOMContentLoaded", () => {
  let eventSlider = new Swiper(".swiper-project", {

    breakpoints: {

      1200: {
        slidesPerGroup: 3,
        slidesPerView: 3,
        spaceBetween: 50
      }
    },
  
    navigation: {
      nextEl: ".swiper-buton-next",
      prevEl: ".swiper-buton-prev"
    },
  });
});

new window.JustValidate('.form', {
  rules: {
    name: {
      required: true,
      minLength: 2,
      maxLength: 20,
    },
    tel: {
      required: true,
      function: (name, value) => {
        const phone = value.replace(/\D+/g, '');
        return phone.length === 11;
      }
    }
  },
  messages: {
    name: {
      required: 'Пожалуйста, введите ваше имя',
      minLength: 'Имя должно содержать не менее 2 символов',
      maxLength: 'Имя должно содержать не более 20 символов',
    },
    tel: {
      required: 'Пожалуйста, введите ваш номер телефона',
      function: 'Номер телефона должен содержать 11 цифр'
    }
  }
});

ymaps.ready(init);
function init() {
  // Создание карты.
  var myMap = new ymaps.Map("map", {
    // Координаты центра карты.
    // Порядок по умолчанию: «широта, долгота».
    // Чтобы не определять координаты центра карты вручную,
    // воспользуйтесь инструментом Определение координат.
    center: [55.758468, 37.6010884],
    // Уровень масштабирования. Допустимые значения:
    // от 0 (весь мир) до 19.
    zoom: 14
  });

  var myPlacemark = new ymaps.Placemark([55.758468, 37.6010884], {}, {
    iconLayout: 'default#image',
    iconImageHref: 'img/map/point.png',
    iconImageSize: [20, 20],
    iconImageOffset: [-3, -42]
  });

  myMap.geoObjects.add(myPlacemark);
}