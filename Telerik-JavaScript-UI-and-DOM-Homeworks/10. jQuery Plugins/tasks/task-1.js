function solve() {

    return function (selector) {
        var $menuDiv = $('<div />')
                .addClass('dropdown-list'),
            $selectMenu = $(selector)
                .hide()
                .appendTo($menuDiv),
            $currentSelection = $('<div />')
                .addClass('current')
                .text('Select a value')
                .appendTo($menuDiv),
            $container = $('<div />')
                .addClass('options-container')
                .css('position', 'absolute')
                .hide()
                .appendTo($menuDiv);

        $selectMenu.find('option').each(function (i) {
            var $this = $(this);
            $('<div />')
                .appendTo($container)
                .addClass('dropdown-item')
                .attr('data-value', $this.val())
                .attr('data-index', i)
                .text($this.text())
                .click(function () {
                    $currentSelection
                        .val($this.val())
                        .text($this.text());
                    $container.hide();

                    $selectMenu.val($this.val());

                });
        });

        $currentSelection.click(function(){
            $container.toggle();
            $currentSelection.text('Select a value');
        });

        $('body').append($menuDiv);
    };
}

module.exports = solve;