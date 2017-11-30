using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A127596
{
public static readonly long[] Value={ 2L,4L,14L,22L,28L,233L,249L,261L,488L,497L,511L,515L,519L,526L,531L,534L,548L,562L,620L,633L,635L,2985L,3119L,3123L,3128L,3157L,4350L,4358L,4392L,4438L,4474L,4484L,4606L,4610L,4759L,5191L,12493L,1761067L,2785124L,2785152L,2785718L,2785729L,2867471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127596Inst : IEnumerable<long>
{
public static readonly long[] Value=A127596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127596.Bytes);
public long this[int i]=>Value[i];

public static A127596Inst Instance=new A127596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127595
{
public static readonly long[] Value={ 0L,1L,15L,128L,945L,6655L,46080L,317057L,2176335L,14925184L,102320625L,701373311L,4807434240L,32951037313L,225850798095L,1548007091840L,10610205501105L,72723448842367L,498453982018560L,3416454544730369L,23416728143799375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127595Inst : IEnumerable<long>
{
public static readonly long[] Value=A127595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127595.Bytes);
public long this[int i]=>Value[i];

public static A127595Inst Instance=new A127595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127594
{
public static readonly long[] Value={ 3L,4L,6L,7L,9L,13L,22L,24L,27L,28L,39L,42L,43L,48L,52L,66L,69L,72L,73L,76L,84L,88L,93L,97L,108L,114L,118L,123L,126L,147L,154L,157L,163L,168L,183L,184L,186L,196L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127594Inst : IEnumerable<long>
{
public static readonly long[] Value=A127594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127594.Bytes);
public long this[int i]=>Value[i];

public static A127594Inst Instance=new A127594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127593
{
public static readonly long[] Value={ 853L,1109L,1621L,1877L,2389L,3413L,5717L,6229L,6997L,7253L,10069L,10837L,11093L,12373L,13397L,16981L,17749L,18517L,18773L,19541L,21589L,22613L,23893L,24917L,27733L,29269L,30293L,31573L,32341L,37717L,39509L,40277L,41813L,43093L,46933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127593Inst : IEnumerable<long>
{
public static readonly long[] Value=A127593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127593.Bytes);
public long this[int i]=>Value[i];

public static A127593Inst Instance=new A127593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127592
{
public static readonly long[] Value={ 149L,277L,661L,853L,1109L,1237L,1301L,1429L,1493L,1621L,1877L,2069L,2389L,2837L,3221L,3413L,3541L,3733L,3797L,3989L,4373L,5077L,5333L,5653L,5717L,6037L,6101L,6229L,6421L,6869L,6997L,7253L,7573L,7829L,8597L,9109L,9173L,9749L,9941L,10069L,10133L,10453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127592Inst : IEnumerable<long>
{
public static readonly long[] Value=A127592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127592.Bytes);
public long this[int i]=>Value[i];

public static A127592Inst Instance=new A127592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127559
{
public static readonly long[] Value={ 7L,3L,4L,0L,0L,0L,3L,5L,3L,9L,8L,2L,2L,7L,9L,8L,5L,0L,2L,9L,7L,3L,9L,1L,8L,4L,6L,1L,5L,9L,2L,7L,6L,9L,4L,9L,1L,1L,2L,4L,7L,3L,4L,1L,2L,2L,3L,9L,9L,1L,6L,1L,1L,5L,8L,1L,5L,8L,2L,6L,1L,8L,9L,2L,4L,0L,3L,1L,3L,6L,2L,0L,9L,5L,9L,1L,6L,3L,9L,3L,0L,9L,5L,9L,1L,7L,9L,4L,0L,9L,5L,2L,7L,0L,5L,4L,2L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127559Inst : IEnumerable<long>
{
public static readonly long[] Value=A127559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127559.Bytes);
public long this[int i]=>Value[i];

public static A127559Inst Instance=new A127559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127558
{
public static readonly long[] Value={ 2L,9L,0L,0L,0L,6L,9L,4L,9L,2L,6L,9L,1L,7L,9L,8L,0L,1L,4L,4L,2L,3L,7L,1L,3L,5L,8L,1L,4L,0L,8L,7L,8L,4L,9L,1L,2L,0L,4L,8L,7L,4L,8L,2L,8L,7L,5L,9L,7L,5L,7L,3L,4L,7L,7L,9L,8L,4L,2L,5L,9L,3L,4L,4L,6L,1L,5L,1L,6L,0L,6L,4L,5L,0L,8L,6L,1L,3L,6L,3L,8L,3L,5L,5L,3L,0L,0L,3L,0L,9L,5L,0L,0L,9L,6L,7L,2L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127558Inst : IEnumerable<long>
{
public static readonly long[] Value=A127558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127558.Bytes);
public long this[int i]=>Value[i];

public static A127558Inst Instance=new A127558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127557
{
public static readonly long[] Value={ 5L,0L,1L,8L,8L,6L,5L,6L,5L,7L,3L,7L,7L,3L,7L,8L,2L,3L,3L,7L,1L,4L,1L,5L,6L,2L,8L,3L,1L,8L,1L,1L,3L,6L,8L,6L,8L,1L,3L,3L,8L,9L,4L,1L,7L,7L,1L,4L,7L,9L,8L,0L,0L,5L,7L,1L,0L,3L,8L,2L,7L,6L,1L,9L,8L,0L,4L,1L,2L,6L,4L,7L,8L,3L,6L,2L,0L,2L,4L,8L,2L,0L,2L,4L,6L,5L,5L,7L,9L,5L,9L,7L,7L,9L,6L,2L,0L,7L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127557Inst : IEnumerable<long>
{
public static readonly long[] Value=A127557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127557.Bytes);
public long this[int i]=>Value[i];

public static A127557Inst Instance=new A127557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127556
{
public static readonly long[] Value={ 4L,1L,6L,3L,6L,6L,3L,5L,1L,4L,7L,3L,3L,2L,9L,1L,2L,7L,7L,0L,4L,7L,3L,6L,8L,7L,8L,3L,7L,9L,4L,6L,0L,1L,1L,3L,5L,8L,0L,5L,7L,6L,4L,4L,9L,7L,4L,6L,3L,7L,4L,3L,9L,6L,9L,1L,5L,9L,0L,3L,6L,9L,5L,1L,4L,8L,8L,9L,8L,3L,6L,6L,8L,4L,4L,8L,0L,3L,1L,3L,7L,5L,7L,8L,0L,5L,3L,7L,9L,7L,1L,6L,5L,3L,8L,4L,7L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127556Inst : IEnumerable<long>
{
public static readonly long[] Value=A127556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127556.Bytes);
public long this[int i]=>Value[i];

public static A127556Inst Instance=new A127556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127555
{
public static readonly long[] Value={ 4L,1L,6L,4L,3L,9L,3L,9L,2L,0L,3L,1L,3L,5L,4L,9L,0L,5L,3L,4L,1L,3L,2L,3L,9L,8L,2L,8L,7L,4L,3L,1L,2L,1L,9L,7L,4L,1L,3L,3L,3L,3L,6L,9L,1L,9L,2L,6L,2L,3L,0L,1L,1L,8L,9L,1L,9L,7L,6L,3L,6L,7L,6L,9L,0L,2L,6L,4L,9L,3L,0L,8L,8L,6L,1L,7L,5L,2L,8L,7L,1L,9L,2L,4L,2L,9L,6L,3L,1L,1L,3L,8L,9L,4L,6L,3L,6L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127555Inst : IEnumerable<long>
{
public static readonly long[] Value=A127555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127555.Bytes);
public long this[int i]=>Value[i];

public static A127555Inst Instance=new A127555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127554
{
public static readonly long[] Value={ 0L,1L,2L,4L,1L,7L,10L,19L,19L,19L,19L,28L,37L,37L,55L,55L,37L,46L,46L,73L,73L,64L,82L,100L,100L,118L,109L,100L,127L,127L,145L,118L,163L,145L,154L,172L,172L,154L,181L,181L,199L,172L,226L,208L,253L,226L,262L,262L,253L,271L,235L,271L,262L,280L,325L,325L,307L,343L,334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127554Inst : IEnumerable<long>
{
public static readonly long[] Value=A127554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127554.Bytes);
public long this[int i]=>Value[i];

public static A127554Inst Instance=new A127554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127553
{
public static readonly BigInteger[] Value={ 1L,2L,18L,96L,15000L,6480L,84707280L,41287680L,21427701120L,56700000000L,94121726392108800L,2483144294400L,BigInteger.Parse("11159820050604594969600"),BigInteger.Parse("24625709514114508800"),BigInteger.Parse("620634514500000000000"),BigInteger.Parse("359450793240158011392000") };
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
public class A127553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127553.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127553Inst Instance=new A127553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127552
{
public static readonly long[] Value={ 3L,1L,9L,6L,4L,4L,7L,1L,9L,3L,3L,8L,6L,1L,6L,8L,7L,1L,1L,1L,3L,8L,6L,8L,6L,2L,9L,5L,4L,0L,2L,0L,7L,5L,1L,7L,0L,8L,1L,9L,3L,4L,3L,1L,0L,9L,5L,0L,6L,2L,2L,9L,6L,9L,8L,6L,8L,3L,5L,7L,2L,6L,6L,9L,2L,9L,9L,9L,7L,4L,2L,6L,6L,8L,7L,5L,8L,1L,3L,0L,2L,1L,7L,7L,0L,1L,3L,0L,2L,7L,7L,0L,4L,1L,4L,2L,0L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127552Inst : IEnumerable<long>
{
public static readonly long[] Value=A127552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127552.Bytes);
public long this[int i]=>Value[i];

public static A127552Inst Instance=new A127552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127551
{
public static readonly long[] Value={ 5L,1L,4L,1L,0L,3L,8L,1L,4L,1L,8L,4L,1L,2L,7L,4L,2L,2L,3L,6L,7L,9L,7L,3L,7L,8L,1L,1L,9L,9L,8L,3L,1L,7L,4L,0L,9L,2L,8L,3L,3L,0L,6L,7L,3L,9L,1L,1L,3L,5L,3L,4L,2L,0L,7L,2L,1L,1L,0L,2L,1L,0L,5L,6L,2L,5L,0L,6L,5L,6L,4L,3L,0L,4L,1L,7L,2L,5L,5L,6L,2L,1L,9L,9L,1L,2L,2L,7L,5L,9L,9L,5L,9L,1L,3L,0L,3L,5L,9L,7L,4L,4L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127551Inst : IEnumerable<long>
{
public static readonly long[] Value=A127551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127551.Bytes);
public long this[int i]=>Value[i];

public static A127551Inst Instance=new A127551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127550
{
public static readonly long[] Value={ 3L,1L,9L,4L,5L,1L,3L,2L,4L,2L,7L,3L,6L,1L,9L,3L,3L,1L,2L,8L,9L,0L,9L,8L,1L,0L,5L,3L,4L,5L,0L,5L,5L,1L,7L,8L,4L,3L,8L,3L,9L,7L,4L,3L,9L,3L,1L,9L,7L,1L,1L,8L,1L,9L,3L,8L,2L,6L,7L,1L,9L,6L,9L,3L,3L,5L,4L,6L,9L,1L,2L,2L,5L,3L,6L,4L,2L,7L,6L,2L,6L,7L,5L,9L,5L,7L,8L,7L,6L,9L,8L,6L,5L,6L,1L,4L,7L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127550Inst : IEnumerable<long>
{
public static readonly long[] Value=A127550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127550.Bytes);
public long this[int i]=>Value[i];

public static A127550Inst Instance=new A127550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127549
{
public static readonly long[] Value={ 1L,3L,1L,3L,0L,3L,6L,7L,3L,6L,4L,3L,3L,5L,8L,2L,9L,0L,6L,3L,8L,3L,9L,5L,1L,6L,0L,2L,6L,4L,1L,7L,8L,2L,4L,7L,6L,3L,9L,6L,6L,8L,9L,7L,7L,1L,8L,0L,3L,2L,5L,6L,3L,4L,0L,2L,1L,0L,1L,2L,4L,4L,4L,2L,1L,4L,4L,5L,6L,4L,7L,3L,1L,7L,7L,6L,2L,7L,2L,2L,4L,3L,6L,9L,5L,3L,2L,2L,0L,1L,7L,2L,3L,8L,3L,2L,8L,1L,7L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127549Inst : IEnumerable<long>
{
public static readonly long[] Value=A127549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127549.Bytes);
public long this[int i]=>Value[i];

public static A127549Inst Instance=new A127549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127548
{
public static readonly long[] Value={ 1L,1L,0L,1L,4L,19L,112L,771L,6088L,54213L,537392L,5867925L,69975308L,904788263L,12607819040L,188341689287L,3002539594128L,50878366664393L,913161208490016L,17304836525709097L,345279674107957524L,7235298537356113339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127548Inst : IEnumerable<long>
{
public static readonly long[] Value=A127548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127548.Bytes);
public long this[int i]=>Value[i];

public static A127548Inst Instance=new A127548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127547
{
public static readonly long[] Value={ 4L,17L,30L,43L,56L,69L,82L,95L,108L,121L,134L,147L,160L,173L,186L,199L,212L,225L,238L,251L,264L,277L,290L,303L,316L,329L,342L,355L,368L,381L,394L,407L,420L,433L,446L,459L,472L,485L,498L,511L,524L,537L,550L,563L,576L,589L,602L,615L,628L,641L,654L,667L,680L,693L,706L,719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127547Inst : IEnumerable<long>
{
public static readonly long[] Value=A127547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127547.Bytes);
public long this[int i]=>Value[i];

public static A127547Inst Instance=new A127547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127546
{
public static readonly long[] Value={ 2L,6L,14L,38L,98L,258L,674L,1766L,4622L,12102L,31682L,82946L,217154L,568518L,1488398L,3896678L,10201634L,26708226L,69923042L,183060902L,479259662L,1254718086L,3284894594L,8599965698L,22515002498L,58945041798L,154320122894L,404015326886L,1057725857762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127546Inst : IEnumerable<long>
{
public static readonly long[] Value=A127546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127546.Bytes);
public long this[int i]=>Value[i];

public static A127546Inst Instance=new A127546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127545
{
public static readonly long[] Value={ 42L,420L,462L,882L,1050L,1092L,1302L,1428L,1722L,1932L,2142L,2268L,2310L,2688L,2730L,3360L,3528L,3822L,4158L,4242L,4788L,5418L,5502L,5880L,6090L,6132L,6300L,6552L,6762L,7308L,7350L,7560L,8232L,8820L,8862L,9240L,9282L,10038L,10332L,10458L,10500L,10710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127545Inst : IEnumerable<long>
{
public static readonly long[] Value=A127545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127545.Bytes);
public long this[int i]=>Value[i];

public static A127545Inst Instance=new A127545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127544
{
public static readonly long[] Value={ 30L,490L,3010L,12310L,715220L,831820L,1741630L,2323520L,7089500L,13848650L,26543660L,92669720L,133230930L,271248950L,541946240L,1844349560L,2841940500L,4351078600L,4835271870L,5371315400L,10015581680L,18440293320L,37027355200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127544Inst : IEnumerable<long>
{
public static readonly long[] Value=A127544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127544.Bytes);
public long this[int i]=>Value[i];

public static A127544Inst Instance=new A127544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127495
{
public static readonly long[] Value={ 23L,28L,43L,65L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127495Inst : IEnumerable<long>
{
public static readonly long[] Value=A127495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127495.Bytes);
public long this[int i]=>Value[i];

public static A127495Inst Instance=new A127495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127494
{
public static readonly long[] Value={ 2L,3L,11L,7L,47L,23L,83L,59L,227L,383L,263L,419L,587L,563L,911L,599L,947L,743L,983L,887L,1019L,1031L,1163L,1607L,1307L,1931L,1451L,5531L,1487L,6827L,1523L,6863L,1559L,6899L,2459L,7043L,3359L,7079L,4259L,12263L,4583L,13163L,5483L,13487L,5519L,13523L,5843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127494Inst : IEnumerable<long>
{
public static readonly long[] Value=A127494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127494.Bytes);
public long this[int i]=>Value[i];

public static A127494Inst Instance=new A127494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127493
{
public static readonly long[] Value={ 1L,5L,8L,9L,22L,29L,45L,49L,60L,69L,87L,89L,90L,107L,114L,124L,125L,131L,134L,138L,145L,156L,171L,183L,188L,191L,203L,204L,207L,212L,219L,255L,261L,290L,298L,303L,329L,330L,343L,344L,349L,354L,378L,397L,398L,400L,403L,454L,456L,466L,474L,515L,549L,560L,570L,578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127493Inst : IEnumerable<long>
{
public static readonly long[] Value=A127493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127493.Bytes);
public long this[int i]=>Value[i];

public static A127493Inst Instance=new A127493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127492
{
public static readonly long[] Value={ 2L,10L,17L,49L,71L,72L,75L,145L,161L,167L,170L,184L,244L,250L,257L,266L,267L,282L,286L,301L,307L,325L,343L,391L,405L,429L,450L,537L,556L,561L,584L,685L,710L,743L,790L,835L,861L,904L,928L,953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127492Inst : IEnumerable<long>
{
public static readonly long[] Value=A127492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127492.Bytes);
public long this[int i]=>Value[i];

public static A127492Inst Instance=new A127492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127491
{
public static readonly long[] Value={ 310733L,426871L,15722159L,166492163L,177861107L,270396557L,342955763L,406947461L,1606837039L,1908243773L,2902193117L,3386269021L,5441167877L,6953015807L,7671152921L,10005413687L,10979785673L,14774655421L,16546239937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127491Inst : IEnumerable<long>
{
public static readonly long[] Value=A127491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127491.Bytes);
public long this[int i]=>Value[i];

public static A127491Inst Instance=new A127491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127490
{
public static readonly long[] Value={ 2927L,342889L,2760049L,5070049L,321039529L,1146272329L,9936508189L,14927726089L,37769930377L,79361849257L,222647590729L,246738487669L,259512888949L,636714780049L,818804190829L,1204024293601L,1265682003121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127490Inst : IEnumerable<long>
{
public static readonly long[] Value=A127490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127490.Bytes);
public long this[int i]=>Value[i];

public static A127490Inst Instance=new A127490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127489
{
public static readonly long[] Value={ 2927L,12673L,48457L,136489L,342889L,745945L,1480489L,2760049L,5070049L,8292889L,12185065L,18656761L,27138729L,37294369L,53106049L,73698049L,95048089L,120087129L,153503149L,192747937L,247731385L,321039529L,396584569L,485290729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127489Inst : IEnumerable<long>
{
public static readonly long[] Value=A127489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127489.Bytes);
public long this[int i]=>Value[i];

public static A127489Inst Instance=new A127489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127488
{
public static readonly BigInteger[] Value={ 6L,30240L,435891456000L,BigInteger.Parse("64630041847212441600000"),BigInteger.Parse("258328699159653623241666283438080000000") };
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
public class A127488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127488Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127488.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127488.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127488Inst Instance=new A127488Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127487
{
public static readonly long[] Value={ 2L,7L,13L,47L,113L,163L,167L,197L,233L,307L,317L,373L,547L,617L,797L,827L,863L,937L,1087L,1213L,1223L,1367L,1483L,1567L,1597L,1783L,1787L,2003L,2063L,2087L,2137L,2203L,2333L,2393L,2437L,2543L,2617L,2693L,2777L,2903L,3037L,3067L,3163L,3347L,3463L,3583L,3607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127487Inst : IEnumerable<long>
{
public static readonly long[] Value=A127487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127487.Bytes);
public long this[int i]=>Value[i];

public static A127487Inst Instance=new A127487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127486
{
public static readonly long[] Value={ 1L,22L,13077L,14267L,16092L,16267L,16282L,36387L,47012L,51912L,54662L,144487L,181777L,205897L,210022L,213982L,250517L,263717L,344092L,409697L,454607L,568777L,643677L,665917L,702947L,749967L,824167L,858187L,887677L,888427L,997787L,1075537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127486Inst : IEnumerable<long>
{
public static readonly long[] Value=A127486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127486.Bytes);
public long this[int i]=>Value[i];

public static A127486Inst Instance=new A127486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127485
{
public static readonly long[] Value={ 1L,2L,13L,22L,23L,98L,253L,343L,573L,638L,702L,1322L,1862L,2543L,2638L,2758L,2792L,2912L,3093L,3158L,3242L,3578L,3968L,4382L,5013L,6503L,7048L,7877L,8372L,8912L,9022L,9207L,10298L,10443L,11538L,12482L,13077L,13078L,13868L,14267L,14268L,14323L,14783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127485Inst : IEnumerable<long>
{
public static readonly long[] Value=A127485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127485.Bytes);
public long this[int i]=>Value[i];

public static A127485Inst Instance=new A127485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127484
{
public static readonly long[] Value={ 1L,2L,3L,8L,13L,14L,22L,23L,24L,34L,38L,64L,98L,99L,133L,147L,153L,178L,232L,253L,254L,297L,328L,343L,344L,367L,407L,498L,573L,574L,582L,587L,624L,638L,639L,653L,668L,679L,702L,703L,759L,772L,793L,797L,849L,874L,944L,958L,1023L,1058L,1067L,1087L,1203L,1212L,1322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127484Inst : IEnumerable<long>
{
public static readonly long[] Value=A127484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127484.Bytes);
public long this[int i]=>Value[i];

public static A127484Inst Instance=new A127484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127483
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,9L,13L,14L,15L,17L,22L,23L,24L,25L,30L,32L,34L,35L,38L,39L,42L,45L,50L,58L,60L,64L,65L,79L,83L,85L,88L,90L,92L,94L,98L,99L,100L,102L,113L,115L,122L,125L,127L,130L,133L,134L,137L,140L,144L,147L,148L,153L,154L,157L,164L,167L,170L,178L,179L,184L,190L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127483Inst : IEnumerable<long>
{
public static readonly long[] Value=A127483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127483.Bytes);
public long this[int i]=>Value[i];

public static A127483Inst Instance=new A127483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127482
{
public static readonly long[] Value={ 2L,6L,30L,210L,210L,630L,4410L,39690L,238140L,4286520L,12859560L,270050760L,1080203040L,12962436480L,362948221440L,5444223321600L,244990049472000L,1469940296832000L,61737492466944000L,432162447268608000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127482Inst : IEnumerable<long>
{
public static readonly long[] Value=A127482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127482.Bytes);
public long this[int i]=>Value[i];

public static A127482Inst Instance=new A127482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127481
{
public static readonly long[] Value={ 1L,3L,2L,4L,0L,6L,7L,6L,0L,8L,6L,0L,0L,0L,20L,12L,8L,18L,0L,0L,12L,8L,0L,0L,0L,0L,0L,42L,15L,14L,0L,24L,0L,0L,0L,32L,13L,0L,24L,0L,0L,0L,0L,0L,54L,18L,12L,0L,0L,60L,0L,0L,0L,0L,40L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,110L,28L,24L,42L,32L,0L,36L,0L,0L,0L,0L,0L,48L,14L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127481Inst : IEnumerable<long>
{
public static readonly long[] Value=A127481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127481.Bytes);
public long this[int i]=>Value[i];

public static A127481Inst Instance=new A127481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127480
{
public static readonly long[] Value={ 0L,2L,1L,4L,4L,6L,14L,8L,5L,14L,3L,10L,11L,12L,52L,18L,54L,20L,34L,22L,27L,34L,45L,24L,18L,16L,84L,26L,61L,28L,160L,30L,147L,32L,444L,36L,647L,44L,47L,42L,311L,40L,33L,52L,851L,48L,224L,38L,82L,72L,41L,50L,216L,62L,148L,54L,728L,60L,89L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127480Inst : IEnumerable<long>
{
public static readonly long[] Value=A127480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127480.Bytes);
public long this[int i]=>Value[i];

public static A127480Inst Instance=new A127480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127431
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,3L,5L,5L,4L,4L,7L,3L,6L,8L,5L,5L,6L,5L,8L,8L,5L,6L,10L,5L,8L,8L,9L,7L,7L,8L,9L,9L,8L,9L,12L,5L,8L,12L,8L,9L,10L,7L,13L,9L,13L,11L,10L,7L,9L,12L,11L,9L,11L,10L,18L,8L,8L,10L,16L,10L,9L,12L,11L,11L,14L,13L,13L,12L,10L,15L,12L,10L,15L,11L,15L,12L,11L,13L,14L,12L,12L,13L,18L,9L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127431Inst : IEnumerable<long>
{
public static readonly long[] Value=A127431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127431.Bytes);
public long this[int i]=>Value[i];

public static A127431Inst Instance=new A127431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127430
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,17L,31L,41L,59L,71L,73L,97L,113L,139L,157L,193L,239L,269L,277L,311L,337L,349L,421L,449L,487L,577L,587L,619L,643L,701L,811L,823L,827L,941L,977L,1021L,1051L,1093L,1217L,1249L,1259L,1361L,1373L,1471L,1571L,1721L,1723L,1747L,1777L,1789L,1861L,1907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127430Inst : IEnumerable<long>
{
public static readonly long[] Value=A127430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127430.Bytes);
public long this[int i]=>Value[i];

public static A127430Inst Instance=new A127430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127429
{
public static readonly BigInteger[] Value={ 0L,0L,0L,2L,40L,904L,32048L,2092112L,268395136L,68719113856L,35184368460032L,36028796979047168L,BigInteger.Parse("73786976294359204864"),BigInteger.Parse("302231454903651066655744"),BigInteger.Parse("2475880078570760462619957248"),BigInteger.Parse("40564819207303340846586828204032"),BigInteger.Parse("1329227995784915872903786137490456576") };
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
public class A127429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127429.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127429Inst Instance=new A127429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127428
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,29L,30L,31L,32L,33L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,66L,67L,68L,69L,70L,72L,73L,74L,75L,76L,80L,81L,82L,83L,84L,86L,87L,88L,89L,90L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127428Inst : IEnumerable<long>
{
public static readonly long[] Value=A127428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127428.Bytes);
public long this[int i]=>Value[i];

public static A127428Inst Instance=new A127428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127427
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,8L,9L,10L,12L,13L,14L,16L,17L,18L,22L,23L,24L,26L,27L,28L,30L,31L,32L,35L,36L,37L,39L,40L,41L,43L,44L,45L,48L,49L,50L,52L,53L,54L,56L,57L,58L,63L,64L,65L,67L,68L,69L,71L,72L,73L,76L,77L,78L,80L,81L,82L,84L,85L,86L,89L,90L,91L,93L,94L,95L,97L,98L,99L,103L,104L,105L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127427Inst : IEnumerable<long>
{
public static readonly long[] Value=A127427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127427.Bytes);
public long this[int i]=>Value[i];

public static A127427Inst Instance=new A127427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127426
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,8L,64L,504L,4132L,36224L,343197L,3528800L,39382654L,476015616L,6209617492L,87072877696L,1307012632486L,20918494920704L,355658666311252L,6402175346437632L,121643693845767057L,2432891768176640000L,BigInteger.Parse("51090865734892274539"),BigInteger.Parse("1124000143459306268672") };
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
public class A127426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127426Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127426.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127426Inst Instance=new A127426Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127425
{
public static readonly BigInteger[] Value={ 0L,0L,29L,12528L,14927013L,44632974375L,289553896419667L,3621335176611561472L,BigInteger.Parse("79763800168579144103361"),BigInteger.Parse("2886490238072828615188093125"),BigInteger.Parse("162510049064391484117789761805165"),BigInteger.Parse("13624190843866457706897020192739557376"),BigInteger.Parse("1640800492737366435568874082163705520197134") };
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
public class A127425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127425Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127425.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127425.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127425Inst Instance=new A127425Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127424
{
public static readonly long[] Value={ 210L,321L,432L,543L,654L,765L,876L,987L,1098L,11109L,121110L,131211L,141312L,151413L,161514L,171615L,181716L,191817L,201918L,212019L,222120L,232221L,242322L,252423L,262524L,272625L,282726L,292827L,302928L,313029L,323130L,333231L,343332L,353433L,363534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127424Inst : IEnumerable<long>
{
public static readonly long[] Value=A127424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127424.Bytes);
public long this[int i]=>Value[i];

public static A127424Inst Instance=new A127424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127423
{
public static readonly long[] Value={ 1L,21L,32L,43L,54L,65L,76L,87L,98L,109L,1110L,1211L,1312L,1413L,1514L,1615L,1716L,1817L,1918L,2019L,2120L,2221L,2322L,2423L,2524L,2625L,2726L,2827L,2928L,3029L,3130L,3231L,3332L,3433L,3534L,3635L,3736L,3837L,3938L,4039L,4140L,4241L,4342L,4443L,4544L,4645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127423Inst : IEnumerable<long>
{
public static readonly long[] Value=A127423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127423.Bytes);
public long this[int i]=>Value[i];

public static A127423Inst Instance=new A127423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127422
{
public static readonly long[] Value={ 12L,123L,234L,345L,456L,567L,678L,789L,8910L,91011L,101112L,111213L,121314L,131415L,141516L,151617L,161718L,171819L,181920L,192021L,202122L,212223L,222324L,232425L,242526L,252627L,262728L,272829L,282930L,293031L,303132L,313233L,323334L,333435L,343536L,353637L,363738L,373839L,383940L,394041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127422Inst : IEnumerable<long>
{
public static readonly long[] Value=A127422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127422.Bytes);
public long this[int i]=>Value[i];

public static A127422Inst Instance=new A127422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127421
{
public static readonly long[] Value={ 1L,12L,23L,34L,45L,56L,67L,78L,89L,910L,1011L,1112L,1213L,1314L,1415L,1516L,1617L,1718L,1819L,1920L,2021L,2122L,2223L,2324L,2425L,2526L,2627L,2728L,2829L,2930L,3031L,3132L,3233L,3334L,3435L,3536L,3637L,3738L,3839L,3940L,4041L,4142L,4243L,4344L,4445L,4546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127421Inst : IEnumerable<long>
{
public static readonly long[] Value=A127421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127421.Bytes);
public long this[int i]=>Value[i];

public static A127421Inst Instance=new A127421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127420
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,4L,2L,2L,1L,9L,5L,5L,3L,1L,1L,24L,15L,15L,10L,5L,5L,2L,1L,77L,53L,53L,38L,23L,23L,13L,8L,3L,3L,1L,295L,218L,218L,165L,112L,112L,74L,51L,28L,28L,15L,7L,4L,1L,1L,1329L,1034L,1034L,816L,598L,598L,433L,321L,209L,209L,135L,84L,56L,28L,28L,13L,6L,2L,1L,6934L,5605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127420Inst : IEnumerable<long>
{
public static readonly long[] Value=A127420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127420.Bytes);
public long this[int i]=>Value[i];

public static A127420Inst Instance=new A127420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127419
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,15L,19L,24L,30L,37L,45L,53L,62L,72L,83L,95L,108L,122L,137L,153L,169L,186L,204L,223L,243L,264L,286L,309L,333L,358L,384L,411L,439L,468L,498L,529L,561L,593L,626L,660L,695L,731L,768L,806L,845L,885L,926L,968L,1011L,1055L,1100L,1146L,1193L,1241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127419Inst : IEnumerable<long>
{
public static readonly long[] Value=A127419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127419.Bytes);
public long this[int i]=>Value[i];

public static A127419Inst Instance=new A127419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127418
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,5L,3L,6L,4L,7L,3L,10L,8L,8L,10L,11L,7L,11L,10L,13L,13L,14L,10L,18L,15L,16L,16L,17L,13L,20L,20L,16L,23L,21L,17L,25L,24L,21L,23L,25L,19L,30L,25L,25L,25L,29L,23L,36L,29L,29L,32L,33L,26L,41L,28L,37L,32L,37L,30L,41L,32L,41L,33L,42L,32L,51L,36L,44L,39L,43L,38L,52L,41L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127418Inst : IEnumerable<long>
{
public static readonly long[] Value=A127418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127418.Bytes);
public long this[int i]=>Value[i];

public static A127418Inst Instance=new A127418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127417
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,3L,2L,2L,4L,3L,1L,4L,3L,2L,5L,2L,4L,4L,1L,2L,6L,4L,1L,6L,3L,3L,5L,2L,4L,3L,4L,3L,6L,4L,2L,3L,5L,5L,4L,3L,3L,7L,2L,2L,7L,4L,3L,5L,3L,4L,5L,6L,3L,3L,4L,2L,6L,6L,4L,6L,4L,5L,3L,3L,5L,5L,3L,3L,7L,6L,2L,6L,5L,4L,5L,2L,5L,8L,1L,5L,6L,5L,1L,6L,7L,3L,9L,2L,4L,5L,2L,5L,6L,6L,5L,5L,4L,4L,6L,4L,4L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127417Inst : IEnumerable<long>
{
public static readonly long[] Value=A127417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127417.Bytes);
public long this[int i]=>Value[i];

public static A127417Inst Instance=new A127417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127416
{
public static readonly long[] Value={ 1L,1L,4L,6L,17L,10L,41L,28L,54L,40L,122L,44L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127416Inst : IEnumerable<long>
{
public static readonly long[] Value=A127416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127416.Bytes);
public long this[int i]=>Value[i];

public static A127416Inst Instance=new A127416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127383
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,15L,46L,141L,446L,1427L,4722L,15884L,54224L,187380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127383Inst : IEnumerable<long>
{
public static readonly long[] Value=A127383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127383.Bytes);
public long this[int i]=>Value[i];

public static A127383Inst Instance=new A127383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127382
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,13L,12L,14L,15L,19L,21L,18L,16L,22L,20L,17L,23L,24L,25L,27L,26L,28L,29L,33L,35L,32L,30L,36L,34L,31L,37L,38L,39L,41L,40L,51L,52L,56L,58L,46L,47L,59L,50L,49L,42L,43L,60L,62L,55L,53L,64L,57L,48L,44L,63L,61L,54L,45L,65L,66L,67L,69L,68L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127382Inst : IEnumerable<long>
{
public static readonly long[] Value=A127382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127382.Bytes);
public long this[int i]=>Value[i];

public static A127382Inst Instance=new A127382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127381
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,13L,12L,14L,15L,19L,22L,18L,16L,21L,17L,20L,23L,24L,25L,27L,26L,28L,29L,33L,36L,32L,30L,35L,31L,34L,37L,38L,39L,41L,40L,51L,52L,60L,64L,46L,47L,59L,50L,49L,42L,43L,56L,63L,55L,44L,58L,45L,48L,53L,62L,54L,61L,57L,65L,66L,67L,69L,68L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127381Inst : IEnumerable<long>
{
public static readonly long[] Value=A127381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127381.Bytes);
public long this[int i]=>Value[i];

public static A127381Inst Instance=new A127381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127380
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,13L,12L,14L,15L,19L,21L,22L,16L,20L,18L,17L,23L,24L,25L,27L,26L,28L,29L,33L,35L,36L,30L,34L,32L,31L,37L,38L,39L,41L,40L,51L,52L,56L,58L,59L,60L,62L,64L,63L,42L,43L,53L,54L,55L,47L,61L,49L,50L,44L,57L,48L,46L,45L,65L,66L,67L,69L,68L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127380Inst : IEnumerable<long>
{
public static readonly long[] Value=A127380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127380.Bytes);
public long this[int i]=>Value[i];

public static A127380Inst Instance=new A127380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127379
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,13L,12L,14L,15L,19L,22L,21L,16L,20L,17L,18L,23L,24L,25L,27L,26L,28L,29L,33L,36L,35L,30L,34L,31L,32L,37L,38L,39L,41L,40L,51L,52L,60L,64L,63L,56L,62L,58L,59L,42L,43L,53L,54L,55L,44L,61L,45L,46L,47L,57L,48L,50L,49L,65L,66L,67L,69L,68L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127379Inst : IEnumerable<long>
{
public static readonly long[] Value=A127379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127379.Bytes);
public long this[int i]=>Value[i];

public static A127379Inst Instance=new A127379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127378
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,6L,5L,4L,17L,18L,20L,22L,21L,14L,15L,19L,12L,13L,16L,11L,10L,9L,45L,46L,48L,50L,49L,54L,55L,61L,63L,64L,57L,62L,59L,58L,37L,38L,39L,41L,40L,51L,52L,56L,31L,32L,60L,34L,36L,35L,42L,43L,53L,28L,29L,47L,33L,26L,27L,44L,30L,25L,24L,23L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127378Inst : IEnumerable<long>
{
public static readonly long[] Value=A127378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127378.Bytes);
public long this[int i]=>Value[i];

public static A127378Inst Instance=new A127378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127377
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,6L,4L,5L,22L,21L,20L,17L,18L,14L,15L,19L,9L,10L,16L,11L,13L,12L,64L,63L,62L,58L,59L,54L,55L,61L,45L,46L,57L,48L,50L,49L,37L,38L,39L,41L,40L,51L,52L,60L,23L,24L,56L,25L,27L,26L,42L,43L,53L,28L,29L,44L,33L,36L,35L,47L,30L,34L,31L,32L,196L,195L,194L,189L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127377Inst : IEnumerable<long>
{
public static readonly long[] Value=A127377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127377.Bytes);
public long this[int i]=>Value[i];

public static A127377Inst Instance=new A127377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127376
{
public static readonly long[] Value={ 1L,2L,3L,11L,6L,7L,1L,9L,4L,5L,6L,14L,2L,3L,4L,12L,7L,1L,2L,10L,5L,6L,7L,8L,3L,4L,5L,13L,1L,2L,3L,11L,6L,7L,1L,9L,4L,5L,6L,14L,2L,3L,4L,12L,7L,1L,2L,10L,5L,6L,7L,8L,3L,4L,5L,13L,1L,2L,3L,11L,6L,7L,1L,9L,4L,5L,6L,14L,2L,3L,4L,12L,7L,1L,2L,10L,5L,6L,7L,8L,3L,4L,5L,13L,1L,2L,3L,11L,6L,7L,1L,9L,4L,5L,6L,14L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127376Inst : IEnumerable<long>
{
public static readonly long[] Value=A127376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127376.Bytes);
public long this[int i]=>Value[i];

public static A127376Inst Instance=new A127376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127375
{
public static readonly long[] Value={ 1L,3L,0L,4L,1L,0L,7L,0L,1L,0L,6L,1L,1L,1L,0L,12L,0L,0L,1L,0L,8L,1L,1L,1L,1L,1L,0L,15L,0L,3L,0L,1L,0L,1L,0L,13L,4L,0L,1L,1L,0L,1L,1L,0L,18L,2L,3L,2L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127375Inst : IEnumerable<long>
{
public static readonly long[] Value=A127375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127375.Bytes);
public long this[int i]=>Value[i];

public static A127375Inst Instance=new A127375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127374
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,0L,4L,0L,1L,0L,5L,1L,1L,1L,0L,6L,1L,0L,0L,1L,0L,7L,1L,1L,1L,1L,1L,0L,8L,0L,2L,0L,1L,0L,1L,0L,9L,3L,0L,1L,1L,0L,1L,1L,0L,10L,1L,2L,1L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127374Inst : IEnumerable<long>
{
public static readonly long[] Value=A127374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127374.Bytes);
public long this[int i]=>Value[i];

public static A127374Inst Instance=new A127374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127373
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,3L,0L,1L,0L,6L,2L,1L,1L,0L,5L,0L,0L,0L,1L,0L,12L,4L,2L,1L,1L,1L,0L,13L,0L,1L,0L,1L,0L,1L,0L,18L,4L,0L,2L,1L,0L,1L,1L,0L,15L,0L,3L,0L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127373Inst : IEnumerable<long>
{
public static readonly long[] Value=A127373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127373.Bytes);
public long this[int i]=>Value[i];

public static A127373Inst Instance=new A127373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127372
{
public static readonly long[] Value={ 1L,3L,0L,3L,1L,0L,6L,0L,1L,0L,3L,1L,1L,1L,0L,9L,2L,0L,0L,1L,0L,3L,1L,1L,1L,1L,1L,0L,10L,0L,3L,0L,1L,0L,1L,0L,6L,3L,0L,1L,1L,0L,1L,1L,0L,9L,2L,3L,2L,0L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127372Inst : IEnumerable<long>
{
public static readonly long[] Value=A127372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127372.Bytes);
public long this[int i]=>Value[i];

public static A127372Inst Instance=new A127372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127371
{
public static readonly long[] Value={ 1L,2L,0L,2L,1L,0L,3L,0L,1L,0L,2L,1L,1L,1L,0L,4L,1L,0L,0L,1L,0L,2L,1L,1L,1L,1L,1L,0L,4L,0L,2L,0L,1L,0L,1L,0L,3L,2L,0L,1L,1L,0L,1L,1L,0L,4L,1L,2L,1L,0L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127371Inst : IEnumerable<long>
{
public static readonly long[] Value=A127371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127371.Bytes);
public long this[int i]=>Value[i];

public static A127371Inst Instance=new A127371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127370
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,6L,7L,4L,2L,5L,11L,4L,6L,7L,11L,8L,5L,18L,19L,6L,6L,7L,19L,12L,12L,13L,18L,19L,12L,12L,16L,16L,10L,16L,14L,18L,17L,26L,32L,35L,11L,39L,22L,15L,30L,31L,19L,45L,25L,34L,51L,22L,24L,22L,19L,52L,53L,29L,32L,57L,31L,34L,59L,17L,45L,26L,34L,26L,35L,47L,36L,30L,37L,45L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127370Inst : IEnumerable<long>
{
public static readonly long[] Value=A127370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127370.Bytes);
public long this[int i]=>Value[i];

public static A127370Inst Instance=new A127370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127369
{
public static readonly long[] Value={ 8L,160L,1920L,17408L,133120L,909312L,5734400L,34078720L,193462272L,1059061760L,5628755968L,29192355840L,148310589440L,740344987648L,3639984783360L,17660905521152L,84696755077120L,402008938905600L,1890610243960832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127369Inst : IEnumerable<long>
{
public static readonly long[] Value=A127369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127369.Bytes);
public long this[int i]=>Value[i];

public static A127369Inst Instance=new A127369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127368
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,0L,3L,0L,1L,2L,3L,4L,0L,1L,0L,0L,0L,5L,0L,1L,2L,3L,4L,5L,6L,0L,1L,0L,3L,0L,5L,0L,7L,0L,1L,2L,0L,4L,5L,0L,7L,8L,0L,1L,0L,3L,0L,0L,0L,7L,0L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,0L,0L,0L,5L,0L,7L,0L,0L,0L,11L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127368Inst : IEnumerable<long>
{
public static readonly long[] Value=A127368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127368.Bytes);
public long this[int i]=>Value[i];

public static A127368Inst Instance=new A127368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127335
{
public static readonly long[] Value={ 77L,98L,124L,150L,180L,210L,240L,270L,304L,340L,372L,408L,442L,474L,510L,546L,582L,620L,660L,696L,732L,768L,802L,846L,888L,928L,966L,1012L,1056L,1104L,1154L,1194L,1236L,1278L,1320L,1362L,1404L,1444L,1480L,1524L,1574L,1622L,1670L,1712L,1758L,1802L,1854L,1900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127335Inst : IEnumerable<long>
{
public static readonly long[] Value=A127335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127335.Bytes);
public long this[int i]=>Value[i];

public static A127335Inst Instance=new A127335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127334
{
public static readonly long[] Value={ 58L,75L,95L,119L,143L,169L,197L,223L,251L,281L,311L,341L,371L,401L,431L,463L,493L,523L,559L,593L,625L,659L,689L,719L,757L,791L,827L,863L,905L,947L,991L,1027L,1063L,1099L,1139L,1171L,1211L,1247L,1281L,1313L,1351L,1395L,1441L,1479L,1519L,1561L,1603L,1643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127334Inst : IEnumerable<long>
{
public static readonly long[] Value=A127334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127334.Bytes);
public long this[int i]=>Value[i];

public static A127334Inst Instance=new A127334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127333
{
public static readonly long[] Value={ 41L,56L,72L,90L,112L,132L,156L,180L,204L,228L,252L,280L,304L,330L,358L,384L,410L,434L,462L,492L,522L,552L,580L,606L,630L,660L,690L,724L,756L,796L,834L,864L,896L,926L,960L,990L,1020L,1054L,1084L,1114L,1140L,1172L,1214L,1250L,1286L,1322L,1362L,1392L,1420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127333Inst : IEnumerable<long>
{
public static readonly long[] Value=A127333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127333.Bytes);
public long this[int i]=>Value[i];

public static A127333Inst Instance=new A127333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127332
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,5L,4L,4L,5L,9L,1L,10L,8L,3L,7L,15L,3L,16L,2L,6L,17L,21L,-6L,13L,19L,11L,8L,27L,-5L,27L,10L,13L,28L,10L,-10L,35L,31L,17L,-6L,40L,-3L,40L,20L,-4L,40L,44L,-18L,32L,18L,26L,23L,50L,4L,21L,0L,28L,54L,58L,-45L,59L,53L,3L,19L,24L,11L,65L,37L,39L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127332Inst : IEnumerable<long>
{
public static readonly long[] Value=A127332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127332.Bytes);
public long this[int i]=>Value[i];

public static A127332Inst Instance=new A127332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127331
{
public static readonly long[] Value={ 2L,5L,11L,29L,31L,61L,71L,101L,109L,199L,229L,241L,269L,331L,379L,431L,491L,631L,691L,821L,919L,941L,991L,1049L,1061L,1259L,1289L,1321L,1409L,1439L,1451L,1459L,1571L,1621L,1831L,1861L,1931L,2039L,2089L,2161L,2251L,2281L,2311L,2389L,2399L,2441L,2539L,2551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127331Inst : IEnumerable<long>
{
public static readonly long[] Value=A127331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127331.Bytes);
public long this[int i]=>Value[i];

public static A127331Inst Instance=new A127331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127330
{
public static readonly long[] Value={ 0L,2L,3L,6L,7L,8L,14L,15L,16L,17L,30L,31L,32L,33L,34L,62L,63L,64L,65L,66L,67L,126L,127L,128L,129L,130L,131L,132L,254L,255L,256L,257L,258L,259L,260L,261L,510L,511L,512L,513L,514L,515L,516L,517L,518L,1022L,1023L,1024L,1025L,1026L,1027L,1028L,1029L,1030L,1031L,2046L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127330Inst : IEnumerable<long>
{
public static readonly long[] Value=A127330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127330.Bytes);
public long this[int i]=>Value[i];

public static A127330Inst Instance=new A127330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127329
{
public static readonly long[] Value={ 15L,21L,33L,39L,51L,57L,69L,87L,93L,111L,123L,129L,141L,159L,177L,183L,201L,213L,219L,237L,249L,267L,291L,303L,309L,321L,327L,339L,381L,393L,411L,417L,447L,453L,471L,489L,501L,519L,537L,543L,573L,579L,591L,597L,633L,669L,681L,687L,699L,717L,723L,753L,771L,789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127329Inst : IEnumerable<long>
{
public static readonly long[] Value=A127329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127329.Bytes);
public long this[int i]=>Value[i];

public static A127329Inst Instance=new A127329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127328
{
public static readonly long[] Value={ 1L,0L,3L,3L,15L,30L,99L,252L,747L,2064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127328Inst : IEnumerable<long>
{
public static readonly long[] Value=A127328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127328.Bytes);
public long this[int i]=>Value[i];

public static A127328Inst Instance=new A127328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127327
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,3L,3L,3L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,4L,4L,4L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127327Inst : IEnumerable<long>
{
public static readonly long[] Value=A127327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127327.Bytes);
public long this[int i]=>Value[i];

public static A127327Inst Instance=new A127327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127326
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,0L,0L,2L,1L,1L,0L,0L,0L,0L,1L,0L,0L,2L,1L,1L,0L,0L,0L,3L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,2L,1L,1L,0L,0L,0L,3L,2L,2L,1L,1L,1L,0L,0L,0L,0L,4L,3L,3L,2L,2L,2L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,2L,1L,1L,0L,0L,0L,3L,2L,2L,1L,1L,1L,0L,0L,0L,0L,4L,3L,3L,2L,2L,2L,1L,1L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127326Inst : IEnumerable<long>
{
public static readonly long[] Value=A127326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127326.Bytes);
public long this[int i]=>Value[i];

public static A127326Inst Instance=new A127326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127325
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,0L,1L,0L,2L,1L,0L,3L,2L,1L,0L,4L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127325Inst : IEnumerable<long>
{
public static readonly long[] Value=A127325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127325.Bytes);
public long this[int i]=>Value[i];

public static A127325Inst Instance=new A127325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127324
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,2L,0L,0L,0L,1L,0L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,0L,0L,1L,0L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,4L,0L,0L,0L,1L,0L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,0L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127324Inst : IEnumerable<long>
{
public static readonly long[] Value=A127324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127324.Bytes);
public long this[int i]=>Value[i];

public static A127324Inst Instance=new A127324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127323
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,2L,2L,2L,0L,0L,1L,1L,0L,1L,1L,2L,2L,2L,0L,1L,1L,2L,2L,2L,3L,3L,3L,3L,0L,0L,1L,1L,0L,1L,1L,2L,2L,2L,0L,1L,1L,2L,2L,2L,3L,3L,3L,3L,0L,1L,1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,0L,0L,1L,1L,0L,1L,1L,2L,2L,2L,0L,1L,1L,2L,2L,2L,3L,3L,3L,3L,0L,1L,1L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127323Inst : IEnumerable<long>
{
public static readonly long[] Value=A127323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127323.Bytes);
public long this[int i]=>Value[i];

public static A127323Inst Instance=new A127323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127322
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127322Inst : IEnumerable<long>
{
public static readonly long[] Value=A127322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127322.Bytes);
public long this[int i]=>Value[i];

public static A127322Inst Instance=new A127322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127321
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127321Inst : IEnumerable<long>
{
public static readonly long[] Value=A127321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127321.Bytes);
public long this[int i]=>Value[i];

public static A127321Inst Instance=new A127321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127320
{
public static readonly long[] Value={ 1L,2L,6L,4L,16L,26L,62L,42L,148L,284L,522L,545L,958L,569L,1684L,3379L,4984L,6780L,7352L,9222L,7973L,11567L,68929L,16782L,410732L,40859L,1005243L,406459L,2473172L,1643473L,15048450L,10921212L,137791026L,79259241L,173848531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127320Inst : IEnumerable<long>
{
public static readonly long[] Value=A127320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127320.Bytes);
public long this[int i]=>Value[i];

public static A127320Inst Instance=new A127320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127159
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,3L,4L,4L,4L,4L,7L,5L,8L,5L,7L,11L,11L,10L,10L,11L,11L,21L,16L,21L,12L,21L,16L,21L,36L,36L,28L,28L,28L,28L,36L,36L,71L,57L,64L,36L,56L,36L,64L,57L,71L,127L,127L,93L,93L,72L,72L,93L,93L,127L,127L,253L,211L,220L,130L,165L,90L,165L,130L,220L,211L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127159Inst : IEnumerable<long>
{
public static readonly long[] Value=A127159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127159.Bytes);
public long this[int i]=>Value[i];

public static A127159Inst Instance=new A127159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127158
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,3L,0L,1L,3L,5L,5L,0L,1L,7L,18L,9L,7L,0L,1L,20L,52L,37L,13L,9L,0L,1L,59L,168L,113L,60L,17L,11L,0L,1L,184L,546L,388L,190L,87L,21L,13L,0L,1L,593L,1826L,1313L,688L,283L,118L,25L,15L,0L,1L,1964L,6211L,4545L,2408L,1076L,392L,153L,29L,17L,0L,1L,6642L,21459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127158Inst : IEnumerable<long>
{
public static readonly long[] Value=A127158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127158.Bytes);
public long this[int i]=>Value[i];

public static A127158Inst Instance=new A127158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127157
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,10L,5L,30L,7L,6L,70L,56L,7L,140L,252L,30L,8L,252L,840L,330L,9L,420L,2310L,1980L,143L,10L,660L,5544L,8580L,2002L,11L,990L,12012L,30030L,15015L,728L,12L,1430L,24024L,90090L,80080L,12376L,13L,2002L,45045L,240240L,340340L,111384L,3876L,14L,2730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127157Inst : IEnumerable<long>
{
public static readonly long[] Value=A127157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127157.Bytes);
public long this[int i]=>Value[i];

public static A127157Inst Instance=new A127157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127156
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,2L,1L,5L,2L,3L,3L,1L,19L,7L,5L,6L,4L,1L,67L,26L,12L,11L,10L,5L,1L,232L,93L,38L,23L,21L,15L,6L,1L,804L,325L,131L,61L,44L,36L,21L,7L,1L,2806L,1129L,456L,192L,105L,80L,57L,28L,8L,1L,9878L,3935L,1585L,648L,297L,185L,137L,85L,36L,9L,1L,35072L,13813L,5520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127156Inst : IEnumerable<long>
{
public static readonly long[] Value=A127156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127156.Bytes);
public long this[int i]=>Value[i];

public static A127156Inst Instance=new A127156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127155
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,4L,1L,0L,10L,2L,1L,1L,0L,20L,12L,9L,1L,0L,35L,42L,47L,6L,1L,1L,0L,56L,112L,180L,64L,16L,1L,0L,84L,252L,558L,374L,148L,12L,1L,1L,0L,120L,504L,1482L,1580L,950L,200L,25L,1L,0L,165L,924L,3498L,5390L,4662L,1770L,365L,20L,1L,1L,0L,220L,1584L,7524L,15752L,18676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127155Inst : IEnumerable<long>
{
public static readonly long[] Value=A127155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127155.Bytes);
public long this[int i]=>Value[i];

public static A127155Inst Instance=new A127155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127154
{
public static readonly long[] Value={ 1L,1L,1L,4L,11L,33L,105L,343L,1148L,3916L,13563L,47571L,168625L,603130L,2174041L,7889617L,28801737L,105696489L,389703392L,1442880489L,5362540760L,19998684400L,74815202891L,280685489717L,1055820378931L,3981166990632L,15045322802905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127154Inst : IEnumerable<long>
{
public static readonly long[] Value=A127154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127154.Bytes);
public long this[int i]=>Value[i];

public static A127154Inst Instance=new A127154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127153
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,0L,1L,11L,2L,0L,1L,33L,6L,2L,0L,1L,105L,17L,7L,2L,0L,1L,343L,56L,19L,8L,2L,0L,1L,1148L,185L,64L,21L,9L,2L,0L,1L,3916L,624L,214L,72L,23L,10L,2L,0L,1L,13563L,2144L,726L,244L,80L,25L,11L,2L,0L,1L,47571L,7468L,2510L,832L,275L,88L,27L,12L,2L,0L,1L,168625L,26317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127153Inst : IEnumerable<long>
{
public static readonly long[] Value=A127153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127153.Bytes);
public long this[int i]=>Value[i];

public static A127153Inst Instance=new A127153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127152
{
public static readonly long[] Value={ 1L,2L,6L,20L,68L,232L,795L,2746L,9586L,33860L,121014L,437252L,1595324L,5869528L,21748408L,81060688L,303606864L,1141733024L,4307943856L,16300004128L,61819681632L,234929133504L,894335405016L,3409775718096L,13017932402704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127152Inst : IEnumerable<long>
{
public static readonly long[] Value=A127152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127152.Bytes);
public long this[int i]=>Value[i];

public static A127152Inst Instance=new A127152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127151
{
public static readonly long[] Value={ 1L,2L,4L,1L,8L,6L,16L,26L,32L,100L,64L,364L,1L,128L,1288L,14L,256L,4488L,118L,512L,15504L,780L,1024L,53296L,4466L,2048L,182688L,23276L,4096L,625184L,113620L,8192L,2137408L,528840L,16384L,7303360L,2375100L,1L,32768L,24946816L,10378056L,30L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127151Inst : IEnumerable<long>
{
public static readonly long[] Value=A127151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127151.Bytes);
public long this[int i]=>Value[i];

public static A127151Inst Instance=new A127151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127150
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,10L,19L,20L,22L,23L,24L,25L,26L,48L,54L,55L,56L,57L,62L,63L,67L,68L,70L,72L,127L,128L,129L,130L,131L,133L,134L,136L,138L,139L,140L,142L,147L,151L,155L,157L,158L,159L,162L,163L,166L,167L,168L,169L,173L,176L,178L,182L,187L,188L,189L,298L,300L,310L,311L,313L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127150Inst : IEnumerable<long>
{
public static readonly long[] Value=A127150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127150.Bytes);
public long this[int i]=>Value[i];

public static A127150Inst Instance=new A127150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127149
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,9L,10L,11L,13L,14L,17L,22L,23L,31L,35L,37L,39L,41L,45L,55L,63L,65L,69L,71L,74L,79L,82L,83L,84L,86L,87L,89L,97L,102L,109L,111L,118L,122L,132L,134L,139L,142L,143L,152L,153L,156L,157L,164L,166L,169L,171L,181L,182L,183L,184L,185L,187L,193L,197L,203L,209L,217L,235L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127149Inst : IEnumerable<long>
{
public static readonly long[] Value=A127149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127149.Bytes);
public long this[int i]=>Value[i];

public static A127149Inst Instance=new A127149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127148
{
public static readonly long[] Value={ -120L,-15L,48L,75L,72L,45L,0L,-57L,-120L,-183L,-240L,-285L,-312L,-315L,-288L,-225L,-120L,33L,240L,507L,840L,1245L,1728L,2295L,2952L,3705L,4560L,5523L,6600L,7797L,9120L,10575L,12168L,13905L,15792L,17835L,20040L,22413L,24960L,27687L,30600L,33705L,37008L,40515L,44232L,48165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127148Inst : IEnumerable<long>
{
public static readonly long[] Value=A127148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127148.Bytes);
public long this[int i]=>Value[i];

public static A127148Inst Instance=new A127148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127147
{
public static readonly long[] Value={ 43L,28L,15L,4L,-5L,-12L,-17L,-20L,-21L,-20L,-17L,-12L,-5L,4L,15L,28L,43L,60L,79L,100L,123L,148L,175L,204L,235L,268L,303L,340L,379L,420L,463L,508L,555L,604L,655L,708L,763L,820L,879L,940L,1003L,1068L,1135L,1204L,1275L,1348L,1423L,1500L,1579L,1660L,1743L,1828L,1915L,2004L,2095L,2188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127147Inst : IEnumerable<long>
{
public static readonly long[] Value=A127147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127147.Bytes);
public long this[int i]=>Value[i];

public static A127147Inst Instance=new A127147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127146
{
public static readonly long[] Value={ 12L,3L,-4L,-9L,-12L,-13L,-12L,-9L,-4L,3L,12L,23L,36L,51L,68L,87L,108L,131L,156L,183L,212L,243L,276L,311L,348L,387L,428L,471L,516L,563L,612L,663L,716L,771L,828L,887L,948L,1011L,1076L,1143L,1212L,1283L,1356L,1431L,1508L,1587L,1668L,1751L,1836L,1923L,2012L,2103L,2196L,2291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127146Inst : IEnumerable<long>
{
public static readonly long[] Value=A127146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127146.Bytes);
public long this[int i]=>Value[i];

public static A127146Inst Instance=new A127146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127145
{
public static readonly long[] Value={ 1L,1L,1L,-2L,-9L,4L,75L,24L,-735L,-816L,8505L,17760L,-114345L,-388800L,1756755L,9233280L,-30405375L,-242968320L,585810225L,7125511680L,-12439852425L,-232838323200L,288735522075L,8450546227200L,-7273385294175L,-339004760371200L,197646339515625L,14945696794828800L,-5763367260275625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127145Inst : IEnumerable<long>
{
public static readonly long[] Value=A127145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127145.Bytes);
public long this[int i]=>Value[i];

public static A127145Inst Instance=new A127145Inst();

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