html {
  margin: 0;
  padding: 0;
  height: 100%;
  font-family: sans-serif;
}

body {
  margin: 0;
  padding: 0;
  height: 100%;
}

/* navigation */
.nav {
  background-color: #1a1963;
  width: 100px;
  height: 100%;
  display: flex;
  flex-direction: column;
  align-items: center;
}
.nav .navicon {
  width: 40px;
  height: 40px;
  padding: 10px;
  margin: 10px;
  cursor: pointer;
}
.nav img.checked {
  background-color: #f6f7f2;
}

/* main-app */
#main-app {
  display: flex;
  flex-direction: row;
  height: 100%;
}

/* main-content */
#main-content {
  display: flex;
  flex-direction: column;
  background-color: #f6f7f2;
  flex: 1;
  height: 100%;
}

/* title */
.title {
  font-size: 3rem;
  padding: 20px 20px 0px 55px;
}

/* table */
.table-container {
  display: flex;
  flex: 1;
  justify-content: center;
  height: 100px;
}
.table-container table {
  border-collapse: collapse;
  display: flex;
  flex-direction: column;
  height: 90%;
  width: 90%;
  margin: 20px;
  font-size: 0.7rem;
  border-style: none;
}
.table-container table th {
  padding: 5px;
  margin: 5px;
}
.table-container table th p {
  margin: 0px;
  padding: 0px;
  padding-bottom: 15px;
}
.table-container table .table-checkbox {
  width: 50px;
}
.table-container table .table-id {
  width: 50px;
}
.table-container table .table-advertiser,
.table-container table .table-description,
.table-container table .table-price {
  width: 15%;
}
.table-container table .table-name {
  width: 12%;
}
.table-container table .table-starttime,
.table-container table .table-endtime {
  width: 15%;
}
.table-container table .table-group {
  margin: 3px;
  color: #696969;
  padding: 0px;
  font-weight: 300;
}
.table-container table .table-description {
  overflow-x: hidden;
  text-overflow: ellipsis;
}
.table-container table .table-action,
.table-container table .table-price {
  width: 100px;
}
.table-container table .table-action {
  position: relative;
}
.table-container table .table-price p::after,
.table-container table .table-starttime p::after,
.table-container table .table-endtime p::after {
  content: url("https://raw.githubusercontent.com/ALPHACamp/WFE-data-table/0f97f3113bff18353154b8644eb0b31fff2a3bef/icons/sort.svg");
  width: 20px;
  height: 20px;
  position: relative;
  top: 8px;
  left: 20px;
  z-index: 99;
}
.table-container table thead {
  margin-right: 6px;
  margin-left: 6px;
  background-color: #bebebe;
  position: relative;
}
.table-container table tbody {
  overflow-y: scroll;
}
.table-container table .table-white {
  background-color: #f6f7f2;
}
.table-container table .table-gray {
  background-color: #e4e4e4;
}
.table-container table .table-orange {
  background-color: #d7792c;
}

.scrollbar {
  padding-left: 6px;
}
.scrollbar::-webkit-scrollbar {
  width: 6px;
}
.scrollbar::-webkit-scrollbar-thumb {
  border-radius: 3px;
}

.nav-action {
  top: 0;
  bottom: 0;
  display: flex;
  position: absolute;
  height: 35px;
  width: 40px;
}
.nav-action:hover {
  cursor: pointer;
}

.hamburger {
  width: 25px;
  height: 2px;
  position: relative;
  background: black;
}
.hamburger .popup-container .activated {
  position: absolute;
  right: 10px;
  top: -5px;
  width: 100px;
  height: 120px;
  border: 1px solid #e4e4e4;
  background-color: #f6f7f2;
  z-index: 99;
}

.hamburger,
.hamburger::before,
.hamburger::after {
  width: 25px;
  height: 2px;
  top: 14px;
  left: 10px;
  background: black;
}

.hamburger::before,
.hamburger::after {
  position: absolute;
  left: 0;
  content: "";
}

.hamburger::before {
  top: 8px;
}

.hamburger::after {
  bottom: 8px;
}

/*# sourceMappingURL=style.cs.map */

