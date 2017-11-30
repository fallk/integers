using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A256182
{
public static readonly long[] Value={ 1L,2L,8L,33L,152L,728L,3590L,18060L,92152L,475290L,2471985L,12943600L,68150321L,360491134L,1914406344L,10201142767L,54518961054L,292128744168L,1568916545308L,8443375819412L,45523087452426L,245849090689509L,1329718513219605L,7201896869193446L,39055252137506382L,212037592384217212L };
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
public class A256182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256182Inst : IEnumerable<long>
{
public static readonly long[] Value=A256182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256182.Bytes);
public long this[int i]=>Value[i];

public static A256182Inst Instance=new A256182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256183
{
public static readonly BigInteger[] Value={ 1L,4L,32L,291L,2864L,29344L,308552L,3303000L,35827360L,392567622L,4336040577L,48205431920L,538811008877L,6049847821760L,68191652330640L,771200434566851L,8747162371041174L,99467000584413264L,1133643934300319998L,12946558434921516388UL,BigInteger.Parse("148122965615855233266"),BigInteger.Parse("1697478425416109676039") };
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
public class A256183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256183Inst Instance=new A256183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256184
{
public static readonly long[] Value={ 0L,-2L,-1L,2L,-4L,-3L,1L,-3L,-2L,-2L,0L,1L,4L,-6L,-5L,3L,-5L,-4L,-1L,-1L,0L,3L,-5L,-4L,2L,-4L,-3L,2L,-4L,-3L,0L,-2L,-1L,-1L,-1L,0L,-4L,2L,3L,6L,-8L,-7L,5L,-7L,-6L,-3L,1L,2L,5L,-7L,-6L,4L,-6L,-5L,1L,-3L,-2L,1L,-3L,-2L,0L,-2L,-1L,-3L,1L,2L,5L,-7L,-6L,4L,-6L,-5L };
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
public class A256184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256184Inst : IEnumerable<long>
{
public static readonly long[] Value=A256184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256184.Bytes);
public long this[int i]=>Value[i];

public static A256184Inst Instance=new A256184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256185
{
public static readonly long[] Value={ 0L,-3L,-2L,3L,-6L,1L,2L,-5L,0L,-3L,0L,-5L,6L,-9L,4L,-1L,-2L,-3L,-2L,-1L,-4L,5L,-8L,3L,0L,-3L,-2L,3L,-6L,1L,0L,-3L,-2L,5L,-8L,3L,-6L,3L,-8L,9L,-12L,7L,-4L,1L,-6L,1L,-4L,-1L,2L,-5L,0L,3L,-6L,1L,2L,-5L,0L,1L,-4L,-1L,4L,-7L,2L,-5L,2L,-7L,8L,-11L,6L,-3L,0L,-5L,0L };
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
public class A256185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256185Inst : IEnumerable<long>
{
public static readonly long[] Value=A256185.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256185.Bytes);
public long this[int i]=>Value[i];

public static A256185Inst Instance=new A256185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256186
{
public static readonly long[] Value={ 101L,103L,107L,109L,307L,401L,503L,509L,601L,607L,701L,709L,809L,907L,1009L,1013L,1031L,1039L,1049L,1051L,1063L,1091L,1093L,1097L,1103L,1301L,1307L,1409L,1607L,1709L,1801L,1901L,1907L,2003L,2011L,2027L,2029L,2039L,2063L,2069L,2081L,2083L,2203L,2207L,2309L,2609L,2707L };
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
public class A256186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256186Inst : IEnumerable<long>
{
public static readonly long[] Value=A256186.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256186.Bytes);
public long this[int i]=>Value[i];

public static A256186Inst Instance=new A256186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256187
{
public static readonly long[] Value={ 1L,-2L,3L,-1L,-1L,-2L,5L,-4L,3L,-2L,1L,1L,-3L,-2L,7L,-3L,-1L,-2L,5L,-3L,1L,-2L,3L,-4L,5L,-2L,-1L,3L,-5L,-2L,9L,-6L,3L,-2L,1L,1L,-3L,-2L,7L,-4L,1L,-2L,3L,-1L,-1L,-2L,5L,-1L,-3L,-2L,7L,-5L,3L,-2L,1L,-4L,7L,-2L,-3L,5L,-7L,-2L,11L,-5L,-1L,-2L,5L,-3L,1L,-2L,3L,-4L };
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
public class A256187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256187Inst : IEnumerable<long>
{
public static readonly long[] Value=A256187.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256187.Bytes);
public long this[int i]=>Value[i];

public static A256187Inst Instance=new A256187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256188
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,5L,1L,2L,3L,7L,8L,9L,1L,2L,3L,4L,11L,12L,13L,14L,1L,2L,3L,4L,5L,16L,17L,18L,19L,20L,1L,2L,3L,4L,5L,6L,22L,23L,24L,25L,26L,27L,1L,2L,3L,4L,5L,6L,7L,29L,30L,31L,32L,33L,34L,35L,1L,2L,3L,4L,5L,6L,7L,8L,37L,38L,39L,40L,41L,42L,43L,44L,1L,2L,3L,4L };
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
public class A256188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256188Inst : IEnumerable<long>
{
public static readonly long[] Value=A256188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256188.Bytes);
public long this[int i]=>Value[i];

public static A256188Inst Instance=new A256188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256189
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,10L,21L,5L,6L,25L,8L,15L,14L,27L,7L,12L,35L,22L,45L,11L,20L,33L,26L,51L,13L,17L,39L,34L,57L,16L,19L,18L,95L,28L,55L,38L,65L,24L,85L,46L,75L,23L,36L,115L,58L,69L,29L,30L,203L,32L,49L,50L,63L,44L,87L,62L,81L,31L,42L,155L,52L,93L,70L,99L,64L,77L,54L };
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
public class A256189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256189Inst : IEnumerable<long>
{
public static readonly long[] Value=A256189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256189.Bytes);
public long this[int i]=>Value[i];

public static A256189Inst Instance=new A256189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256190
{
public static readonly long[] Value={ 8L,5L,2L,2L,6L,8L,8L,1L,3L,9L,2L,1L,9L,4L,7L,5L,9L,5L,0L,5L,1L,4L,3L,9L,2L,2L,1L,4L,4L,3L,9L,5L,5L,9L,7L,5L,4L,7L,5L,8L,8L,3L,1L,4L,6L,9L,3L,2L,2L,0L,2L,0L,8L,9L,8L,5L,3L,2L,7L,0L,1L,6L,1L,7L,9L,0L,5L,8L,8L,7L,0L,1L,6L,9L,9L,2L,9L,5L,1L,3L,8L,3L,0L,2L,7L,4L,9L,4L,5L,0L,6L,3L,5L,2L,4L,0L,7L,0L,2L,4L,3L,8L,2L,5L };
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
public class A256190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256190Inst : IEnumerable<long>
{
public static readonly long[] Value=A256190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256190.Bytes);
public long this[int i]=>Value[i];

public static A256190Inst Instance=new A256190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256191
{
public static readonly long[] Value={ 9L,5L,1L,3L,5L,0L,7L,6L,9L,8L,6L,6L,8L,7L,3L,1L,8L,3L,6L,2L,9L,2L,4L,8L,7L,1L,7L,7L,2L,6L,5L,4L,0L,2L,1L,9L,2L,5L,5L,0L,5L,7L,8L,6L,2L,6L,0L,8L,8L,3L,7L,7L,3L,4L,3L,0L,5L,0L,0L,0L,0L,7L,7L,0L,4L,3L,4L,2L,6L,5L,3L,8L,3L,3L,2L,2L,8L,2L,1L,0L,1L,1L,5L,3L,7L,1L,6L,3L,7L,9L,4L,2L,6L,6L,4L,4L,7L,2L,0L,9L,7L,9L,7L,3L };
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
public class A256191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256191Inst : IEnumerable<long>
{
public static readonly long[] Value=A256191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256191.Bytes);
public long this[int i]=>Value[i];

public static A256191Inst Instance=new A256191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256192
{
public static readonly long[] Value={ 1L,0L,5L,0L,5L,8L,7L,4L,8L,5L,6L,0L,7L,8L,6L,8L,5L,1L,9L,1L,8L,9L,5L,0L,0L,2L,8L,2L,0L,8L,4L,7L,8L,1L,0L,6L,8L,4L,3L,7L,5L,0L,1L,9L,2L,7L,6L,7L,2L,9L,0L,0L,0L,6L,2L,2L,0L,0L,7L,0L,4L,7L,0L,8L,0L,8L,2L,4L,1L,1L,4L,3L,8L,9L,8L,2L,6L,7L,6L,2L,5L,6L,5L,1L,5L,1L,5L,5L,2L,6L,9L,7L,8L,9L,6L,1L,6L,3L,4L,6L,3L,1L,3L,3L };
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
public class A256192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256192Inst : IEnumerable<long>
{
public static readonly long[] Value=A256192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256192.Bytes);
public long this[int i]=>Value[i];

public static A256192Inst Instance=new A256192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256193
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,3L,6L,4L,1L,5L,12L,11L,5L,1L,7L,20L,24L,16L,6L,1L,11L,35L,49L,41L,22L,7L,1L,15L,54L,89L,91L,63L,29L,8L,1L,22L,86L,158L,186L,155L,92L,37L,9L,1L,30L,128L,262L,351L,342L,247L,129L,46L,10L,1L,42L,192L,428L,635L,700L,590L,376L,175L,56L,11L,1L };
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
public class A256193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256193Inst : IEnumerable<long>
{
public static readonly long[] Value=A256193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256193.Bytes);
public long this[int i]=>Value[i];

public static A256193Inst Instance=new A256193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256194
{
public static readonly BigInteger[] Value={ 15L,440L,21945L,277704L,178986115L,215289360L,107174712645L,2019114114160L,5162399729063577L,310327149656160L,BigInteger.Parse("264020420256172514935"),555320997799108800L,BigInteger.Parse("183986274976015448239875"),BigInteger.Parse("7616449380979972355121376"),BigInteger.Parse("132186242095677958872242925"),BigInteger.Parse("3493664585524176681103200") };
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
public class A256194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256194Inst Instance=new A256194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256195
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4578L,33184L,258757L,2136978L,18478134L,165857600L,1535336290L };
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
public class A256195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256195Inst : IEnumerable<long>
{
public static readonly long[] Value=A256195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256195.Bytes);
public long this[int i]=>Value[i];

public static A256195Inst Instance=new A256195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256196
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4579L,33216L,259401L,2147525L,18632512L,167969934L,1563027614L };
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
public class A256196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256196Inst : IEnumerable<long>
{
public static readonly long[] Value=A256196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256196.Bytes);
public long this[int i]=>Value[i];

public static A256196Inst Instance=new A256196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256197
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4579L,33218L,259483L,2149558L,18672277L,168648090L,1573625606L };
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
public class A256197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256197Inst : IEnumerable<long>
{
public static readonly long[] Value=A256197.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256197.Bytes);
public long this[int i]=>Value[i];

public static A256197Inst Instance=new A256197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256198
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4580L,33249L,260092L,2159381L,18815124L,170605392L,1599499163L };
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
public class A256198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256198Inst : IEnumerable<long>
{
public static readonly long[] Value=A256198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256198.Bytes);
public long this[int i]=>Value[i];

public static A256198Inst Instance=new A256198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256199
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4580L,33252L,260202L,2161837L,18858720L,171285237L,1609282391L };
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
public class A256199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256199Inst : IEnumerable<long>
{
public static readonly long[] Value=A256199.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256199.Bytes);
public long this[int i]=>Value[i];

public static A256199Inst Instance=new A256199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256200
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4580L,33252L,260204L,2161930L,18861307L,171341565L,1610345257L };
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
public class A256200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256200Inst : IEnumerable<long>
{
public static readonly long[] Value=A256200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256200.Bytes);
public long this[int i]=>Value[i];

public static A256200Inst Instance=new A256200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256201
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4580L,33254L,260285L,2163930L,18900534L,172016256L,1621031261L };
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
public class A256201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256201Inst : IEnumerable<long>
{
public static readonly long[] Value=A256201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256201.Bytes);
public long this[int i]=>Value[i];

