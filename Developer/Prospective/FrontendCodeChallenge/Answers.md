# Question 1.1

Both div elements will be red

# Question 1.2

```js
function toPink() {
    var element = document.getElementById("firstDiv");
    element.style.backgroundColor = "pink";
}
```
# Question 1.3

```js
function addYellowCard() {
    var element = document.getElementById("secondDiv");
    element.classList.add(["yellow-card"])
}
```

# Question 2.1
The comparison used is not a strict comparison so if the value are similar the conditional will be true.

# Question 2.2
By using `===` instead of `==` for a strict comparison.

# Question 3.1
You'd start by adding:
```html
<meta name="viewport" content="width=device-width, initial-scale=1.0">" 
```
Then you'd set size constraints to the elements that require them.
```css
.responsive {
    max-height: 100%;
    width: auto;
}
```

# Question 3.2
Bundling them in one file yeilds faster load times