﻿
function MainViewModel() {
    var self = this;

    app.mainViewModel = self;

    self.current = ko.observable();
}

ko.components.register("Main-nc", {});