public static A256201Inst Instance=new A256201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256202
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4580L,33256L,260370L,2166120L,18945144L,172810050L,1633997788L };
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
public class A256202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256202Inst : IEnumerable<long>
{
public static readonly long[] Value=A256202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256202.Bytes);
public long this[int i]=>Value[i];

public static A256202Inst Instance=new A256202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256203
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4581L,33283L,260805L,2171393L,18994464L,173094540L,1632480259L };
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
public class A256203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256203Inst : IEnumerable<long>
{
public static readonly long[] Value=A256203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256203.Bytes);
public long this[int i]=>Value[i];

public static A256203Inst Instance=new A256203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256204
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4581L,33284L,260847L,2172454L,19015582L,173461305L,1638327423L };
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
public class A256204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256204Inst : IEnumerable<long>
{
public static readonly long[] Value=A256204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256204.Bytes);
public long this[int i]=>Value[i];

public static A256204Inst Instance=new A256204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256205
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4581L,33285L,260886L,2173374L,19032746L,173741467L,1642533692L };
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
public class A256205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256205Inst : IEnumerable<long>
{
public static readonly long[] Value=A256205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256205.Bytes);
public long this[int i]=>Value[i];

public static A256205Inst Instance=new A256205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256206
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4581L,33287L,260967L,2175379L,19072271L,174426353L,1653484169L };
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
public class A256206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256206Inst : IEnumerable<long>
{
public static readonly long[] Value=A256206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256206.Bytes);
public long this[int i]=>Value[i];

public static A256206Inst Instance=new A256206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256207
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4582L,33325L,261853L,2191902L,19344408L,178582940L,1713999264L };
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
public class A256207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256207Inst : IEnumerable<long>
{
public static readonly long[] Value=A256207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256207.Bytes);
public long this[int i]=>Value[i];

public static A256207Inst Instance=new A256207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256208
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,119L,694L,4582L,33325L,261863L,2192390L,19358590L,178904675L,1720317763L };
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
public class A256208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256208Inst : IEnumerable<long>
{
public static readonly long[] Value=A256208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256208.Bytes);
public long this[int i]=>Value[i];

