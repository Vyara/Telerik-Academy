function solve() {
    return function () {
        $.fn.listview = function (data) {
            var $this = $(this),
                templateSelect = '#' + $this.attr('data-template'),
                templateHTML = $(templateSelect).html(),
                template = handlebars.compile(templateHTML),
                i,
                len = data.length;

            for (i = 0; i < len; i += 1) {
                $this.append(template(data[i]));
            }

            return this;
        };
    };
}

module.exports = solve;