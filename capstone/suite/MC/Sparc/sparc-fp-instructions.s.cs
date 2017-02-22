# CS_ARCH_SPARC, CS_MODE_BIG_ENDIAN + CS_MODE_V9, None
0x89,0xa0,0x18,0x80 = fitos %f0, %f4
0x89,0xa0,0x19,0x00 = fitod %f0, %f4
0x89,0xa0,0x19,0x80 = fitoq %f0, %f4
0x89,0xa0,0x1a,0x20 = fstoi %f0, %f4
0x89,0xa0,0x1a,0x40 = fdtoi %f0, %f4
0x89,0xa0,0x1a,0x60 = fqtoi %f0, %f4
0x89,0xa0,0x19,0x20 = fstod %f0, %f4
0x89,0xa0,0x19,0xa0 = fstoq %f0, %f4
0x89,0xa0,0x18,0xc0 = fdtos %f0, %f4
0x89,0xa0,0x19,0xc0 = fdtoq %f0, %f4
0x89,0xa0,0x18,0xe0 = fqtos %f0, %f4
0x89,0xa0,0x19,0x60 = fqtod %f0, %f4
0x89,0xa0,0x00,0x20 = fmovs %f0, %f4
0x89,0xa0,0x00,0x40 = fmovd %f0, %f4
0x89,0xa0,0x00,0x60 = fmovq %f0, %f4
0x89,0xa0,0x00,0xa0 = fnegs %f0, %f4
0x89,0xa0,0x00,0xc0 = fnegd %f0, %f4
0x89,0xa0,0x00,0xe0 = fnegq %f0, %f4
0x89,0xa0,0x01,0x20 = fabss %f0, %f4
0x89,0xa0,0x01,0x40 = fabsd %f0, %f4
0x89,0xa0,0x01,0x60 = fabsq %f0, %f4
0x89,0xa0,0x05,0x20 = fsqrts %f0, %f4
0x89,0xa0,0x05,0x40 = fsqrtd %f0, %f4
0x89,0xa0,0x05,0x60 = fsqrtq %f0, %f4
0x91,0xa0,0x08,0x24 = fadds %f0, %f4, %f8
0x91,0xa0,0x08,0x44 = faddd %f0, %f4, %f8
0x91,0xa0,0x08,0x64 = faddq %f0, %f4, %f8
0xbf,0xa0,0x48,0x43 = faddd %f32, %f34, %f62
0xbb,0xa0,0x48,0x65 = faddq %f32, %f36, %f60
0x91,0xa0,0x08,0xa4 = fsubs %f0, %f4, %f8
0x91,0xa0,0x08,0xc4 = fsubd %f0, %f4, %f8
0x91,0xa0,0x08,0xe4 = fsubq %f0, %f4, %f8
0x91,0xa0,0x09,0x24 = fmuls %f0, %f4, %f8
0x91,0xa0,0x09,0x44 = fmuld %f0, %f4, %f8
0x91,0xa0,0x09,0x64 = fmulq %f0, %f4, %f8
0x91,0xa0,0x0d,0x24 = fsmuld %f0, %f4, %f8
0x91,0xa0,0x0d,0xc4 = fdmulq %f0, %f4, %f8
0x91,0xa0,0x09,0xa4 = fdivs %f0, %f4, %f8
0x91,0xa0,0x09,0xc4 = fdivd %f0, %f4, %f8
0x91,0xa0,0x09,0xe4 = fdivq %f0, %f4, %f8
0x81,0xa8,0x0a,0x24 = fcmps %fcc0, %f0, %f4
0x81,0xa8,0x0a,0x44 = fcmpd %fcc0, %f0, %f4
0x81,0xa8,0x0a,0x64 = fcmpq %fcc0, %f0, %f4
0x81,0xa8,0x0a,0xa4 = fcmpes %fcc0, %f0, %f4
0x81,0xa8,0x0a,0xc4 = fcmped %fcc0, %f0, %f4
0x81,0xa8,0x0a,0xe4 = fcmpeq %fcc0, %f0, %f4
0x85,0xa8,0x0a,0x24 = fcmps %fcc2, %f0, %f4
0x85,0xa8,0x0a,0x44 = fcmpd %fcc2, %f0, %f4
0x85,0xa8,0x0a,0x64 = fcmpq %fcc2, %f0, %f4
0x85,0xa8,0x0a,0xa4 = fcmpes %fcc2, %f0, %f4
0x85,0xa8,0x0a,0xc4 = fcmped %fcc2, %f0, %f4
0x85,0xa8,0x0a,0xe4 = fcmpeq %fcc2, %f0, %f4
0x89,0xa0,0x10,0x80 = fxtos %f0, %f4
0x89,0xa0,0x11,0x00 = fxtod %f0, %f4
0x89,0xa0,0x11,0x80 = fxtoq %f0, %f4
0x89,0xa0,0x10,0x20 = fstox %f0, %f4
0x89,0xa0,0x10,0x40 = fdtox %f0, %f4
0x89,0xa0,0x10,0x60 = fqtox %f0, %f4