public static A256208Inst Instance=new A256208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256209
{
public static readonly long[] Value={ 1L,3L,7L,14L,27L,49L,84L,141L,230L,364L,567L,867L,1302L,1932L,2829L,4091L,5859L,8309L,11675L,16275L,22513L,30914L,42174L,57176L,77049L,103263L,137669L,182616L,241110L,316910L,414750L,540603L,701903L,907928L,1170261L,1503238L,1924607L,2456349L };
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
public class A256209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256209Inst : IEnumerable<long>
{
public static readonly long[] Value=A256209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256209.Bytes);
public long this[int i]=>Value[i];

public static A256209Inst Instance=new A256209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256210
{
public static readonly long[] Value={ 2L,1L,3L,5L,4L,6L,7L,9L,11L,13L,8L,10L,15L,12L,14L,17L,16L,19L,18L,21L,23L,20L,22L,25L,27L,29L,31L,24L,26L,28L,33L,30L,35L,32L,37L,34L,39L,36L,41L,38L,40L,43L,45L,47L,42L,44L,49L,46L,48L,51L,50L,53L,52L,55L,57L,59L,54L,56L,58L,61L,63L,60L,65L,62L,67L,64L,69L };
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
public class A256210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256210Inst : IEnumerable<long>
{
public static readonly long[] Value=A256210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256210.Bytes);
public long this[int i]=>Value[i];

public static A256210Inst Instance=new A256210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256211
{
public static readonly long[] Value={ -1L,1L,1L,0L,1L,1L,2L,3L,3L,4L,6L,7L,7L,10L,12L,14L,18L,21L,25L,31L,35L,42L,51L,59L,68L,81L,95L,108L,127L,146L,168L,196L,223L,255L,296L,336L,382L,438L };
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
public class A256211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256211Inst : IEnumerable<long>
{
public static readonly long[] Value=A256211.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256211.Bytes);
public long this[int i]=>Value[i];

public static A256211Inst Instance=new A256211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256212
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,11L,13L,15L,19L,20L,22L,23L,27L,29L,31L,33L,39L,41L,43L,47L,49L,52L,55L,57L,58L,62L,63L,65L,67L,68L,72L,73L,74L,77L,79L,80L,86L,91L,92L,93L,95L,96L,99L,101L,102L,103L,110L,111L,113L,115L,118L,123L,124L,127L,129L,131L,134L,137L };
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
public class A256212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256212Inst : IEnumerable<long>
{
public static readonly long[] Value=A256212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256212.Bytes);
public long this[int i]=>Value[i];

public static A256212Inst Instance=new A256212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256213
{
public static readonly long[] Value={ 2L,3L,10L,13L,21L,24L,33L,43L,46L,58L,61L,70L,75L,90L,97L,102L,111L,120L,133L,138L,141L,155L,162L,178L,187L,192L,200L,209L,214L,219L,247L,255L,262L,265L,286L,289L,302L,312L,319L,339L,346L,349L,366L,376L,392L,395L,413L,428L,435L,444L,449L,468L,471L,483L,496L };
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
public class A256213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256213Inst : IEnumerable<long>
{
public static readonly long[] Value=A256213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256213.Bytes);
public long this[int i]=>Value[i];

public static A256213Inst Instance=new A256213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256214
{
public static readonly long[] Value={ 2L,3L,10L,13L,21L,24L,31L,38L,43L,51L,59L,67L,78L,81L,90L,101L,108L,119L,131L,136L,141L,152L,159L,171L,183L,188L,195L,207L,214L,219L,237L,256L,263L,264L,278L,292L,299L,306L,316L,328L,339L,347L,368L,371L,379L,380L,405L,421L,431L,440L,447L,457L };
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
public class A256214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256214Inst : IEnumerable<long>
{
public static readonly long[] Value=A256214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256214.Bytes);
public long this[int i]=>Value[i];

public static A256214Inst Instance=new A256214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256215
{
public static readonly long[] Value={ 1L,2L,2L,6L,18L,9L,24L,144L,192L,64L,120L,1200L,3000L,2500L,625L,720L,10800L,43200L,64800L,38880L,7776L,5040L,105840L,617400L,1440600L,1512630L,705894L,117649L };
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
public class A256215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256215Inst : IEnumerable<long>
{
public static readonly long[] Value=A256215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256215.Bytes);
public long this[int i]=>Value[i];

public static A256215Inst Instance=new A256215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256216
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,4L,7L,18L,31L,70L,126L,261L,484L,960L,1800L,3515L,6643L,12852L,24458L,47151L,90157L,173744L,333498L,643230L,1238671L,2392650L,4620006L,8939676L,17302033L,33538048L,65042526L,126289800L,245361172L };
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
public class A256216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256216Inst : IEnumerable<long>
{
public static readonly long[] Value=A256216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256216.Bytes);
public long this[int i]=>Value[i];

public static A256216Inst Instance=new A256216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256217
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,7L,8L,14L,16L,26L,32L,52L,64L,101L,128L,202L,256L,399L,512L,796L,1024L,1583L,2048L,3162L,4096L,6302L,8192L,12586L,16384L,25124L,32768L,50186L,65536L,100232L,131072L };
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
public class A256217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256217Inst : IEnumerable<long>
{
public static readonly long[] Value=A256217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256217.Bytes);
public long this[int i]=>Value[i];

public static A256217Inst Instance=new A256217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256218
{
public static readonly long[] Value={ 5L,58L,604L,6074L,60786L,607919L,6079261L,60792699L,607927089L,6079271005L,60792710170L,607927101837L,6079271018522L,60792710185383L,607927101854006L };
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
public class A256218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256218Inst : IEnumerable<long>
{
public static readonly long[] Value=A256218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256218.Bytes);
public long this[int i]=>Value[i];

public static A256218Inst Instance=new A256218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256219
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,11L,14L,15L,18L,26L,29L,34L,38L,41L,42L,46L,56L,57L,61L,65L,69L,73L,80L,84L,93L,96L,97L,101L,104L,108L,124L,128L,132L,136L,144L,145L,153L,160L,161L,169L,173L,177L,185L,188L,192L,196L,204L,220L,221L,224L,225L,236L,237L,241L,253L };
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
public class A256219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256219Inst : IEnumerable<long>
{
public static readonly long[] Value=A256219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256219.Bytes);
public long this[int i]=>Value[i];

public static A256219Inst Instance=new A256219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256220
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,22L,28L,37L,45L,62L,70L,125L,133L,172L,330L,421L,450L,840L,901L,1710L,2356L,2724L,2824L,5367L,6022L,7142L,8072L,18771L,19204L,35739L,36453L,42853L,82094L,88574L,155642L,264869L };
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
public class A256220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256220Inst : IEnumerable<long>
{
public static readonly long[] Value=A256220.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256220.Bytes);
public long this[int i]=>Value[i];

public static A256220Inst Instance=new A256220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256221
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,8L,8L,12L,12L,13L,13L,13L,13L,15L,15L,15L,17L,17L,17L,19L,21L,21L,23L,24L,25L,25L };
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
public class A256221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256221Inst : IEnumerable<long>
{
public static readonly long[] Value=A256221.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256221.Bytes);
public long this[int i]=>Value[i];

public static A256221Inst Instance=new A256221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256222
{
public static readonly long[] Value={ 0L,1L,3L,5L,13L,13L,13L,89L,89L,89L,1597L,1597L,1597L,1597L,1597L,1597L,17711L,17711L,17711L,28657L,28657L,28657L,28657L,1346269L,1346269L,1346269L,1346269L,24157817L,24157817L,24157817L,24157817L,24157817L,24157817L,39088169L,39088169L,39088169L,39088169L };
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
public class A256222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256222Inst : IEnumerable<long>
{
public static readonly long[] Value=A256222.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256222.Bytes);
public long this[int i]=>Value[i];

public static A256222Inst Instance=new A256222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256223
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,21L,21L,21L,21L,34L,34L,144L,144L,144L,144L,144L,144L,144L,144L,144L,144L,987L,987L,987L,987L,987L,987L,987L,987L,987L,987L,46368L,46368L,46368L,46368L,46368L,46368L,46368L,46368L,46368L,832040L,832040L,832040L,832040L,832040L,832040L,832040L };
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
public class A256223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256223Inst : IEnumerable<long>
{
public static readonly long[] Value=A256223.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256223.Bytes);
public long this[int i]=>Value[i];

public static A256223Inst Instance=new A256223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256224
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,8L,15L,14L,5L,6L,25L,16L,35L,12L,7L,10L,21L,22L,27L,11L,18L,55L,26L,33L,13L,24L,65L,28L,39L,20L,51L,32L,17L,30L,119L,38L,49L,19L,42L,95L,34L,45L,44L,57L,40L,63L,46L,75L,23L,36L,115L,52L,69L,50L,81L,56L,87L,62L,29L,31L,58L,93L,64L,99L,68L,77L,48L };
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
public class A256224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256224Inst : IEnumerable<long>
{
public static readonly long[] Value=A256224.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256224.Bytes);
public long this[int i]=>Value[i];

