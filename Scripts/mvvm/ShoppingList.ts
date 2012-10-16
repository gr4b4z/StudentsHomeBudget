/// <reference path="Knockout.d.ts" />
declare var ko: knockout;
module app {
    export module models {
        export class ShoppingListItem {
            name: string;
            isDone: bool;
            items: string;
            constructor (name: string, items: string, isDone: bool) {
                this.name = name;
                this.items = items;
                this.isDone = isDone;
            }
            isDirty () { };
            save (form) {
                alert("Could now transmit to server: " + ko.toJSON(self));
            };

        };
        }
    
    export module viewModels{
         export class   ShoppingListModel {
            shoppingLists;
            addList() {
                this.shoppingLists.unshift(new app.models.ShoppingListItem((this.shoppingLists.length+1).toString(), "",false));
                };
                removeItem(item:app.models.ShoppingListItem) {
                      this.shoppingLists.remove(item);
                };
            save (form) {
                alert("Could now transmit to server: " + ko.toJSON(this.shoppingLists));
                // To actually transmit to server as a regular form post, write this: ko.utils.postJson($("form")[0], self.gifts);
            };
            constructor (shoppingLists) {
               this.shoppingLists = ko.observableArray(shoppingLists);

            };
        };
    }
}
var viewModel = new app.viewModels.ShoppingListModel([
            new app.models.ShoppingListItem("1", "item1&#10;item2",true),
            new app.models.ShoppingListItem("2", "item1\n item2",false),
            new app.models.ShoppingListItem("3", "item1\n item2",false)
        ]);
ko.applyBindings(viewModel);
