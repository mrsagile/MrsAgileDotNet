  var visible = false;

var toggleText = function (divId) {
    alert("text" + this.text());

        visible = !(visible);
        if (visible) this.text( "-"); else this.text("+");

        $("#" + divId).toggle();
    }