public static A256224Inst Instance=new A256224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256225
{
public static readonly long[] Value={ 0L,1L,7L,30L,84L,192L,377L,674L,1115L,1747L,2611L,3765L,5260L,7166L,9542L,12470L,16019L,20282L,25337L,31289L,38225L,46262L,55496L,66055L,78045L,91606L,106852L,123935L,142979L,164147L,187572L,213429L,241860L,273052L,307156L,344370L,384855L,428821L,476437L,527925L };
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
public class A256225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256225Inst : IEnumerable<long>
{
public static readonly long[] Value=A256225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256225.Bytes);
public long this[int i]=>Value[i];

public static A256225Inst Instance=new A256225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256226
{
public static readonly long[] Value={ 0L,1L,11L,58L,199L,532L,1206L,2432L,4494L,7760L,12692L,19858L,29941L,43752L,62239L,86499L,117788L,157532L,207338L,269005L,344534L,436140L,546261L,677571L,832989L,1015691L,1229120L,1476997L,1763332L,2092435L,2468926L,2897747L,3384171L,3933815L,4552649L,5247008L };
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
public class A256226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256226Inst : IEnumerable<long>
{
public static readonly long[] Value=A256226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256226.Bytes);
public long this[int i]=>Value[i];

public static A256226Inst Instance=new A256226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256227
{
public static readonly long[] Value={ 20L,30L,50L,70L,101L,103L,107L,109L,110L,130L,170L,190L,200L,203L,209L,230L,290L,300L,301L,307L,310L,370L,401L,403L,407L,410L,430L,470L,500L,503L,509L,530L,590L,601L,607L,610L,670L,700L,701L,703L,709L,710L,730L,790L,803L,809L,830L,890L,907L,970L,1001L,1003L,1007L,1009L,1010L,1013L,1027L,1030L };
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
public class A256227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256227Inst : IEnumerable<long>
{
public static readonly long[] Value=A256227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256227.Bytes);
public long this[int i]=>Value[i];

public static A256227Inst Instance=new A256227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256228
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,10L,17L,21L,41L,51L,59L,61L,77L,79L,83L,97L,108L,427L,615L,869L,900L,966L,3150L,3239L,3932L,5218L,11941L,30558L,44697L,90334L };
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
public class A256228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256228Inst : IEnumerable<long>
{
public static readonly long[] Value=A256228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256228.Bytes);
public long this[int i]=>Value[i];

public static A256228Inst Instance=new A256228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256229
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,4L,8L,16L,32L,64L,128L,256L,512L,1L,3L,9L,27L,81L,243L,729L,2187L,6561L,19683L,1L,4L,16L,64L,256L,1024L,4096L,16384L,65536L,262144L,1L,5L,25L,125L,625L,3125L,15625L,78125L,390625L,1953125L,1L,6L,36L,216L,1296L };
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
public class A256229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256229Inst : IEnumerable<long>
{
public static readonly long[] Value=A256229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256229.Bytes);
public long this[int i]=>Value[i];

public static A256229Inst Instance=new A256229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256230
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,9L,18L,21L,30L,33L,36L,78L,81L,96L,105L,138L,141L,156L,165L,198L,210L,228L,261L,270L,273L,306L,330L,336L,345L,366L,378L,393L,438L,453L,498L,525L,546L,561L,576L,585L,600L,606L,618L,660L,690L,726L,765L,810L,828L,861L,876L,933L,936L,966L,996L,1005L,1008L };
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
public class A256230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256230Inst : IEnumerable<long>
{
public static readonly long[] Value=A256230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256230.Bytes);
public long this[int i]=>Value[i];

public static A256230Inst Instance=new A256230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256231
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,9L,10L,15L,8L,11L,12L,16L,13L,19L,21L,31L,17L,23L,25L,33L,14L,20L,22L,32L,18L,24L,26L,34L,27L,39L,43L,63L,35L,47L,51L,67L,29L,41L,45L,65L,37L,49L,53L,69L,28L,40L,44L,64L,36L,48L,52L,68L,30L,42L,46L,66L,38L,50L,54L,70L,55L,79L,87L,127L,71L };
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
public class A256231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256231Inst : IEnumerable<long>
{
public static readonly long[] Value=A256231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256231.Bytes);
public long this[int i]=>Value[i];

