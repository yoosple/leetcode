/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function(functions) {
	return function(x) {
        if (functions.length > 0) {
            let result = functions[functions.length - 1](x);
            for (let i = functions.length - 2; i >= 0; i--) {
                result = functions[i](result);
            }
            return result;
        } else {
            return x;           
        }
    }
};

/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */