/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorybetterthenbuilder.abstractFactory;

import factorybetterthenbuilder.product.Game;
import factorybetterthenbuilder.product.Dlc;

/**
 *
 * @author Marcin
 */
public abstract class AbstractFactory {
    public abstract Game getGame(String productName);
    public abstract Dlc getDlc(String productName);
}
