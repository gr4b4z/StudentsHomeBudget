var app;
(function (app) {
    (function (models) {
        var ShoppingListItem = (function () {
            function ShoppingListItem(name, items, isDone) {
                this.name = name;
                this.items = items;
                this.isDone = isDone;
            }
            ShoppingListItem.prototype.isDirty = function () {
            };
            ShoppingListItem.prototype.save = function (form) {
                alert("Could now transmit to server: " + ko.toJSON(self));
            };
            return ShoppingListItem;
        })();
        models.ShoppingListItem = ShoppingListItem;        
        ; ;
    })(app.models || (app.models = {}));
    var models = app.models;

    (function (viewModels) {
        var ShoppingListModel = (function () {
            function ShoppingListModel(shoppingLists) {
                this.shoppingLists = ko.observableArray(shoppingLists);
            }
            ShoppingListModel.prototype.addList = function () {
                this.shoppingLists.unshift(new app.models.ShoppingListItem((this.shoppingLists.length + 1).toString(), "", false));
            };
            ShoppingListModel.prototype.removeItem = function (item) {
                this.shoppingLists.remove(item);
            };
            ShoppingListModel.prototype.save = function (form) {
                alert("Could now transmit to server: " + ko.toJSON(this.shoppingLists));
            };
            return ShoppingListModel;
        })();
        viewModels.ShoppingListModel = ShoppingListModel;        
        ; ;
    })(app.viewModels || (app.viewModels = {}));
    var viewModels = app.viewModels;

})(app || (app = {}));

var viewModel = new app.viewModels.ShoppingListModel([
    new app.models.ShoppingListItem("1", "item1&#10;item2", true), 
    new app.models.ShoppingListItem("2", "item1\n item2", false), 
    new app.models.ShoppingListItem("3", "item1\n item2", false)
]);
ko.applyBindings(viewModel);
