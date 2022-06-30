(function() {
    require.config({
        paths: {
            "ConfidenceLevelWidgetComponent": Terrasoft.getFileContentUrl("Opportunity", "src/js/confidence-level-widget.js"),
           
        },
        shim: {
            "ConfidenceLevelWidgetComponent": {
                deps: ["ng-core", "chartjs"]
            }
        }
    });
})();
