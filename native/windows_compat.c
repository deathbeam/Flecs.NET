// Standalone copies of mingw's __CRT_INLINE math helpers for the Windows static
// library. Clang at -O0 does not emit extern-inline (gnu_inline) bodies, so Debug
// builds reference these symbols externally, and the MSVC CRT they get linked
// against has no such symbols. Added in build.zig for static Windows Debug builds.
#include <math.h>

int __isnan(double x) {
    return x != x;
}

int __isnanf(float x) {
    return x != x;
}

int __fpclassify(double x) {
    union { double d; unsigned long long u; } v;
    v.d = x;
    unsigned long long m = v.u & 0x7fffffffffffffffULL;
    if (m == 0) return FP_ZERO;
    if (m < (1ULL << 52)) return FP_SUBNORMAL;
    if (m < 0x7ff0000000000000ULL) return FP_NORMAL;
    return m > 0x7ff0000000000000ULL ? FP_NAN : FP_INFINITE;
}

int __fpclassifyf(float x) {
    union { float f; unsigned u; } v;
    v.f = x;
    unsigned m = v.u & 0x7fffffff;
    if (m == 0) return FP_ZERO;
    if (m < 0x800000) return FP_SUBNORMAL;
    if (m < 0x7f800000) return FP_NORMAL;
    return m > 0x7f800000 ? FP_NAN : FP_INFINITE;
}
