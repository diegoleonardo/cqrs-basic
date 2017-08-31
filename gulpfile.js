var path = require('path');
var gulp = require('gulp');
var plumber = require('gulp-plumber');
var msbuild = require("gulp-msbuild");
var iisexpress = require('gulp-serve-iis-express');
var browserSync = require('browser-sync').create();

var PORT = '51826';
var sources = [
    '**/*.cs'
];
var views = [
    '**/*.cshtml',
];

gulp.task('default', ['server', 'build'], function () {
    browserSync.init({
        proxy: 'http://localhost:' + PORT,
        notify: false,
        ui: false
    });
    gulp.watch(sources, ['build']);
    return gulp.watch(views, ['reload']);
});

gulp.task('reload', function () {
    browserSync.reload();
});

gulp.task('build', function () {
    console.log("Rolou build!");
    return gulp.src("./simple_cqrs.sln")
        .pipe(plumber())
        .pipe(msbuild({
            toolsVersion: 'auto',
            logCommand: true
        }));
});

gulp.task('server', function () {
    var configPath = path.join(__dirname, '.\\.vs\\config\\applicationhost.config');
    iisexpress({
        siteNames: ['simple.cqrs.webApp'],
        configFile: configPath,
        port: PORT
    });
});