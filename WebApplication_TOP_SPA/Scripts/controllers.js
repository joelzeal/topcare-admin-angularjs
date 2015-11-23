'use strict';

// Google Analytics Collection APIs Reference:
// https://developers.google.com/analytics/devguides/collection/analyticsjs/

angular.module('app.controllers', [])

    // Path: /
    .controller('HomeCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /about
    .controller('AboutCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'AngularJS SPA | About';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])


     // Path: /about
    .controller('MembersCtrl', ['$scope', '$location', '$window', 'MemberDataService', function ($scope, $location, $window, MemberDataService) {
        $scope.$root.title = 'TopCare Admin | Members';

        MemberDataService.getAllMembers().then(function (d) {
            $scope.membersList = d.data;
        })

        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])
    .factory('MemberDataService', ['$http', function ($http) {
         var fac = {};


         //get all members
         fac.getAllMembers = function () {
             return $http.get('/api/Members');
         };


         //insert member
         fac.insertMember = function (member) {
             var request = $http({
                 method: 'post',
                 url: '/api/Members',
                 data: member
             });
             return request;
         }

         //update member
         fac.updateMember = function (memberId, member) {
             var request = $http({
                 method: 'put',
                 url: '/api/Members/' + memberId,
                 data: member
             });
             return request;
         }

         //delete a member
         fac.deleteMember = function (memberId) {
             var request = $http({
                 method: 'delete',
                 url: '/api/Members/' + memberId
             });
             return request;
         }

         //get a single member
         fac.getSingleMember = function (memberId) {
             return $http.get('/api/Members/' + memberId);
         }

         return fac;
     }])


    // Path: /login
    .controller('LoginCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'AngularJS SPA | Sign In';
        // TODO: Authorize a user
        $scope.login = function () {
            $location.path('/');
            return false;
        };
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /error/404
    .controller('Error404Ctrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'Error 404: Page Not Found';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }]);