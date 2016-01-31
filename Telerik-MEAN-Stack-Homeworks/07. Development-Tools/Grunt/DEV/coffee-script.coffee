toggle = true;

document.getElementById('btn-test').addEventListener('click', (e) ->
 button = e.target
 text = button.innerHTML
 button.innerHTML = if text == 'Testing' then 'hide' else 'show'
 document.getElementById('cat').className = if toggle then '' else 'hidden'
 toggle = !toggle
 return
);
