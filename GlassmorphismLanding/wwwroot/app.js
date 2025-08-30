const btn = document.getElementById('menuBtn');
const menu = document.getElementById('menu');
btn?.addEventListener('click', () => {
    const open = menu.style.display === 'flex';
    menu.style.display = open ? 'none' : 'flex';
    btn.setAttribute('aria-expanded', String(!open));
});