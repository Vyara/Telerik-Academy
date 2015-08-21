function createCalendar(selector, events) {
    var i, j, k;
    if (typeof selector === 'string') {
        var root = document.querySelector(selector);
    }
    root.style.height = '1000px';
    var fragment = document.createDocumentFragment();
    var calendar = document.createElement('table');
    calendar.style.border = '1px solid black';
    calendar.style.borderCollapse = 'collapse';
    calendar.style.height = '80%';
    calendar.style.width = '70%';
    calendar.style.textAlign = 'center';
    var week = document.createElement('tr');
    week.style.border = '1px solid black';
    var date = document.createElement('th');
    date.style.height = '20px';
    date.style.border = '1px solid black';
    date.style.backgroundColor = 'lightgrey';
    var day = document.createElement('td');
    day.style.border = '1px solid black';
    day.style.textAlign = 'left';
    day.style.height = '150px';
    var daysCount = 0;
    var dateCount = 0;
    var weekDays = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'];
    for (i = 0; i < 10; i += 1) {
        var currentWeek = week.cloneNode(true);
        if (i % 2 === 0) {
            for (j = 0; j < 7; j += 1) {
                if (dateCount < 30) {
                    dateCount += 1;
                    var currentDate = date.cloneNode(true);
                    currentDate.innerText = weekDays[j] + ' ' + dateCount + ' ' + 'June 2014';
                    currentDate.setAttribute('id', '0' + dateCount);
                    currentWeek.appendChild(currentDate);
                }
            }
        } else {
            for (k = 0; k < 7; k += 1) {
                if (daysCount < 30) {
                    daysCount += 1;
                    var currentDay = day.cloneNode(true);
                    currentDay.setAttribute('id', '' + daysCount);
                    currentWeek.appendChild(currentDay);
                }
            }
        }
        fragment.appendChild(currentWeek);
    }

    calendar.appendChild(fragment);
    root.appendChild(calendar);

    calendar.addEventListener('mouseover', function (ev) {
        var target = ev.target;
        if (target.tagName === 'TD') {
            var currentDate = document.getElementById('0' + target.id);
            currentDate.style.background = 'lightgreen';
        }
    }, false);

    calendar.addEventListener('mouseout', function (ev) {
        var target = ev.target;
        if (target.tagName === 'TD') {
            var currentDate = document.getElementById('0' + target.id);
            currentDate.style.background = 'lightgrey';
        }
    }, false);

    calendar.addEventListener('click', function (ev) {
        var target = ev.target;
        var dates = document.getElementsByTagName('td');
        var currentDate = document.getElementById('0' + target.id);
        if (target.tagName === 'TD') {
            currentDate.style.background = 'red';
            target.style.background = 'yellow';
            for (var date in dates) {
                if(date.id !== target.id) {
                    date.style.background = 'none';
                }
            }
        }
    }, false);

    var allDays = calendar.getElementsByTagName('td');
    var eventsLength = events.length;
    var daysLength = allDays.length;

    for (i = 0; i < eventsLength; i += 1) {
        for (j = 0; j < daysLength; j += 1) {
            if (events[i].date === allDays[j].id) {
                allDays[j].innerText = events[i].hour + ' ' + events[i].duration + ' ' + events[i].title;
            }
        }
    }

}
