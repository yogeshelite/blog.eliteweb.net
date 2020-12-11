$(document).ready(function () {
    if (window.matchMedia('(max-width: 768px)').matches) {
        // Footer toggleClass
        $("#address_1").click(function () {
            $("#address_1_1").toggle();
            $("#address_1 .footer_toggle").toggleClass("action_arrow");
        });
        $("#address_2").click(function () {
            $("#address_2_2").toggle();
            $("#address_2 .footer_toggle").toggleClass("action_arrow");
        });
        $("#address_3").click(function () {
            $("#address_3_3").toggle();
            $("#address_3 .footer_toggle").toggleClass("action_arrow");
        });
    }
    $('#nav-icon1').click(function () {
        $(this).toggleClass('open');
        $("#menu").toggle();
        $("body").toggleClass("body_overflow");
    });
    // development
    $(".services_tab li .Ios_bt").addClass("active-btn");
    $(".Ios_bt").click(function () {
        $(".services_tab li a").removeClass("active-btn");
        $(".services_tab li .Ios_bt").addClass("active-btn");
        $("#Android_app, #cross_app, #xamarin_app").hide();
        $("#IOS_app").show();

    });
    $(".android_bt").click(function () {
        $(".services_tab li a").removeClass("active-btn");
        $(".services_tab li .android_bt").addClass("active-btn");
        $("#IOS_app").hide();
        $("#IOS_app, #cross_app, #xamarin_app").hide();
        $("#Android_app").show();

    });
    $(".cross_bt").click(function () {
        $(".services_tab li a").removeClass("active-btn");
        $(".services_tab li .cross_bt").addClass("active-btn");
        $("#IOS_app, #Android_app, #xamarin_app").hide();
        $("#cross_app").show();

    });
    $(".xam_bt").click(function () {
        $(".services_tab li a").removeClass("active-btn");
        $(".services_tab li .xam_bt").addClass("active-btn");
        $("#IOS_app, #Android_app, #cross_app").hide();
        $("#xamarin_app").show();

    });

    //faq

    $(".industry-filter-btn li .process_bt").addClass("active-btn");
    $(".process_bt").click(function () {
        $(".industry-filter-btn li a").removeClass("active-btn");
        $(".industry-filter-btn li .process_bt").addClass("active-btn");
        $("#career_app, #team_app").hide();
        $("#process_app").show();

    });
    $(".career_bt").click(function () {
        $(".industry-filter-btn li a").removeClass("active-btn");
        $(".industry-filter-btn li .career_bt").addClass("active-btn");
        $("#process_app").hide();
        $("#process_app, #team_app").hide();
        $("#career_app").show();

    });
    $(".team_bt").click(function () {
        $(".industry-filter-btn li a").removeClass("active-btn");
        $(".industry-filter-btn li .team_bt").addClass("active-btn");
        $("#process_app, #career_app").hide();
        $("#team_app").show();

    });
});

// menu
// slider
jQuery(document).ready(function ($) {
    var owl = $('.owl-carousel1');

    owl.owlCarousel({
        // loop: true,
        nav: true,
        // lazyLoad: true,
        margin: 10,
        video: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            960: {
                items: 1,
            },
            1200: {
                items: 1
            }
        }
    });
});


// case-study


var $sticky = $('.sticky');
var $stickyrStopper = $('.sticky-stopper');
if (!!$sticky.offset()) { // make sure ".sticky" element exists

    var generalSidebarHeight = $sticky.innerHeight();
    var stickyTop = $sticky.offset().top;
    var stickOffset = 0;
    var stickyStopperPosition = $stickyrStopper.offset().top;
    var stopPoint = stickyStopperPosition - generalSidebarHeight - stickOffset;
    var diff = stopPoint + stickOffset;

    $(window).scroll(function () { // scroll event
        var windowTop = $(window).scrollTop(); // returns number

        if (stopPoint < windowTop) {
            $sticky.css({ position: 'absolute', top: diff });
        } else if (stickyTop < windowTop + stickOffset) {
            $sticky.css({ position: 'fixed', top: stickOffset });
        } else {
            $sticky.css({ position: 'absolute', top: 'initial' });
        }
    });

}


//$(window).scroll(function () {
//    var doc_scroll = $(window).scrollTop();
//    var bc_offset = $("#background-case-study").offset().top;
//    var pro_offset = $("#problem-case-study").offset().top;
//    var challange_offset = $("#challange-case-study").offset().top;
//    var solutions_offset = $("#solution-case-study").offset().top;
//    var result_offset = $("#result-case-study").offset().top;
//    var stop_offset = $(".sticky-stopper").offset().top - generalSidebarHeight;
//    $("#bacckground-s, #problem-s, #challange-s, #solution-s, #result-s").removeClass('side-active');
//    if (doc_scroll <= pro_offset) {
//        $("#bacckground-s").addClass('side-active');
//    } else if (doc_scroll <= challange_offset) {
//        $("#problem-s").addClass('side-active');
//    }
//    else if (doc_scroll <= solutions_offset) {
//        $("#challange-s").addClass('side-active');
//    }
//    else if (doc_scroll <= result_offset) {
//        $("#solution-s").addClass('side-active');
//    }
//    else if (doc_scroll >= result_offset) {
//        $("#result-s").addClass('side-active');
//    }
//    console.log(doc_scroll);
//    if (doc_scroll >= stop_offset) {
//        $(".sidebar-elite").css({ "position": "absolute" });
//    }


//});


//work page tab

$(document).ready(function () {
    $('.contact-tab ul li a').click(function () {
        $('.contact-tab li a').removeClass("active-tab-btn");
        $(this).addClass("active-tab-btn");
        $("#Requirement").val($(this).text());
    });

});
var ShowhideOther = function () {
    var value = $("#Industries").val();
    if (value === "Other") {
        $("#divIndustriesOther").show();
    } else {
        $("#divIndustriesOther").hide();
    }
};
$(document).ready(function () {
    var msg = $("#msg").val();
    var modal = '';
    var btn = document.getElementById("btn_dismiss");
    if (btn !== null && btn !== "null") {
        if (msg === "Thanks, we will get back to you!") {
            modal = span.onclick = function () {
                modal.style.display = "none";
            }
            modal.style.display = "block";
        } else if (msg === "There are some problems sending Email.") {
            modal = document.getElementById("oops_modal");
            modal.style.display = "block";
        }
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = "none";
            }
        }
        btn.onclick = function () {
            modal.style.display = "none";
        }
    }
});
var trigerFile = function () {
    $("#file").click();
};