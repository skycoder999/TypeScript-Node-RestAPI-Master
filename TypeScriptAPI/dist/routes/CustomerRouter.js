"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = require("express");
const Customers = require('../data');
class CustomerRouter {
    /**
     * Initialize the HeroRouter
     */
    constructor() {
        this.router = express_1.Router();
        this.init();
    }
    /**
     * GET all Heroes.
     */
    getAll(req, res, next) {
        res.send(Customers);
    }
    /**
     * Take each handler, and attach to one of the Express.Router's
     * endpoints.
     */
    init() {
        this.router.get('/', this.getAll);
    }
}
exports.CustomerRouter = CustomerRouter;
// Create the HeroRouter, and export its configured Express.Router
const customerRoutes = new CustomerRouter();
customerRoutes.init();
exports.default = customerRoutes.router;