public static A256231Inst Instance=new A256231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256232
{
public static readonly long[] Value={ 1L,0L,1L,-1L,2L,0L,2L,-2L,1L,0L,2L,-1L,2L,0L,2L,-3L,2L,0L,2L,-2L,2L,0L,2L,-2L,3L,0L,1L,-2L,2L,0L,2L,-4L,2L,0L,4L,-1L,2L,0L,2L,-4L,2L,0L,2L,-2L,2L,0L,2L,-3L,3L,0L,2L,-2L,2L,0L,4L,-4L,2L,0L,2L,-2L,2L,0L,2L,-5L,4L,0L,2L,-2L,2L,0L,2L,-2L,2L,0L,3L,-2L,4L,0L,2L,-6L };
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
public class A256232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256232Inst : IEnumerable<long>
{
public static readonly long[] Value=A256232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256232.Bytes);
public long this[int i]=>Value[i];

public static A256232Inst Instance=new A256232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256233
{
public static readonly long[] Value={ -1L,2L,9L,27L,74L,197L,519L,1362L,3569L,9347L,24474L,64077L,167759L,439202L,1149849L,3010347L,7881194L,20633237L,54018519L,141422322L,370248449L,969323027L,2537720634L,6643838877L,17393795999L,45537549122L,119218851369L,312119004987L,817138163594L };
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
public class A256233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256233Inst : IEnumerable<long>
{
public static readonly long[] Value=A256233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256233.Bytes);
public long this[int i]=>Value[i];

public static A256233Inst Instance=new A256233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256234
{
public static readonly long[] Value={ 682775764735680L,47184892811061120L,50194833750826260L,70151123608154420L,76685404549625256L,93295105984206480L,94615738903617540L,123483356772380760L,141536742113504220L,211283804186719200L,214070508927033000L };
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
public class A256234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256234Inst : IEnumerable<long>
{
public static readonly long[] Value=A256234.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256234.Bytes);
public long this[int i]=>Value[i];

public static A256234Inst Instance=new A256234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256235
{
public static readonly long[] Value={ 0L,5L,70L,450L,1680L,4800L,11310L,23590L,44600L,78615L,130550L,207075L,315600L,465790L,667940L,935250L,1281520L,1723970L,2280330L,2972455L,3822500L,4857510L,6104560L,7596325L,9365400L,11450750L,13890760L,16731225L,20017060L,23801315L,28135800L,33081495L };
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
public class A256235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256235Inst : IEnumerable<long>
{
public static readonly long[] Value=A256235.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256235.Bytes);
public long this[int i]=>Value[i];

public static A256235Inst Instance=new A256235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256236
{
public static readonly long[] Value={ 5L,17L,449L,557L,19601L,132857L,4486949L,126664001L };
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
public class A256236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256236Inst : IEnumerable<long>
{
public static readonly long[] Value=A256236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256236.Bytes);
public long this[int i]=>Value[i];

public static A256236Inst Instance=new A256236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256237
{
public static readonly long[] Value={ 8923L,24943L,35437L,42533L,52783L,83437L,105953L,116437L,126631L,133241L,145589L,164729L,172331L,192173L,204013L,215279L,254329L,304709L,308899L,398833L,430499L,436687L,454351L,476869L,479909L,483443L,497597L,522479L,527729L,529103L,545257L,561439L,562651L };
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
public class A256237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256237Inst : IEnumerable<long>
{
public static readonly long[] Value=A256237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256237.Bytes);
public long this[int i]=>Value[i];

public static A256237Inst Instance=new A256237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256238
{
public static readonly long[] Value={ 0L,1L,6L,68L,847L,7963L,81327L };
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
public class A256238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256238Inst : IEnumerable<long>
{
public static readonly long[] Value=A256238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256238.Bytes);
public long this[int i]=>Value[i];

public static A256238Inst Instance=new A256238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256239
{
public static readonly long[] Value={ 0L,6L,132L,1044L,4776L,15960L,43416L,102144L,215712L,419040L,761520L,1310628L,2155752L,3412656L,5228076L,7784910L,11307648L,16068264L,22392504L,30666570L,41344080L,54953640L,72106452L,93504798L,119950416L,152353650L,191742720L,239273514L,296239776L,364083690L };
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
public class A256239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256239Inst : IEnumerable<long>
{
public static readonly long[] Value=A256239.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256239.Bytes);
public long this[int i]=>Value[i];

public static A256239Inst Instance=new A256239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256240
{
public static readonly long[] Value={ 1L,89L,98L,135L,139L,144L,153L,193L,233L,315L,319L,323L,332L,351L,391L,414L,441L,513L,531L,913L,931L,1224L,1242L,1367L,1376L,1422L,1637L,1673L,1736L,1763L,2124L,2142L,2214L,2241L,2412L,2421L,3167L,3176L,3617L,3671L,3716L,3761L,4122L,4212L };
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
public class A256240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256240Inst : IEnumerable<long>
{
public static readonly long[] Value=A256240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256240.Bytes);
public long this[int i]=>Value[i];

public static A256240Inst Instance=new A256240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256241
{
public static readonly long[] Value={ 4L,6L,12L,15L,20L,21L,28L,30L,33L,39L,42L,44L,51L,52L,57L,66L,68L,69L,76L,78L,87L,92L,93L,102L,111L,114L,116L,123L,124L,129L,138L,141L,148L,159L,164L,172L,174L,177L,183L,186L,188L,201L,212L,213L,219L,222L,236L,237L,244L,246L,249L,258L,267L,268L,282L,284L,291L,292L,303L,309L,316L,318L,321L,327L,332L,339L,354L,356L,366L };
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
public class A256241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256241Inst : IEnumerable<long>
{
public static readonly long[] Value=A256241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256241.Bytes);
public long this[int i]=>Value[i];

public static A256241Inst Instance=new A256241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256242
{
public static readonly long[] Value={ 1L,89L,135L,139L,144L,233L,1224L,1367L,11249L,12222L,111126L,111266L,111338L,112229L,112337L,1111119L,1111134L,1111137L,1111177L,1111333L,1111346L,11111117L,11111119L,11111223L,11112236L,111111119L,111111139L,111111299L,111112334L,1111111169L,1111122233L,11111111118L,11111111133L,11111111369L,111111111133L };
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
public class A256242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256242Inst : IEnumerable<long>
{
public static readonly long[] Value=A256242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256242.Bytes);
public long this[int i]=>Value[i];

public static A256242Inst Instance=new A256242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256243
{
public static readonly long[] Value={ 4L,1L,3L,6L,2L,5L,1L,4L,8L,3L,7L,2L,6L,1L,5L,10L,4L,9L,3L,8L,2L,7L,1L,6L,12L,5L,11L,4L,10L,3L,9L,2L,8L,1L,7L,14L,6L,13L,5L,12L,4L,11L,3L,10L,2L,9L,1L,8L,16L,7L,15L,6L,14L,5L,13L,4L,12L,3L,11L,2L,10L,1L,9L,18L,8L,17L,7L,16L,6L,15L,5L,14L,4L,13L,3L,12L,2L,11L,1L,10L,20L,9L,19L,8L,18L,7L,17L,6L,16L,5L,15L,4L,14L,3L,13L,2L,12L,1L,11L,22L };
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
public class A256243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256243Inst : IEnumerable<long>
{
public static readonly long[] Value=A256243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256243.Bytes);
public long this[int i]=>Value[i];

public static A256243Inst Instance=new A256243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256244
{
public static readonly long[] Value={ 3L,2L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,12L };
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
public class A256244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256244Inst : IEnumerable<long>
{
public static readonly long[] Value=A256244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256244.Bytes);
public long this[int i]=>Value[i];

public static A256244Inst Instance=new A256244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256245
{
public static readonly long[] Value={ 1L,0L,2L,4L,0L,1L,3L,0L,9L,2L,0L,8L,1L,0L,7L,3L,0L,6L,2L,0L,5L,1L,0L,4L,8L,0L,3L,7L,0L,2L,6L,0L,1L,5L,0L,15L,4L,0L,14L,3L,0L,13L,2L,0L,12L,1L,0L,11L,5L,0L,10L,4L,0L,9L,3L,0L,8L,2L,0L,7L,1L,0L,6L,12L,0L,5L,11L,0L,4L,10L,0L,3L,9L,0L,2L,8L,0L,1L,7L,0L,21L,6L,0L,20L,5L,0L,19L,4L,0L,18L,3L,0L,17L,2L };
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
public class A256245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256245Inst : IEnumerable<long>
{
public static readonly long[] Value=A256245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256245.Bytes);
public long this[int i]=>Value[i];

public static A256245Inst Instance=new A256245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256246
{
public static readonly long[] Value={ 1L,6L,10L,75L,140L,302L,463L,951L,989L,1219L,1297L,1681L,1776L,1877L,1921L,2379L,2662L,2769L,2828L,3499L,3763L,4810L,4959L,5424L,6156L,6238L,6319L,6829L,7820L,8013L,8108L,9178L,11831L,13570L,13939L,14309L,14677L,17661L,19456L,19894L,21946L,22084L,23148L,23470L };
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
public class A256246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256246Inst : IEnumerable<long>
{
public static readonly long[] Value=A256246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256246.Bytes);
public long this[int i]=>Value[i];

public static A256246Inst Instance=new A256246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256247
{
public static readonly long[] Value={ 2L,5L,7L,23L,33L,51L,65L,97L,99L,111L,115L,133L,137L,141L,143L,161L,171L,175L,177L,199L,207L,237L,241L,253L,271L,273L,275L,287L,309L,313L,315L,337L,387L,417L,423L,429L,435L,481L,507L,513L,541L,543L,557L,561L,589L,591L,613L,625L,631L,639L,651L,661L,677L,679L,727L,745L,769L,773L,777L,789L };
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
public class A256247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256247Inst : IEnumerable<long>
{
public static readonly long[] Value=A256247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256247.Bytes);
public long this[int i]=>Value[i];

public static A256247Inst Instance=new A256247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256248
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,10L,14L,20L,29L,41L,57L,79L,110L,153L,210L,286L,392L,534L,723L,982L,1330L,1790L,2415L,3249L,4359L,5838L,7824L,10457L,13949L,18581L,24724L,32848L,43568L,57723L,76429L,101095L,133599L,176414L,232772L,306920L,404256L,532034L,699655L,919551L,1207627L };
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
public class A256248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256248Inst : IEnumerable<long>
{
public static readonly long[] Value=A256248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256248.Bytes);
public long this[int i]=>Value[i];

public static A256248Inst Instance=new A256248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256249
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,9L,14L,21L,22L,25L,30L,37L,46L,57L,70L,85L,86L,89L,94L,101L,110L,121L,134L,149L,166L,185L,206L,229L,254L,281L,310L,341L,342L,345L,350L,357L,366L,377L,390L,405L,422L,441L,462L,485L,510L,537L,566L,597L,630L,665L,702L,741L,782L,825L,870L,917L,966L,1017L,1070L,1125L,1182L,1241L,1302L,1365L,1366L,1369L,1374L };
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
public class A256249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256249Inst : IEnumerable<long>
{
public static readonly long[] Value=A256249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256249.Bytes);
public long this[int i]=>Value[i];

public static A256249Inst Instance=new A256249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256250
{
public static readonly long[] Value={ 1L,5L,9L,21L,25L,37L,57L,85L,89L,101L,121L,149L,185L,229L,281L,341L,345L,357L,377L,405L,441L,485L,537L,597L,665L,741L,825L,917L,1017L,1125L,1241L,1365L,1369L,1381L,1401L,1429L,1465L,1509L,1561L,1621L,1689L,1765L,1849L,1941L,2041L,2149L,2265L,2389L,2521L,2661L,2809L,2965L,3129L,3301L,3481L,3669L,3865L,4069L,4281L,4501L,4729L,4965L,5209L,5461L };
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
public class A256250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256250Inst : IEnumerable<long>
{
public static readonly long[] Value=A256250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256250.Bytes);
public long this[int i]=>Value[i];

public static A256250Inst Instance=new A256250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256251
{
public static readonly long[] Value={ 1L,4L,4L,12L,4L,12L,20L,28L,4L,12L,20L,28L,36L,44L,52L,60L,4L,12L,20L,28L,36L,44L,52L,60L,68L,76L,84L,92L,100L,108L,116L,124L,4L,12L,20L,28L,36L,44L,52L,60L,68L,76L,84L,92L,100L,108L,116L,124L,132L,140L,148L,156L,164L,172L,180L,188L,196L,204L,212L,220L,228L,236L,244L,252L,4L,12L,20L,28L,36L,44L,52L,60L,68L,76L,84L,92L,100L };
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
public class A256251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256251Inst : IEnumerable<long>
{
public static readonly long[] Value=A256251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256251.Bytes);
public long this[int i]=>Value[i];

public static A256251Inst Instance=new A256251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256252
{
public static readonly long[] Value={ 4L,1L,2L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,2L,1L,3L,1L,1L,2L,1L,2L,1L,1L,6L,1L,1L,1L,2L,2L,4L,2L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,4L,2L,1L,2L,5L,1L,5L,1L,1L,2L,1L,1L,2L,2L,4L,1L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,4L,1L,6L,1L,1L,2L,1L,1L,6L,1L,2L,1L,4L,2L,1L,1L,2L,1L,3L,1L,2L,1L,2L };
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
public class A256252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256252Inst : IEnumerable<long>
{
public static readonly long[] Value=A256252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256252.Bytes);
public long this[int i]=>Value[i];

public static A256252Inst Instance=new A256252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256253
{
public static readonly long[] Value={ 1L,3L,1L,2L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,1L,1L,1L,2L,1L,3L,1L,1L,2L,1L,2L,1L,1L,6L,1L,1L,1L,2L,2L,4L,2L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,4L,2L,1L,2L,5L,1L,5L,1L,1L,2L,1L,1L,2L,2L,4L,1L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,4L,1L,6L,1L,1L,2L,1L,1L,6L,1L,2L,1L,4L,2L,1L,1L,2L,1L,3L,1L,2L,1L,2L };
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
public class A256253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256253Inst : IEnumerable<long>
{
public static readonly long[] Value=A256253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256253.Bytes);
public long this[int i]=>Value[i];

public static A256253Inst Instance=new A256253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256254
{
public static readonly long[] Value={ 9L,8L,8L,2L,4L,8L,7L,3L,7L,5L,1L,7L,3L,5L,6L,8L,5L,7L,3L,1L,7L,0L,6L,8L,8L,2L,6L,2L,4L,8L,1L,4L,0L,2L,4L,8L,5L,8L,7L,6L,6L,2L,3L,6L,7L,0L,8L,5L,4L,4L,4L,4L,4L,0L,5L,5L,1L,9L,2L,7L,3L,6L,3L,8L,9L,6L,4L,8L,5L,3L,8L,0L,0L,9L,2L,2L,4L,5L,3L,3L,4L,2L,4L,6L,5L,0L,4L,6L,7L,6L,1L,9L,0L,7L,8L,2L,2L,7L,2L,3L,1L,1L,3L,9L,1L,2L,8L,4L,6L,8L,4L,4L,6L,3L };
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
public class A256254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256254Inst : IEnumerable<long>
{
public static readonly long[] Value=A256254.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256254.Bytes);
public long this[int i]=>Value[i];

public static A256254Inst Instance=new A256254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256255
{
public static readonly long[] Value={ 1L,1L,7L,1L,7L,13L,19L,1L,7L,13L,19L,25L,31L,37L,43L,1L,7L,13L,19L,25L,31L,37L,43L,49L,55L,61L,67L,73L,79L,85L,91L,1L,7L,13L,19L,25L,31L,37L,43L,49L,55L,61L,67L,73L,79L,85L,91L,97L,103L,109L,115L,121L,127L,133L,139L,145L,151L,157L,163L,169L,175L,181L,187L,1L,7L,13L,19L,25L,31L,37L,43L,49L,55L,61L,67L,73L,79L,85L,91L,97L,103L };
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
public class A256255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256255Inst : IEnumerable<long>
{
public static readonly long[] Value=A256255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256255.Bytes);
public long this[int i]=>Value[i];

public static A256255Inst Instance=new A256255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256256
{
public static readonly long[] Value={ 0L,6L,18L,30L,54L,66L,90L,114L,162L,174L,198L,222L,270L,294L,342L,390L,486L,498L,522L,546L,594L,618L,666L,714L,810L,834L,882L,930L,1026L,1074L,1170L,1266L,1458L,1470L,1494L,1518L,1566L,1590L,1638L,1686L,1782L,1806L,1854L,1902L,1998L,2046L,2142L,2238L,2430L,2454L,2502L,2550L,2646L,2694L,2790L,2886L,3078L,3126L,3222L,3318L,3510L,3606L,3798L,3990L,4374L };
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
public class A256256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256256Inst : IEnumerable<long>
{
public static readonly long[] Value=A256256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256256.Bytes);
public long this[int i]=>Value[i];

public static A256256Inst Instance=new A256256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256257
{
public static readonly long[] Value={ 6L,12L,12L,24L,12L,24L,24L,48L,12L,24L,24L,48L,24L,48L,48L,96L,12L,24L,24L,48L,24L,48L,48L,96L,24L,48L,48L,96L,48L,96L,96L,192L,12L,24L,24L,48L,24L,48L,48L,96L,24L,48L,48L,96L,48L,96L,96L,192L,24L,48L,48L,96L,48L,96L,96L,192L,48L,96L,96L,192L,96L,192L,192L,384L,12L,24L,24L,48L,24L,48L,48L,96L,24L,48L,48L,96L,48L,96L,96L,192L };
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
public class A256257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256257Inst : IEnumerable<long>
{
public static readonly long[] Value=A256257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256257.Bytes);
public long this[int i]=>Value[i];

public static A256257Inst Instance=new A256257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256258
{
public static readonly long[] Value={ 1L,3L,5L,7L,5L,11L,17L,15L,5L,11L,17L,23L,29L,35L,41L,31L,5L,11L,17L,23L,29L,35L,41L,47L,53L,59L,65L,71L,77L,83L,89L,63L,5L,11L,17L,23L,29L,35L,41L,47L,53L,59L,65L,71L,77L,83L,89L,95L,101L,107L,113L,119L,125L,131L,137L,143L,149L,155L,161L,167L,173L,179L,185L,127L,5L,11L,17L,23L,29L,35L,41L,47L,53L,59L,65L,71L,77L,83L,89L,95L,101L,107L,113L,119L,125L,131L,137L };
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
public class A256258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256258Inst : IEnumerable<long>
{
public static readonly long[] Value=A256258.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256258.Bytes);
public long this[int i]=>Value[i];

public static A256258Inst Instance=new A256258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256259
{
public static readonly long[] Value={ 1L,3L,7L,12L,28L,31L,60L,91L,124L,168L,127L,360L,403L,546L,508L,744L,1170L,1651L,2418L,2880L,2821L,3048L,2047L,4368L,3751L,5952L,9360L,9906L,8188L,12493L,8191L,19344L,15367L,22568L,22506L,24384L,28800L,26611L,39312L,32764L,51181L,59520L,49128L,79248L,99944L,92202L,112320L,116281L,106483L,160797L };
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
public class A256259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256259Inst : IEnumerable<long>
{
public static readonly long[] Value=A256259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256259.Bytes);
public long this[int i]=>Value[i];

public static A256259Inst Instance=new A256259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256260
{
public static readonly long[] Value={ 1L,5L,9L,21L,25L,37L,57L,85L,89L,101L,121L,149L,169L,213L,281L,341L,345L,357L,377L,405L,425L,469L,537L,597L,617L,661L,729L,821L,937L,1077L,1241L,1365L,1369L,1381L,1401L,1429L,1449L,1493L,1561L,1621L,1641L,1685L,1753L,1845L,1961L,2101L,2265L,2389L,2409L,2453L,2521L,2613L,2729L,2869L,3033L,3221L,3433L,3669L,3929L,4213L,4521L,4853L,5209L,5461L };
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
public class A256260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256260Inst : IEnumerable<long>
{
public static readonly long[] Value=A256260.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256260.Bytes);
public long this[int i]=>Value[i];

public static A256260Inst Instance=new A256260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256261
{
public static readonly long[] Value={ 1L,4L,4L,12L,4L,12L,20L,28L,4L,12L,20L,28L,20L,44L,68L,60L,4L,12L,20L,28L,20L,44L,68L,60L,20L,44L,68L,92L,116L,140L,164L,124L,4L,12L,20L,28L,20L,44L,68L,60L,20L,44L,68L,92L,116L,140L,164L,124L,20L,44L,68L,92L,116L,140L,164L,188L,212L,236L,260L,284L,308L,332L,356L,252L,4L,12L,20L,28L,20L,44L,68L,60L,20L,44L,68L,92L,116L,140L };
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
public class A256261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256261Inst : IEnumerable<long>
{
public static readonly long[] Value=A256261.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256261.Bytes);
public long this[int i]=>Value[i];

public static A256261Inst Instance=new A256261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256262
{
public static readonly long[] Value={ 1L,3L,1L,2L,1L,2L,4L,2L,4L,2L,7L,2L,4L,2L,13L,2L,1L,2L,13L,2L,4L,2L,13L,2L,4L,2L,1L,2L,13L,2L,4L,2L,13L,2L,4L,2L,13L,2L,16L,2L,34L,2L,4L,2L,13L,2L,28L,2L,22L,2L,13L,2L,7L,2L,10L,2L,7L,2L,73L,2L,4L,2L,1L,2L,13L,2L,10L,2L,67L,2L,4L,2L,7L,2L,4L,2L,13L,2L,28L,2L };
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
public class A256262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256262Inst : IEnumerable<long>
{
public static readonly long[] Value=A256262.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256262.Bytes);
public long this[int i]=>Value[i];

public static A256262Inst Instance=new A256262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256263
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,3L,5L,7L,1L,3L,5L,7L,5L,11L,17L,15L,1L,3L,5L,7L,5L,11L,17L,15L,5L,11L,17L,23L,29L,35L,41L,31L,1L,3L,5L,7L,5L,11L,17L,15L,5L,11L,17L,23L,29L,35L,41L,31L,5L,11L,17L,23L,29L,35L,41L,47L,53L,59L,65L,71L,77L,83L,89L,63L,1L,3L,5L,7L,5L,11L,17L,15L,5L,11L,17L,23L,29L,35L,41L,31L,5L,11L,17L,23L,29L,35L,41L,47L,53L,59L,65L,71L,77L,83L,89L };
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
public class A256263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256263Inst : IEnumerable<long>
{
public static readonly long[] Value=A256263.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256263.Bytes);
public long this[int i]=>Value[i];

public static A256263Inst Instance=new A256263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256264
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,9L,14L,21L,22L,25L,30L,37L,42L,53L,70L,85L,86L,89L,94L,101L,106L,117L,134L,149L,154L,165L,182L,205L,234L,269L,310L,341L,342L,345L,350L,357L,362L,373L,390L,405L,410L,421L,438L,461L,490L,525L,566L,597L,602L,613L,630L,653L,682L,717L,758L,805L,858L,917L,982L,1053L,1130L,1213L,1302L,1365L };
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
public class A256264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256264Inst : IEnumerable<long>
{
public static readonly long[] Value=A256264.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256264.Bytes);
public long this[int i]=>Value[i];

public static A256264Inst Instance=new A256264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256265
{
public static readonly long[] Value={ 1L,3L,7L,11L,15L,23L,35L,43L,47L,55L,67L,79L,95L,123L,155L,171L,175L,183L,195L,207L,223L,251L,283L,303L,319L,347L,387L,439L,503L,579L,651L,683L,687L,695L,707L,719L,735L,763L,795L,815L,831L,859L,899L,951L,1015L,1091L,1163L,1199L,1215L,1243L,1283L,1335L,1399L,1475L,1563L,1663L,1775L,1899L,2035L,2183L,2343L,2515L,2667L,2731L };
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
public class A256265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256265Inst : IEnumerable<long>
{
public static readonly long[] Value=A256265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256265.Bytes);
public long this[int i]=>Value[i];

public static A256265Inst Instance=new A256265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256266
{
public static readonly long[] Value={ 0L,6L,18L,24L,48L,66L,78L,84L,132L,174L,210L,240L,264L,282L,294L,300L,396L,486L,570L,648L,720L,786L,846L,900L,948L,990L,1026L,1056L,1080L,1098L,1110L,1116L,1308L,1494L,1674L,1848L,2016L,2178L,2334L,2484L,2628L,2766L,2898L,3024L,3144L,3258L,3366L,3468L,3564L,3654L,3738L,3816L,3888L,3954L,4014L,4068L,4116L,4158L,4194L,4224L,4248L };
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
public class A256266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256266Inst : IEnumerable<long>
{
public static readonly long[] Value=A256266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256266.Bytes);
public long this[int i]=>Value[i];

public static A256266Inst Instance=new A256266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256267
{
public static readonly long[] Value={ 2L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,13L,13L,7L,5L,2L,17L,3L,19L,5L,7L,11L,23L,29L,5L,13L,3L,7L,29L,31L,31L,2L,11L,17L,7L,37L,37L,19L,13L,41L,41L,7L,43L,11L,47L,23L,47L,53L,7L,5L,17L,13L,53L,3L,11L,59L,19L,29L,59L,61L,61L,31L,67L,2L,13L,11L,67L,17L,23L,71L,71L,73L };
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
public class A256267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256267Inst : IEnumerable<long>
{
public static readonly long[] Value=A256267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256267.Bytes);
public long this[int i]=>Value[i];

public static A256267Inst Instance=new A256267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256268
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,6L,3L,1L,1L,1L,24L,15L,4L,1L,1L,1L,120L,105L,28L,5L,1L,1L,1L,720L,945L,280L,45L,6L,1L,1L,1L,5040L,10395L,3640L,585L,66L,7L,1L,1L,1L,40320L,135135L,58240L,9945L,1056L,91L,8L,1L,1L,1L,362880L,2027025L,1106560L,208845L,22176L,1729L,120L,9L,1L,1L };
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
public class A256268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256268Inst : IEnumerable<long>
{
public static readonly long[] Value=A256268.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256268.Bytes);
public long this[int i]=>Value[i];

public static A256268Inst Instance=new A256268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256269
{
public static readonly long[] Value={ 1L,-1L,0L,0L,-1L,0L,0L,0L,0L,4L,-2L,0L,0L,-2L,0L,0L,-1L,0L,4L,0L,0L,0L,0L,0L,0L,-3L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,0L,4L,-2L,0L,0L,-2L,0L,0L,0L,0L,8L,0L,0L,0L,-1L,0L,0L,-2L,0L,0L,0L,0L,0L,-2L,0L,0L,-2L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,4L,-2L,0L,0L,0L,0L,0L,0L,0L,4L };
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
public class A256269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256269Inst : IEnumerable<long>
{
public static readonly long[] Value=A256269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256269.Bytes);
public long this[int i]=>Value[i];

public static A256269Inst Instance=new A256269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256270
{
public static readonly long[] Value={ 1L,2L,6L,24L,12L,54L,18L,36L,30L,48L,60L,84L,42L,90L,66L,72L,96L,78L,120L,126L,102L,150L,144L,108L,156L,114L,138L,132L,180L,204L,210L,168L,186L,192L,234L,174L,162L,216L,198L,222L,246L,228L,264L,348L,240L,270L,300L,330L,336L,402L,390L,414L,288L,306L,258L,294L,318L,324L,276L,252L,372L,426L,366L,282L,432L,354L,378L };
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
public class A256270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256270Inst : IEnumerable<long>
{
public static readonly long[] Value=A256270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256270.Bytes);
public long this[int i]=>Value[i];

public static A256270Inst Instance=new A256270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256271
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,6L,11L,8L,9L,10L,13L,12L,17L,14L,15L,16L,19L,18L,23L,20L,27L,22L,25L,21L,26L,29L,24L,31L,28L,33L,32L,35L,34L,39L,38L,37L,30L,41L,36L,43L,40L,47L,42L,53L,44L,45L,46L,49L,48L,59L,50L,51L,52L,55L,54L,61L,56L,57L,58L,63L,62L,65L,64L,67L,60L,71L,66L,73L,68L,69L,70L,79L,74L,75L,76L,77L,72L,83L,78L,85L };
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
public class A256271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256271Inst : IEnumerable<long>
{
public static readonly long[] Value=A256271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256271.Bytes);
public long this[int i]=>Value[i];

public static A256271Inst Instance=new A256271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256272
{
public static readonly long[] Value={ 2L,7L,14L,36L,72L,188L,410L,1021L,2392L,5818L,13862L,33678L,80784L,195440L,470916L,1137710L,2744212L,6627675L,15994430L,38619812L,93222780L,225072548L,543339722L,1311772784L,3166816034L,7645450834L,18457558444L,44560677618L,107578520352L,259717999680L,627013566050L,1513745792655L,3654502889812L };
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
public class A256272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256272Inst : IEnumerable<long>
{
public static readonly long[] Value=A256272.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256272.Bytes);
public long this[int i]=>Value[i];

public static A256272Inst Instance=new A256272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256273
{
public static readonly long[] Value={ 1L,6L,6L,1L,0L,9L,5L,8L,4L,5L,5L,4L,7L,7L,5L,5L,7L,0L,2L,6L,2L,2L,9L,1L,3L,9L,3L,7L,5L,3L,9L,9L,0L,5L,9L,6L,4L,0L,1L,2L,6L,9L,9L,5L,0L,4L,1L,5L,6L,0L,2L,2L,0L,0L,7L,2L,8L,4L,3L,5L,9L,1L,4L,1L,2L,9L,9L,7L,5L,8L,3L,5L,2L,1L,5L,4L,6L,8L,1L,5L,2L,8L,1L,7L,6L,2L,9L,7L,4L,4L,0L,3L,3L,0L,6L,9L,7L,9L,4L,3L,3L,7L,1L,7L,0L };
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
public class A256273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256273Inst : IEnumerable<long>
{
public static readonly long[] Value=A256273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256273.Bytes);
public long this[int i]=>Value[i];

public static A256273Inst Instance=new A256273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256274
{
public static readonly long[] Value={ 67928439L,266947136L,282959564L,290650720L,411522246L,412395369L,442605172L,469294445L,474377829L,484820862L,516574437L };
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
public class A256274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256274Inst : IEnumerable<long>
{
public static readonly long[] Value=A256274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256274.Bytes);
public long this[int i]=>Value[i];

public static A256274Inst Instance=new A256274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256275
{
public static readonly BigInteger[] Value={ 0L,6L,238L,31710L,16510910L,34089189246L,280371153272574L,9205322385119247870L,BigInteger.Parse("1207744073945406663293950"),BigInteger.Parse("633515663914742881158342637566"),BigInteger.Parse("1328903397983747395279166325955489790"),BigInteger.Parse("11149011303623843458013522930838119932485630"),BigInteger.Parse("374121581799746201009538413109130562019709006364670") };
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
public class A256275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256275Inst Instance=new A256275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256276
{
public static readonly long[] Value={ 1L,2L,0L,1L,4L,0L,0L,2L,0L,2L,0L,0L,2L,0L,0L,1L,4L,0L,0L,4L,0L,0L,0L,0L,3L,4L,0L,0L,4L,0L,0L,2L,0L,2L,0L,0L,2L,0L,0L,2L,4L,0L,0L,0L,0L,0L,0L,0L,1L,6L,0L,2L,4L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,1L,8L,0L,0L,4L,0L,0L,0L,0L,2L,4L,0L,0L,0L,0L,0L,4L,0L,2L,0L,0L,4L,0L,0L };
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
public class A256276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256276Inst : IEnumerable<long>
{
public static readonly long[] Value=A256276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256276.Bytes);
public long this[int i]=>Value[i];

public static A256276Inst Instance=new A256276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256277
{
public static readonly long[] Value={ 2L,1L,6L,7L,10L,1L,12L,1L,18L,19L,22L,6L,11L,1L,30L,9L,15L,1L,15L,1L,42L,15L,46L,29L,36L,1L,27L,55L,58L,1L,14L,19L,66L,21L,70L,1L,32L,35L,78L,43L,82L,40L,60L,1L,7L,60L,70L,1L,18L,1L,102L,96L,106L,1L,39L,1L,17L,96L,3L,111L,84L,31L,126L,84L,130L,37L,30L,1L };
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
public class A256277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256277Inst : IEnumerable<long>
{
public static readonly long[] Value=A256277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256277.Bytes);
public long this[int i]=>Value[i];

public static A256277Inst Instance=new A256277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256278
{
public static readonly BigInteger[] Value={ 1L,2L,33L,965L,28958L,869713L,26121321L,784539274L,23563199185L,707707535789L,21255600833094L,638400107288033L,19173990901769297L,575880114843495250L,17296237823997043137UL,BigInteger.Parse("519482849213446974997"),BigInteger.Parse("15602377428720941973934"),BigInteger.Parse("468608697663159238917041") };
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
public class A256278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256278Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256278.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256278.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256278Inst Instance=new A256278Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256279
{
public static readonly long[] Value={ 1L,1L,0L,0L,-1L,0L,0L,0L,0L,-4L,-2L,0L,0L,2L,0L,0L,-1L,0L,4L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,-2L,0L,4L,2L,0L,0L,-2L,0L,0L,0L,0L,-8L,0L,0L,0L,1L,0L,0L,-2L,0L,0L,0L,0L,0L,-2L,0L,0L,2L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,4L,2L,0L,0L,0L,0L,0L,0L,0L,-4L,-2L };
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
public class A256279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256279Inst : IEnumerable<long>
{
public static readonly long[] Value=A256279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256279.Bytes);
public long this[int i]=>Value[i];

public static A256279Inst Instance=new A256279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256280
{
public static readonly long[] Value={ 1L,-2L,4L,0L,-2L,8L,0L,0L,4L,4L,-4L,0L,0L,-4L,0L,0L,-2L,8L,4L,0L,8L,0L,0L,0L,0L,-6L,8L,0L,0L,8L,0L,0L,4L,0L,-4L,0L,4L,-4L,0L,0L,-4L,8L,0L,0L,0L,8L,0L,0L,0L,-2L,12L,0L,-4L,8L,0L,0L,0L,0L,-4L,0L,0L,-4L,0L,0L,-2L,16L,0L,0L,8L,0L,0L,0L,4L,-4L,8L,0L,0L,0L,0L,0L,8L };
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
public class A256280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256280Inst : IEnumerable<long>
{
public static readonly long[] Value=A256280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256280.Bytes);
public long this[int i]=>Value[i];

public static A256280Inst Instance=new A256280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256281
{
public static readonly long[] Value={ 1L,3L,6L,15L,30L,78L,170L,423L,991L,2410L,5742L,13950L,33462L,80954L,195060L,471255L,1136690L,2745273L,6625110L,15996850L,38614140L,93228102L,225058682L,543354078L,1311738151L,3166849426L,7645371036L,18457637018L,44560482150L,107578717860L,259717522850L,627014037303L,1513744660692L,3654504012630L };
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
public class A256281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256281Inst : IEnumerable<long>
{
public static readonly long[] Value=A256281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256281.Bytes);
public long this[int i]=>Value[i];

public static A256281Inst Instance=new A256281Inst();

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