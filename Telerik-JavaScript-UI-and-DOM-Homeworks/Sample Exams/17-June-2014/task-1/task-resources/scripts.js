function createImagesPreviewer(selector, items) {
    var i,
        len = items.length;
    if (typeof selector === 'string') {
        var root = document.querySelector(selector);
    }
    var fragment = document.createDocumentFragment();
    var imagePreviewer = document.createElement('div');
    imagePreviewer.style.display = 'inner-block';
    imagePreviewer.style.width = '70%';
    imagePreviewer.style.float = 'left';
    var previewImage = document.createElement('img');
    previewImage.src = items[0].url;
    previewImage.style.width = '1200px';
    previewImage.style.borderRadius = '25px';
    var previewImageTitle = document.createElement('h2');
    previewImageTitle.innerText = items[0].title;
    imagePreviewer.appendChild(previewImageTitle);
    imagePreviewer.appendChild(previewImage);
    imagePreviewer.style.textAlign = 'center';

    var aside = document.createElement('div');
    aside.style.display = 'inline-block';
    aside.style.float = 'right';
    aside.style.width = '30%';
    var listOfImages = document.createElement('ul');
    listOfImages.style.listStyleType = 'none';
    listOfImages.style.height = '950px';
    listOfImages.style.overflowY = 'scroll';
    var asideLi = document.createElement('li');
    asideLi.classList.add('image-container');
    var asideImage = document.createElement('img');
    asideImage.style.borderRadius = '25px';
    asideImage.style.width = '500px';
    var asideImageTitle = document.createElement('h3');
    aside.style.textAlign = 'center';


    var filterInput = document.createElement('input');
    filterInput.style.width = '60%';
    var filterInputTitle = document.createElement('h2');
    filterInputTitle.innerText = 'Filter';
    filterInputTitle.style.textAlign = 'center';

    listOfImages.appendChild(filterInputTitle);
    listOfImages.appendChild(filterInput);

    for (i = 0; i < len; i += 1) {
        var currentItem = items[i];
        var currentLi = asideLi.cloneNode(true);
        var currentImageTitle = asideImageTitle.cloneNode(true);
        currentImageTitle.innerText = currentItem.title;
        var currentImage = asideImage.cloneNode(true);
        currentImage.src = currentItem.url;

        currentLi.appendChild(currentImageTitle);
        currentLi.appendChild(currentImage);
        listOfImages.appendChild(currentLi);
    }

    listOfImages.addEventListener('click', function (ev) {
        var target = ev.target;
        if (target.tagName === 'IMG') {
            previewImage.src = target.src;
            previewImageTitle.innerText = target.previousElementSibling.innerText;
        }

    }, false);

    listOfImages.addEventListener('mouseover', function(ev){
        var target = ev.target;
        if (target.tagName === 'IMG') {
            target.parentElement.style.backgroundColor = 'grey';
            target.style.cursor = 'pointer';
        }
    }, false);

    listOfImages.addEventListener('mouseout', function(ev){
        var target = ev.target;
        if (target.tagName === 'IMG') {
            target.parentElement.style.backgroundColor = '';
        }
    }, false);

    filterInput.addEventListener('keyup', function(ev){
        var target = ev.target;
        var liChildren = listOfImages.getElementsByTagName('li');
        len = liChildren.length;
        for (i = 0; i < len; i += 1) {
            var currentLi = liChildren[i];
            var header = currentLi.firstElementChild.innerText;
            if (header.toLowerCase().indexOf(target.value.toLowerCase()) >= 0) {
                liChildren[i].style.display = 'inline-block';
            } else{
                liChildren[i].style.display = 'none';
            }
        }
    }, false);


    aside.appendChild(listOfImages);

    fragment.appendChild(imagePreviewer);
    fragment.appendChild(aside);

    root.appendChild(fragment);
}