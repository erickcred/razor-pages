window.addEventListener('scroll', () => {
    if (window.scrollY >= 44) {
        document.querySelector('header').classList.add('sticky')
    } else {
        document.querySelector('header').classList.remove('sticky')
    }
})