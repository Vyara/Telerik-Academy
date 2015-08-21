/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

 */
function solve() {
    var CONSTANTS = {
        SELECTOR: {
            BUTTON: '.button',
            CONTENT: '.content'
        },
        CLASSES: {
            BUTTON: 'button',
            CONTENT: 'content'
        },

        DISPLAY_OPTION: {
            HIDDEN: 'none',
            VISIBLE: ''
        },

        BUTTON_INNER_HTML: {
            SHOW: 'show',
            HIDE: 'hide'
        }
    };


    function getElement(element) {
        if (typeof element !== 'string' || !$(element).size()) {
            throw new Error('Invalid selector.');
        }
        return $(element);
    }


    function clickedButtonActions() {
       $(this).text(CONSTANTS.BUTTON_INNER_HTML.HIDE).click(function(){
          var $this = $(this),
              $content;

           $content = $this.next(CONSTANTS.SELECTOR.CONTENT);
           if($content.length && $content.nextAll(CONSTANTS.SELECTOR.BUTTON).length){
               if ($content.css('display') === CONSTANTS.DISPLAY_OPTION.HIDDEN) {
                   $this.text(CONSTANTS.BUTTON_INNER_HTML.HIDE);
                   $content.css('display', CONSTANTS.DISPLAY_OPTION.VISIBLE);
               } else {
                   $this.text(CONSTANTS.BUTTON_INNER_HTML.SHOW);
                   $content.css('display', CONSTANTS.DISPLAY_OPTION.HIDDEN);
               }
           }
       })
    }

    return function (selector) {
        var element;
        element = getElement(selector);
       element.children(CONSTANTS.SELECTOR.BUTTON).each(clickedButtonActions);
    };
}

module.exports = solve;