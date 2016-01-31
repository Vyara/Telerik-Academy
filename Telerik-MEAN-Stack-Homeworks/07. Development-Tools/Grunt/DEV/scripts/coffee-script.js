var toggle;

toggle = true;

document.getElementById('btn-test').addEventListener('click', function(e) {
    var button, text;
    button = e.target;
    text = button.innerHTML;
    button.innerHTML = text === 'Testing' ? 'hide' : 'show';
    document.getElementById('cat').className = toggle ? '' : 'hidden';
    toggle = !toggle;
});

