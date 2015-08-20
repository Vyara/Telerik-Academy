/**
script for generating console
 */
(function () {
    function createJsConsole(selector) {
        var self = this;
        //var consoleElement = document.querySelector(selector);
        var consoleElement = document.getElementById(selector);

        if (consoleElement.className) {
            consoleElement.className = consoleElement.className + " js-console";
        } else {
            consoleElement.className = "js-console";
        }

        var textArea = document.createElement("p");
        consoleElement.appendChild(textArea);

        self.write = function jsConsoleWrite(text) {
            var textLine = document.createElement("span");
            if (text !== "" && text !== undefined) {
                var toWrite = text.toString();
                textLine.innerHTML = toWrite;
                textArea.appendChild(textLine);
                consoleElement.scrollTop = consoleElement.scrollHeight;
            }
        };

        self.writeLine = function jsConsoleWriteLine(text) {
            self.write(text);
            textArea.appendChild(document.createElement("br"));
        };

        self.read = function readText(inputSelector) {
            var element = document.querySelector(inputSelector);
            if (element.innerHTML) {
                return element.innerHTML;
            } else {
                return element.value;
            }
        };

        self.readInteger = function readInteger(inputSelector) {
            var text = self.read(inputSelector);
            return parseInt(text, 10);
        };

        self.readFloat = function readFloat(inputSelector) {
            var text = self.read(inputSelector);
            return parseFloat(text);
        };

        self.clearConsole = function clearConsole() {
            textArea.innerHTML = "";
        };

        return self;
    }
    jsConsole = new createJsConsole("js-console");
}).call(this);

/**
 * Problem visualization
 */

var previousButton = document.getElementById('previous');
nextButton = document.getElementById('next');
nextButton.onclick = next;
previousButton.onclick = previous;

count = 1;
function next(){
    if(count < 7){
        document.getElementById('article' + count).style.display = "none";
        count++;
        document.getElementById('article' + count).style.display = "block";
        jsConsole.clearConsole();
    }

}
function previous() {
    if (count > 1) {
        document.getElementById('article' + count).style.display = "none";
        count--;
        document.getElementById('article' + count).style.display = "block";
        jsConsole.clearConsole();
    }
}