const express = require('express')
const { engine } = require('express-handlebars')
const app = express()
const port = 3000

app.engine('.hbs', engine({extname: '.hbs'}))
app.set('view engine', '.hbs')
app.set('views', './views')
app.use(express.static('public'))
app.use(express.json());

  let checkboxStates = [
    { id: 'checkbox1', value: 'checkbox1', checked: false },
    { id: 'checkbox2', value: 'checkbox2', checked: false },
    { id: 'checkbox3', value: 'checkbox3', checked: false },
    { id: 'checkbox4', value: 'checkbox4', checked: false },
    { id: 'checkbox5', value: 'checkbox5', checked: false },
    { id: 'checkbox6', value: 'checkbox6', checked: false },
    { id: 'checkbox7', value: 'checkbox7', checked: false },
    { id: 'checkbox8', value: 'checkbox8', checked: false },
    { id: 'checkbox9', value: 'checkbox9', checked: false },
    { id: 'checkbox10', value: 'checkbox10', checked: false },
    { id: 'checkbox11', value: 'checkbox11', checked: false },
    { id: 'checkbox12', value: 'checkbox12', checked: false },
    { id: 'checkbox13', value: 'checkbox13', checked: false },
    { id: 'checkbox14', value: 'checkbox14', checked: false }
  ]

app.get('/', (req, res) => {
  res.render('index', { checkboxes: checkboxStates })
})

app.post('/checkbox', (req, res) => {
  const { id, checked } = req.body;
  checkboxStates = checkboxStates.map(checkbox => {
    if (checkbox.id === id) {
      return { ...checkbox, checked };
    }
    return checkbox;
  });
  const checkedCheckboxes = checkboxStates.filter(checkbox => checkbox.checked).map(checkbox => checkbox.id);
  res.json({ message: 'Checkbox state updated' });
});

app.listen(port, () => {
  console.log(`express server is running on http://localhost:${port}`)
})

// --table controller

// index start from 1
const Handlebars = require('handlebars');
Handlebars.registerHelper('inc', function(value) {
  return parseInt(value) + 1;
});
// background-color: gray or white
Handlebars.registerHelper('oddOrEven', function(index) {
  return (index % 2 === 0) ? 'table-gray' : 'table-white';
});
// background-color: orange
Handlebars.registerHelper('addOrange', function(checked) {
  return checked ? 'table-orange' : '';
});

//table duplicate



