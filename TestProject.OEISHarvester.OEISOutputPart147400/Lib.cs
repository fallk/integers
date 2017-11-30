using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A176705
{
public static readonly long[] Value={ 8L,5L,3L,2L,5L,3L,1L,3L,4L,2L,6L,1L,8L,3L,1L,1L,12L,7L,1L,4L,2L,2L,3L,4L,7L,2L,6L,2L,3L,2L,3L,1L,1L,2L,1L,4L,1L,2L,7L,0L,3L,3L,2L,4L,3L,1L,2L,2L,1L,12L,3L,3L,2L,3L,4L,2L,1L,1L,5L,3L,1L,5L,1L,2L,3L,5L,3L,3L,2L,1L,2L,0L,3L,2L,1L,3L,1L,4L,4L,11L,5L,1L,4L,3L,7L,0L,3L,4L,2L,1L,1L,2L,5L,0L,2L,2L,2L,2L,4L,1L,3L,9L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176705Inst : IEnumerable<long>
{
public static readonly long[] Value=A176705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176705.Bytes);
public long this[int i]=>Value[i];

public static A176705Inst Instance=new A176705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176706
{
public static readonly long[] Value={ 2L,3L,7L,23L,131L,313L,353L,397L,887L,1307L,1439L,1783L,2003L,2027L,2069L,2111L,2593L,2777L,3541L,4111L,4201L,4889L,5653L,5897L,6421L,6823L,8353L,8447L,9721L,9749L,11159L,11483L,12011L,12073L,12251L,13313L,14323L,14431L,15083L,15131L,15887L,17029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176706Inst : IEnumerable<long>
{
public static readonly long[] Value=A176706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176706.Bytes);
public long this[int i]=>Value[i];

public static A176706Inst Instance=new A176706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176707
{
public static readonly long[] Value={ 2L,5L,3L,7L,9L,8L,10L,4L,5L,6L,5L,10L,12L,12L,7L,7L,7L,11L,7L,13L,13L,6L,9L,8L,12L,9L,7L,13L,9L,14L,11L,7L,13L,15L,10L,13L,10L,16L,15L,2L,9L,8L,10L,17L,15L,14L,10L,6L,16L,12L,9L,18L,11L,12L,13L,4L,17L,19L,10L,15L,10L,18L,16L,4L,18L,10L,6L,12L,11L,10L,12L,11L,12L,13L,12L,7L,16L,19L,14L,14L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176707Inst : IEnumerable<long>
{
public static readonly long[] Value=A176707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176707.Bytes);
public long this[int i]=>Value[i];

public static A176707Inst Instance=new A176707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176708
{
public static readonly long[] Value={ 1L,2L,6L,11L,17L,25L,34L,45L,58L,73L,89L,108L,128L,150L,174L,201L,229L,260L,292L,327L,364L,403L,443L,487L,533L,581L,631L,684L,738L,796L,855L,917L,981L,1047L,1115L,1188L,1262L,1338L,1416L,1498L,1581L,1668L,1756L,1847L,1941L,2037L,2134L,2236L,2340L,2447L,2556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176708Inst : IEnumerable<long>
{
public static readonly long[] Value=A176708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176708.Bytes);
public long this[int i]=>Value[i];

public static A176708Inst Instance=new A176708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176709
{
public static readonly long[] Value={ 1L,11L,901L,524137L,373486525L,268749463729L,193492277719861L,139314094050615817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176709Inst : IEnumerable<long>
{
public static readonly long[] Value=A176709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176709.Bytes);
public long this[int i]=>Value[i];

public static A176709Inst Instance=new A176709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176710
{
public static readonly long[] Value={ 1L,2L,12L,24L,144L,288L,1728L,3456L,20736L,41472L,248832L,497664L,2985984L,5971968L,35831808L,71663616L,429981696L,859963392L,5159780352L,10319560704L,61917364224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176710Inst : IEnumerable<long>
{
public static readonly long[] Value=A176710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176710.Bytes);
public long this[int i]=>Value[i];

public static A176710Inst Instance=new A176710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176711
{
public static readonly long[] Value={ 21L,285L,1365L,4221L,10197L,21021L,38805L,66045L,105621L,160797L,235221L,332925L,458325L,616221L,811797L,1050621L,1338645L,1682205L,2088021L,2563197L,3115221L,3751965L,4481685L,5313021L,6254997L,7317021L,8508885L,9840765L,11323221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176711Inst : IEnumerable<long>
{
public static readonly long[] Value=A176711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176711.Bytes);
public long this[int i]=>Value[i];

public static A176711Inst Instance=new A176711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176712
{
public static readonly long[] Value={ 285L,2805L,9405L,22197L,43677L,76725L,124605L,190965L,279837L,395637L,543165L,727605L,954525L,1229877L,1559997L,1951605L,2411805L,2948085L,3568317L,4280757L,5094045L,6017205L,7059645L,8231157L,9541917L,11002485L,12623805L,14417205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176712Inst : IEnumerable<long>
{
public static readonly long[] Value=A176712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176712.Bytes);
public long this[int i]=>Value[i];

public static A176712Inst Instance=new A176712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176713
{
public static readonly long[] Value={ 5L,7L,0L,1L,4L,0L,8L,1L,0L,2L,8L,5L,2L,7L,0L,8L,8L,9L,4L,7L,5L,6L,9L,9L,8L,3L,9L,0L,1L,8L,1L,5L,1L,5L,0L,9L,8L,7L,9L,9L,4L,7L,6L,3L,5L,9L,4L,0L,3L,3L,2L,9L,5L,0L,3L,9L,8L,4L,4L,6L,3L,1L,8L,2L,9L,2L,6L,0L,9L,2L,7L,7L,1L,4L,8L,0L,6L,9L,3L,2L,2L,0L,0L,5L,4L,4L,6L,4L,4L,8L,2L,9L,8L,5L,0L,7L,3L,1L,5L,0L,0L,1L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176713Inst : IEnumerable<long>
{
public static readonly long[] Value=A176713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176713.Bytes);
public long this[int i]=>Value[i];

public static A176713Inst Instance=new A176713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176714
{
public static readonly long[] Value={ 4L,0L,4L,8L,9L,9L,9L,5L,0L,6L,0L,5L,0L,8L,4L,6L,6L,3L,0L,5L,5L,4L,9L,3L,7L,7L,1L,4L,0L,5L,7L,7L,5L,1L,4L,4L,0L,2L,9L,5L,2L,5L,6L,4L,3L,0L,3L,5L,2L,7L,2L,7L,8L,9L,5L,6L,5L,7L,9L,3L,7L,7L,1L,9L,7L,5L,5L,0L,5L,1L,7L,3L,5L,5L,0L,2L,5L,8L,4L,3L,7L,2L,4L,7L,7L,3L,3L,9L,5L,6L,5L,8L,3L,8L,8L,0L,3L,8L,7L,3L,0L,1L,5L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176714Inst : IEnumerable<long>
{
public static readonly long[] Value=A176714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176714.Bytes);
public long this[int i]=>Value[i];

public static A176714Inst Instance=new A176714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176715
{
public static readonly long[] Value={ 6L,3L,6L,4L,7L,4L,6L,6L,5L,6L,3L,8L,7L,8L,2L,5L,1L,5L,0L,8L,4L,0L,5L,0L,4L,3L,7L,7L,5L,2L,2L,1L,9L,7L,8L,0L,0L,0L,0L,5L,9L,7L,2L,9L,6L,4L,4L,5L,8L,8L,7L,3L,9L,6L,7L,3L,0L,9L,9L,8L,1L,2L,3L,1L,8L,5L,3L,1L,3L,8L,4L,0L,6L,7L,3L,0L,6L,4L,7L,6L,7L,2L,1L,3L,2L,5L,3L,7L,6L,3L,5L,1L,0L,1L,5L,2L,3L,6L,6L,8L,6L,5L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176715Inst : IEnumerable<long>
{
public static readonly long[] Value=A176715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176715.Bytes);
public long this[int i]=>Value[i];

public static A176715Inst Instance=new A176715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176716
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,20L,26L,42L,52L,110L,130L,260L,286L,442L,484L,798L,850L,1196L,1306L,3190L,3320L,4030L,4290L,9620L,9906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176716Inst : IEnumerable<long>
{
public static readonly long[] Value=A176716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176716.Bytes);
public long this[int i]=>Value[i];

public static A176716Inst Instance=new A176716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176717
{
public static readonly long[] Value={ 13L,15L,16L,20L,79L,91L,111L,116L,117L,119L,125L,131L,205L,215L,225L,250L,276L,282L,284L,298L,303L,313L,332L,340L,362L,364L,446L,501L,523L,554L,562L,686L,720L,728L,759L,796L,798L,830L,877L,904L,923L,925L,953L,962L,978L,986L,988L,992L,1007L,1056L,1097L,1117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176717Inst : IEnumerable<long>
{
public static readonly long[] Value=A176717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176717.Bytes);
public long this[int i]=>Value[i];

public static A176717Inst Instance=new A176717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176718
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,55L,83L,121L,170L,232L,302L,379L,470L,571L,674L,781L,896L,1018L,1145L,1282L,1430L,1591L,1760L,1945L,2144L,2362L,2591L,2833L,3083L,3340L,3611L,3892L,4184L,4489L,4802L,5122L,5447L,5782L,6128L,6487L,6863L,7255L,7661L,8077L,8504L,8944L,9392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176718Inst : IEnumerable<long>
{
public static readonly long[] Value=A176718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176718.Bytes);
public long this[int i]=>Value[i];

public static A176718Inst Instance=new A176718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176719
{
public static readonly BigInteger[] Value={ 1L,2L,6L,30L,194L,1442L,11782L,103102L,951554L,9173186L,91780614L,948985822L,10110931650L,110794764642L,1247186300934L,14412811665278L,170949340705794L,2081185257723778L,26012832364535814L,333929563132811678L,4404347475363755714L,BigInteger.Parse("59705917899701420834"),BigInteger.Parse("832080588205468939782") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176719Inst Instance=new A176719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176720
{
public static readonly long[] Value={ 1L,2L,4L,8L,18L,44L,112L,288L,744L,1938L,5104L,13584L,36456L,98468L,267376L,729488L,1999074L,5500412L,15189636L,42084952L,116949848L,325878288L,910333152L,2548892864L,7152113760L,20108587038L,56641227416L,159820928328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176720Inst : IEnumerable<long>
{
public static readonly long[] Value=A176720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176720.Bytes);
public long this[int i]=>Value[i];

public static A176720Inst Instance=new A176720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176721
{
public static readonly BigInteger[] Value={ 2L,30205L,133050536L,1713435083707L,12173043638400828L,BigInteger.Parse("151229306063970112979"),BigInteger.Parse("1815272942608097141328160"),BigInteger.Parse("16183327444272811414262846321"),BigInteger.Parse("331634334544577293143126414662454") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176721Inst Instance=new A176721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176722
{
public static readonly long[] Value={ 13L,229L,1013L,1741L,39317L,64013L,74101L,157477L,438989L,551381L,830597L,1906637L,2000389L,4096013L,7077901L,9261013L,10941061L,15625013L,16003021L,21024589L,24897101L,27000013L,69934541L,74088013L,79507013L,93576677L,122023949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176722Inst : IEnumerable<long>
{
public static readonly long[] Value=A176722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176722.Bytes);
public long this[int i]=>Value[i];

public static A176722Inst Instance=new A176722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176723
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176723Inst : IEnumerable<long>
{
public static readonly long[] Value=A176723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176723.Bytes);
public long this[int i]=>Value[i];

public static A176723Inst Instance=new A176723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176724
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,2L,1L,1L,1L,0L,0L,0L,1L,0L,1L,2L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,2L,1L,1L,1L,0L,0L,0L,0L,0L,2L,1L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,1L,2L,1L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,2L,1L,2L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176724Inst : IEnumerable<long>
{
public static readonly long[] Value=A176724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176724.Bytes);
public long this[int i]=>Value[i];

public static A176724Inst Instance=new A176724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176725
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,2L,1L,3L,2L,2L,1L,3L,2L,2L,1L,3L,2L,2L,1L,3L,3L,2L,2L,2L,1L,4L,3L,3L,2L,2L,2L,1L,4L,3L,3L,2L,2L,2L,1L,4L,3L,3L,3L,2L,3L,2L,2L,2L,1L,4L,4L,3L,3L,3L,2L,3L,2L,2L,2L,1L,4L,4L,3L,3L,3L,2L,3L,2L,2L,2L,1L,5L,4L,3L,4L,3L,3L,3L,2L,3L,2L,3L,2L,2L,2L,1L,5L,4L,4L,4L,3L,4L,3L,3L,3L,2L,3L,2L,3L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176725Inst : IEnumerable<long>
{
public static readonly long[] Value=A176725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176725.Bytes);
public long this[int i]=>Value[i];

public static A176725Inst Instance=new A176725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176726
{
public static readonly BigInteger[] Value={ 1L,0L,-2L,0L,-32L,0L,-704L,0L,-54784L,0L,-2610176L,0L,-10976325632L,0L,-52971659264L,0L,-179326416191488L,0L,-24309257264168960L,0L,BigInteger.Parse("-69389116291423404032"),0L,BigInteger.Parse("-8404514249426618810368"),0L,BigInteger.Parse("-81520321871322828385550336"),0L,BigInteger.Parse("-438807077783516207378333696"),0L,BigInteger.Parse("-690781531822985516802849636352") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176726Inst Instance=new A176726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176727
{
public static readonly long[] Value={ 1L,1L,3L,1L,15L,1L,21L,1L,45L,1L,33L,1L,1365L,1L,45L,1L,765L,1L,399L,1L,3465L,1L,1035L,1L,20475L,1L,189L,1L,435L,1L,7161L,1L,58905L,1L,315L,1L,959595L,1L,117L,1L,20295L,1L,148995L,1L,108675L,1L,14805L,1L,2436525L,1L,65637L,1L,78705L,1L,21945L,1L,24795L,1L,531L,1L,85180095L,1L,135135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176727Inst : IEnumerable<long>
{
public static readonly long[] Value=A176727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176727.Bytes);
public long this[int i]=>Value[i];

public static A176727Inst Instance=new A176727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176728
{
public static readonly BigInteger[] Value={ 1L,0L,-1L,0L,-17L,0L,-1955L,0L,-44089L,0L,-4627969L,0L,-10431967727L,0L,-424734574531L,0L,-187497600357613L,0L,-263146180762981877L,0L,BigInteger.Parse("-77335840394370605087"),0L,BigInteger.Parse("-38414950218116664660463"),0L,BigInteger.Parse("-95193934978797641162562791"),0L,BigInteger.Parse("-1044549307308161782597280065"),0L,BigInteger.Parse("-836232289988098415162220532417") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176728Inst Instance=new A176728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176729
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,6L,1L,24L,1L,10L,1L,12L,1L,210L,1L,48L,1L,90L,1L,420L,1L,330L,1L,360L,1L,1638L,1L,28L,1L,30L,1L,7392L,1L,510L,1L,36L,1L,51870L,1L,840L,1L,6930L,1L,13860L,1L,4830L,1L,1008L,1L,99450L,1L,5148L,1L,2970L,1L,3192L,1L,870L,1L,180L,1L,2792790L,1L,137280L,1L,1530L,1L,5796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176729Inst : IEnumerable<long>
{
public static readonly long[] Value=A176729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176729.Bytes);
public long this[int i]=>Value[i];

public static A176729Inst Instance=new A176729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176730
{
public static readonly BigInteger[] Value={ 1L,6L,180L,12960L,1710720L,359251200L,109930867200L,46170964224000L,25486372251648000L,17891433320656896000UL,BigInteger.Parse("15565546988971499520000"),BigInteger.Parse("16437217620353903493120000"),BigInteger.Parse("20710894201645918401331200000"),BigInteger.Parse("30693545206839251070772838400000"),BigInteger.Parse("52854284846177190343870827724800000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176730Inst Instance=new A176730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176731
{
public static readonly BigInteger[] Value={ 1L,12L,504L,45360L,7076160L,1698278400L,580811212800L,268334780313600L,161000868188160000L,BigInteger.Parse("121716656350248960000"),BigInteger.Parse("113196490405731532800000"),BigInteger.Parse("127006462235230779801600000"),BigInteger.Parse("169172607697327398695731200000"),BigInteger.Parse("263909268007830741965340672000000"),BigInteger.Parse("476620138022142319989405253632000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176731Inst Instance=new A176731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176732
{
public static readonly BigInteger[] Value={ 1L,6L,43L,356L,3333L,34754L,398959L,4996032L,67741129L,988344062L,15434831091L,256840738076L,4536075689293L,84731451264186L,1668866557980343L,34563571477305464L,750867999393119889L,17072113130285524982UL,BigInteger.Parse("405423357986250112699"),BigInteger.Parse("10037458628015142154452"),BigInteger.Parse("258639509502117306002581") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176732Inst Instance=new A176732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176733
{
public static readonly BigInteger[] Value={ 1L,7L,57L,527L,5441L,61959L,770713L,10391023L,150869313L,2346167879L,38896509881L,684702346767L,12752503850497L,250514001320647L,5176062576469401L,112204510124346479L,2546140161382663553L,BigInteger.Parse("60356495873790805383"),BigInteger.Parse("1491840283714484609593"),BigInteger.Parse("38382424018590349736719") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176733Inst Instance=new A176733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176734
{
public static readonly BigInteger[] Value={ 1L,8L,73L,746L,8425L,104084L,1395217L,20157542L,312129649L,5155334720L,90449857081L,1679650774658L,32908313146393L,678322072223756L,14672571587601985L,332293083938376254L,7862829504396683617L,BigInteger.Parse("194024597448534426872"),BigInteger.Parse("4984283037788104293289"),BigInteger.Parse("133083801736564331309210") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176734Inst Instance=new A176734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176735
{
public static readonly BigInteger[] Value={ 1L,9L,91L,1019L,12501L,166589L,2394751L,36920799L,607496041L,10622799089L,196677847971L,3843107102339L,79025598374461L,1705654851091749L,38551739502886471L,910569176481673319L,BigInteger.Parse("22431936328103456721"),BigInteger.Parse("575367515026293191129"),BigInteger.Parse("15340898308261381733611"),BigInteger.Parse("424560869593530584247819") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176735Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176735.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176735Inst Instance=new A176735Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176736
{
public static readonly BigInteger[] Value={ 1L,10L,111L,1352L,17909L,256134L,3931555L,64441684L,1123029513L,20730064706L,403978495031L,8286870547680L,178468044946621L,4025739435397822L,94912091598455979L,2334250550458513004L,BigInteger.Parse("59779945135439664785"),BigInteger.Parse("1591626582328767492474"),BigInteger.Parse("43990176790179196598143"),BigInteger.Parse("1260374228606935319612536") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176736Inst Instance=new A176736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176737
{
public static readonly long[] Value={ 1L,0L,4L,3L,16L,24L,73L,144L,364L,795L,1888L,4272L,9937L,22752L,52564L,120819L,278512L,640968L,1476505L,3399408L,7828924L,18027147L,41513920L,95595360L,220137121L,506923200L,1167334564L,2688104163L,6190107856L,14254420344L,32824743913L,75588004944L,174062236684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176737Inst : IEnumerable<long>
{
public static readonly long[] Value=A176737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176737.Bytes);
public long this[int i]=>Value[i];

public static A176737Inst Instance=new A176737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176738
{
public static readonly long[] Value={ 1L,0L,5L,4L,25L,40L,141L,300L,865L,2064L,5525L,13780L,35881L,91000L,234525L,598524L,1536625L,3930720L,10077221L,25800100L,66108985L,169309384L,433745325L,1110982860L,2845964161L,7289895600L,18673752245L,47833334644L,122528343625L,313861682200L,803975056701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176738Inst : IEnumerable<long>
{
public static readonly long[] Value=A176738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176738.Bytes);
public long this[int i]=>Value[i];

public static A176738Inst Instance=new A176738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176739
{
public static readonly long[] Value={ 1L,0L,2L,4L,4L,16L,24L,48L,112L,192L,416L,832L,1600L,3328L,6528L,13056L,26368L,52224L,104960L,209920L,418816L,839680L,1677312L,3354624L,6713344L,13418496L,26845184L,53690368L,107364352L,214761472L,429490176L,858980352L,1718026240L,3435921408L,6871973888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176739Inst : IEnumerable<long>
{
public static readonly long[] Value=A176739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176739.Bytes);
public long this[int i]=>Value[i];

public static A176739Inst Instance=new A176739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176740
{
public static readonly long[] Value={ -1L,-1L,3L,-1L,10L,-15L,-1L,15L,10L,-105L,105L,-1L,21L,35L,-210L,-280L,1260L,-945L,-1L,28L,56L,35L,-378L,-1260L,-280L,3150L,6300L,-17325L,10395L,-1L,36L,84L,126L,-630L,-2520L,-1575L,-2100L,6930L,34650L,15400L,-51975L,-138600L,270270L,-135135L,-1L,45L,120L,210L,126L,-990L,-4620L,-6930L,-4620L,-5775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176740Inst : IEnumerable<long>
{
public static readonly long[] Value=A176740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176740.Bytes);
public long this[int i]=>Value[i];

public static A176740Inst Instance=new A176740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176741
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,2L,5L,7L,2L,9L,11L,2L,13L,11L,24L,35L,11L,46L,35L,81L,116L,35L,151L,186L,35L,221L,186L,407L,593L,186L,779L,965L,186L,1151L,965L,2116L,3081L,965L,4046L,3081L,7127L,10208L,3081L,13289L,16370L,3081L,19451L,16370L,35821L,52191L,16370L,68561L,52191L,120752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176741Inst : IEnumerable<long>
{
public static readonly long[] Value=A176741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176741.Bytes);
public long this[int i]=>Value[i];

public static A176741Inst Instance=new A176741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176742
{
public static readonly long[] Value={ 1L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L,0L,-2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176742Inst : IEnumerable<long>
{
public static readonly long[] Value=A176742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176742.Bytes);
public long this[int i]=>Value[i];

public static A176742Inst Instance=new A176742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176743
{
public static readonly long[] Value={ 1L,3L,2L,10L,3L,7L,4L,18L,5L,11L,6L,26L,7L,15L,8L,34L,9L,19L,10L,42L,11L,23L,12L,50L,13L,27L,14L,58L,15L,31L,16L,66L,17L,35L,18L,74L,19L,39L,20L,82L,21L,43L,22L,90L,23L,47L,24L,98L,25L,51L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176743Inst : IEnumerable<long>
{
public static readonly long[] Value=A176743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176743.Bytes);
public long this[int i]=>Value[i];

public static A176743Inst Instance=new A176743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176744
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,11L,16L,21L,23L,25L,31L,33L,36L,38L,43L,49L,51L,64L,77L,81L,83L,91L,96L,100L,118L,121L,135L,144L,150L,163L,169L,176L,189L,196L,203L,211L,213L,223L,225L,230L,237L,243L,256L,278L,283L,289L,291L,315L,324L,350L,361L,390L,395L,400L,408L,430L,437L,441L,484L,497L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176744Inst : IEnumerable<long>
{
public static readonly long[] Value=A176744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176744.Bytes);
public long this[int i]=>Value[i];

public static A176744Inst Instance=new A176744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176745
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,8L,13L,16L,19L,22L,25L,28L,31L,32L,37L,42L,52L,64L,75L,78L,81L,87L,90L,93L,99L,102L,105L,108L,111L,114L,126L,128L,138L,149L,152L,155L,161L,164L,167L,173L,176L,179L,182L,185L,188L,200L,212L,223L,226L,229L,235L,238L,241L,247L,250L,253L,256L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176745Inst : IEnumerable<long>
{
public static readonly long[] Value=A176745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176745.Bytes);
public long this[int i]=>Value[i];

public static A176745Inst Instance=new A176745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176746
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,12L,13L,19L,21L,28L,34L,43L,50L,54L,55L,61L,65L,72L,79L,89L,96L,103L,112L,118L,128L,135L,142L,144L,159L,174L,181L,188L,204L,210L,219L,226L,233L,237L,251L,257L,266L,290L,296L,310L,314L,334L,341L,356L,366L,373L,377L,383L,397L,412L,419L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176746Inst : IEnumerable<long>
{
public static readonly long[] Value=A176746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176746.Bytes);
public long this[int i]=>Value[i];

public static A176746Inst Instance=new A176746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176747
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,10L,14L,15L,21L,23L,28L,32L,36L,40L,45L,52L,55L,66L,74L,78L,82L,86L,91L,105L,113L,117L,120L,124L,136L,153L,155L,166L,171L,184L,190L,197L,201L,209L,210L,217L,228L,231L,247L,253L,276L,278L,300L,311L,325L,349L,351L,378L,390L,406L,435L,439L,465L,474L,496L,516L,518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176747Inst : IEnumerable<long>
{
public static readonly long[] Value=A176747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176747.Bytes);
public long this[int i]=>Value[i];

public static A176747Inst Instance=new A176747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176748
{
public static readonly BigInteger[] Value={ 1L,2L,7L,341L,39651814L,BigInteger.Parse("62343213007067363340803"),BigInteger.Parse("242307882727623698206171607564035372782206955665032728479504584309813") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176748Inst Instance=new A176748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176749
{
public static readonly long[] Value={ 1L,3L,5L,18L,65L,262L,1093L,4731L,20979L,94930L,436451L,2033321L,9577653L,45538184L,218263593L,1053456780L,5115724797L,24977183908L,122537039845L,603755499411L,2986339566083L,14823218200440L,73813096856015L,368631268757920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176749Inst : IEnumerable<long>
{
public static readonly long[] Value=A176749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176749.Bytes);
public long this[int i]=>Value[i];

public static A176749Inst Instance=new A176749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176750
{
public static readonly long[] Value={ 1L,4L,7L,29L,113L,506L,2321L,11112L,54429L,272364L,1384701L,7135397L,37178543L,195556526L,1036967927L,5537451445L,29752654081L,160731437308L,872518135861L,4756932856431L,26035840213731L,143003903810742L,787983925181427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176750Inst : IEnumerable<long>
{
public static readonly long[] Value=A176750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176750.Bytes);
public long this[int i]=>Value[i];

public static A176750Inst Instance=new A176750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176751
{
public static readonly long[] Value={ 1L,5L,9L,42L,173L,846L,4177L,21691L,114911L,622910L,3428951L,19138401L,108003785L,615344844L,3534413525L,20444816044L,118994823449L,696370777980L,4095034311841L,24185709305851L,143402427296079L,853276282454676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176751Inst : IEnumerable<long>
{
public static readonly long[] Value=A176751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176751.Bytes);
public long this[int i]=>Value[i];

public static A176751Inst Instance=new A176751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176752
{
public static readonly long[] Value={ 1L,0L,-2L,-6L,-14L,-26L,-30L,30L,330L,1286L,3538L,6910L,5434L,-28618L,-182302L,-654098L,-1693750L,-2852570L,264050L,25822302L,126877786L,411465750L,956711938L,1191638734L,-2480333334L,-23263594746L,-96124321390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176752Inst : IEnumerable<long>
{
public static readonly long[] Value=A176752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176752.Bytes);
public long this[int i]=>Value[i];

public static A176752Inst Instance=new A176752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176753
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-4L,-12L,-34L,-93L,-248L,-644L,-1622L,-3932L,-9054L,-19314L,-36066L,-48953L,8372L,415848L,2180870L,8609676L,29858358L,95443242L,286747530L,815867808L,2199049782L,5577559986L,13083598882L,27240793594L,44583397354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176753Inst : IEnumerable<long>
{
public static readonly long[] Value=A176753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176753.Bytes);
public long this[int i]=>Value[i];

public static A176753Inst Instance=new A176753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176754
{
public static readonly long[] Value={ 1L,2L,2L,6L,18L,62L,218L,790L,2914L,10926L,41514L,159558L,619314L,2424414L,9561594L,37956726L,151548930L,608199182L,2452070090L,9926901670L,40338175954L,164471889342L,672683135130L,2759049956566L,11345904429730L,46769328002414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176754Inst : IEnumerable<long>
{
public static readonly long[] Value=A176754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176754.Bytes);
public long this[int i]=>Value[i];

public static A176754Inst Instance=new A176754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176755
{
public static readonly long[] Value={ 1L,3L,4L,15L,52L,208L,846L,3579L,15456L,68096L,304570L,1379980L,6319978L,29211278L,136086710L,638364319L,3012609980L,14293438828L,68139158918L,326218902372L,1567802352910L,7561126873098L,36581288824402L,177496766695528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176755Inst : IEnumerable<long>
{
public static readonly long[] Value=A176755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176755.Bytes);
public long this[int i]=>Value[i];

public static A176755Inst Instance=new A176755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176756
{
public static readonly long[] Value={ 1L,4L,6L,26L,98L,438L,1970L,9294L,44698L,219766L,1096930L,5549614L,28383498L,146538150L,762627954L,3996744862L,21074272538L,111723476502L,595145562242L,3183988894350L,17100312159018L,92164073738118L,498318304290450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176756Inst : IEnumerable<long>
{
public static readonly long[] Value=A176756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176756.Bytes);
public long this[int i]=>Value[i];

public static A176756Inst Instance=new A176756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176757
{
public static readonly long[] Value={ 1L,5L,8L,39L,156L,764L,3710L,19075L,99640L,533316L,2895978L,15948420L,88781874L,498980622L,2827021998L,16129973367L,92598274980L,534480546320L,3099969839270L,18057658897612L,105598220332966L,619702140284970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176757Inst : IEnumerable<long>
{
public static readonly long[] Value=A176757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176757.Bytes);
public long this[int i]=>Value[i];

public static A176757Inst Instance=new A176757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176758
{
public static readonly long[] Value={ 2L,8L,28L,88L,264L,768L,2192L,6176L,17248L,47872L,132288L,364416L,1001600L,2748416L,7532800L,20627968L,56452608L,154423296L,422276096L,1154447360L,3155544064L,8624177152L,23567831040L,64400793600L,175970803712L,480810303488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176758Inst : IEnumerable<long>
{
public static readonly long[] Value=A176758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176758.Bytes);
public long this[int i]=>Value[i];

public static A176758Inst Instance=new A176758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176759
{
public static readonly long[] Value={ 1L,0L,1L,4L,11L,27L,67L,178L,505L,1489L,4473L,13593L,41749L,129579L,406021L,1282464L,4077987L,13041655L,41919347L,135352451L,438827223L,1427986281L,4662359911L,15268900019L,50143755435L,165095296125L,544847069819L,1802020334105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176759Inst : IEnumerable<long>
{
public static readonly long[] Value=A176759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176759.Bytes);
public long this[int i]=>Value[i];

public static A176759Inst Instance=new A176759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176760
{
public static readonly long[] Value={ 0L,1L,3L,10L,17L,19L,27L,30L,57L,93L,100L,170L,190L,219L,267L,270L,300L,314L,327L,359L,387L,417L,423L,424L,570L,685L,693L,807L,828L,891L,917L,930L,963L,1000L,1207L,1223L,1317L,1333L,1673L,1693L,1700L,1827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176760Inst : IEnumerable<long>
{
public static readonly long[] Value=A176760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176760.Bytes);
public long this[int i]=>Value[i];

public static A176760Inst Instance=new A176760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176761
{
public static readonly long[] Value={ 1L,3L,35L,39L,295L,311L,33079L,33087L,37183L,38207L,1099511665983L,1099511666111L,1099511797183L,1099512059327L,1099514156479L,1099514156495L,1099648374223L,1100722116047L,1100722124239L,1100722126287L,1100722388431L,9896815410639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176761Inst : IEnumerable<long>
{
public static readonly long[] Value=A176761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176761.Bytes);
public long this[int i]=>Value[i];

public static A176761Inst Instance=new A176761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176762
{
public static readonly long[] Value={ 1L,10L,13L,23L,19L,7L,356L,4L,2L,11L,15L,5L,3L,14L,45L,36L,6L,112L,269L,15999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176762Inst : IEnumerable<long>
{
public static readonly long[] Value=A176762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176762.Bytes);
public long this[int i]=>Value[i];

public static A176762Inst Instance=new A176762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176763
{
public static readonly long[] Value={ 1L,27L,3L,243L,6561L,6561L,27L,81L,9L,10460353203L,1162261467L,129140163L,31381059609L,177147L,1594323L,129140163L,177147L,2187L,19683L,387420489L,2187L,1162261467L,1594323L,243L,2541865828329L,1162261467L,27L,282429536481L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176763Inst : IEnumerable<long>
{
public static readonly long[] Value=A176763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176763.Bytes);
public long this[int i]=>Value[i];

public static A176763Inst Instance=new A176763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176764
{
public static readonly BigInteger[] Value={ 1L,256L,16384L,4L,256L,16L,1048576L,16384L,4096L,1024L,1099511627776L,1125899906842624L,BigInteger.Parse("1180591620717411303424"),262144L,288230376151711744L,16L,17179869184L,1073741824L,4194304L,72057594037927936L,262144L,BigInteger.Parse("4722366482869645213696") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176764Inst Instance=new A176764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176765
{
public static readonly BigInteger[] Value={ 1L,25L,3125L,48828125L,5L,625L,78125L,78125L,390625L,6103515625L,11920928955078125L,125L,BigInteger.Parse("931322574615478515625"),244140625L,15625L,95367431640625L,30517578125L,2384185791015625L,1953125L,1220703125L,BigInteger.Parse("116415321826934814453125") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176765Inst Instance=new A176765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176766
{
public static readonly BigInteger[] Value={ 1L,216L,36L,46656L,46656L,6L,7776L,2176782336L,1296L,10077696L,2821109907456L,1296L,13060694016L,BigInteger.Parse("6140942214464815497216"),101559956668416L,216L,60466176L,470184984576L,21936950640377856L,BigInteger.Parse("170581728179578208256"),216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176766Inst Instance=new A176766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176767
{
public static readonly long[] Value={ 2401L,1L,2401L,343L,49L,823543L,16807L,7L,16807L,49L,96889010407L,117649L,13841287201L,13841287201L,11398895185373143L,4747561509943L,16807L,117649L,11398895185373143L,1977326743L,13841287201L,3909821048582988049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176767Inst : IEnumerable<long>
{
public static readonly long[] Value=A176767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176767.Bytes);
public long this[int i]=>Value[i];

public static A176767Inst Instance=new A176767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176768
{
public static readonly ulong[] Value={ 1L,512L,32768L,64L,512L,64L,32768L,8L,4096L,1073741824L,4398046511104L,512L,134217728L,262144L,2097152L,16777216L,134217728L,1073741824L,68719476736L,2097152L,262144L,2251799813685248L,9223372036854775808UL,1073741824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176768Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A176768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176768.Bytes);
public ulong this[int i]=>Value[i];

public static A176768Inst Instance=new A176768Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176769
{
public static readonly BigInteger[] Value={ 1L,729L,531441L,59049L,6561L,6561L,729L,81L,9L,31381059609L,205891132094649L,150094635296999121L,31381059609L,531441L,150094635296999121L,16677181699666569L,1350851717672992089L,2541865828329L,BigInteger.Parse("8862938119652501095929") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176769Inst Instance=new A176769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176770
{
public static readonly BigInteger[] Value={ 1L,121L,1331L,14641L,161051L,14641L,1771561L,19487171L,19487171L,161051L,11L,121L,1331L,14641L,1771561L,161051L,1771561L,BigInteger.Parse("9849732675807611094711841"),19487171L,BigInteger.Parse("672749994932560009201"),121L,34522712143931L,2357947691L,25937424601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176770Inst Instance=new A176770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176771
{
public static readonly BigInteger[] Value={ 1L,12L,20736L,144L,2985984L,20736L,1728L,1728L,2985984L,8916100448256L,2218611106740436992L,12L,BigInteger.Parse("79496847203390844133441536"),144L,5159780352L,429981696L,1728L,35831808L,61917364224L,20736L,15407021574586368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176771Inst Instance=new A176771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176772
{
public static readonly BigInteger[] Value={ 1L,2197L,13L,4826809L,28561L,169L,2197L,28561L,169L,10604499373L,51185893014090757L,371293L,13L,51185893014090757L,815730721L,169L,62748517L,137858491849L,2197L,BigInteger.Parse("1461920290375446110677"),2197L,23298085122481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176772Inst Instance=new A176772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176773
{
public static readonly BigInteger[] Value={ 1L,2744L,38416L,14L,537824L,196L,2744L,38416L,196L,105413504L,11112006825558016L,56693912375296L,105413504L,14L,155568095557812224L,38416L,2177953337809371136L,BigInteger.Parse("5976303958948914397184"),196L,20661046784L,2177953337809371136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176773Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176773.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176773Inst Instance=new A176773Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176774
{
public static readonly long[] Value={ 3L,4L,5L,3L,7L,8L,4L,3L,11L,5L,13L,14L,3L,4L,17L,7L,19L,20L,3L,5L,23L,9L,4L,26L,10L,3L,29L,11L,31L,32L,12L,7L,5L,3L,37L,38L,14L,8L,41L,15L,43L,44L,3L,9L,47L,17L,4L,50L,5L,10L,53L,19L,3L,56L,20L,11L,59L,21L,61L,62L,22L,4L,8L,3L,67L,68L,24L,5L,71L,25L,73L,74L,9L,14L,77L,3L,79L,80L,4L,15L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176774Inst : IEnumerable<long>
{
public static readonly long[] Value=A176774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176774.Bytes);
public long this[int i]=>Value[i];

public static A176774Inst Instance=new A176774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176775
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,2L,3L,4L,2L,3L,2L,2L,5L,4L,2L,3L,2L,2L,6L,4L,2L,3L,5L,2L,3L,7L,2L,3L,2L,2L,3L,4L,5L,8L,2L,2L,3L,4L,2L,3L,2L,2L,9L,4L,2L,3L,7L,2L,6L,4L,2L,3L,10L,2L,3L,4L,2L,3L,2L,2L,3L,8L,5L,11L,2L,2L,3L,7L,2L,3L,2L,2L,5L,4L,2L,12L,2L,2L,9L,4L,2L,3L,5L,2L,3L,4L,2L,3L,13L,8L,3L,4L,5L,6L,2L,2L,3L,10L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176775Inst : IEnumerable<long>
{
public static readonly long[] Value=A176775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176775.Bytes);
public long this[int i]=>Value[i];

public static A176775Inst Instance=new A176775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176776
{
public static readonly long[] Value={ 1L,3L,4L,5L,8L,17L,40L,93L,208L,449L,944L,1949L,3976L,8049L,16216L,32573L,65312L,130817L,261856L,523965L,1048216L,2096753L,4193864L,8388125L,16776688L,33553857L,67108240L,134217053L,268434728L,536870129L,1073740984L,2147482749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176776Inst : IEnumerable<long>
{
public static readonly long[] Value=A176776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176776.Bytes);
public long this[int i]=>Value[i];

public static A176776Inst Instance=new A176776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176777
{
public static readonly long[] Value={ 1L,4L,6L,8L,12L,22L,46L,100L,216L,458L,954L,1960L,3988L,8062L,16230L,32588L,65328L,130834L,261874L,523984L,1048236L,2096774L,4193886L,8388148L,16776712L,33553882L,67108266L,134217080L,268434756L,536870158L,1073741014L,2147482780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176777Inst : IEnumerable<long>
{
public static readonly long[] Value=A176777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176777.Bytes);
public long this[int i]=>Value[i];

public static A176777Inst Instance=new A176777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176778
{
public static readonly long[] Value={ 1L,-1L,-4L,-7L,-8L,-3L,16L,65L,176L,413L,904L,1905L,3928L,7997L,16160L,32513L,65248L,130749L,261784L,523889L,1048136L,2096669L,4193776L,8388033L,16776592L,33553757L,67108136L,134216945L,268434616L,536870013L,1073740864L,2147482625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176778Inst : IEnumerable<long>
{
public static readonly long[] Value=A176778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176778.Bytes);
public long this[int i]=>Value[i];

public static A176778Inst Instance=new A176778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176779
{
public static readonly long[] Value={ 1L,12L,121L,1011L,1121L,10111L,11121L,109911L,111311L,111211L,1101111L,1112211L,1111211L,11011111L,11192111L,11111211L,11112111L,111011111L,111113111L,111122111L,111112111L,1110111111L,1111122111L,1111921111L,1111112111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176779Inst : IEnumerable<long>
{
public static readonly long[] Value=A176779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176779.Bytes);
public long this[int i]=>Value[i];

public static A176779Inst Instance=new A176779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176780
{
public static readonly long[] Value={ 6L,42L,156L,420L,930L,1806L,3192L,5256L,8190L,12210L,17556L,24492L,33306L,44310L,57840L,74256L,93942L,117306L,144780L,176820L,213906L,256542L,305256L,360600L,423150L,493506L,572292L,660156L,757770L,865830L,985056L,1116192L,1260006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176780Inst : IEnumerable<long>
{
public static readonly long[] Value=A176780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176780.Bytes);
public long this[int i]=>Value[i];

public static A176780Inst Instance=new A176780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176781
{
public static readonly long[] Value={ 3L,11L,3L,17L,3L,3L,3L,11L,89L,41L,257L,3L,29L,131L,353L,3L,3L,11L,89L,521L,257L,3L,17L,3L,467L,89L,149L,17L,71L,47L,293L,17L,191L,47L,3L,41L,23L,11L,401L,41L,443L,41L,293L,479L,311L,23L,587L,41L,1289L,1013L,29L,41L,59L,293L,1031L,17L,23L,17L,347L,401L,599L,11L,227L,827L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176781Inst : IEnumerable<long>
{
public static readonly long[] Value=A176781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176781.Bytes);
public long this[int i]=>Value[i];

public static A176781Inst Instance=new A176781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176782
{
public static readonly BigInteger[] Value={ 1L,2L,6L,212L,9528116L,BigInteger.Parse("865009958745459864472"),BigInteger.Parse("647236979404329414852005811109907426259024826523626405446225816") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176782Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176782.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176782Inst Instance=new A176782Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176783
{
public static readonly long[] Value={ 17L,59L,127L,487L,659L,857L,1607L,2237L,2591L,2971L,4751L,5261L,6359L,6947L,7561L,8867L,15131L,17909L,19891L,20921L,21977L,23059L,25301L,27647L,28859L,30097L,33967L,36677L,42409L,50159L,51787L,53441L,56827L,60317L,69497L,71411L,73351L,81371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176783Inst : IEnumerable<long>
{
public static readonly long[] Value=A176783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176783.Bytes);
public long this[int i]=>Value[i];

public static A176783Inst Instance=new A176783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176784
{
public static readonly long[] Value={ 1L,1L,-3L,-1L,2L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176784Inst : IEnumerable<long>
{
public static readonly long[] Value=A176784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176784.Bytes);
public long this[int i]=>Value[i];

public static A176784Inst Instance=new A176784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176785
{
public static readonly BigInteger[] Value={ 0L,1L,0L,4L,24L,256L,3360L,53824L,1016064L,22095616L,543966720L,14955833344L,454227400704L,15103031627776L,545668238868480L,21286707282264064L,891735287528914944L,BigInteger.Parse("39926103010743156736") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176785Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176785.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176785Inst Instance=new A176785Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176786
{
public static readonly long[] Value={ 6L,4L,8L,6L,8L,6L,6L,8L,2L,6L,4L,4L,8L,8L,6L,2L,4L,2L,2L,2L,8L,2L,6L,2L,4L,4L,8L,6L,4L,2L,8L,6L,2L,6L,2L,8L,2L,6L,2L,8L,4L,6L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176786Inst : IEnumerable<long>
{
public static readonly long[] Value=A176786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176786.Bytes);
public long this[int i]=>Value[i];

public static A176786Inst Instance=new A176786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176787
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,2L,4L,4L,8L,0L,5L,8L,0L,4L,5L,12L,9L,8L,15L,0L,11L,16L,19L,20L,20L,0L,17L,4L,20L,20L,10L,28L,5L,26L,25L,8L,0L,34L,26L,20L,2L,32L,6L,16L,35L,42L,7L,44L,11L,20L,26L,0L,21L,44L,5L,4L,53L,20L,33L,20L,49L,10L,53L,60L,0L,38L,6L,60L,65L,60L,65L,44L,16L,0L,20L,72L,60L,26L,5L,60L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176787Inst : IEnumerable<long>
{
public static readonly long[] Value=A176787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176787.Bytes);
public long this[int i]=>Value[i];

public static A176787Inst Instance=new A176787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176788
{
public static readonly long[] Value={ 0L,0L,1L,3L,0L,0L,1L,7L,0L,2L,6L,3L,12L,10L,12L,3L,13L,6L,11L,7L,3L,8L,14L,15L,12L,22L,15L,3L,19L,12L,16L,11L,30L,14L,17L,15L,17L,34L,9L,7L,26L,24L,36L,19L,42L,8L,2L,3L,24L,12L,48L,35L,2L,42L,52L,31L,15L,22L,51L,27L,32L,56L,24L,27L,22L,30L,6L,31L,54L,52L,12L,15L,7L,56L,12L,15L,52L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176788Inst : IEnumerable<long>
{
public static readonly long[] Value=A176788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176788.Bytes);
public long this[int i]=>Value[i];

public static A176788Inst Instance=new A176788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176789
{
public static readonly long[] Value={ 0L,0L,2L,3L,2L,4L,5L,7L,4L,4L,2L,7L,3L,0L,4L,3L,5L,10L,3L,19L,7L,4L,3L,7L,14L,0L,10L,7L,5L,4L,29L,11L,4L,6L,14L,19L,4L,26L,13L,39L,13L,28L,2L,15L,19L,20L,11L,19L,14L,14L,40L,39L,0L,10L,4L,7L,7L,8L,7L,19L,26L,38L,28L,27L,39L,4L,57L,23L,43L,14L,5L,55L,30L,6L,64L,7L,70L,52L,50L,19L,37L,10L,75L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176789Inst : IEnumerable<long>
{
public static readonly long[] Value=A176789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176789.Bytes);
public long this[int i]=>Value[i];

public static A176789Inst Instance=new A176789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176790
{
public static readonly long[] Value={ 3137L,4357L,13457L,80657L,115601L,184901L,309137L,341057L,1008017L,1073297L,4227137L,5541317L,11806097L,16974401L,18576101L,22848401L,24443137L,24542117L,27625537L,28132417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176790Inst : IEnumerable<long>
{
public static readonly long[] Value=A176790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176790.Bytes);
public long this[int i]=>Value[i];

public static A176790Inst Instance=new A176790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176791
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,7L,1L,1L,15L,455L,15L,1L,1L,31L,4495L,4495L,31L,1L,1L,63L,39711L,553270671L,39711L,63L,1L,1L,127L,333375L,89356415775L,89356415775L,333375L,127L,1L,1L,255L,2731135L,12801990477375L,BigInteger.Parse("629921975126394617164575"),12801990477375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176791Inst Instance=new A176791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176792
{
public static readonly BigInteger[] Value={ 7L,79L,1021L,3486784393L,155568095557812211L,BigInteger.Parse("6176733962839469999999999999999999999999999971") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A176792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A176792Inst Instance=new A176792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176793
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,25L,25L,1L,1L,113L,145L,113L,1L,1L,481L,673L,673L,481L,1L,1L,1985L,2881L,3137L,2881L,1985L,1L,1L,8065L,11905L,13441L,13441L,11905L,8065L,1L,1L,32513L,48385L,55553L,57601L,55553L,48385L,32513L,1L,1L,130561L,195073L,225793L,238081L,238081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176793Inst : IEnumerable<long>
{
public static readonly long[] Value=A176793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176793.Bytes);
public long this[int i]=>Value[i];

public static A176793Inst Instance=new A176793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176794
{
public static readonly long[] Value={ 1L,1L,1L,1L,17L,1L,1L,129L,129L,1L,1L,833L,1025L,833L,1L,1L,5121L,6657L,6657L,5121L,1L,1L,30977L,40961L,43265L,40961L,30977L,1L,1L,186369L,247809L,266241L,266241L,247809L,186369L,1L,1L,1119233L,1490945L,1610753L,1638401L,1610753L,1490945L,1119233L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176794Inst : IEnumerable<long>
{
public static readonly long[] Value=A176794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176794.Bytes);
public long this[int i]=>Value[i];

public static A176794Inst Instance=new A176794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176795
{
public static readonly long[] Value={ 1L,1L,1L,1L,37L,1L,1L,361L,361L,1L,1L,3025L,3601L,3025L,1L,1L,24481L,30241L,30241L,24481L,1L,1L,196417L,244801L,254017L,244801L,196417L,1L,1L,1572481L,1964161L,2056321L,2056321L,1964161L,1572481L,1L,1L,12582145L,15724801L,16498945L,16646401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176795Inst : IEnumerable<long>
{
public static readonly long[] Value=A176795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176795.Bytes);
public long this[int i]=>Value[i];

public static A176795Inst Instance=new A176795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176796
{
public static readonly long[] Value={ 1L,3L,12L,14L,17L,25L,30L,35L,39L,69L,71L,74L,80L,83L,88L,102L,107L,122L,126L,129L,134L,151L,170L,172L,176L,184L,187L,202L,220L,239L,244L,249L,258L,261L,263L,272L,280L,283L,289L,298L,308L,321L,363L,371L,377L,386L,390L,403L,421L,432L,438L,447L,451L,453L,477L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176796Inst : IEnumerable<long>
{
public static readonly long[] Value=A176796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176796.Bytes);
public long this[int i]=>Value[i];

public static A176796Inst Instance=new A176796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176797
{
public static readonly long[] Value={ 1L,3L,7L,11L,13L,21L,21L,43L,35L,43L,61L,63L,85L,111L,77L,157L,91L,129L,119L,147L,185L,171L,273L,183L,255L,343L,231L,301L,245L,255L,333L,313L,507L,301L,455L,481L,521L,425L,471L,547L,473L,455L,813L,441L,931L,629L,559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176797Inst : IEnumerable<long>
{
public static readonly long[] Value=A176797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176797.Bytes);
public long this[int i]=>Value[i];

public static A176797Inst Instance=new A176797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176798
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,7L,10L,13L,16L,11L,15L,19L,23L,27L,16L,21L,26L,31L,36L,41L,22L,28L,34L,40L,46L,52L,58L,29L,36L,43L,50L,57L,64L,71L,78L,37L,45L,53L,61L,69L,77L,85L,93L,101L,46L,55L,64L,73L,82L,91L,100L,109L,118L,127L,56L,66L,76L,86L,96L,106L,116L,126L,136L,146L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176798Inst : IEnumerable<long>
{
public static readonly long[] Value=A176798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176798.Bytes);
public long this[int i]=>Value[i];

public static A176798Inst Instance=new A176798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176799
{
public static readonly long[] Value={ 1L,3L,7L,11L,13L,21L,35L,43L,61L,63L,77L,85L,91L,111L,119L,129L,147L,157L,171L,183L,185L,231L,245L,255L,273L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176799Inst : IEnumerable<long>
{
public static readonly long[] Value=A176799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176799.Bytes);
public long this[int i]=>Value[i];

public static A176799Inst Instance=new A176799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176800
{
public static readonly long[] Value={ 1L,3L,7L,11L,13L,21L,21L,35L,43L,43L,61L,63L,77L,85L,91L,111L,119L,129L,147L,157L,171L,183L,185L,231L,245L,255L,255L,273L,301L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176800Inst : IEnumerable<long>
{
public static readonly long[] Value=A176800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176800.Bytes);
public long this[int i]=>Value[i];

public static A176800Inst Instance=new A176800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176801
{
public static readonly long[] Value={ 1L,3L,1L,5L,1L,1L,1L,7L,5L,3L,1L,2L,1L,1L,1L,19L,1L,3L,1L,1L,1L,1L,1L,3L,5L,3L,1L,2L,1L,1L,1L,3L,1L,3L,1L,17L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,19L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176801Inst : IEnumerable<long>
{
public static readonly long[] Value=A176801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176801.Bytes);
public long this[int i]=>Value[i];

public static A176801Inst Instance=new A176801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176802
{
public static readonly long[] Value={ 1L,3L,2L,7L,27L,1L,4L,3L,182L,27L,270L,14L,126L,4L,6L,31L,1638L,91L,980L,6L,32L,84L,4455L,15L,248L,63L,10L,1L,8190L,3L,16L,21L,672L,819L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176802Inst : IEnumerable<long>
{
public static readonly long[] Value=A176802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176802.Bytes);
public long this[int i]=>Value[i];

public static A176802Inst Instance=new A176802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176803
{
public static readonly long[] Value={ 1L,4L,0L,1L,4L,0L,0L,4L,1L,100L,0L,0L,9L,0L,0L,1L,100L,4L,0L,1L,0L,0L,0L,0L,1L,25L,0L,0L,325L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176803Inst : IEnumerable<long>
{
public static readonly long[] Value=A176803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176803.Bytes);
public long this[int i]=>Value[i];

public static A176803Inst Instance=new A176803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A176804
{
public static readonly long[] Value={ 3L,11L,17L,41L,179L,197L,239L,281L,311L,419L,431L,461L,521L,599L,641L,821L,827L,857L,1019L,1049L,1061L,1091L,1151L,1229L,1289L,1319L,1427L,1481L,1487L,1607L,1667L,1697L,1721L,1871L,1877L,1931L,1997L,2027L,2081L,2111L,2141L,2309L,2339L,2591L,2687L,2789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A176804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A176804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A176804Inst : IEnumerable<long>
{
public static readonly long[] Value=A176804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A176804.Bytes);
public long this[int i]=>Value[i];

public static A176804Inst Instance=new A176804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}