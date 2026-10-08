let car = {
    manufacturer: "BMW",
    model: "X5",
    year: 2020,
    speed: 100
};

function showCar(car) {
    console.log("Виробник:", car.manufacturer);
    console.log("Модель:", car.model);
    console.log("Рік:", car.year);
    console.log("Швидкість:", car.speed);
}

function travelTime(car, distance) {
    let hours = distance / car.speed;
    let breaks = Math.floor(hours / 4);
    return hours + breaks;
}

showCar(car);
console.log("Час поїздки:", travelTime(car, 800), "год");


let fraction1 = {
    numerator: 1,
    denominator: 2
};

let fraction2 = {
    numerator: 3,
    denominator: 4
};

function add(a, b) {
    return {
        numerator: a.numerator * b.denominator + b.numerator * a.denominator,
        denominator: a.denominator * b.denominator
    };
}

function subtract(a, b) {
    return {
        numerator: a.numerator * b.denominator - b.numerator * a.denominator,
        denominator: a.denominator * b.denominator
    };
}

function multiply(a, b) {
    return {
        numerator: a.numerator * b.numerator,
        denominator: a.denominator * b.denominator
    };
}

function divide(a, b) {
    return {
        numerator: a.numerator * b.denominator,
        denominator: a.denominator * b.numerator
    };
}

function reduce(fraction) {
    let a = Math.abs(fraction.numerator);
    let b = Math.abs(fraction.denominator);

    while (b != 0) {
        let temp = b;
        b = a % b;
        a = temp;
    }

    fraction.numerator /= a;
    fraction.denominator /= a;

    return fraction;
}

console.log("Додавання:", add(fraction1, fraction2));
console.log("Віднімання:", subtract(fraction1, fraction2));
console.log("Множення:", multiply(fraction1, fraction2));
console.log("Ділення:", divide(fraction1, fraction2));
console.log("Скорочення:", reduce({ numerator: 8, denominator: 12 }));


let time = {
    hours: 10,
    minutes: 30,
    seconds: 20
};

function showTime(time) {
    console.log(
        time.hours + ":" +
        time.minutes + ":" +
        time.seconds
    );
}

function addSeconds(time, seconds) {
    let total = time.hours * 3600 + time.minutes * 60 + time.seconds;

    total += seconds;
    total = total % 86400;

    time.hours = Math.floor(total / 3600);
    total = total % 3600;
    time.minutes = Math.floor(total / 60);
    time.seconds = total % 60;
}

function addMinutes(time, minutes) {
    addSeconds(time, minutes * 60);
}

function addHours(time, hours) {
    addSeconds(time, hours * 3600);
}

showTime(time);
addSeconds(time, 50);
showTime(time);
addMinutes(time, 20);
showTime(time);
addHours(time, 2);
showTime(time);


let shoppingList = [
    { name: "Хліб", quantity: 2, bought: false },
    { name: "Молоко", quantity: 1, bought: true },
    { name: "Яблука", quantity: 5, bought: false }
];

function showList(list) {
    for (let item of list) {
        if (!item.bought) {
            console.log(item.name, item.quantity, "шт.");
        }
    }

    for (let item of list) {
        if (item.bought) {
            console.log(item.name, item.quantity, "шт. куплено");
        }
    }
}

function addPurchase(list, name, quantity) {
    for (let item of list) {
        if (item.name == name) {
            item.quantity += quantity;
            return;
        }
    }

    list.push({
        name: name,
        quantity: quantity,
        bought: false
    });
}

function buyProduct(list, name) {
    for (let item of list) {
        if (item.name == name) {
            item.bought = true;
        }
    }
}

addPurchase(shoppingList, "Хліб", 3);
buyProduct(shoppingList, "Яблука");
showList(shoppingList);


let check = [
    { name: "Хліб", quantity: 2, price: 25 },
    { name: "Молоко", quantity: 1, price: 35 },
    { name: "Сир", quantity: 2, price: 120 }
];

function showCheck(check) {
    for (let item of check) {
        console.log(
            item.name,
            item.quantity,
            item.price,
            item.quantity * item.price
        );
    }
}

function totalPrice(check) {
    let sum = 0;

    for (let item of check) {
        sum += item.quantity * item.price;
    }

    return sum;
}

function mostExpensive(check) {
    let max = check[0];

    for (let item of check) {
        if (item.quantity * item.price > max.quantity * max.price) {
            max = item;
        }
    }

    return max;
}

function averagePrice(check) {
    let sum = 0;
    let count = 0;

    for (let item of check) {
        sum += item.price * item.quantity;
        count += item.quantity;
    }

    return sum / count;
}

showCheck(check);
console.log("Загальна сума:", totalPrice(check));
console.log("Найдорожча покупка:", mostExpensive(check));
console.log("Середня вартість:", averagePrice(check));


let styles = [
    { name: "color", value: "red" },
    { name: "font-size", value: "30px" },
    { name: "text-align", value: "center" },
    { name: "text-decoration", value: "underline" }
];

function showText(styles, text) {
    let style = "";

    for (let item of styles) {
        style += item.name + ":" + item.value + ";";
    }

    document.write("<p style='" + style + "'>" + text + "</p>");
}

showText(styles, "Привіт!");


let rooms = [
    { name: "101", places: 15, department: "IT" },
    { name: "202", places: 20, department: "Економіка" },
    { name: "303", places: 12, department: "IT" },
    { name: "404", places: 18, department: "Математика" }
];

let group = {
    name: "Група 1",
    students: 14,
    department: "IT"
};

function showRooms(rooms) {
    for (let room of rooms) {
        console.log(room);
    }
}

function showByDepartment(rooms, department) {
    for (let room of rooms) {
        if (room.department == department) {
            console.log(room);
        }
    }
}

function showForGroup(rooms, group) {
    for (let room of rooms) {
        if (
            room.places >= group.students &&
            room.department == group.department
        ) {
            console.log(room);
        }
    }
}

function sortByPlaces(rooms) {
    rooms.sort(function(a, b) {
        return a.places - b.places;
    });
}

function sortByName(rooms) {
    rooms.sort(function(a, b) {
        return a.name.localeCompare(b.name);
    });
}

showRooms(rooms);
showByDepartment(rooms, "IT");
showForGroup(rooms, group);

sortByPlaces(rooms);
showRooms(rooms);

sortByName(rooms);
showRooms(rooms);