// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {    
    setTimeout(() => {
        $("div.alert.notification").fadeOut();
    }, 2000);

    // 2021 4 29 2번째 15분을 보면 나옴
    // 확인 차 한번 더 팝업으로 질문하는 창이 나옴. (예시. 정말 지우실건가요?)
    $("a.confirmDeletion").click(() => {
        if (!confirm("Confirm Deletion")) {
            return false;
        }
    });
}); 