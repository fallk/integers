using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A245182
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,6L,4L,1L,12L,26L,20L,7L,1L,60L,140L,121L,51L,11L,1L,360L,894L,849L,410L,110L,16L,1L,2520L,6594L,6763L,3634L,1135L,211L,22L,1L };
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
public class A245182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245182Inst : IEnumerable<long>
{
public static readonly long[] Value=A245182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245182.Bytes);
public long this[int i]=>Value[i];

public static A245182Inst Instance=new A245182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245183
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,4L,10L,9L,4L,1L,20L,50L,48L,24L,7L,1L,120L,310L,315L,171L,56L,11L,1L,840L,2254L,2419L,1409L,505L,116L,16L,1L };
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
public class A245183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245183Inst : IEnumerable<long>
{
public static readonly long[] Value=A245183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245183.Bytes);
public long this[int i]=>Value[i];

public static A245183Inst Instance=new A245183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245184
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,4L,4L,2L,1L,5L,15L,17L,10L,4L,1L,30L,85L,97L,61L,25L,7L,1L,210L,595L,691L,451L,192L,57L,11L,1L };
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
public class A245184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245184Inst : IEnumerable<long>
{
public static readonly long[] Value=A245184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245184.Bytes);
public long this[int i]=>Value[i];

public static A245184Inst Instance=new A245184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245185
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,5L,2L,1L,1L,3L,7L,7L,3L,1L,1L,3L,11L,15L,11L,3L,1L,1L,4L,15L,25L,25L,15L,4L,1L,1L,4L,20L,41L,52L,41L,20L,4L,1L };
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
public class A245185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245185Inst : IEnumerable<long>
{
public static readonly long[] Value=A245185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245185.Bytes);
public long this[int i]=>Value[i];

public static A245185Inst Instance=new A245185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245186
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,6L,8L,10L,8L,6L,8L,8L,10L,10L,10L,8L,8L,6L,8L,10L,10L,8L,10L,12L,12L,10L,12L,12L,10L,8L,10L,10L,8L,6L,8L,8L,10L,10L,12L,12L,10L,8L,10L,12L,14L,12L,12L,12L,12L,10L,12L,12L,12L,12L,14L,12L,10L,8L,10L,12L,12L,10L,10L,8L,8L,6L,8L,10L,10L,8L,10L,12L,12L,10L,12L,12L,12L,12L,14L,12L,10L,8L,10L,12L,14L,12L,14L,16L,14L,12L,14L,14L,14L,12L,12L,12L,12L,10L,12L,12L };
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
public class A245186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245186Inst : IEnumerable<long>
{
public static readonly long[] Value=A245186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245186.Bytes);
public long this[int i]=>Value[i];

