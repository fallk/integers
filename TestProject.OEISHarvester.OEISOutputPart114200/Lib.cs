using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A273816
{
public static readonly long[] Value={ 6L,9L,4L,8L,8L,2L,2L,7L,8L,1L,0L,7L,9L,6L,2L,9L,7L,8L,9L,4L,3L,6L,4L,3L,6L,4L,4L,5L,4L,7L,0L,8L,2L,9L,7L,5L,7L,6L,7L,4L,8L,5L,1L,1L,3L,2L,6L,0L,9L,8L,9L,1L,7L,3L,5L,1L,6L,2L,3L,8L,0L,6L,8L,8L,1L,9L,1L,4L,2L,2L,3L,3L,8L,1L,9L,9L,8L,0L,4L,1L,8L,6L,8L,3L,9L,9L,5L,2L,3L,5L,1L,8L,0L,6L,0L,9L,5L,5L,3L,7L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273816Inst : IEnumerable<long>
{
public static readonly long[] Value=A273816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273816.Bytes);
public long this[int i]=>Value[i];

public static A273816Inst Instance=new A273816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273817
{
public static readonly long[] Value={ 5L,8L,5L,9L,7L,6L,8L,0L,9L,6L,7L,2L,3L,6L,4L,7L,2L,2L,6L,5L,0L,3L,9L,0L,5L,7L,2L,2L,1L,8L,0L,6L,9L,2L,6L,7L,2L,7L,3L,8L,5L,0L,7L,5L,2L,4L,0L,8L,9L,6L,4L,0L,6L,5L,1L,6L,6L,5L,7L,5L,0L,4L,7L,2L,2L,5L,1L,6L,5L,2L,3L,8L,4L,8L,8L,7L,1L,3L,6L,6L,3L,5L,6L,9L,6L,5L,2L,1L,7L,8L,1L,2L,4L,1L,5L,7L,3L,9L,5L,7L,6L,5L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273817Inst : IEnumerable<long>
{
public static readonly long[] Value=A273817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273817.Bytes);
public long this[int i]=>Value[i];

public static A273817Inst Instance=new A273817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273818
{
public static readonly long[] Value={ 1L,8L,8L,0L,0L,5L,1L,2L,8L,9L,1L,8L,5L,3L,4L,4L,9L,1L,4L,7L,7L,9L,6L,0L,5L,6L,6L,3L,0L,6L,3L,6L,6L,7L,9L,2L,0L,6L,2L,3L,7L,1L,9L,0L,0L,0L,5L,7L,3L,0L,5L,8L,4L,0L,1L,2L,8L,1L,0L,2L,0L,4L,4L,2L,9L,1L,9L,0L,2L,3L,9L,3L,8L,8L,6L,7L,7L,9L,0L,1L,3L,9L,2L,5L,7L,7L,9L,8L,1L,3L,9L,2L,1L,1L,3L,5L,0L,2L,4L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273818Inst : IEnumerable<long>
{
public static readonly long[] Value=A273818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273818.Bytes);
public long this[int i]=>Value[i];

public static A273818Inst Instance=new A273818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273819
{
public static readonly long[] Value={ 1L,1L,4L,6L,3L,5L,7L,4L,6L,2L,2L,9L,8L,1L,9L,6L,3L,0L,2L,0L,0L,5L,2L,0L,7L,6L,2L,9L,5L,7L,4L,2L,5L,6L,8L,9L,6L,9L,8L,4L,6L,7L,6L,6L,9L,8L,7L,8L,6L,1L,8L,7L,5L,3L,5L,5L,5L,4L,3L,3L,3L,9L,6L,3L,0L,0L,2L,2L,0L,3L,1L,7L,9L,8L,4L,9L,5L,1L,5L,5L,1L,4L,2L,6L,2L,0L,2L,9L,0L,4L,1L,6L,5L,5L,4L,3L,1L,9L,4L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273819Inst : IEnumerable<long>
{
public static readonly long[] Value=A273819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273819.Bytes);
public long this[int i]=>Value[i];

public static A273819Inst Instance=new A273819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273820
{
public static readonly BigInteger[] Value={ 1L,6L,420L,360360L,72201776446800L,BigInteger.Parse("591133442051411133755680800"),BigInteger.Parse("6676878045498705789701874602220118271269436344024536000") };
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
public class A273820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273820Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273820.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273820.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273820Inst Instance=new A273820Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273821
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,4L,0L,3L,3L,8L,0L,9L,10L,7L,16L,0L,28L,32L,25L,15L,32L,0L,90L,104L,84L,56L,31L,64L,0L,297L,345L,283L,195L,119L,63L,128L,0L,1001L,1166L,965L,676L,425L,246L,127L,256L,0L,3432L,4004L,3333L,2359L,1506L,894L,501L,255L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273821Inst : IEnumerable<long>
{
public static readonly long[] Value=A273821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273821.Bytes);
public long this[int i]=>Value[i];

public static A273821Inst Instance=new A273821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273822
{
public static readonly long[] Value={ 27L,227L,335L,2387L,9299L,104571L,113519L,118499L,212343L,258999L,328499L,455600L,699891L,820755L,971360L,977051L,1059239L,1119723L,1193631L,1421367L,1604084L,2231999L,2794067L,4191431L,5450948L,6054611L,6769607L,7672391L,7760639L,7875035L,8091615L,9606203L,15511268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273822Inst : IEnumerable<long>
{
public static readonly long[] Value=A273822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273822.Bytes);
public long this[int i]=>Value[i];

public static A273822Inst Instance=new A273822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273823
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,1L,5L,3L,6L,7L,4L,2L,1L,8L,5L,3L,9L,6L,10L,11L,7L,4L,2L,1L,12L,8L,5L,3L,13L,9L,6L,14L,10L,15L,16L,11L,7L,4L,2L,1L,17L,12L,8L,5L,3L,18L,13L,9L,6L,19L,14L,10L,20L,15L,21L,22L,16L,11L,7L,4L,2L,1L,23L,17L,12L,8L,5L,3L,24L,18L,13L,9L,6L,25L,19L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273823Inst : IEnumerable<long>
{
public static readonly long[] Value=A273823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273823.Bytes);
public long this[int i]=>Value[i];

public static A273823Inst Instance=new A273823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273824
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,5L,2L,6L,3L,1L,7L,8L,4L,9L,5L,2L,10L,6L,3L,1L,11L,12L,7L,13L,8L,4L,14L,9L,5L,2L,15L,10L,6L,3L,1L,16L,17L,11L,18L,12L,7L,19L,13L,8L,4L,20L,14L,9L,5L,2L,21L,15L,10L,6L,3L,1L,22L,23L,16L,24L,17L,11L,25L,18L,12L,7L,26L,19L,13L,8L,4L,27L,20L,14L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273824Inst : IEnumerable<long>
{
public static readonly long[] Value=A273824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273824.Bytes);
public long this[int i]=>Value[i];

public static A273824Inst Instance=new A273824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273825
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,1L,6L,7L,8L,2L,9L,3L,10L,11L,12L,4L,13L,5L,1L,14L,6L,15L,16L,17L,7L,18L,8L,2L,19L,9L,3L,20L,10L,21L,22L,23L,11L,24L,12L,4L,25L,13L,5L,1L,26L,14L,6L,27L,15L,28L,29L,30L,16L,31L,17L,7L,32L,18L,8L,2L,33L,19L,9L,3L,34L,20L,10L,35L,21L,36L,37L,38L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273825Inst : IEnumerable<long>
{
public static readonly long[] Value=A273825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273825.Bytes);
public long this[int i]=>Value[i];

public static A273825Inst Instance=new A273825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273826
{
public static readonly long[] Value={ 1L,5L,5L,3L,8L,6L,5L,4L,2L,11L,5L,5L,10L,1L,3L,1L,9L,15L,4L,9L,2L,4L,6L,2L,13L,13L,10L,7L,8L,6L,3L,5L,9L,14L,6L,9L,13L,9L,9L,10L,13L,11L,5L,4L,14L,5L,8L,5L,6L,15L,10L,17L,14L,13L,6L,1L,18L,17L,2L,8L,8L,5L,17L,3L,23L,15L,9L,17L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273826Inst : IEnumerable<long>
{
public static readonly long[] Value=A273826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273826.Bytes);
public long this[int i]=>Value[i];

public static A273826Inst Instance=new A273826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273827
{
public static readonly long[] Value={ 1L,5L,9L,25L,37L,53L,65L,109L,141L,173L,201L,253L,293L,341L,369L,477L,541L,605L,665L,749L,821L,901L,961L,1093L,1181L,1277L,1353L,1485L,1573L,1685L,1745L,1981L,2109L,2237L,2361L,2509L,2645L,2789L,2913L,3109L,3261L,3421L,3561L,3757L,3909L,4085L,4209L,4501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273827Inst : IEnumerable<long>
{
public static readonly long[] Value=A273827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273827.Bytes);
public long this[int i]=>Value[i];

public static A273827Inst Instance=new A273827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273860
{
public static readonly long[] Value={ 1L,5L,21L,89L,377L,1569L,6425L,26033L,104841L,420833L,1686329L,6751377L,27017705L,108095297L,432430233L,1729819121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273860Inst : IEnumerable<long>
{
public static readonly long[] Value=A273860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273860.Bytes);
public long this[int i]=>Value[i];

public static A273860Inst Instance=new A273860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273861
{
public static readonly long[] Value={ 1L,6L,15L,36L,65L,106L,167L,256L,357L,470L,603L,764L,953L,1186L,1495L,1872L,2269L,2678L,3107L,3564L,4049L,4578L,5183L,5856L,6565L,7318L,8139L,9044L,10049L,11218L,12631L,14200L,15805L,17422L,19059L,20724L,22417L,24154L,25967L,27848L,29765L,31726L,33755L,35868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273861Inst : IEnumerable<long>
{
public static readonly long[] Value=A273861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273861.Bytes);
public long this[int i]=>Value[i];

public static A273861Inst Instance=new A273861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273862
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,12L,14L,13L,15L,100L,17L,16L,18L,20L,19L,21L,22L,24L,25L,23L,26L,27L,102L,29L,28L,30L,32L,104L,31L,33L,34L,35L,36L,38L,37L,39L,40L,42L,44L,105L,41L,45L,46L,48L,49L,50L,51L,43L,52L,54L,55L,56L,57L,58L,60L,47L,62L,63L,64L,65L,66L,106L,53L,68L,69L,70L,72L,74L,75L,108L,59L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,110L,111L,112L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,128L,129L,130L,132L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273862Inst : IEnumerable<long>
{
public static readonly long[] Value=A273862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273862.Bytes);
public long this[int i]=>Value[i];

public static A273862Inst Instance=new A273862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273863
{
public static readonly long[] Value={ 0L,2L,1L,3L,4L,5L,6L,7L,9L,11L,8L,13L,15L,17L,19L,10L,21L,23L,25L,27L,29L,12L,31L,33L,35L,37L,39L,41L,14L,43L,45L,47L,49L,51L,53L,55L,16L,57L,59L,61L,63L,65L,67L,69L,71L,73L,18L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,20L,97L,99L,101L,103L,105L,107L,109L,111L,22L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,135L,137L,24L,139L,141L,143L,145L,147L,149L,151L,153L,155L,157L,159L,161L,163L,165L,167L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273863Inst : IEnumerable<long>
{
public static readonly long[] Value=A273863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273863.Bytes);
public long this[int i]=>Value[i];

public static A273863Inst Instance=new A273863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273864
{
public static readonly long[] Value={ 0L,2L,1L,3L,4L,5L,6L,7L,11L,8L,9L,101L,10L,13L,103L,12L,15L,17L,19L,14L,21L,23L,105L,16L,25L,27L,29L,31L,107L,18L,33L,35L,37L,39L,20L,41L,43L,45L,109L,22L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,135L,137L,1001L,24L,139L,141L,1003L,26L,143L,145L,147L,1005L,28L,149L,151L,153L,155L,157L,159L,161L,163L,165L,167L,169L,171L,173L,175L,177L,179L,181L,183L,185L,187L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273864Inst : IEnumerable<long>
{
public static readonly long[] Value=A273864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273864.Bytes);
public long this[int i]=>Value[i];

public static A273864Inst Instance=new A273864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273865
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,4L,6L,8L,7L,10L,12L,9L,14L,16L,18L,20L,22L,11L,24L,26L,28L,30L,13L,32L,34L,36L,38L,40L,42L,15L,44L,46L,48L,50L,52L,54L,56L,58L,17L,60L,62L,64L,66L,68L,70L,72L,19L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,21L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,23L,118L,120L,122L,124L,126L,128L,130L,132L,134L,25L,136L,138L,140L,142L,144L,146L,148L,150L,152L,154L,156L,158L,160L,162L,27L,164L,166L,168L,170L,172L,174L,176L,178L,180L,182L,184L,186L,188L,190L,192L,194L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273865Inst : IEnumerable<long>
{
public static readonly long[] Value=A273865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273865.Bytes);
public long this[int i]=>Value[i];

public static A273865Inst Instance=new A273865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273866
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,3L,5L,5L,3L,1L,1L,3L,6L,7L,6L,3L,1L,1L,4L,9L,13L,13L,9L,4L,1L,1L,4L,10L,17L,20L,17L,10L,4L,1L,1L,5L,15L,30L,42L,42L,30L,15L,5L,1L,1L,5L,16L,36L,57L,66L,57L,36L,16L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273866Inst : IEnumerable<long>
{
public static readonly long[] Value=A273866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273866.Bytes);
public long this[int i]=>Value[i];

public static A273866Inst Instance=new A273866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273867
{
public static readonly long[] Value={ 2L,5L,6L,8L,9L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273867Inst : IEnumerable<long>
{
public static readonly long[] Value=A273867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273867.Bytes);
public long this[int i]=>Value[i];

public static A273867Inst Instance=new A273867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273868
{
public static readonly long[] Value={ 25L,51L,91L,107L,145L,651L,1473L,2145L,5577L,12457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273868Inst : IEnumerable<long>
{
public static readonly long[] Value=A273868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273868.Bytes);
public long this[int i]=>Value[i];

public static A273868Inst Instance=new A273868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273869
{
public static readonly long[] Value={ 3L,11L,14L,53L,110L,216L,322L,364L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273869Inst : IEnumerable<long>
{
public static readonly long[] Value=A273869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273869.Bytes);
public long this[int i]=>Value[i];

public static A273869Inst Instance=new A273869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273870
{
public static readonly long[] Value={ 1L,3L,5L,17L,217L,257L,387L,8209L,20137L,37025L,59141L,65537L,283801L,649801L,1382401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273870Inst : IEnumerable<long>
{
public static readonly long[] Value=A273870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273870.Bytes);
public long this[int i]=>Value[i];

public static A273870Inst Instance=new A273870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273871
{
public static readonly long[] Value={ 3L,5L,17L,257L,8209L,59141L,65537L,649801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273871Inst : IEnumerable<long>
{
public static readonly long[] Value=A273871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273871.Bytes);
public long this[int i]=>Value[i];

public static A273871Inst Instance=new A273871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273872
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,14L,17L,20L,23L,26L,30L,34L,38L,41L,44L,47L,50L,53L,56L,59L,62L,65L,68L,72L,76L,80L,84L,88L,92L,96L,100L,103L,106L,109L,112L,115L,118L,121L,124L,127L,130L,133L,136L,139L,142L,145L,148L,151L,154L,157L,160L,163L,166L,169L,172L,175L,178L,182L,186L,190L,194L,198L,202L,206L,210L,214L,218L,222L,226L,230L,234L,238L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273872Inst : IEnumerable<long>
{
public static readonly long[] Value=A273872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273872.Bytes);
public long this[int i]=>Value[i];

public static A273872Inst Instance=new A273872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273873
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,12L,28L,65L,166L,412L,1076L,2806L,7524L,20020L,54744L,148417L,410078L,1126732L,3144500L,8728570L,24555900L,68713420L,194469616L,548088278L,1559301428L,4418131108L,12628267512L,35957541462L,103150588492L,294924202032L,848878072440L,2435729999665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273873Inst : IEnumerable<long>
{
public static readonly long[] Value=A273873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273873.Bytes);
public long this[int i]=>Value[i];

public static A273873Inst Instance=new A273873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273874
{
public static readonly long[] Value={ 5L,1L,2L,0L,2L,0L,0L,0L,0L,2L,5L,1L,12L,0L,3L,0L,3L,0L,0L,0L,0L,0L,53L,1L,1L,1L,2L,0L,4L,0L,0L,0L,5L,2L,0L,0L,2L,0L,3L,0L,5L,0L,0L,5L,0L,0L,73L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273874Inst : IEnumerable<long>
{
public static readonly long[] Value=A273874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273874.Bytes);
public long this[int i]=>Value[i];

public static A273874Inst Instance=new A273874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273875
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,3L,1L,1L,4L,3L,1L,1L,3L,3L,1L,1L,3L,6L,4L,6L,5L,2L,4L,2L,4L,5L,5L,5L,5L,5L,3L,2L,4L,6L,4L,8L,5L,5L,3L,4L,7L,7L,6L,3L,10L,2L,4L,1L,3L,10L,4L,8L,4L,8L,5L,4L,5L,9L,5L,4L,4L,4L,10L,1L,11L,11L,4L,10L,10L,4L,4L,9L,6L,9L,7L,5L,6L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273875Inst : IEnumerable<long>
{
public static readonly long[] Value=A273875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273875.Bytes);
public long this[int i]=>Value[i];

public static A273875Inst Instance=new A273875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273908
{
public static readonly long[] Value={ 5L,15L,20L,34L,39L,41L,45L,55L,60L,65L,80L,85L,111L,125L,135L,136L,145L,150L,156L,164L,175L,180L,194L,219L,220L,240L,245L,255L,260L,265L,299L,306L,313L,320L,325L,340L,351L,353L,369L,371L,375L,405L,410L,444L,445L,455L,495L,500L,505L,514L,525L,540L,544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273908Inst : IEnumerable<long>
{
public static readonly long[] Value=A273908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273908.Bytes);
public long this[int i]=>Value[i];

public static A273908Inst Instance=new A273908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273909
{
public static readonly long[] Value={ -4L,-4L,-4L,6L,-4L,18L,-4L,30L,80L,-4L,112L,66L,-4L,78L,176L,200L,-4L,232L,126L,-4L,280L,150L,320L,518L,186L,-4L,198L,-4L,210L,1328L,246L,512L,-4L,1092L,-4L,592L,616L,318L,656L,680L,-4L,1428L,-4L,378L,-4L,1966L,2086L,438L,-4L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273909Inst : IEnumerable<long>
{
public static readonly long[] Value=A273909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273909.Bytes);
public long this[int i]=>Value[i];

public static A273909Inst Instance=new A273909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273910
{
public static readonly ulong[] Value={ 1L,11L,101L,1011L,10001L,110111L,1000101L,11011011L,100000001L,1100000111L,10100010101L,101101101011L,1000000010001L,11000001110111L,101000101000101L,1011011011011011L,10000000000000001L,110000000000000111L,1010000000000010101L,10110000000001101011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273910Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A273910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273910.Bytes);
public ulong this[int i]=>Value[i];

public static A273910Inst Instance=new A273910Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273911
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,55L,69L,219L,257L,775L,1301L,2923L,4113L,12407L,20805L,46811L,65537L,196615L,327701L,721003L,1114385L,3606391L,4527173L,14380507L,16777473L,50333447L,83891477L,184576875L,285282321L,923234423L,1158959429L,3681400539L,4294967297L,12884901895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273911Inst : IEnumerable<long>
{
public static readonly long[] Value=A273911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273911.Bytes);
public long this[int i]=>Value[i];

public static A273911Inst Instance=new A273911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273912
{
public static readonly ulong[] Value={ 1L,11L,101L,1101L,10001L,111011L,1010001L,11011011L,100000001L,1110000011L,10101000101L,110101101101L,1000100000001L,11101110000011L,101000101000101L,1101101101101101L,10000000000000001L,111000000000000011L,1010100000000000101L,11010110000000001101UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273912Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A273912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273912.Bytes);
public ulong this[int i]=>Value[i];

public static A273912Inst Instance=new A273912Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273913
{
public static readonly long[] Value={ 1902L,1902L,730L,230L,550L,420L,502L,1902L,2150L,1074L,1074L,1074L,1902L,1902L,8170L,730L,550L,730L,600L,230L,80L,230L,470L,550L,1074L,4045L,4990L,180L,230L,106L,90L,4990L,1062L,102L,902L,1230L,730L,108L,1406L,1017L,1410L,630L,2038L,505L,230L,1810L,150L,2306L,630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273913Inst : IEnumerable<long>
{
public static readonly long[] Value=A273913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273913.Bytes);
public long this[int i]=>Value[i];

public static A273913Inst Instance=new A273913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273914
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,6L,4L,1L,1L,5L,10L,10L,5L,1L,1L,6L,15L,20L,15L,6L,1L,1L,7L,21L,35L,35L,20L,7L,1L,1L,8L,28L,56L,70L,53L,26L,8L,1L,1L,9L,36L,84L,126L,121L,76L,33L,9L,1L,1L,10L,45L,120L,210L,245L,192L,106L,41L,10L,1L,1L,11L,55L,165L,330L,453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273914Inst : IEnumerable<long>
{
public static readonly long[] Value=A273914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273914.Bytes);
public long this[int i]=>Value[i];

public static A273914Inst Instance=new A273914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273915
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,1L,1L,3L,3L,2L,2L,2L,2L,1L,1L,3L,4L,3L,2L,2L,2L,1L,1L,3L,4L,4L,2L,2L,3L,1L,2L,4L,5L,4L,4L,4L,4L,2L,2L,6L,5L,3L,3L,4L,4L,1L,2L,5L,7L,6L,4L,4L,6L,3L,2L,5L,5L,5L,2L,4L,5L,2L,2L,6L,8L,5L,5L,5L,5L,1L,3L,7L,6L,6L,4L,5L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273915Inst : IEnumerable<long>
{
public static readonly long[] Value=A273915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273915.Bytes);
public long this[int i]=>Value[i];

public static A273915Inst Instance=new A273915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273916
{
public static readonly long[] Value={ 0L,4L,7L,9L,11L,12L,12L,14L,15L,16L,16L,18L,19L,20L,22L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273916Inst : IEnumerable<long>
{
public static readonly long[] Value=A273916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273916.Bytes);
public long this[int i]=>Value[i];

public static A273916Inst Instance=new A273916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273917
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,2L,1L,2L,2L,2L,1L,1L,3L,3L,1L,2L,5L,3L,1L,4L,4L,2L,2L,1L,2L,3L,1L,4L,8L,4L,1L,4L,4L,1L,1L,5L,8L,5L,3L,3L,3L,2L,1L,6L,6L,1L,1L,4L,7L,5L,3L,8L,10L,5L,2L,1L,3L,3L,2L,5L,5L,2L,3L,8L,8L,4L,2L,7L,8L,1L,1L,1L,3L,3L,2L,7L,7L,4L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273917Inst : IEnumerable<long>
{
public static readonly long[] Value=A273917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273917.Bytes);
public long this[int i]=>Value[i];

public static A273917Inst Instance=new A273917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273918
{
public static readonly BigInteger[] Value={ 1L,5L,29L,905L,835409L,698981939105L,BigInteger.Parse("488580362881004355588929"),BigInteger.Parse("238710771078004490460834598457103704776369419905") };
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
public class A273918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273918.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273918Inst Instance=new A273918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273919
{
public static readonly long[] Value={ 0L,0L,0L,3L,57L,984L,22551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273919Inst : IEnumerable<long>
{
public static readonly long[] Value=A273919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273919.Bytes);
public long this[int i]=>Value[i];

public static A273919Inst Instance=new A273919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273920
{
public static readonly long[] Value={ 0L,0L,0L,1L,5L,145L,2969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273920Inst : IEnumerable<long>
{
public static readonly long[] Value=A273920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273920.Bytes);
public long this[int i]=>Value[i];

public static A273920Inst Instance=new A273920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273921
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,15L,253L,5561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273921Inst : IEnumerable<long>
{
public static readonly long[] Value=A273921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273921.Bytes);
public long this[int i]=>Value[i];

public static A273921Inst Instance=new A273921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273922
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,6L,42L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273922Inst : IEnumerable<long>
{
public static readonly long[] Value=A273922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273922.Bytes);
public long this[int i]=>Value[i];

public static A273922Inst Instance=new A273922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273923
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,3L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273923Inst : IEnumerable<long>
{
public static readonly long[] Value=A273923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273923.Bytes);
public long this[int i]=>Value[i];

public static A273923Inst Instance=new A273923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273972
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,34L,68L,128L,256L,544L,1088L,2056L,4112L,8738L,17476L,32768L,65536L,139264L,278528L,526336L,1052672L,2236928L,4473856L,8388736L,16777472L,35652128L,71304256L,134744072L,269488144L,572662306L,1145324612L,2147483648L,4294967296L,9126805504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273972Inst : IEnumerable<long>
{
public static readonly long[] Value=A273972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273972.Bytes);
public long this[int i]=>Value[i];

public static A273972Inst Instance=new A273972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273973
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,17L,17L,1L,1L,17L,17L,257L,257L,4369L,4369L,1L,1L,17L,17L,257L,257L,4369L,4369L,65537L,65537L,1114129L,1114129L,16843009L,16843009L,286331153L,286331153L,1L,1L,17L,17L,257L,257L,4369L,4369L,65537L,65537L,1114129L,1114129L,16843009L,16843009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273973Inst : IEnumerable<long>
{
public static readonly long[] Value=A273973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273973.Bytes);
public long this[int i]=>Value[i];

public static A273973Inst Instance=new A273973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273974
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,13L,32L,82L,226L,651L,1939L,5946L,18637L,59736L,194898L,645742L,2167325L,7359262L,25237989L,87325031L,304549332L,1069685013L,3781189896L,13443608964L,48049822995L,172568075048L,622514907195L,2254799747130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273974Inst : IEnumerable<long>
{
public static readonly long[] Value=A273974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273974.Bytes);
public long this[int i]=>Value[i];

public static A273974Inst Instance=new A273974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273975
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,1L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,3L,2L,1L,1L,3L,6L,7L,6L,3L,1L,1L,4L,6L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,3L,6L,10L,12L,12L,10L,6L,3L,1L,1L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273975Inst : IEnumerable<long>
{
public static readonly long[] Value=A273975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273975.Bytes);
public long this[int i]=>Value[i];

public static A273975Inst Instance=new A273975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273976
{
public static readonly BigInteger[] Value={ 2L,23L,733L,BigInteger.Parse("302155729822807067683647339069918655121463860225627810920499638685341") };
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
public class A273976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273976Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273976.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273976.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273976Inst Instance=new A273976Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273977
{
public static readonly long[] Value={ 11L,111L,112L,121L,122L,1111L,1112L,1121L,1122L,1123L,1211L,1212L,1213L,1221L,1222L,1223L,1231L,1232L,1233L,11111L,11112L,11121L,11122L,11123L,11211L,11212L,11213L,11221L,11222L,11223L,11231L,11232L,11233L,11234L,12111L,12112L,12113L,12121L,12122L,12123L,12131L,12132L,12133L,12134L,12211L,12212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273977Inst : IEnumerable<long>
{
public static readonly long[] Value=A273977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273977.Bytes);
public long this[int i]=>Value[i];

public static A273977Inst Instance=new A273977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273978
{
public static readonly long[] Value={ 11L,111L,1111L,1122L,1212L,1221L,11111L,11122L,11212L,11221L,11222L,12112L,12121L,12122L,12211L,12212L,12221L,111111L,111122L,111212L,111221L,111222L,112112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273978Inst : IEnumerable<long>
{
public static readonly long[] Value=A273978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273978.Bytes);
public long this[int i]=>Value[i];

public static A273978Inst Instance=new A273978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273979
{
public static readonly ulong[] Value={ 1L,11L,11L,11L,1011L,10011L,111011L,11L,1011L,110011L,10111011L,1100000011L,101100001011L,1001100110011L,11101110111011L,11L,1011L,110011L,10111011L,1100000011L,101100001011L,11001100110011L,1011101110111011L,110000000000000011L,10110000000000001011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273979Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A273979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273979.Bytes);
public ulong this[int i]=>Value[i];

public static A273979Inst Instance=new A273979Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273980
{
public static readonly long[] Value={ 8L,13L,21L,26L,34L,39L,47L,55L,60L,68L,73L,81L,86L,89L,94L,102L,107L,115L,120L,128L,136L,141L,149L,154L,162L,167L,175L,183L,188L,196L,201L,209L,217L,222L,230L,235L,243L,248L,256L,264L,269L,277L,282L,290L,295L,298L,303L,311L,316L,324L,329L,337L,345L,350L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273980Inst : IEnumerable<long>
{
public static readonly long[] Value=A273980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273980.Bytes);
public long this[int i]=>Value[i];

public static A273980Inst Instance=new A273980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273981
{
public static readonly long[] Value={ 1L,4L,26L,56L,98L,152L,218L,296L,386L,488L,602L,728L,866L,1016L,1178L,1352L,1538L,1736L,1946L,2168L,2402L,2648L,2906L,3176L,3458L,3752L,4058L,4376L,4706L,5048L,5402L,5768L,6146L,6536L,6938L,7352L,7778L,8216L,8666L,9128L,9602L,10088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273981Inst : IEnumerable<long>
{
public static readonly long[] Value=A273981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273981.Bytes);
public long this[int i]=>Value[i];

public static A273981Inst Instance=new A273981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273982
{
public static readonly long[] Value={ 1L,4L,25L,52L,89L,136L,193L,260L,337L,424L,521L,628L,745L,872L,1009L,1156L,1313L,1480L,1657L,1844L,2041L,2248L,2465L,2692L,2929L,3176L,3433L,3700L,3977L,4264L,4561L,4868L,5185L,5512L,5849L,6196L,6553L,6920L,7297L,7684L,8081L,8488L,8905L,9332L,9769L,10216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273982Inst : IEnumerable<long>
{
public static readonly long[] Value=A273982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273982.Bytes);
public long this[int i]=>Value[i];

public static A273982Inst Instance=new A273982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273983
{
public static readonly BigInteger[] Value={ 1L,31L,2745L,487935L,145769625L,65830256415L,41892106080825L,35736278004165375L,BigInteger.Parse("39370290736153001625"),BigInteger.Parse("54420772423242699849375"),BigInteger.Parse("92234193751998833171261625"),BigInteger.Parse("188098544080793843475953349375"),BigInteger.Parse("454418941572893462364414856265625"),BigInteger.Parse("1283429428883663190972186961851609375") };
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
public class A273983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273983Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A273983.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A273983.Bytes);
public BigInteger this[int i]=>Value[i];

public static A273983Inst Instance=new A273983Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273984
{
public static readonly long[] Value={ 1L,0L,7L,1L,2L,8L,5L,0L,5L,5L,4L,2L,1L,8L,0L,7L,6L,5L,8L,5L,1L,8L,7L,1L,1L,9L,7L,8L,0L,3L,0L,8L,1L,7L,1L,6L,0L,7L,6L,3L,1L,7L,9L,7L,7L,7L,1L,6L,7L,0L,5L,6L,2L,1L,7L,0L,2L,4L,6L,9L,3L,6L,5L,9L,9L,5L,0L,1L,8L,3L,8L,7L,1L,4L,9L,3L,0L,6L,4L,0L,8L,7L,9L,9L,6L,2L,7L,2L,3L,0L,0L,0L,9L,3L,7L,4L,3L,0L,9L,6L,7L,6L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273984Inst : IEnumerable<long>
{
public static readonly long[] Value=A273984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273984.Bytes);
public long this[int i]=>Value[i];

public static A273984Inst Instance=new A273984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273985
{
public static readonly long[] Value={ 0L,8L,5L,9L,3L,7L,2L,9L,0L,6L,9L,1L,7L,6L,8L,4L,5L,2L,4L,2L,3L,8L,4L,1L,7L,4L,5L,7L,8L,7L,6L,4L,6L,9L,5L,8L,0L,3L,3L,7L,8L,7L,3L,7L,7L,9L,1L,3L,0L,6L,4L,9L,8L,0L,6L,4L,3L,1L,6L,8L,4L,6L,6L,9L,6L,3L,7L,5L,7L,9L,0L,7L,5L,2L,2L,9L,7L,2L,3L,0L,2L,5L,5L,5L,6L,5L,1L,6L,0L,0L,9L,8L,3L,3L,8L,1L,9L,3L,1L,2L,4L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273985Inst : IEnumerable<long>
{
public static readonly long[] Value=A273985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273985.Bytes);
public long this[int i]=>Value[i];

public static A273985Inst Instance=new A273985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273986
{
public static readonly long[] Value={ 0L,5L,4L,5L,1L,4L,2L,5L,3L,1L,3L,2L,7L,6L,1L,8L,8L,0L,3L,6L,3L,0L,3L,3L,9L,1L,9L,8L,0L,2L,0L,0L,9L,5L,9L,6L,8L,7L,7L,6L,1L,4L,3L,4L,9L,5L,4L,4L,5L,7L,5L,9L,1L,3L,6L,4L,9L,9L,4L,0L,2L,6L,4L,6L,3L,4L,0L,8L,5L,7L,9L,9L,3L,6L,3L,3L,0L,3L,5L,4L,6L,1L,0L,5L,5L,1L,5L,7L,3L,8L,2L,8L,2L,4L,7L,0L,9L,0L,6L,1L,3L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273986Inst : IEnumerable<long>
{
public static readonly long[] Value=A273986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273986.Bytes);
public long this[int i]=>Value[i];

public static A273986Inst Instance=new A273986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A273987
{
public static readonly long[] Value={ 509203L,63064644938L,9L,346802L,84687L,408034255082L,14L,4L,10176L,862L,25L,302L,4L,36370321851498L,9L,86L,246L,144L,8L,560L,4461L,476L,4L,36L,149L,8L,144L,4L,1369L,134718L,10L,16L,6L,287860L,4L,7772L,13L,4L,81L,8L,15137L,672L,4L,22564L,8177L,14L,3226L,36L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A273987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A273987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A273987Inst : IEnumerable<long>
{
public static readonly long[] Value=A273987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A273987.Bytes);
public long this[int i]=>Value[i];

public static A273987Inst Instance=new A273987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275044
{
public static readonly BigInteger[] Value={ 1L,1L,3L,64L,25097L,350813126L,293327384637282L,BigInteger.Parse("22208366234650578141209"),BigInteger.Parse("213426677887357366350726096998529"),BigInteger.Parse("344735749788852590196707169431958672823413322"),BigInteger.Parse("118966637603805785518622376062965559343297730169187276656138") };
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
public class A275044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275044Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275044.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275044.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275044Inst Instance=new A275044Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275045
{
public static readonly BigInteger[] Value={ 1L,13L,589L,37501L,2776861L,224127793L,19128964429L,1697822272957L,155124241235293L,14493082279323913L,1378280656022778289L,BigInteger.Parse("132975844343348756257"),BigInteger.Parse("12983655880217911846621"),BigInteger.Parse("1280541892692200972993809"),BigInteger.Parse("127387054518359023378891069"),BigInteger.Parse("12766850683487700784950948541"),BigInteger.Parse("1287829822333113383109436556893") };
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
public class A275045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275045Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275045.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275045.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275045Inst Instance=new A275045Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275046
{
public static readonly long[] Value={ 1L,2L,6L,20L,70L,245L,874L,3164L,11577L,42694L,158431L,590873L,2212797L,8315535L,31341163L,118423810L,448455754L,1701534151L,6467049185L,24617030774L,93834205107L,358116770601L,1368283768753L,5233261657558L,20034371696497L,76763164565117L,294357181436313L,1129575035419485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275046Inst : IEnumerable<long>
{
public static readonly long[] Value=A275046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275046.Bytes);
public long this[int i]=>Value[i];

public static A275046Inst Instance=new A275046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275047
{
public static readonly BigInteger[] Value={ 1L,18L,1350L,141120L,17151750L,2272538268L,318430816704L,46404203788800L,6961609406993670L,1068002895589987500L,BigInteger.Parse("166779781860762170100"),BigInteger.Parse("26422986893371642828800"),BigInteger.Parse("4236593267629481817240000"),BigInteger.Parse("686167053247777413372681600"),BigInteger.Parse("112093956900827388909570240000") };
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
public class A275047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275047.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275047Inst Instance=new A275047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275048
{
public static readonly BigInteger[] Value={ 1L,616L,947175L,1812651820L,3833011883965L,8582819380142616L,BigInteger.Parse("19946071353510410136"),BigInteger.Parse("47578122531207001944168"),BigInteger.Parse("115702070514540009854741415"),BigInteger.Parse("285583642613093627090885877280"),BigInteger.Parse("713269435359072253352128013072035"),BigInteger.Parse("1798640871397075848520426334656821360"),BigInteger.Parse("4571867984920021228226177292547960261132") };
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
public class A275048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275048Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275048.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275048.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275048Inst Instance=new A275048Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275049
{
public static readonly BigInteger[] Value={ 1L,30L,3870L,698880L,146881350L,33664290660L,8161119046080L,2057838873742080L,534207274296708870L,BigInteger.Parse("141819633092233024500"),BigInteger.Parse("38325111684989079770820"),BigInteger.Parse("10507683011039968126464000"),BigInteger.Parse("2915637485437466384104036800"),BigInteger.Parse("817228372649330361131497411200") };
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
public class A275049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275049Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275049.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275049.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275049Inst Instance=new A275049Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275050
{
public static readonly BigInteger[] Value={ 1L,36L,5580L,1209600L,305127900L,83936348496L,24422566424256L,7391145688692480L,2302861234904415900L,BigInteger.Parse("733755111903173646000"),BigInteger.Parse("237987702318837667276080"),BigInteger.Parse("78313025454309175928186880"),BigInteger.Parse("26080521003090619899885979200"),BigInteger.Parse("8773677817145303533293886560000") };
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
public class A275050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275050.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275050Inst Instance=new A275050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275051
{
public static readonly BigInteger[] Value={ 1L,60L,20475L,9373650L,4881796920L,2734407111744L,1605040007778900L,973419698810097000L,BigInteger.Parse("604759111060745718000"),BigInteger.Parse("382741738086972337402560"),BigInteger.Parse("245810413547242455520545552"),BigInteger.Parse("159759730493918131135425965280"),BigInteger.Parse("104861901534978616465850670348000") };
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
public class A275051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275051Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275051.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275051.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275051Inst Instance=new A275051Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275052
{
public static readonly BigInteger[] Value={ 1L,112L,103488L,139087872L,219932697600L,380982080962560L,699690909055057920L,BigInteger.Parse("1338362619711643975680"),BigInteger.Parse("2637829075787918298316800"),BigInteger.Parse("5319794376634771700187136000"),BigInteger.Parse("10925401705883689450455905075200"),BigInteger.Parse("22771065347191895949498972005990400"),BigInteger.Parse("48042740185717267168321727861725593600") };
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
public class A275052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275052Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275052.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275052.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275052Inst Instance=new A275052Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275053
{
public static readonly BigInteger[] Value={ 1L,21L,5544L,2194500L,1032711750L,535163031270L,294927297193620L,169625328357359160L,BigInteger.Parse("100668944872954458000"),BigInteger.Parse("61198401105544584882000"),BigInteger.Parse("37917347562767179794006720"),BigInteger.Parse("23857493242377754986443300520"),BigInteger.Parse("15203471586481919338384641390900"),BigInteger.Parse("9792887011999654848831359131972500") };
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
public class A275053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275053Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275053.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275053.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275053Inst Instance=new A275053Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275054
{
public static readonly BigInteger[] Value={ 1L,24L,6732L,2771340L,1342525275L,711891288108L,399866544799722L,233750557331494632L,BigInteger.Parse("140707672445849703480"),BigInteger.Parse("86621407014527646518400"),BigInteger.Parse("54278825541246092520182592"),BigInteger.Parse("34504174655166790354911360048"),BigInteger.Parse("22195631874904018057471849288020"),BigInteger.Parse("14421008706115620277976088538033200") };
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
public class A275054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275054Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275054.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275054.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275054Inst Instance=new A275054Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275055
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,4L,1L,5L,1L,2L,3L,6L,1L,7L,1L,2L,4L,8L,1L,3L,9L,1L,2L,5L,10L,1L,11L,1L,2L,4L,3L,6L,12L,1L,13L,1L,2L,7L,14L,1L,3L,5L,15L,1L,2L,4L,8L,16L,1L,17L,1L,2L,3L,6L,9L,18L,1L,19L,1L,2L,4L,5L,10L,20L,1L,3L,7L,21L,1L,2L,11L,22L,1L,23L,1L,2L,4L,8L,3L,6L,12L,24L,1L,5L,25L,1L,2L,13L,26L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275055Inst : IEnumerable<long>
{
public static readonly long[] Value=A275055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275055.Bytes);
public long this[int i]=>Value[i];

public static A275055Inst Instance=new A275055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275056
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,1L,3L,5L,17L,11L,13L,5L,4L,13L,5L,13L,19L,17L,5L,7L,4L,13L,5L,9L,11L,7L,9L,5L,7L,45L,59L,149L,233L,1081L,1501L,1361L,1501L,1291L,477L,1291L,1711L,1627L,2047L,1837L,2257L,729L,2257L,2047L,2467L,2257L,799L,659L,687L,1921L,687L,1921L,2341L,2201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275056Inst : IEnumerable<long>
{
public static readonly long[] Value=A275056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275056.Bytes);
public long this[int i]=>Value[i];

public static A275056Inst Instance=new A275056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275057
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,6L,17L,41L,116L,313L,895L,2550L,7450L,21881L,65168L,195370L,591007L,1798718L,5510023L,16966529L,52506837L,163200904L,509323732L,1595311747L,5013746254L,15805787496L,49969942138L,158396065350L,503317495573L,1602973785463L,5116010587910L,16360492172347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275057Inst : IEnumerable<long>
{
public static readonly long[] Value=A275057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275057.Bytes);
public long this[int i]=>Value[i];

public static A275057Inst Instance=new A275057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275058
{
public static readonly long[] Value={ 11L,13L,17L,19L,41L,43L,47L,97L,163L,167L,251L,257L,367L,491L,499L,641L,643L,647L,811L,1009L,1213L,1217L,1447L,1693L,1697L,1699L,2251L,2897L,3613L,3617L,4001L,4003L,4007L,5297L,6257L,6761L,6763L,7297L,7841L,8419L,9001L,9007L,9613L,9619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275058Inst : IEnumerable<long>
{
public static readonly long[] Value=A275058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275058.Bytes);
public long this[int i]=>Value[i];

public static A275058Inst Instance=new A275058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275059
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,13L,15L,19L,31L,33L,35L,41L,51L,53L,59L,65L,83L,89L,91L,101L,103L,115L,131L,141L,149L,161L,163L,181L,185L,187L,191L,193L,199L,217L,221L,233L,241L,263L,281L,287L,295L,303L,329L,331L,349L,373L,401L,415L,419L,431L,433L,445L,449L,461L,463L,469L,473L,499L,517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275059Inst : IEnumerable<long>
{
public static readonly long[] Value=A275059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275059.Bytes);
public long this[int i]=>Value[i];

public static A275059Inst Instance=new A275059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275812
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,0L,3L,2L,0L,0L,2L,0L,0L,0L,4L,0L,2L,0L,2L,0L,0L,0L,3L,2L,0L,3L,2L,0L,0L,0L,5L,0L,0L,0L,4L,0L,0L,0L,3L,0L,0L,0L,2L,2L,0L,0L,4L,2L,2L,0L,2L,0L,3L,0L,3L,0L,0L,0L,2L,0L,0L,2L,6L,0L,0L,0L,2L,0L,0L,0L,5L,0L,0L,2L,2L,0L,0L,0L,4L,4L,0L,0L,2L,0L,0L,0L,3L,0L,2L,0L,2L,0L,0L,0L,5L,0L,2L,2L,4L,0L,0L,0L,3L,0L,0L,0L,5L,0L,0L,0L,4L,0L,0L,0L,2L,2L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275812Inst : IEnumerable<long>
{
public static readonly long[] Value=A275812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275812.Bytes);
public long this[int i]=>Value[i];

public static A275812Inst Instance=new A275812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275813
{
public static readonly long[] Value={ 0L,3L,5L,8L,10L,13L,14L,19L,22L,30L,33L,35L,36L,39L,41L,42L,45L,47L,50L,52L,54L,57L,59L,63L,65L,69L,71L,73L,74L,81L,83L,84L,87L,89L,93L,95L,97L,100L,105L,107L,111L,113L,114L,117L,119L,144L,147L,149L,152L,154L,157L,158L,163L,166L,168L,171L,173L,176L,178L,181L,182L,187L,190L,192L,195L,197L,200L,202L,205L,206L,211L,214L,216L,219L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275813Inst : IEnumerable<long>
{
public static readonly long[] Value=A275813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275813.Bytes);
public long this[int i]=>Value[i];

public static A275813Inst Instance=new A275813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275814
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,11L,12L,15L,16L,17L,18L,20L,21L,23L,24L,25L,26L,27L,28L,29L,31L,32L,34L,37L,38L,40L,43L,44L,46L,48L,49L,51L,53L,55L,56L,58L,60L,61L,62L,64L,66L,67L,68L,70L,72L,75L,76L,77L,78L,79L,80L,82L,85L,86L,88L,90L,91L,92L,94L,96L,98L,99L,101L,102L,103L,104L,106L,108L,109L,110L,112L,115L,116L,118L,120L,121L,122L,123L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275814Inst : IEnumerable<long>
{
public static readonly long[] Value=A275814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275814.Bytes);
public long this[int i]=>Value[i];

public static A275814Inst Instance=new A275814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275815
{
public static readonly long[] Value={ 0L,4L,17L,40L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275815Inst : IEnumerable<long>
{
public static readonly long[] Value=A275815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275815.Bytes);
public long this[int i]=>Value[i];

public static A275815Inst Instance=new A275815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275816
{
public static readonly long[] Value={ 2L,4L,8L,16L,32L,64L,128L,256L,432L,1024L,864L,4096L,1728L,2592L,3456L,65536L,6912L,262144L,10368L,14400L,27648L,4194304L,21600L,32400L,110592L,50400L,43200L,268435456L,64800L,1073741824L,86400L,230400L,1769472L,129600L,151200L,68719476736L,7077888L,921600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275816Inst : IEnumerable<long>
{
public static readonly long[] Value=A275816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275816.Bytes);
public long this[int i]=>Value[i];

public static A275816Inst Instance=new A275816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275817
{
public static readonly long[] Value={ 2L,3L,2L,4L,5L,3L,2L,3L,6L,7L,4L,3L,2L,3L,4L,8L,9L,5L,3L,5L,2L,3L,4L,5L,10L,11L,6L,4L,3L,5L,2L,5L,3L,4L,6L,12L,13L,7L,5L,4L,3L,7L,2L,5L,3L,4L,5L,7L,14L,15L,8L,5L,4L,3L,5L,7L,2L,5L,3L,7L,4L,6L,8L,16L,17L,9L,6L,5L,4L,3L,5L,7L,2L,5L,8L,3L,4L,5L,6L,9L,18L,19L,10L,7L,5L,4L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275817Inst : IEnumerable<long>
{
public static readonly long[] Value=A275817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275817.Bytes);
public long this[int i]=>Value[i];

public static A275817Inst Instance=new A275817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275818
{
public static readonly long[] Value={ 1L,4L,3L,7L,11L,7L,5L,8L,17L,22L,13L,10L,7L,11L,15L,31L,37L,21L,13L,22L,9L,14L,19L,24L,49L,56L,31L,21L,16L,27L,11L,28L,17L,23L,35L,71L,79L,43L,31L,25L,19L,45L,13L,33L,20L,27L,34L,48L,97L,106L,57L,36L,29L,22L,37L,52L,15L,38L,23L,54L,31L,47L,63L,127L,137L,73L,49L,41L,33L,25L,42L,59L,17L,43L,69L,26L,35L,44L,53L,80L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275818Inst : IEnumerable<long>
{
public static readonly long[] Value=A275818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275818.Bytes);
public long this[int i]=>Value[i];

public static A275818Inst Instance=new A275818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275819
{
public static readonly long[] Value={ 2L,60L,210L,2160L,1260L,77760L,4620L,12600L,18480L,3456000L,27720L,4730880L,302400L,453600L,120120L,1990656000L,180180L,1238630400L,997920L,1108800L,10644480L,1146617856000L,720720L,2494800L,70963200L,3880800L,2882880L,11415217766400L,5821200L,18602577100800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275819Inst : IEnumerable<long>
{
public static readonly long[] Value=A275819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275819.Bytes);
public long this[int i]=>Value[i];

public static A275819Inst Instance=new A275819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275820
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,3L,1L,3L,3L,3L,2L,7L,3L,8L,7L,10L,7L,16L,8L,17L,17L,21L,17L,35L,22L,37L,36L,46L,37L,69L,46L,74L,71L,91L,81L,128L,96L,144L,139L,173L,154L,236L,185L,263L,257L,314L,286L,417L,345L,470L,462L,557L,517L,719L,617L,815L,802L,960L,904L,1211L,1068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275820Inst : IEnumerable<long>
{
public static readonly long[] Value=A275820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275820.Bytes);
public long this[int i]=>Value[i];

public static A275820Inst Instance=new A275820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275821
{
public static readonly long[] Value={ 1L,0L,1L,-1L,1L,0L,1L,-1L,1L,-1L,3L,-2L,3L,-3L,2L,-1L,4L,-3L,4L,-4L,7L,-7L,7L,-7L,9L,-6L,11L,-10L,10L,-11L,15L,-14L,18L,-19L,21L,-17L,24L,-22L,26L,-29L,35L,-34L,42L,-43L,43L,-39L,52L,-52L,59L,-59L,74L,-72L,79L,-87L,93L,-87L,107L,-108L,118L,-126L,149L,-146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275821Inst : IEnumerable<long>
{
public static readonly long[] Value=A275821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275821.Bytes);
public long this[int i]=>Value[i];

public static A275821Inst Instance=new A275821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275822
{
public static readonly BigInteger[] Value={ 1L,7L,209L,7791L,335209L,15667799L,773221225L,39651016343L,2092095886657L,112840936041343L,6193764391911873L,344853399798469695L,BigInteger.Parse("19429178297906958721"),BigInteger.Parse("1105629520934309041279"),BigInteger.Parse("63455683531507986958721"),BigInteger.Parse("3668895994183490904049279") };
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
public class A275822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275822Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275822.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275822.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275822Inst Instance=new A275822Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275823
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,3L,7L,4L,9L,5L,11L,6L,13L,7L,15L,8L,17L,9L,19L,5L,7L,11L,23L,12L,25L,13L,9L,14L,29L,15L,31L,8L,33L,17L,35L,18L,37L,19L,13L,10L,41L,7L,43L,22L,45L,23L,47L,12L,49L,25L,51L,13L,53L,9L,11L,28L,19L,29L,59L,15L,61L,31L,21L,16L,65L,33L,67L,17L,69L,35L,71L,36L,73L,37L,75L,38L,77L,13L,79L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275823Inst : IEnumerable<long>
{
public static readonly long[] Value=A275823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275823.Bytes);
public long this[int i]=>Value[i];

public static A275823Inst Instance=new A275823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275824
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,2L,2L,3L,3L,2L,3L,2L,3L,1L,1L,2L,1L,3L,2L,6L,4L,3L,4L,2L,3L,2L,2L,3L,1L,5L,4L,4L,5L,4L,4L,1L,3L,3L,1L,3L,5L,7L,6L,4L,5L,3L,5L,3L,3L,4L,4L,5L,4L,6L,7L,3L,5L,4L,4L,3L,2L,6L,3L,6L,5L,5L,7L,7L,7L,3L,6L,7L,5L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275824Inst : IEnumerable<long>
{
public static readonly long[] Value=A275824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275824.Bytes);
public long this[int i]=>Value[i];

public static A275824Inst Instance=new A275824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275825
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,5L,14L,52L,238L,1288L,8144L,59150L,486080L,4464304L,45352840L,505200280L,6124903616L,80304039608L,1132339758992L,17089219746352L,274872988654576L,4694355262548640L,84840179120802560L,1617735736056994736L,BigInteger.Parse("32457990536915964800"),BigInteger.Parse("683569125395013719680") };
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
public class A275825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275825Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A275825.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A275825.Bytes);
public BigInteger this[int i]=>Value[i];

public static A275825Inst Instance=new A275825Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275826
{
public static readonly long[] Value={ 1L,2L,6L,8L,20L,20L,28L,36L,36L,56L,90L,90L,120L,126L,126L,126L,172L,172L,342L,342L,374L,380L,464L,464L,464L,464L,464L,464L,464L,464L,847L,847L,1056L,1105L,1105L,1105L,1105L,1105L,1330L,1330L,1728L,1728L,1728L,1728L,1728L,2410L,2856L,2856L,2856L,2856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275826Inst : IEnumerable<long>
{
public static readonly long[] Value=A275826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275826.Bytes);
public long this[int i]=>Value[i];

public static A275826Inst Instance=new A275826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275827
{
public static readonly long[] Value={ 1L,7L,50L,364L,2688L,20064L,151008L,1144000L,8712704L,66646528L,511673344L,3940579328L,30429184000L,235521884160L,1826663915520L,14192851599360L,110453212446720L,860819570688000L,6717522904350720L,52482715893104640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275827Inst : IEnumerable<long>
{
public static readonly long[] Value=A275827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275827.Bytes);
public long this[int i]=>Value[i];

public static A275827Inst Instance=new A275827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275860
{
public static readonly long[] Value={ 1L,1L,7L,33L,164L,813L,4039L,20063L,99665L,495099L,2459470L,12217747L,60693301L,301502133L,1497752387L,7440286381L,36960623072L,183606865105L,912091791531L,4530938620963L,22508046862781L,111811749387479L,555439900107962L,2759222392297991L,13706808258965257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275860Inst : IEnumerable<long>
{
public static readonly long[] Value=A275860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275860.Bytes);
public long this[int i]=>Value[i];

public static A275860Inst Instance=new A275860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275861
{
public static readonly long[] Value={ 1L,1L,9L,51L,305L,1813L,10784L,64144L,381543L,2269503L,13499513L,80298135L,477631347L,2841058559L,16899254596L,100520563016L,597918892325L,3556555903317L,21155193548465L,125835844069155L,748499871500621L,4452245397810113L,26482955892270832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275861Inst : IEnumerable<long>
{
public static readonly long[] Value=A275861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275861.Bytes);
public long this[int i]=>Value[i];

public static A275861Inst Instance=new A275861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275862
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,19L,41L,89L,194L,424L,927L,2026L,4429L,9682L,21166L,46272L,101157L,221143L,483449L,1056887L,2310503L,5051084L,11042380L,24140196L,52773864L,115371090L,252217431L,551382781L,1205400317L,2635174646L,5760862444L,12594055635L,27532377118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275862Inst : IEnumerable<long>
{
public static readonly long[] Value=A275862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275862.Bytes);
public long this[int i]=>Value[i];

public static A275862Inst Instance=new A275862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275863
{
public static readonly long[] Value={ 1L,1L,4L,12L,40L,130L,425L,1387L,4529L,14789L,48294L,157707L,515002L,1681772L,5491935L,17934267L,58565504L,191249427L,624537327L,2039466884L,6660010527L,21748693527L,71021760134L,231926134152L,757369735715L,2473239674667L,8076523525954L,26374408001552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275863Inst : IEnumerable<long>
{
public static readonly long[] Value=A275863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275863.Bytes);
public long this[int i]=>Value[i];

public static A275863Inst Instance=new A275863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275864
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,50L,118L,279L,661L,1566L,3711L,8795L,20843L,49396L,117064L,277432L,657492L,1558206L,3692830L,8751726L,20740926L,49154420L,116492243L,276077771L,654283356L,1550601878L,3674808723L,8709017668L,20639710651L,48914547197L,115923763079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275864Inst : IEnumerable<long>
{
public static readonly long[] Value=A275864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275864.Bytes);
public long this[int i]=>Value[i];

public static A275864Inst Instance=new A275864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275865
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-2L,-1L,1L,3L,3L,0L,-4L,-6L,-3L,4L,11L,10L,-1L,-17L,-24L,-10L,21L,46L,38L,-12L,-75L,-95L,-30L,98L,192L,141L,-77L,-327L,-375L,-72L,455L,790L,503L,-431L,-1401L,-1455L,-81L,2061L,3213L,1728L,-2227L,-5933L,-5559L,561L,9180L,12929L,5623L,-10959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275865Inst : IEnumerable<long>
{
public static readonly long[] Value=A275865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275865.Bytes);
public long this[int i]=>Value[i];

public static A275865Inst Instance=new A275865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275866
{
public static readonly long[] Value={ 0L,0L,2L,1L,1L,3L,5L,1L,7L,2L,4L,3L,2L,6L,6L,1L,3L,7L,6L,2L,2L,5L,4L,3L,8L,3L,38L,6L,5L,6L,36L,1L,9L,4L,4L,7L,6L,7L,12L,2L,37L,2L,9L,5L,4L,5L,35L,3L,8L,8L,8L,3L,2L,38L,38L,6L,11L,6L,10L,6L,5L,37L,36L,1L,9L,9L,8L,4L,4L,4L,34L,7L,38L,7L,3L,7L,7L,12L,11L,2L,6L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275866Inst : IEnumerable<long>
{
public static readonly long[] Value=A275866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275866.Bytes);
public long this[int i]=>Value[i];

public static A275866Inst Instance=new A275866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A275867
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,8L,144L,3552L,131452L,7840396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A275867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A275867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A275867Inst : IEnumerable<long>
{
public static readonly long[] Value=A275867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A275867.Bytes);
public long this[int i]=>Value[i];

public static A275867Inst Instance=new A275867Inst();

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