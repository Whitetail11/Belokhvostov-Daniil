const dragAndDrop =  () => {
    const cards = document.querySelectorAll('.js-card');
    const cells = document.querySelectorAll('.js-cell');
    let currentcard;


    const dragStart = function () {
        setTimeout(() => {
            this.classList.add('hidden');
        }, 0);
        currentcard = this;
    };


    const dragEnd = function () {
        this.classList.remove('hidden');
    };

    const dragOver = function (evt) {
        evt.preventDefault();
    };

    const dragEnter = function(evt) {
        evt.preventDefault();
        this.classList.add('hovered');
    };

    const dragLeave = function() {
        this.classList.remove('hovered');
    };

    const dragDrop = function() {
        this.append(currentcard);
        this.classList.remove('hovered');
    };



cards.forEach((card) => {
    card.addEventListener('dragstart', dragStart);
    card.addEventListener('dragend', dragEnd);

});
cells.forEach((cell) => {
    cell.addEventListener('dragover', dragOver);
    cell.addEventListener('dragenter', dragEnter);
    cell.addEventListener('dragleave', dragLeave);
    cell.addEventListener('drop', dragDrop);
});

};
dragAndDrop();