public static A245186Inst Instance=new A245186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245187
{
public static readonly long[] Value={ 1L,2L,0L,0L,1L,2L,1L,2L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,1L,2L,1L,2L,0L,0L,1L,2L,1L,2L,1L,2L,0L,0L,1L,2L,1L,2L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,1L,2L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,1L,2L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,1L,2L,1L,2L,0L,0L,1L,2L,1L,2L,1L,2L,0L,0L,1L,2L,1L,2L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,1L,2L };
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
public class A245187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245187Inst : IEnumerable<long>
{
public static readonly long[] Value=A245187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245187.Bytes);
public long this[int i]=>Value[i];

public static A245187Inst Instance=new A245187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245188
{
public static readonly long[] Value={ 1L,3L,2L,1L,2L,0L,1L,3L,2L,0L,1L,2L,1L,3L,2L,1L,2L,0L,1L,2L,1L,3L,2L,0L,1L,3L,2L,1L,2L,0L,1L,3L,2L,0L,1L,2L,1L,3L,2L,0L,1L,3L,2L,1L,2L,0L,1L,2L,1L,3L,2L,1L,2L,0L,1L,3L,2L,0L,1L,2L,1L,3L,2L,1L,2L,0L,1L,2L,1L,3L,2L,0L,1L,3L,2L,1L,2L,0L,1L,2L,1L,3L,2L,1L,2L,0L,1L,3L,2L,0L,1L,2L,1L,3L,2L,0L,1L,3L,2L,1L,2L,0L,1L,3L,2L,0L,1L,2L,1L,3L,2L,1L,2L,0L,1L };
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
public class A245188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245188Inst : IEnumerable<long>
{
public static readonly long[] Value=A245188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245188.Bytes);
public long this[int i]=>Value[i];

public static A245188Inst Instance=new A245188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245189
{
public static readonly long[] Value={ 1L,5L,5L,8L,6L,10L,9L,11L,6L,12L,10L,14L,11L,14L,10L,12L,6L,12L,10L,15L,11L,17L,14L,18L,11L,18L,14L,17L,11L,15L,10L,12L,6L,12L,10L,15L,11L,17L,14L,18L,11L,19L,15L,21L,16L,21L,15L,19L,11L,19L,15L,21L,16L,21L,15L,19L,11L,18L,14L,17L,11L,15L,10L,12L,6L,12L,10L,15L,11L,17L,14L,18L,11L,19L,15L,21L,16L,21L,15L,19L,11L,19L,15L,22L,16L,24L,19L,25L,16L,25L,19L,24L,16L,22L,15L,19L,11L,19L,15L,22L };
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
public class A245189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245189Inst : IEnumerable<long>
{
public static readonly long[] Value=A245189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245189.Bytes);
public long this[int i]=>Value[i];

public static A245189Inst Instance=new A245189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245190
{
public static readonly BigInteger[] Value={ 1L,3L,336L,80510976L,BigInteger.Parse("4632013631072036192256"),BigInteger.Parse("9259244309598002961669050091730162686136971834955923456") };
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
public class A245190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245190Inst Instance=new A245190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245191
{
public static readonly long[] Value={ 1L,2L,5L,8L,20L,34L,85L,128L,320L,544L,1360L,2056L,5140L,8738L,21845L,32768L,81920L,139264L,348160L,526336L,1315840L,2236928L,5592320L,8388736L,20971840L,35652128L,89130320L,134744072L,336860180L,572662306L,1431655765L,2147483648L,5368709120L,9126805504L };
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
public class A245191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245191Inst : IEnumerable<long>
{
public static readonly long[] Value=A245191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245191.Bytes);
public long this[int i]=>Value[i];

public static A245191Inst Instance=new A245191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245192
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,1L,2L,2L,3L,1L,2L,3L,3L,1L,2L,1L,2L,1L,2L,3L,3L,1L,2L,3L,4L,1L,2L,1L,2L,3L,2L,2L,3L,1L,2L,3L,2L,3L,4L,1L,2L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,1L,2L,3L,4L,2L,3L,1L,2L,3L,4L,5L,2L,1L,2L,1L,2L,3L,4L,1L,2L,3L,4L,1L,2L,1L };
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
public class A245192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245192Inst : IEnumerable<long>
{
public static readonly long[] Value=A245192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245192.Bytes);
public long this[int i]=>Value[i];

public static A245192Inst Instance=new A245192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245193
{
public static readonly long[] Value={ 11L,3L,7L,19L,11L,13L,17L,19L,31L,233L,37L,139L,71L,73L,277L,79L,191L,193L,97L,199L,2111L,113L,1117L,3119L,131L,4133L,137L,139L,1171L,173L,4177L,179L,191L,193L,197L,199L,311L,313L,317L,1319L,331L,2333L,337L,2339L,2371L,373L,2377L,379L,3391L,2393L,397L,1399L };
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
public class A245193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245193Inst : IEnumerable<long>
{
public static readonly long[] Value=A245193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245193.Bytes);
public long this[int i]=>Value[i];

public static A245193Inst Instance=new A245193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245194
{
public static readonly long[] Value={ 0L,0L,0L,1L,-1L,0L,1L,1L,-2L,0L,0L,1L,0L,0L,1L,1L,-3L,0L,0L,1L,-1L,0L,1L,1L,-1L,0L,0L,1L,0L,0L,1L,1L,-4L,0L,0L,1L,-1L,0L,1L,1L,-2L,0L,0L,1L,0L,0L,1L,1L,-2L,0L,0L,1L,-1L,0L,1L,1L,-1L,0L,0L,1L,0L,0L,1L,1L,-5L,0L,0L,1L,-1L,0L,1L,1L,-2L,0L,0L,1L,0L,0L,1L,1L,-3L,0L,0L,1L,-1L,0L,1L,1L,-1L,0L,0L,1L,0L,0L,1L };
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
public class A245194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245194Inst : IEnumerable<long>
{
public static readonly long[] Value=A245194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245194.Bytes);
public long this[int i]=>Value[i];

public static A245194Inst Instance=new A245194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245195
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,1L,2L,2L,2L,4L,8L,1L,1L,1L,2L,1L,1L,2L,4L,2L,2L,2L,4L,4L,4L,8L,16L,1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,1L,2L,2L,2L,4L,8L,2L,2L,2L,4L,2L,2L,4L,8L,4L,4L,4L,8L,8L,8L,16L,32L,1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,1L,2L,2L,2L,4L,8L,1L,1L,1L,2L,1L,1L,2L,4L,2L,2L,2L,4L,4L,4L,8L,16L,2L,2L,2L,4L,2L };
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
public class A245195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245195Inst : IEnumerable<long>
{
public static readonly long[] Value=A245195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245195.Bytes);
public long this[int i]=>Value[i];

public static A245195Inst Instance=new A245195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245196
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,2L,0L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L };
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
public class A245196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245196Inst : IEnumerable<long>
{
public static readonly long[] Value=A245196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245196.Bytes);
public long this[int i]=>Value[i];

public static A245196Inst Instance=new A245196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245197
{
public static readonly long[] Value={ 1L,8L,85L,125L,365L,445L,533L,629L,965L,1685L,1800L,1853L,2340L,2605L,2813L,3029L,3973L,4765L,5045L,5220L,5629L,5933L,6245L,6893L,8285L,8653L,11029L,11453L,11885L,12773L,14165L,15133L,16645L,17165L,17460L,17693L,20453L,21029L,22205L,22805L,23413L,24653L,27229L };
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
public class A245197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245197Inst : IEnumerable<long>
{
public static readonly long[] Value=A245197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245197.Bytes);
public long this[int i]=>Value[i];

public static A245197Inst Instance=new A245197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245198
{
public static readonly long[] Value={ 1L,0L,4L,0L,0L,4L,1L,9L,1L,1L,5L,2L,5L,9L,5L,2L,0L,5L,7L,2L,6L,5L,0L,2L,8L,4L,1L,2L,1L,7L,8L,9L,4L,2L,6L,9L,3L,1L,6L,8L,9L,0L,2L,6L,7L,0L,1L,8L,6L,6L,3L,1L,0L,5L,4L,8L,4L,8L,7L,9L,5L,5L,4L,0L,1L,0L,0L,0L,5L,3L,1L,5L,5L,6L,9L,8L,6L,3L,4L,3L,8L,6L,8L,0L,3L,0L,2L,8L,3L,1L,8L,3L,9L,5L,3L,7L,8L,7L,4L,3L,3L,6L,4L,3L };
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
public class A245198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245198Inst : IEnumerable<long>
{
public static readonly long[] Value=A245198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245198.Bytes);
public long this[int i]=>Value[i];

public static A245198Inst Instance=new A245198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245199
{
public static readonly long[] Value={ 1L,8L,10L,34L,57L,74L,85L,125L,185L,202L,219L,394L,451L,456L,489L,505L,514L,546L,570L,629L,640L,679L,680L,802L,985L,1000L,1026L,1057L,1154L,1285L,1354L,1365L,1387L,1417L,1480L,1717L,1752L,1938L,2005L,2016L,2047L,2176L,2190L,2340L,2457L,2509L,2565L,2594L,2649L };
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
public class A245199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245199Inst : IEnumerable<long>
{
public static readonly long[] Value=A245199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245199.Bytes);
public long this[int i]=>Value[i];

public static A245199Inst Instance=new A245199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245200
{
public static readonly long[] Value={ 6L,15L,12L,27L,18L,39L,24L,30L,63L,75L,42L,87L,48L,54L,60L,123L,135L,72L,147L,159L,84L,90L,195L,102L,207L,108L,219L,114L,255L,132L,138L,279L,150L,303L,315L,327L,168L,174L,180L,363L,192L,387L,198L,399L,423L,447L,228L,459L,234L,240L,483L,252L,258L,264L,270L,543L };
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
public class A245200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245200Inst : IEnumerable<long>
{
public static readonly long[] Value=A245200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245200.Bytes);
public long this[int i]=>Value[i];

public static A245200Inst Instance=new A245200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245201
{
public static readonly long[] Value={ 3L,1L,2L,0L,1L,2L,5L,7L,3L,4L,5L,7L,7L,8L,5L,6L,1L,7L,1L,7L,9L,5L,0L,8L,5L,2L,3L,6L,5L,3L,6L,8L,2L,8L,0L,7L,9L,5L,0L,6L,7L,0L,8L,0L,1L,0L,5L,5L,9L,8L,9L,3L,1L,6L,4L,5L,4L,6L,3L,8L,6L,6L,2L,0L,3L,0L,0L,1L,5L,9L,4L,6L,7L,0L,9L,5L,9L,0L,3L,1L,6L,0L,4L,0L,9L,0L,8L,4L,9L,5L,5L,1L,8L,6L,1L,3L,6L,2L,3L,0L,0L,9L,3L,0L };
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
public class A245201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245201Inst : IEnumerable<long>
{
public static readonly long[] Value=A245201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245201.Bytes);
public long this[int i]=>Value[i];

public static A245201Inst Instance=new A245201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245202
{
public static readonly long[] Value={ 3L,9L,21L,24L,26L,30L,51L,72L,77L,84L,90L,93L,100L,119L,122L,162L,168L,174L,194L,210L,213L,221L,276L,282L,291L,301L,381L,384L,386L,408L,414L,437L,469L,510L,527L,533L,564L,594L,597L,616L,723L,731L,744L,770L,791L,794L,858L,869L,896L,917L,930L,948L,952L,954L };
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
public class A245202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245202Inst : IEnumerable<long>
{
public static readonly long[] Value=A245202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245202.Bytes);
public long this[int i]=>Value[i];

public static A245202Inst Instance=new A245202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245203
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,3L,2L,0L,0L,2L,3L,0L,1L,0L,0L,1L,0L,0L,4L,3L,3L,7L,0L,0L,7L,3L,3L,4L,0L,0L,1L,0L,9L,4L,0L,6L,2L,0L,0L,2L,6L,0L,4L,6L,0L,1L,0L,6L,4L,0L,6L,2L,0L,0L,2L,9L,0L,5L,6L,0L,4L,12L,0L,1L,0L,9L,7L,0L,6L,5L,3L,12L,16L,0L,0L,8L,3L,15L,5L,0L,6L,2L,9L,0L,17L,6L,0L,1L,0L,3L,2L,0L,0L,14L,27L,9L,5L,9L,6L,7L,12L,0L,10L,15L,0L,1L,0L,0L,4L,3L,3L,5L,0L,0L,2L,3L,0L,1L,0L,0L,1L,0L,0L,4L };
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
public class A245203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245203Inst : IEnumerable<long>
{
public static readonly long[] Value=A245203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245203.Bytes);
public long this[int i]=>Value[i];

public static A245203Inst Instance=new A245203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245204
{
public static readonly long[] Value={ 1L,2L,2L,4L,1L,1L,5L,1L,-2L,-6L,10L,14L,5L,7L,7L,-28L,-12L,13L,14L,26L,-21L,-31L,-13L,-10L,-11L,-7L,-6L,5L,2L,-21L,2L,33L,-15L,-24L,34L,71L,-15L,24L,9L,37L,73L,-18L,-84L,-65L,9L,-90L,-65L,-47L,97L,-64L,-100L,-8L,41L,81L,-81L,-71L,-65L,-70L,113L,10L,-80L,119L,57L,78L,20L,124L,167L,-71L,-48L };
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
public class A245204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245204Inst : IEnumerable<long>
{
public static readonly long[] Value=A245204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245204.Bytes);
public long this[int i]=>Value[i];

public static A245204Inst Instance=new A245204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245205
{
public static readonly long[] Value={ 0L,3L,8L,21L,24L,35L,64L,75L,87L,97L,176L,274L,278L,304L,736L,757L,902L,920L,1139L,1936L,4361L,6374L,10181L,11848L,17771L,43487L,49987L,71552L,93124L,152446L,217835L,217856L,243706L,440152L,480487L,864901L };
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
public class A245205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245205Inst : IEnumerable<long>
{
public static readonly long[] Value=A245205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245205.Bytes);
public long this[int i]=>Value[i];

public static A245205Inst Instance=new A245205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245206
{
public static readonly long[] Value={ 1019L };
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
public class A245206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245206Inst : IEnumerable<long>
{
public static readonly long[] Value=A245206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245206.Bytes);
public long this[int i]=>Value[i];

public static A245206Inst Instance=new A245206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245207
{
public static readonly long[] Value={ 2L,5L,11L,19L,29L,41L,54L,70L,88L,108L,130L,154L,179L,207L,237L,269L,303L,339L,376L,416L,458L,502L,548L,596L,645L,697L,751L,807L,865L,925L,986L,1050L,1116L,1184L,1254L,1325L,1399L,1475L,1553L,1633L,1715L,1798L,1884L,1972L,2062L,2154L,2248L,2343L,2441L,2541L,2643L,2747L,2853L,2960L,3070L };
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
public class A245207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245207Inst : IEnumerable<long>
{
public static readonly long[] Value=A245207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245207.Bytes);
public long this[int i]=>Value[i];

public static A245207Inst Instance=new A245207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245208
{
public static readonly long[] Value={ 280L,290L,10063L,10081L,10171L,10372L,10382L,10393L,10451L,10462L,10552L,10561L,10562L,10573L,10652L,10783L,10871L,10943L,10951L,10952L,10961L,10963L,11053L,11141L,11183L,11263L,11362L,11372L,11441L,11452L,11453L,11542L,11552L,11563L,11642L,11773L,11843L };
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
public class A245208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245208Inst : IEnumerable<long>
{
public static readonly long[] Value=A245208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245208.Bytes);
public long this[int i]=>Value[i];

public static A245208Inst Instance=new A245208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245209
{
public static readonly long[] Value={ 10031L,10040L,10190L,10231L,10390L,10441L,10480L,10541L,10721L,10921L,10970L,11021L,11030L,11180L,11221L,11380L,11431L,11470L,11531L,11711L,11911L,11960L,12020L,12170L,12370L,12460L,12521L,12701L,12901L,12950L,13010L,13160L,13201L,13360L,13450L,13511L,13601L };
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
public class A245209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245209Inst : IEnumerable<long>
{
public static readonly long[] Value=A245209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245209.Bytes);
public long this[int i]=>Value[i];

public static A245209Inst Instance=new A245209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245210
{
public static readonly long[] Value={ 1001320L,1001720L,1002220L,1004420L,1005520L,1005710L,1005910L,1006120L,1007420L,1008710L,1009220L,1009510L,1009610L,1011220L,1011620L,1012120L,1014320L,1015420L,1015610L,1015810L,1016020L,1017320L,1018610L,1019120L,1019410L,1019510L,1021120L,1021520L };
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
public class A245210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245210Inst : IEnumerable<long>
{
public static readonly long[] Value=A245210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245210.Bytes);
public long this[int i]=>Value[i];

public static A245210Inst Instance=new A245210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245211
{
public static readonly long[] Value={ 0L,1L,1L,5L,1L,11L,1L,17L,7L,15L,1L,47L,1L,19L,17L,49L,1L,62L,1L,67L,21L,27L,1L,151L,11L,31L,34L,87L,1L,145L,1L,129L,29L,39L,25L,254L,1L,43L,33L,219L,1L,189L,1L,127L,104L,51L,1L,423L,15L,130L,41L,147L,1L,278L,33L,287L,45L,63L,1L,589L,1L,67L,132L,321L,37L,277L };
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
public class A245211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245211Inst : IEnumerable<long>
{
public static readonly long[] Value=A245211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245211.Bytes);
public long this[int i]=>Value[i];

public static A245211Inst Instance=new A245211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245212
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,13L,15L,20L,25L,21L,25L,25L,37L,43L,31L,33L,46L,37L,53L,63L,61L,45L,41L,64L,73L,74L,81L,57L,95L,61L,63L,103L,97L,115L,70L,73L,109L,123L,101L,81L,147L,85L,137L,166L,133L,93L,57L,132L,170L,163L,165L,105L,154L,187L,161L,183L,169L,117L,131L,121L };
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
public class A245212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245212Inst : IEnumerable<long>
{
public static readonly long[] Value=A245212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245212.Bytes);
public long this[int i]=>Value[i];

public static A245212Inst Instance=new A245212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245213
{
public static readonly long[] Value={ 72L,96L,120L,144L,180L,192L,216L,240L,288L,336L,360L,384L,432L,480L,504L,528L,540L,576L,600L,624L,648L,672L,720L,756L,768L,792L,840L,864L,900L,936L,960L,972L,1008L,1056L,1080L,1120L,1152L,1176L,1200L,1224L,1248L,1260L,1280L,1296L,1320L,1344L,1368L,1440L,1512L };
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
public class A245213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245213Inst : IEnumerable<long>
{
public static readonly long[] Value=A245213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245213.Bytes);
public long this[int i]=>Value[i];

public static A245213Inst Instance=new A245213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245214
{
public static readonly long[] Value={ 144L,192L,216L,240L,288L,336L,360L,384L,432L,480L,504L,540L,576L,600L,648L,672L,720L,768L,792L,840L,864L,900L,936L,960L,1008L,1056L,1080L,1152L,1200L,1248L,1260L,1296L,1320L,1344L,1440L,1512L,1536L,1560L,1584L,1620L,1632L,1680L,1728L,1800L,1824L,1848L,1872L,1920L,1944L,1980L,2016L,2040L,2100L,2112L,2160L,2240L };
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
public class A245214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245214Inst : IEnumerable<long>
{
public static readonly long[] Value=A245214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245214.Bytes);
public long this[int i]=>Value[i];

public static A245214Inst Instance=new A245214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245215
{
public static readonly long[] Value={ 3L,6L,6L,3L,0L,4L,6L,9L,4L,6L,5L,3L,2L,7L,2L,6L,5L,6L,6L,8L,2L,4L,9L,4L,1L,3L,1L,4L,2L,9L,0L,9L,6L,6L,9L,2L,9L,9L,8L,4L,2L,7L,8L,8L,9L,3L,9L,2L,5L,4L,3L,1L,6L,0L,4L,1L,0L,3L,1L,0L,3L,8L,0L,6L,3L,6L,0L,0L,5L,6L,4L,5L,2L,9L,0L,6L,1L,5L,4L,6L,1L,6L,9L,4L,9L,5L };
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
public class A245215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245215Inst : IEnumerable<long>
{
public static readonly long[] Value=A245215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245215.Bytes);
public long this[int i]=>Value[i];

public static A245215Inst Instance=new A245215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245216
{
public static readonly long[] Value={ 2L,7L,2L,9L,9L,6L,7L,7L,4L,1L,5L,9L,9L,8L,0L,2L,4L,8L,7L,8L,9L,1L,6L,4L,6L,7L,7L,4L,8L,7L,5L,9L,0L,7L,5L,2L,1L,1L,4L,3L,7L,8L,4L,1L,1L,3L,5L,3L,7L,0L,3L,4L,6L,2L,5L,9L,8L,6L,9L,5L,2L,7L,2L,4L,5L,2L,9L,0L,0L,6L,8L,8L,6L,4L,9L,3L,2L,6L,4L,2L,8L,6L,8L,0L,0L,6L };
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
public class A245216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245216Inst : IEnumerable<long>
{
public static readonly long[] Value=A245216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245216.Bytes);
public long this[int i]=>Value[i];

public static A245216Inst Instance=new A245216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245217
{
public static readonly long[] Value={ 2L,9L,0L,9L,9L,5L,0L,2L,7L,0L,8L,6L,5L,9L,0L,6L,3L,0L,7L,4L,0L,5L,1L,1L,6L,6L,8L,1L,8L,3L,7L,7L,7L,6L,5L,1L,3L,8L,5L,4L,3L,2L,0L,1L,6L,1L,0L,9L,6L,3L,8L,8L,9L,9L,6L,6L,2L,3L,6L,0L,5L,9L,9L,9L,3L,0L,5L,6L,4L,4L,0L,8L,2L,9L,8L,2L,1L,1L,8L,9L,6L,3L,0L,3L,3L,1L };
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
public class A245217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245217Inst : IEnumerable<long>
{
public static readonly long[] Value=A245217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245217.Bytes);
public long this[int i]=>Value[i];

public static A245217Inst Instance=new A245217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245218
{
public static readonly long[] Value={ 3L,4L,3L,6L,4L,8L,4L,8L,4L,3L,0L,9L,8L,1L,3L,5L,1L,7L,8L,4L,6L,1L,0L,5L,3L,9L,0L,3L,9L,2L,4L,7L,1L,3L,5L,6L,5L,0L,0L,9L,8L,8L,1L,6L,0L,6L,7L,3L,7L,8L,3L,0L,5L,4L,3L,6L,5L,8L,6L,6L,6L,6L,0L,5L,1L,7L,6L,2L,7L,1L,0L,7L,9L,0L,7L,6L,9L,8L,6L,2L,6L,0L,4L,6L,1L,6L };
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
public class A245218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245218Inst : IEnumerable<long>
{
public static readonly long[] Value=A245218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245218.Bytes);
public long this[int i]=>Value[i];

public static A245218Inst Instance=new A245218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245219
{
public static readonly long[] Value={ 3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L };
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
public class A245219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245219Inst : IEnumerable<long>
{
public static readonly long[] Value=A245219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245219.Bytes);
public long this[int i]=>Value[i];

public static A245219Inst Instance=new A245219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245220
{
public static readonly long[] Value={ 3L,6L,7L,5L,4L,3L,4L,9L,1L,1L,8L,4L,9L,5L,1L,2L,4L,8L,7L,2L,1L,2L,6L,0L,9L,7L,2L,5L,4L,1L,0L,9L,2L,5L,4L,0L,7L,0L,8L,3L,4L,4L,0L,8L,8L,6L,0L,5L,2L,0L,6L,3L,6L,5L,9L,3L,6L,0L,9L,1L,7L,8L,7L,0L,4L,6L,9L,2L,5L,9L,5L,1L,9L,7L,4L,4L,3L,5L,6L,0L,6L,2L,5L,8L,0L,2L };
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
public class A245220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245220Inst : IEnumerable<long>
{
public static readonly long[] Value=A245220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245220.Bytes);
public long this[int i]=>Value[i];

public static A245220Inst Instance=new A245220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245221
{
public static readonly long[] Value={ 2L,7L,2L,0L,7L,6L,6L,4L,5L,0L,7L,2L,9L,4L,7L,5L,2L,9L,7L,5L,4L,6L,9L,5L,1L,7L,3L,4L,8L,1L,7L,1L,5L,1L,3L,2L,4L,2L,5L,4L,7L,4L,9L,7L,9L,6L,1L,7L,1L,4L,6L,4L,1L,6L,7L,9L,0L,0L,0L,8L,2L,8L,3L,6L,6L,8L,7L,6L,6L,2L,4L,2L,1L,2L,1L,6L,7L,7L,7L,9L,0L,9L,7L,7L,8L,6L };
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
public class A245221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245221Inst : IEnumerable<long>
{
public static readonly long[] Value=A245221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245221.Bytes);
public long this[int i]=>Value[i];

public static A245221Inst Instance=new A245221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245222
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,2L,1L };
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
public class A245222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245222Inst : IEnumerable<long>
{
public static readonly long[] Value=A245222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245222.Bytes);
public long this[int i]=>Value[i];

public static A245222Inst Instance=new A245222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245223
{
public static readonly long[] Value={ 3L,6L,9L,3L,0L,6L,3L,9L,6L,4L,5L,3L,0L,1L,2L,3L,0L,5L,9L,7L,2L,7L,8L,1L,6L,9L,3L,6L,8L,7L,1L,9L,0L,6L,6L,9L,4L,4L,5L,6L,3L,1L,3L,3L,1L,6L,9L,0L,3L,8L,4L,9L,6L,0L,5L,3L,1L,0L,9L,1L,0L,0L,2L,8L,8L,6L,3L,3L,4L,6L,9L,2L,4L,5L,3L,0L,2L,7L,0L,1L,2L,6L,2L,9L,8L,0L };
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
public class A245223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245223Inst : IEnumerable<long>
{
public static readonly long[] Value=A245223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245223.Bytes);
public long this[int i]=>Value[i];

public static A245223Inst Instance=new A245223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245224
{
public static readonly long[] Value={ 2L,7L,0L,7L,7L,7L,8L,7L,1L,6L,0L,0L,5L,0L,7L,8L,1L,2L,4L,3L,4L,0L,2L,0L,6L,6L,6L,5L,9L,6L,3L,1L,3L,1L,6L,2L,9L,9L,2L,3L,3L,1L,2L,4L,2L,4L,9L,1L,0L,4L,4L,5L,1L,7L,6L,6L,6L,9L,1L,3L,7L,9L,1L,8L,3L,4L,6L,4L,8L,3L,0L,8L,8L,4L,3L,2L,3L,4L,7L,0L,0L,2L,3L,5L,5L,3L };
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
public class A245224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245224Inst : IEnumerable<long>
{
public static readonly long[] Value=A245224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245224.Bytes);
public long this[int i]=>Value[i];

public static A245224Inst Instance=new A245224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245225
{
public static readonly long[] Value={ 2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L };
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
public class A245225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245225Inst : IEnumerable<long>
{
public static readonly long[] Value=A245225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245225.Bytes);
public long this[int i]=>Value[i];

public static A245225Inst Instance=new A245225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245226
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,10L,13L,16L,17L,18L,20L,25L,26L,29L,32L,36L,37L,40L,41L,45L,49L,50L,52L,53L,58L,61L,64L,65L,68L,72L,73L,74L,80L,81L,82L,85L,89L,90L,97L,98L,100L,101L,104L,106L,109L,113L,116L,117L,121L,122L,125L,128L,130L,137L,144L,145L,148L,149L,153L,157L };
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
public class A245226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245226Inst : IEnumerable<long>
{
public static readonly long[] Value=A245226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245226.Bytes);
public long this[int i]=>Value[i];

public static A245226Inst Instance=new A245226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245227
{
public static readonly long[] Value={ 0L,2L,3L,5L,7L,9L,10L,12L,13L,15L,17L,18L,19L,21L,22L,25L,26L,27L,29L,30L,32L,34L,35L,37L,38L,40L,42L,43L,44L,46L,47L,50L,51L,52L,54L,55L,57L,59L,60L,62L,63L,65L,67L,68L,69L,71L,72L,75L,76L,77L,79L,80L,82L,84L,85L,87L,88L,90L,92L,93L,94L,96L,97L,100L,101L,102L };
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
public class A245227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245227Inst : IEnumerable<long>
{
public static readonly long[] Value=A245227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245227.Bytes);
public long this[int i]=>Value[i];

public static A245227Inst Instance=new A245227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245228
{
public static readonly long[] Value={ 1L,13L,169L,1755L,16432L,134459L,962988L,6009159L,32819436L,157702259L,671225412L,2546958349L,8668626707L,26607292908L,74002375408L,187274148048L,432761029519L,915980606957L,1780453974039L,3185285527359L,5254786194372L,8006264748053L,11280519244644L,14712774203725L,17777183437949L,19909964116172L,20675571474936L,19909964116172L,17777183437949L,14712774203725L,11280519244644L,8006264748053L,5254786194372L,3185285527359L,1780453974039L,915980606957L,432761029519L,187274148048L,74002375408L,26607292908L,8668626707L,2546958349L,671225412L,157702259L,32819436L,6009159L,962988L,134459L,16432L,1755L,169L,13L,1L };
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
public class A245228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245228Inst : IEnumerable<long>
{
public static readonly long[] Value=A245228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245228.Bytes);
public long this[int i]=>Value[i];

public static A245228Inst Instance=new A245228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245229
{
public static readonly long[] Value={ 7L,47L,61L,103L,113L,211L,223L,229L,311L,337L,401L,419L,491L,787L,1021L,1453L,1489L,1697L,2039L,3659L,4703L,5279L };
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
public class A245229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245229Inst : IEnumerable<long>
{
public static readonly long[] Value=A245229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245229.Bytes);
public long this[int i]=>Value[i];

public static A245229Inst Instance=new A245229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245230
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,2L,3L,4L,0L,2L,3L,5L,7L,0L,3L,4L,7L,9L,11L,0L,3L,5L,8L,10L,13L,16L,0L,4L,6L,10L,12L,16L,19L,22L };
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
public class A245230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245230Inst : IEnumerable<long>
{
public static readonly long[] Value=A245230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245230.Bytes);
public long this[int i]=>Value[i];

public static A245230Inst Instance=new A245230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245231
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,7L,8L,10L,10L,12L,13L,14L,15L,17L,18L,20L,20L,22L,23L,24L,25L,27L,28L,30L,30L,32L,33L,34L,35L,37L,38L,40L,40L,42L,43L,44L,45L,47L,48L,50L,50L,52L,53L,54L,55L,57L,58L,60L,60L,62L,63L,64L,65L,67L,68L,70L,70L,72L,73L,74L,75L,77L,78L,80L,80L,82L,83L,84L,85L,87L,88L,90L,90L,92L,93L,94L,95L,97L,98L,100L };
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
public class A245231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245231Inst : IEnumerable<long>
{
public static readonly long[] Value=A245231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245231.Bytes);
public long this[int i]=>Value[i];

public static A245231Inst Instance=new A245231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245232
{
public static readonly long[] Value={ 6L,85L,146L,489L,1469L,3281L,4579L,6181L,8119L,19871L,23969L,99269L,238631L,439031L,470009L,536269L,961969L,1240619L,1365631L,2579981L,2887219L,3105031L,3696881L,3953221L,5096981L,5413801L,7002379L,8006069L,8874781L,22050881L,23310631L,27854731L,34596869L,40465769L };
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
public class A245232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245232Inst : IEnumerable<long>
{
public static readonly long[] Value=A245232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245232.Bytes);
public long this[int i]=>Value[i];

public static A245232Inst Instance=new A245232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245233
{
public static readonly ulong[] Value={ 1L,1L,2L,6L,24L,114L,592L,3216L,17904L,101198L,578208L,3332136L,19343408L,113017332L,664168160L,3923729280L,23291913440L,138872375958L,831321465408L,4994806458040L,30111586314800L,182094123983660L,1104331746746208L,6715050373394528L,40931670125150624L,250065092876686924L,1530948705125205952L,9391164635349135184UL };
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
public class A245233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245233Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A245233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245233.Bytes);
public ulong this[int i]=>Value[i];

public static A245233Inst Instance=new A245233Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245234
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,28L,45L,47L,49L,51L,53L,55L,57L,59L,61L,30L,48L,63L,65L,67L,69L,71L,73L,75L,77L,32L,50L,66L,79L,81L,83L,85L,87L,89L,91L,34L,52L,68L,82L,93L };
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
public class A245234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245234Inst : IEnumerable<long>
{
public static readonly long[] Value=A245234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245234.Bytes);
public long this[int i]=>Value[i];

public static A245234Inst Instance=new A245234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245235
{
public static readonly long[] Value={ 1L,2L,2L,8L,8L,8L,64L,64L,64L,64L,1024L,1024L,1024L,1024L,1024L,32768L,32768L,32768L,32768L,32768L,32768L,2097152L,2097152L,2097152L,2097152L,2097152L,2097152L,2097152L,268435456L,268435456L,268435456L,268435456L,268435456L,268435456L,268435456L,268435456L };
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
public class A245235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245235Inst : IEnumerable<long>
{
public static readonly long[] Value=A245235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245235.Bytes);
public long this[int i]=>Value[i];

public static A245235Inst Instance=new A245235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245236
{
public static readonly long[] Value={ 4L,5L,6L,9L,12L,15L,45L,432L,570L };
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
public class A245236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245236Inst : IEnumerable<long>
{
public static readonly long[] Value=A245236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245236.Bytes);
public long this[int i]=>Value[i];

public static A245236Inst Instance=new A245236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245237
{
public static readonly long[] Value={ 19L,269L,349L,383L,1303L,15031L };
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
public class A245237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245237Inst : IEnumerable<long>
{
public static readonly long[] Value=A245237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245237.Bytes);
public long this[int i]=>Value[i];

public static A245237Inst Instance=new A245237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245238
{
public static readonly long[] Value={ 0L,0L,4L,9L,1L,0L,9L,2L,5L,6L,4L,7L,7L,6L,0L,8L,3L,2L,3L,5L,2L,7L,3L,9L,1L,5L,0L,9L,2L,3L,6L,1L,5L,1L,8L,6L,0L,3L,2L,4L,8L,4L,2L,9L,7L,4L,1L,7L,6L,9L,2L,9L,4L,5L,9L,7L,7L,9L,6L,1L,6L,5L,7L,5L,2L,8L,0L,3L,0L,6L,3L,1L };
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
public class A245238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245238Inst : IEnumerable<long>
{
public static readonly long[] Value=A245238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245238.Bytes);
public long this[int i]=>Value[i];

public static A245238Inst Instance=new A245238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245239
{
public static readonly long[] Value={ 0L,3L,4L,7L,9L,11L,13L,16L,17L,19L,21L,24L,25L,28L,29L,32L,33L,36L,37L,40L,42L,45L,46L,48L,50L,53L,54L,57L,58L,61L,63L,66L,66L,69L,70L,73L,75L,78L,79L,82L,83L,85L,87L,90L,91L,94L,95L,98L,99L,102L,103L,106L,108L,111L,112L,114L,116L,119L,120L,123L,124L,127L,129L };
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
public class A245239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245239Inst : IEnumerable<long>
{
public static readonly long[] Value=A245239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245239.Bytes);
public long this[int i]=>Value[i];

public static A245239Inst Instance=new A245239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245240
{
public static readonly long[] Value={ 0L,1L,-1L,1L,0L,-5L,21L,-59L,117L,-95L,-484L,3131L,-11219L,28216L,-40975L,-49778L,630853L,-2758309L,8205948L,-16014181L,3933569L,135111669L,-743995720L,2566032656L,-6105683945L,6584104436L,26402611080L,-205994058892L,825490609412L,-2295266373781L };
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
public class A245240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245240Inst : IEnumerable<long>
{
public static readonly long[] Value=A245240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245240.Bytes);
public long this[int i]=>Value[i];

public static A245240Inst Instance=new A245240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245241
{
public static readonly long[] Value={ 0L,1L,4L,9L,99L,412L,2633L,5093L,5632L,28233L,36780L,47084L,53572L };
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
public class A245241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245241Inst : IEnumerable<long>
{
public static readonly long[] Value=A245241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245241.Bytes);
public long this[int i]=>Value[i];

public static A245241Inst Instance=new A245241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245242
{
public static readonly BigInteger[] Value={ 1L,2L,5L,40L,987L,73026L,15656191L,9146092572L,15579632823935L,71399036100619112L,BigInteger.Parse("916371430754269894286"),BigInteger.Parse("33098484899485154272997507"),BigInteger.Parse("3182514246669584511131232330210"),BigInteger.Parse("875352526298195795986890973534420721"),BigInteger.Parse("650999500319874632196352991280266092913655") };
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
public class A245242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245242Inst Instance=new A245242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245243
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,28L,10L,1L,1L,455L,495L,35L,1L,1L,10626L,54264L,8008L,126L,1L,1L,324632L,10518300L,4686825L,125970L,462L,1L,1L,12271512L,3190187286L,5586853480L,354817320L,1961256L,1716L,1L,1L,553270671L,1399358844975L,11899700525790L,2254848913647L,25140840660L,30421755L,6435L,1L };
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
public class A245243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245243Inst : IEnumerable<long>
{
public static readonly long[] Value=A245243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245243.Bytes);
public long this[int i]=>Value[i];

public static A245243Inst Instance=new A245243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245244
{
public static readonly long[] Value={ 1L,-3L,4L,25L,-56L,32L,-427L,1228L,-1184L,384L,12465L,-41840L,52416L,-29184L,6144L,-555731L,2079892L,-3076288L,2258688L,-829440L,122880L,35135945L,-142843304L,237829600L,-208562688L,102279168L,-26787840L,2949120L,-2990414715L,12987478876L,-23672564832L,23581133952L,-13947525120L,4929576960L,-970260480L };
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
public class A245244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245244Inst : IEnumerable<long>
{
public static readonly long[] Value=A245244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245244.Bytes);
public long this[int i]=>Value[i];

public static A245244Inst Instance=new A245244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245245
{
public static readonly BigInteger[] Value={ 1L,3L,495L,4686825L,2254848913647L,BigInteger.Parse("52588547141148893628"),BigInteger.Parse("58152371703925106867047535565"),BigInteger.Parse("3012179439602547459232394950891834843500"),BigInteger.Parse("7255167425905233148164780983569428433097979870294255"),BigInteger.Parse("808718755397067598640202627155266231883064669446721506930287016061") };
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
public class A245245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245245Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245245.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245245Inst Instance=new A245245Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245246
{
public static readonly long[] Value={ 0L,1L,3L,14L,74L,571L,6558L,125066L,4147388L };
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
public class A245246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245246Inst : IEnumerable<long>
{
public static readonly long[] Value=A245246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245246.Bytes);
public long this[int i]=>Value[i];

public static A245246Inst Instance=new A245246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245247
{
public static readonly BigInteger[] Value={ 1L,1L,5L,30L,255L,2880L,39495L,640800L,12048225L,257203200L,6146830125L,162636676800L,4719436701375L,149035892832000L,5088353594517375L,186769650799200000L,7334368923555410625L,BigInteger.Parse("306830158711872000000"),BigInteger.Parse("13623286425863528263125"),BigInteger.Parse("639832207565577018240000") };
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
public class A245247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245247Inst Instance=new A245247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245248
{
public static readonly BigInteger[] Value={ 1L,1L,6L,42L,408L,5328L,84960L,1600128L,34957440L,868247424L,24152048640L,744116855040L,25155056424960L,925729237969920L,36842642690181120L,1576774342552872960L,BigInteger.Parse("72212210263605657600"),BigInteger.Parse("3523820406525504552960"),BigInteger.Parse("182532196288859620147200"),BigInteger.Parse("10003033225361632653803520") };
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
public class A245248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245248Inst Instance=new A245248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245249
{
public static readonly BigInteger[] Value={ 1L,1L,7L,56L,609L,8960L,162015L,3455760L,85499505L,2407507200L,75954495015L,2654662651200L,101833013541105L,4253509461922560L,192174397814079135L,9338303873329240320UL,BigInteger.Parse("485654062232697912225"),BigInteger.Parse("26915598265961374986240"),BigInteger.Parse("1583628181230906140008455") };
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
public class A245249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245249Inst Instance=new A245249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245250
{
public static readonly long[] Value={ 3L,3L,4L,1L,2L,6L,6L,9L,4L,0L,7L,2L,4L,7L,3L,0L,4L,7L,1L,8L,8L,9L,3L,4L,8L,8L,6L,0L,2L,5L,4L,7L,3L,4L,3L,6L,2L,0L,2L,6L,3L,1L,7L,6L,2L,4L,5L,6L,0L,0L,1L,6L,8L,9L,8L,7L,8L,3L,1L,7L,9L,6L,9L,3L,4L,9L,9L,1L,8L,5L,9L,6L,5L,2L,3L,3L,5L,1L,6L,3L,2L,3L,3L,4L,2L,4L,4L,4L,1L,9L,7L,2L,4L,3L,7L,1L,4L,6L,7L,3L,5L,7L,2L,5L };
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
public class A245250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245250Inst : IEnumerable<long>
{
public static readonly long[] Value=A245250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245250.Bytes);
public long this[int i]=>Value[i];

public static A245250Inst Instance=new A245250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245251
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,0L,2L,3L,6L,0L,2L,4L,6L,10L,0L,3L,6L,8L,10L,15L,0L,3L,6L,9L,12L,15L,21L,0L,4L,7L,12L,14L,18L,21L,28L,0L,4L,9L,12L,16L,21L,24L,28L,36L,0L,5L,9L,14L,20L,23L,27L,32L,36L,45L,0L,5L,10L,15L,20L,25L,30L,35L,40L,45L,55L,0L,6L,12L,18L,22L,30L,33L,40L,45L,50L,55L,66L,0L,6L,12L,18L,24L,30L,36L,45L };
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
public class A245251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245251Inst : IEnumerable<long>
{
public static readonly long[] Value=A245251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245251.Bytes);
public long this[int i]=>Value[i];

public static A245251Inst Instance=new A245251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245252
{
public static readonly long[] Value={ 2L,29L,661L,4289L,24247L,2088221L,4446863L };
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
public class A245252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245252Inst : IEnumerable<long>
{
public static readonly long[] Value=A245252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245252.Bytes);
public long this[int i]=>Value[i];

public static A245252Inst Instance=new A245252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245253
{
public static readonly long[] Value={ 2L,9L,2L,4L,2L,7L,9L,9L,9L,9L,4L,4L,9L,2L,1L,8L,1L,5L,3L,6L,0L,1L,4L,5L,8L,5L,4L,4L,0L,2L,0L,5L,7L,4L,3L,0L,0L,1L,0L,6L,1L,5L,2L,0L,7L,0L,9L,6L,8L,9L,1L,5L,4L,4L,4L,5L,5L,5L,9L,0L,0L,0L,9L,7L,6L,4L,7L,0L,3L,0L,6L,8L,6L,8L,0L,3L,0L,8L,4L,3L,7L,9L,2L,9L,6L,3L,6L,8L,6L,9L,7L,4L,4L,1L,3L,2L,4L,4L,1L,9L,7L,6L,3L };
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
public class A245253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245253Inst : IEnumerable<long>
{
public static readonly long[] Value=A245253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245253.Bytes);
public long this[int i]=>Value[i];

public static A245253Inst Instance=new A245253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245254
{
public static readonly long[] Value={ 2L,2L,0L,0L,1L,6L,1L,0L,5L,8L,0L,9L,9L,0L,2L,6L,5L,5L,3L,1L,9L,4L,5L,5L,7L,8L,6L,6L,5L,5L,9L,9L,4L,4L,8L,7L,2L,6L,8L,5L,6L,6L,2L,3L,2L,4L,7L,5L,2L,7L,2L,3L,8L,8L,8L,7L,2L,3L,1L,4L,5L,1L,1L,7L,7L,6L,3L,1L,6L,9L,0L,1L,1L,2L,6L,9L,6L,6L,5L,9L,4L,7L,5L,8L,4L,7L,0L,2L,9L,7L,3L,4L,7L,2L,6L,8L,0L,7L,6L,2L,5L,8L,1L,6L,1L };
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
public class A245254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245254Inst : IEnumerable<long>
{
public static readonly long[] Value=A245254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245254.Bytes);
public long this[int i]=>Value[i];

public static A245254Inst Instance=new A245254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245255
{
public static readonly long[] Value={ 2L,3L,0L,3L,8L,4L,2L,1L,9L,6L,2L,8L,3L,7L,7L,0L,4L,2L,2L,1L,1L,2L,3L,7L,5L,6L,0L,8L,8L,8L,2L,2L,6L,7L,8L,4L,6L,9L,7L,1L,1L,9L,6L,0L,7L,7L,8L,2L,8L,8L,0L,8L,5L,3L,4L,2L,1L,9L,3L,0L,5L,1L,7L,3L,0L,8L,5L,6L,3L,5L,1L,6L,9L,5L,8L,9L,0L,6L,1L,6L,3L,8L,4L,2L,2L,6L,0L,6L,2L,2L,5L,3L,6L,3L,8L,6L,5L,7L,0L,0L,4L,6L,1L,8L,9L };
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
public class A245255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245255Inst : IEnumerable<long>
{
public static readonly long[] Value=A245255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245255.Bytes);
public long this[int i]=>Value[i];

public static A245255Inst Instance=new A245255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245256
{
public static readonly long[] Value={ 3L,3L,0L,3L,8L,4L,2L,1L,9L,6L,3L,0L,7L,1L,8L,2L,5L,1L,2L,9L,8L,9L,0L,5L,7L,2L,5L,1L,4L,6L,3L,0L,5L,1L,4L,6L,3L,6L,3L,0L,0L,0L,8L,0L,6L,8L,5L,2L,2L,0L,1L,4L,1L,8L,5L,8L,6L,3L,3L,7L,1L,7L,6L,9L,4L,4L,9L,7L,1L,0L,4L,5L,4L,7L,3L,0L,3L,7L,9L,3L,2L,2L,5L,7L,1L,2L,7L,7L,3L,9L,9L,4L,1L,1L,6L,0L,9L,9L,5L,1L,8L,4L };
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
public class A245256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245256Inst : IEnumerable<long>
{
public static readonly long[] Value=A245256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245256.Bytes);
public long this[int i]=>Value[i];

public static A245256Inst Instance=new A245256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245257
{
public static readonly long[] Value={ 2L,2L,2L,4L,7L,5L,1L,4L,8L,0L,9L,8L,0L,5L,8L,3L,0L,1L,5L,3L,7L,5L,5L,9L,8L,9L,2L,4L,9L,2L,4L,1L,9L,0L,4L,2L,4L,2L,3L,6L,3L,6L,6L,7L,0L,7L,9L,8L,2L,4L,6L,6L,7L,0L,1L,6L,9L,4L,5L,6L,3L,3L,1L,5L,7L,4L,7L,1L,2L,9L,8L,7L,8L,6L,6L,2L,2L,6L,2L,4L,2L,7L,8L,4L,6L,6L,8L,4L,0L,5L,6L,6L,1L,6L,4L,9L,4L,6L,2L,3L,5L,9L,2L,4L,6L };
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
public class A245257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245257Inst : IEnumerable<long>
{
public static readonly long[] Value=A245257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245257.Bytes);
public long this[int i]=>Value[i];

public static A245257Inst Instance=new A245257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245258
{
public static readonly long[] Value={ 3L,4L,4L,9L,3L,5L,8L,8L,9L,0L,2L,5L,9L,7L,4L,0L,4L,1L,5L,9L,5L,1L,3L,2L,1L,8L,5L,1L,2L,5L,3L,8L,8L,8L,3L,6L,0L,3L,4L,5L,6L,2L,4L,5L,0L,3L,8L,2L,5L,4L,1L,5L,9L,1L,0L,8L,8L,1L,4L,9L,4L,1L,0L,0L,5L,7L,5L,5L,6L,9L,6L,0L,6L,8L,8L,7L,2L,1L,0L,1L,3L,5L,7L,0L,3L,7L,6L,9L,4L,2L,8L,5L,9L,6L,1L,3L,3L,6L,0L,8L,8L,1L,9L,8L,1L };
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
public class A245258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245258Inst : IEnumerable<long>
{
public static readonly long[] Value=A245258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245258.Bytes);
public long this[int i]=>Value[i];

public static A245258Inst Instance=new A245258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245259
{
public static readonly long[] Value={ 3L,7L,6L,6L,7L,4L,4L,7L,4L,9L,7L,7L,2L,8L,4L,4L,9L,8L,4L,6L,9L,8L,1L,4L,8L,1L,1L,2L,8L,3L,1L,3L,0L,8L,0L,8L,5L,7L,0L,4L,1L,2L,9L,5L,2L,9L,9L,9L,4L,4L,3L,8L,6L,5L,0L,9L,9L,9L,2L,6L,9L,5L,7L,9L,5L,3L,3L,4L,0L,2L,9L,5L,6L,0L,9L,9L,5L,6L,8L,7L,1L,2L,1L,4L,6L,5L,4L,6L,1L,5L,7L,6L,9L,7L,0L,8L,4L,1L,5L,3L,0L,2L,2L,2L,7L,6L };
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
public class A245259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245259Inst : IEnumerable<long>
{
public static readonly long[] Value=A245259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245259.Bytes);
public long this[int i]=>Value[i];

public static A245259Inst Instance=new A245259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245260
{
public static readonly long[] Value={ 7L,8L,2L,1L,8L,8L,2L,9L,4L,2L,8L,0L,1L,9L,9L,9L,0L,1L,2L,2L,0L,2L,9L,7L,0L,7L,5L,9L,2L,6L,7L,4L,4L,7L,8L,0L,1L,8L,1L,9L,0L,8L,4L,0L,3L,9L,6L,6L,2L,9L,9L,5L,1L,6L,8L,7L,0L,9L,6L,8L,3L,3L,2L,3L,9L,5L,6L,9L,1L,6L,9L,9L,4L,1L,2L,4L,6L,7L,4L,6L,7L,1L,9L,5L,3L,8L,2L,3L,9L,2L,9L,0L,6L,6L,7L,3L,2L,5L,1L,3L,6L,6L,7L,5L,8L,5L };
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
public class A245260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245260Inst : IEnumerable<long>
{
public static readonly long[] Value=A245260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245260.Bytes);
public long this[int i]=>Value[i];

public static A245260Inst Instance=new A245260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245261
{
public static readonly long[] Value={ 3L,2L,6L,4L,8L,0L,3L,4L,3L,3L,9L,7L,5L,5L,5L,7L,1L,4L,0L,2L,2L,8L,8L,1L,3L,1L,1L,9L,8L,5L,5L,7L,6L,3L,8L,2L,7L,8L,9L,8L,2L,7L,6L,1L,8L,7L,1L,3L,8L,5L,3L,6L,1L,9L,5L,8L,9L,5L,6L,9L,5L,6L,0L,9L,3L,8L,8L,1L,3L,9L,2L,5L,7L,3L,1L,5L,5L,5L,1L,5L,7L,1L,1L,8L,4L,8L,5L,4L,2L,8L,2L,0L,4L,4L,0L,5L,7L,8L,5L,7L,8L,6L,3L,1L,5L };
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
public class A245261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245261Inst : IEnumerable<long>
{
public static readonly long[] Value=A245261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245261.Bytes);
public long this[int i]=>Value[i];

public static A245261Inst Instance=new A245261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245262
{
public static readonly long[] Value={ 4L,2L,7L,6L,8L,6L,6L,1L,6L,0L,1L,7L,9L,2L,8L,7L,9L,7L,4L,0L,6L,7L,5L,5L,6L,4L,2L,1L,1L,2L,6L,9L,5L,1L,9L,1L,9L,3L,6L,2L,4L,5L,5L,3L,4L,5L,2L,7L,8L,1L,9L,5L,8L,8L,7L,6L,3L,6L,0L,6L,0L,9L,7L,1L,9L,0L,3L,5L,2L,0L,5L,5L,9L,0L,8L,8L,3L,4L,0L,0L,3L,6L,9L,6L,4L,3L,9L,6L,9L,8L,3L,4L,2L,8L,4L,5L,8L,8L,9L,3L,4L,9L,1L,6L };
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
public class A245262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245262Inst : IEnumerable<long>
{
public static readonly long[] Value=A245262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245262.Bytes);
public long this[int i]=>Value[i];

public static A245262Inst Instance=new A245262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245263
{
public static readonly long[] Value={ 3L,8L,9L,1L,1L,5L,6L,8L,2L,3L,3L,2L,6L,8L,5L,3L,8L,1L,8L,0L,7L,8L,2L,6L,2L,5L,5L,6L,7L,1L,9L,9L,0L,5L,0L,4L,9L,8L,5L,2L,9L,8L,1L,4L,4L,5L,6L,7L,0L,1L,3L,9L,2L,9L,9L,6L,2L,7L,7L,2L,8L,9L,5L,6L,0L,0L,8L,9L,3L,8L,8L,4L,1L,5L,4L,4L,1L,8L,3L,7L,2L,8L,5L,9L,6L,1L,9L,8L,0L,6L,2L,7L,0L,8L,3L,4L,4L,6L,2L,2L,7L };
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
public class A245263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245263Inst : IEnumerable<long>
{
public static readonly long[] Value=A245263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245263.Bytes);
public long this[int i]=>Value[i];

public static A245263Inst Instance=new A245263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245264
{
public static readonly long[] Value={ 1L,2L,6L,12L,26L,53L,110L,231L,483L,1013L,2125L,4445L,9307L,19487L,40802L,85439L,178910L,374622L,784426L,1642522L };
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
public class A245264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245264Inst : IEnumerable<long>
{
public static readonly long[] Value=A245264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245264.Bytes);
public long this[int i]=>Value[i];

public static A245264Inst Instance=new A245264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245265
{
public static readonly BigInteger[] Value={ 1L,1L,3L,37L,649L,15461L,471571L,17456041L,760880625L,38178439849L,2167446089251L,137359883836781L,9612722107574521L,736277501363180557L,BigInteger.Parse("61265207586681046131"),BigInteger.Parse("5503291392884323494961"),BigInteger.Parse("530778414439201798454881"),BigInteger.Parse("54706967800114521799571921"),BigInteger.Parse("6000952913613549583603208515") };
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
public class A245265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245265Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245265.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245265.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245265Inst Instance=new A245265Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245266
{
public static readonly BigInteger[] Value={ 1L,1L,2L,12L,102L,1062L,13812L,215592L,3896892L,80103612L,1847079192L,47204854992L,1324132604232L,40446893218632L,1336423937927472L,47492006442366432L,1806200688076918032L,BigInteger.Parse("73199329659111178512"),BigInteger.Parse("3149155288463030836512"),BigInteger.Parse("143338650123433404564672") };
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
public class A245266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245266Inst Instance=new A245266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245267
{
public static readonly BigInteger[] Value={ 1L,1L,2L,14L,140L,1676L,25076L,453332L,9503324L,226526300L,6060973796L,179862832196L,5861003051852L,208044896591564L,7990667301671060L,330174871461525236L,14604088858565826236UL,BigInteger.Parse("688475187932426663612"),BigInteger.Parse("34460842719620518022084"),BigInteger.Parse("1825219532294016983274020") };
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
public class A245267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A245267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A245267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A245267Inst Instance=new A245267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245268
{
public static readonly long[] Value={ 1L,3L,7L,14L,26L,48L,92L,184L,375L,758L,1497L,2884L,5461L,10286L,19507L,37584L,73866L,147987L,301075L,618794L,1278116L,2640993L,5439593L,11138764L,22640100L,45644797L,91293390L,181301470L,358024924L,704359427L,1383415456L,2718141072L,5351701032L,10570658330L };
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
public class A245268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245268Inst : IEnumerable<long>
{
public static readonly long[] Value=A245268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245268.Bytes);
public long this[int i]=>Value[i];

public static A245268Inst Instance=new A245268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245269
{
public static readonly long[] Value={ 1L,3L,7L,15L,31L,63L,127L,254L,502L,978L,1882L,3600L,6904L,13380L,26332L,52664L,106744L,218232L,447736L,917760L,1873312L,3799920L,7653136L,15306272L,30429856L,60234528L,118956831L,234885092L,464595690L,921868388L,1836393687L,3672648928L,7369572624L,14821243232L };
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
public class A245269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245269Inst : IEnumerable<long>
{
public static readonly long[] Value=A245269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245269.Bytes);
public long this[int i]=>Value[i];

public static A245269Inst Instance=new A245269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245270
{
public static readonly long[] Value={ 5L,7L,10L,11L,47L,15L,11L,14L,91L,23L,87L,27L,95L,123L,20L,35L,94L,39L,171L,127L,183L,47L,95L,22L,187L,15L,175L,59L,763L,63L,21L,247L,355L,191L,174L,75L,359L,251L,187L,83L,767L,87L,343L,235L,367L,95L,167L,30L,182L,483L,347L,107L,95L,375L,191L,487L,379L,119L };
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
public class A245270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245270Inst : IEnumerable<long>
{
public static readonly long[] Value=A245270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245270.Bytes);
public long this[int i]=>Value[i];

public static A245270Inst Instance=new A245270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245271
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,22L,36L,58L,95L,154L,249L,403L,652L,1056L,1709L,2766L,4475L,7241L,11717L,18959L,30676L,49635L,80311L,129947L,210258L,340205L,550464L,890670L,1441135L,2331806L,3772941L,6104748L,9877690L,15982438L,25860128L,41842566L,67702694L,109545261L,177247955L };
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
public class A245271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245271Inst : IEnumerable<long>
{
public static readonly long[] Value=A245271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245271.Bytes);
public long this[int i]=>Value[i];

public static A245271Inst Instance=new A245271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245272
{
public static readonly long[] Value={ 25L,49L,55L,85L,91L,115L,121L,133L,143L,145L,169L,175L,187L,203L,205L,217L,235L,247L,253L,259L,265L,289L,295L,299L,301L,319L,323L,325L,341L,343L,355L,361L,385L,391L,403L,413L,415L,427L,445L,451L,469L,473L,475L,481L,493L,505L,511L,517L,529L,533L,535L,551L,553L };
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
public class A245272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245272Inst : IEnumerable<long>
{
public static readonly long[] Value=A245272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245272.Bytes);
public long this[int i]=>Value[i];

public static A245272Inst Instance=new A245272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245273
{
public static readonly long[] Value={ 0L,0L,6L,3L,5L,6L,4L,5L,5L,9L,0L,8L,5L,8L,4L,8L,5L,1L,2L,1L,0L,1L,0L,0L,0L,2L,6L,7L,2L,9L,9L,6L,0L,4L,3L,8L,1L,9L,8L,9L,9L,4L,9L,1L,0L,1L,6L,0L,9L,1L,9L,8L,8L,1L,1L,6L,9L,8L,6L,8L,2L,8L,0L,8L,5L,7L,7L,6L,0L,0L,7L,8L,3L,9L,8L,0L,8L,5L,3L,4L,2L,7L,6L,4L,8L,7L,0L,5L,6L,0L,3L,2L,8L,0L,8L,3L,9L,2L,4L,7L,2L,6L,6L,3L,7L,4L,2L };
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
public class A245273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245273Inst : IEnumerable<long>
{
public static readonly long[] Value=A245273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245273.Bytes);
public long this[int i]=>Value[i];

public static A245273Inst Instance=new A245273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245274
{
public static readonly long[] Value={ 35L,65L,77L,95L,119L,121L,125L,143L,155L,161L,185L,187L,203L,209L,215L,217L,221L,245L,247L,275L,287L,289L,299L,305L,323L,329L,335L,341L,365L,371L,377L,395L,407L,413L,425L,427L,437L,455L,473L,485L,497L,515L,517L,527L,529L,533L,539L,545L,551L,575L,581L,583L,605L };
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
public class A245274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245274Inst : IEnumerable<long>
{
public static readonly long[] Value=A245274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245274.Bytes);
public long this[int i]=>Value[i];

public static A245274Inst Instance=new A245274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245275
{
public static readonly long[] Value={ 0L,4L,6L,1L,5L,4L,3L,1L,7L,2L,9L,5L,8L,0L,4L,6L,0L,2L,7L,5L,7L,1L,0L,7L,9L,9L,0L,3L,7L,9L,0L,7L,7L,3L,0L,3L,5L,3L,0L,2L,6L,7L,9L,6L,2L,3L,2L,4L,1L,4L,4L,9L,9L,0L,3L,4L,8L,8L,4L,8L,4L,5L,3L,5L,0L,8L,0L,4L,2L,6L,7L,6L,2L,4L,9L,6L,6L,6L,9L,5L,5L,4L,7L,0L,1L,3L,2L,2L,6L,3L,3L,2L,2L,7L,9L,1L,0L,8L,0L,8L,8L,3L,1L,1L,8L };
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
public class A245275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245275Inst : IEnumerable<long>
{
public static readonly long[] Value=A245275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245275.Bytes);
public long this[int i]=>Value[i];

public static A245275Inst Instance=new A245275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245276
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,5L,8L,2L,3L,1L,4L,5L,2L,1L,0L,5L,9L,2L,2L,7L,6L,2L,6L,6L,8L,2L,3L,8L,9L,1L,4L,5L,7L,8L,4L,7L,3L,9L,6L,4L,1L,8L,9L,2L,4L,8L,9L,8L,6L,5L,1L,8L,7L,7L,0L,2L,7L,3L,4L,5L,2L,6L,7L,2L,8L,9L,1L,2L,1L,3L,0L,0L,0L,6L,2L,6L,2L,4L,0L,2L,2L,6L,6L,8L,2L,9L,8L,1L,0L,0L,3L,4L,8L,1L,3L,6L,6L,9L,9L,4L,1L,8L,0L,1L };
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
public class A245276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245276Inst : IEnumerable<long>
{
public static readonly long[] Value=A245276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245276.Bytes);
public long this[int i]=>Value[i];

public static A245276Inst Instance=new A245276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245277
{
public static readonly long[] Value={ 2L,11L,67L,23L,37L,491L,47L,373L,79L,6043L,379L,2203L,647L,3389L,631L,34807L,211L,28663L,1283L,6449L,439L,266003L,577L,15649L,1811L,244471L,379L,485504623L,157L,31907L,2939L,15269L,2557L,22948529L,853L,197959L,743L,59723L,113L,96873817L };
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
public class A245277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245277Inst : IEnumerable<long>
{
public static readonly long[] Value=A245277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245277.Bytes);
public long this[int i]=>Value[i];

public static A245277Inst Instance=new A245277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245278
{
public static readonly long[] Value={ 5L,7L,8L,4L,1L,6L,7L,6L,2L,7L,8L,8L,9L,0L,0L,7L,5L,9L,0L,7L,4L,6L,0L,2L,0L,5L,8L,1L,4L,6L,1L,9L,5L,6L,7L,4L,7L,9L,9L,4L,8L,3L,9L,6L,9L,4L,3L,6L,6L,4L,5L,5L,0L,1L,5L,4L,8L,3L,1L,7L,6L,7L,4L,9L,4L,1L,7L,9L,6L,0L,2L,0L,8L,2L,4L,1L,2L,2L,0L,7L,1L,4L,5L,0L,6L,5L,8L,2L,7L,4L,8L,7L,0L,0L,2L,7L,9L,3L,9L,1L };
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
public class A245278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245278Inst : IEnumerable<long>
{
public static readonly long[] Value=A245278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245278.Bytes);
public long this[int i]=>Value[i];

public static A245278Inst Instance=new A245278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245279
{
public static readonly long[] Value={ 1L,8L,2L,4L,8L,7L,8L,8L,7L,5L,2L,1L,9L,7L,9L,3L,3L,9L,8L,4L,1L,6L,7L,9L,3L,9L,1L,4L,8L,7L,8L,2L,0L,6L,6L,4L,8L,7L,5L,3L,0L,3L,9L,3L,8L,3L,2L,5L,0L,5L,4L,0L,3L,2L,1L,1L,9L,8L,6L,6L,4L,9L,9L,4L,5L,6L,5L,1L,8L,8L,3L,9L,7L,7L,1L,6L,0L,0L,9L,2L,1L,1L,7L,8L,4L,8L,9L,9L,7L,8L,0L,4L,3L,7L,2L,6L,0L,9L,6L,9L,7L,4L,0L };
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
public class A245279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245279Inst : IEnumerable<long>
{
public static readonly long[] Value=A245279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245279.Bytes);
public long this[int i]=>Value[i];

public static A245279Inst Instance=new A245279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245280
{
public static readonly long[] Value={ 8L,1L,7L,5L,1L,2L,1L,1L,2L,4L,7L,8L,0L,2L,0L,6L,6L,0L,1L,5L,8L,3L,2L,0L,6L,0L,8L,5L,1L,2L,1L,7L,9L,3L,3L,5L,1L,2L,4L,6L,9L,6L,0L,6L,1L,6L,7L,4L,9L,4L,5L,9L,6L,7L,8L,8L,0L,1L,3L,3L,5L,0L,0L,5L,4L,3L,4L,8L,1L,1L,6L,0L,2L,2L,8L,3L,9L,9L,0L,7L,8L,8L,2L,1L,5L,1L,0L,0L,2L,1L,9L,5L,6L,2L,7L,3L,9L,0L,3L,0L,2L,5L,9L,7L };
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
public class A245280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245280Inst : IEnumerable<long>
{
public static readonly long[] Value=A245280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245280.Bytes);
public long this[int i]=>Value[i];

public static A245280Inst Instance=new A245280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A245281
{
public static readonly long[] Value={ 2L,12L,10L,14L,4L,24L,20L,22L,26L,6L,16L,18L,8L,28L,21L,15L,5L,25L,35L,30L,3L,33L,36L,32L,34L,38L,48L,40L,42L,27L,57L,45L,50L,52L,54L,44L,46L,56L,58L,68L,60L,62L,64L,66L,63L,39L,9L,69L,90L,70L,7L,77L,147L,49L,84L,74L,37L,333L,93L,31L,124L,72L,75L,51L,17L,102L };
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
public class A245281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A245281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A245281Inst : IEnumerable<long>
{
public static readonly long[] Value=A245281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A245281.Bytes);
public long this[int i]=>Value[i];

public static A245281Inst Instance=new A245281Inst();

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