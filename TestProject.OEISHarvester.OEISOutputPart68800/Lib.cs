using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A134701
{
public static readonly long[] Value={ 5L,5L,5L,5L,13L,283L,283L,1823L,443119823L,35332754383L,57704757113L,69478435945493L,2235755385712423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134701Inst : IEnumerable<long>
{
public static readonly long[] Value=A134701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134701.Bytes);
public long this[int i]=>Value[i];

public static A134701Inst Instance=new A134701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134702
{
public static readonly long[] Value={ 7L,11L,11L,11L,11L,11L,11L,11L,29614931L,29614931L,1172182334669L,67667595358511L,124204021800149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134702Inst : IEnumerable<long>
{
public static readonly long[] Value=A134702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134702.Bytes);
public long this[int i]=>Value[i];

public static A134702Inst Instance=new A134702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134703
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,24L,43L,63L,89L,132L,135L,153L,175L,209L,224L,226L,254L,258L,262L,263L,264L,267L,283L,308L,332L,333L,334L,347L,357L,370L,371L,372L,373L,374L,375L,376L,377L,378L,379L,407L,445L,463L,472L,518L,538L,598L,629L,635L,653L,675L,730L,731L,732L,733L,734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134703Inst : IEnumerable<long>
{
public static readonly long[] Value=A134703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134703.Bytes);
public long this[int i]=>Value[i];

public static A134703Inst Instance=new A134703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134704
{
public static readonly long[] Value={ 3L,3L,10L,9L,17L,40L,25L,103L,114L,141L,469L,264L,989L,1507L,1114L,5281L,3369L,8808L,19633L,9039L,56162L,48133L,71245L,245320L,89301L,555627L,700426L,512505L,2896001L,1203880L,5013385L,9831415L,3325650L,31944381L,19420165L,39925128L,130084109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134704Inst : IEnumerable<long>
{
public static readonly long[] Value=A134704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134704.Bytes);
public long this[int i]=>Value[i];

public static A134704Inst Instance=new A134704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134705
{
public static readonly BigInteger[] Value={ 3L,7L,62L,508L,1048448L,134216704L,1073739776L,9007199250546688L,BigInteger.Parse("5192296858534827626278696515534848"),BigInteger.Parse("187072209578355573530071658285452771612302071824384") };
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
public class A134705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134705.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134705Inst Instance=new A134705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134706
{
public static readonly BigInteger[] Value={ 2L,6L,61L,507L,1048447L,134216703L,1073739775L,9007199250546687L,BigInteger.Parse("5192296858534827626278696515534847"),BigInteger.Parse("187072209578355573530071658285452771612302071824383") };
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
public class A134706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134706Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134706.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134706.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134706Inst Instance=new A134706Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134707
{
public static readonly long[] Value={ 1L,3L,7L,11L,17L,23L,31L,39L,49L,59L,70L,81L,94L,107L,121L,136L,151L,167L,184L,202L,220L,239L,259L,279L,300L,322L,344L,367L,390L,415L,439L,465L,491L,518L,545L,573L,601L,631L,660L,691L,722L,753L,785L,818L,851L,885L,919L,954L,990L,1026L,1063L,1100L,1138L,1176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134707Inst : IEnumerable<long>
{
public static readonly long[] Value=A134707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134707.Bytes);
public long this[int i]=>Value[i];

public static A134707Inst Instance=new A134707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134708
{
public static readonly BigInteger[] Value={ 1L,2L,8L,32L,2048L,32768L,131072L,536870912L,576460752303423488L,BigInteger.Parse("154742504910672534362390528"),BigInteger.Parse("40564819207303340847894502572032"),BigInteger.Parse("42535295865117307932921825928971026432") };
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
public class A134708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134708Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134708.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134708.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134708Inst Instance=new A134708Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134709
{
public static readonly BigInteger[] Value={ 0L,1L,7L,31L,2047L,32767L,131071L,536870911L,576460752303423487L,BigInteger.Parse("154742504910672534362390527") };
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
public class A134709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134709.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134709Inst Instance=new A134709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134710
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,128L,1024L,2048L,4194304L,2251799813685248L,BigInteger.Parse("302231454903657293676544"),BigInteger.Parse("39614081257132168796771975168"),BigInteger.Parse("20769187434139310514121985316880384") };
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
public class A134710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134710.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134710Inst Instance=new A134710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134711
{
public static readonly BigInteger[] Value={ 0L,0L,1L,3L,127L,1023L,2047L,4194303L,2251799813685247L,BigInteger.Parse("302231454903657293676543") };
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
public class A134711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134711.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134711Inst Instance=new A134711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134776
{
public static readonly BigInteger[] Value={ 3L,6917L,82499L,19720133460129649L,BigInteger.Parse("11784299926611415613401489"),BigInteger.Parse("3378745302877576498748105171045289001743711517992420088871061377762366601077190668071") };
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
public class A134776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134776Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134776.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134776Inst Instance=new A134776Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134777
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,1L,1L,1L,4L,5L,1L,1L,8L,9L,2L,1L,2L,3L,4L,5L,6L,7L,8L,9L,3L,1L,3L,3L,4L,5L,6L,7L,8L,9L,4L,4L,4L,4L,4L,5L,4L,4L,8L,4L,5L,5L,5L,5L,5L,5L,5L,5L,8L,5L,6L,1L,6L,6L,4L,5L,6L,7L,8L,9L,7L,1L,7L,7L,4L,5L,7L,7L,8L,9L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,4L,5L,9L,9L,8L,9L,1L,1L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134777Inst : IEnumerable<long>
{
public static readonly long[] Value=A134777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134777.Bytes);
public long this[int i]=>Value[i];

public static A134777Inst Instance=new A134777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134778
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,1L,1L,6L,7L,1L,1L,0L,2L,2L,2L,2L,2L,2L,2L,2L,2L,0L,3L,2L,3L,3L,3L,3L,3L,3L,3L,0L,1L,2L,3L,4L,4L,6L,7L,4L,9L,0L,1L,2L,3L,4L,5L,6L,7L,5L,9L,0L,6L,2L,3L,6L,6L,6L,6L,6L,6L,0L,7L,2L,3L,7L,7L,6L,7L,7L,7L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,9L,9L,6L,7L,9L,9L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134778Inst : IEnumerable<long>
{
public static readonly long[] Value=A134778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134778.Bytes);
public long this[int i]=>Value[i];

public static A134778Inst Instance=new A134778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134779
{
public static readonly long[] Value={ 1L,4L,6L,8L,11L,14L,16L,18L,21L,24L,27L,30L,33L,36L,38L,40L,43L,46L,49L,52L,55L,58L,61L,64L,66L,68L,71L,74L,76L,78L,80L,82L,85L,88L,90L,92L,95L,98L,101L,104L,106L,108L,111L,114L,117L,120L,122L,124L,126L,128L,131L,134L,137L,140L,143L,146L,148L,150L,153L,156L,159L,162L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134779Inst : IEnumerable<long>
{
public static readonly long[] Value=A134779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134779.Bytes);
public long this[int i]=>Value[i];

public static A134779Inst Instance=new A134779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134780
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,-1L,6L,-7L,19L,-33L,73L,-146L,311L,-652L,1392L,-2977L,6420L,-13899L,30247L,-66078L,144911L,-318853L,703768L,-1557718L,3456813L,-7689531L,17142887L,-38296408L,85715645L,-192191445L,431647744L,-970958480L,2187288804L,-4934101775L,11144794835L,-25203825094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134780Inst : IEnumerable<long>
{
public static readonly long[] Value=A134780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134780.Bytes);
public long this[int i]=>Value[i];

public static A134780Inst Instance=new A134780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134781
{
public static readonly long[] Value={ 1L,1L,4L,7L,13L,19L,33L,47L,74L,106L,154L,214L,307L,417L,575L,772L,1045L,1379L,1837L,2394L,3135L,4048L,5232L,6686L,8560L,10840L,13737L,17273L,21701L,27086L,33783L,41890L,51893L,63969L,78748L,96536L,118196L,144146L,175561L,213122L,258327L,312202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134781Inst : IEnumerable<long>
{
public static readonly long[] Value=A134781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134781.Bytes);
public long this[int i]=>Value[i];

public static A134781Inst Instance=new A134781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134782
{
public static readonly long[] Value={ 1L,1L,11L,20L,57L,92L,207L,312L,623L,932L,1674L,2464L,4162L,6024L,9595L,13748L,21126L,29820L,44449L,62004L,90191L,124288L,177135L,241632L,338508L,457272L,631031L,845008L,1150752L,1528380L,2057700L,2712192L,3614217L,4730148L,6245541L,8119672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134782Inst : IEnumerable<long>
{
public static readonly long[] Value=A134782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134782.Bytes);
public long this[int i]=>Value[i];

public static A134782Inst Instance=new A134782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134783
{
public static readonly long[] Value={ 1L,1L,8L,22L,42L,70L,155L,246L,421L,722L,1101L,1730L,2761L,4062L,6106L,9040L,13065L,18806L,27081L,37950L,53183L,74290L,102213L,140048L,191612L,258426L,348300L,467484L,622023L,825016L,1090957L,1432290L,1875930L,2448610L,3179136L,4114996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134783Inst : IEnumerable<long>
{
public static readonly long[] Value=A134783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134783.Bytes);
public long this[int i]=>Value[i];

public static A134783Inst Instance=new A134783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134784
{
public static readonly long[] Value={ 1L,2L,17L,46L,116L,252L,533L,1034L,1961L,3540L,6253L,10654L,17897L,29284L,47265L,74868L,117158L,180608L,275562L,415300L,620210L,916860L,1344251L,1953974L,2819664L,4038300L,5746031L,8122072L,11413112L,15943576L,22153909L,30620666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134784Inst : IEnumerable<long>
{
public static readonly long[] Value=A134784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134784.Bytes);
public long this[int i]=>Value[i];

public static A134784Inst Instance=new A134784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134785
{
public static readonly long[] Value={ 1L,2L,36L,128L,386L,1024L,2488L,5632L,12031L,24576L,48308L,91904L,170110L,307200L,542872L,941056L,1602819L,2686976L,4439688L,7238272L,11657090L,18561024L,29242240L,45617664L,70507772L,108036096L,164192188L,247620352L,370726652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134785Inst : IEnumerable<long>
{
public static readonly long[] Value=A134785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134785.Bytes);
public long this[int i]=>Value[i];

public static A134785Inst Instance=new A134785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134786
{
public static readonly long[] Value={ 1L,4L,276L,2048L,11202L,49152L,184024L,614400L,1881471L,5373952L,14478180L,37122048L,91231550L,216072192L,495248952L,1102430208L,2390434947L,5061476352L,10487167336L,21301241856L,42481784514L,83300614144L,160791890304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134786Inst : IEnumerable<long>
{
public static readonly long[] Value=A134786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134786.Bytes);
public long this[int i]=>Value[i];

public static A134786Inst Instance=new A134786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134787
{
public static readonly long[] Value={ 1L,8L,11L,12L,13L,16L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,29L,30L,31L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134787Inst : IEnumerable<long>
{
public static readonly long[] Value=A134787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134787.Bytes);
public long this[int i]=>Value[i];

public static A134787Inst Instance=new A134787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134788
{
public static readonly BigInteger[] Value={ -1L,0L,6L,78L,220L,1580L,28634L,514200L,433494394L,2971215026L,99194853094755414L,BigInteger.Parse("1066340417491710595814572038"),BigInteger.Parse("19134702400093278081449423780"),BigInteger.Parse("475420437734698220747368027166749382927701417016557193662268716376935475882") };
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
public class A134788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134788Inst Instance=new A134788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134789
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,18L,94L,1246L,17732L,10081266L,63217342L,1195118711985006L,BigInteger.Parse("8140003186959622868813528"),BigInteger.Parse("139669360584622467747806014"),BigInteger.Parse("1324290912910022899017738237233285189213652972190967113265372469016533360") };
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
public class A134789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134789Inst Instance=new A134789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134790
{
public static readonly BigInteger[] Value={ 0L,1L,1L,8L,17L,93L,1245L,17732L,10081265L,63217341L,1195118711985005L,BigInteger.Parse("8140003186959622868813528"),BigInteger.Parse("139669360584622467747806013"),BigInteger.Parse("1324290912910022899017738237233285189213652972190967113265372469016533360") };
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
public class A134790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134790Inst Instance=new A134790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134791
{
public static readonly long[] Value={ -1L,0L,0L,2L,2L,4L,7L,9L,16L,17L,34L,57L,60L,166L,200L,201L,209L,237L,266L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134791Inst : IEnumerable<long>
{
public static readonly long[] Value=A134791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134791.Bytes);
public long this[int i]=>Value[i];

public static A134791Inst Instance=new A134791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134808
{
public static readonly long[] Value={ 0L,101L,102L,103L,104L,105L,106L,107L,108L,109L,201L,202L,203L,204L,205L,206L,207L,208L,209L,301L,302L,303L,304L,305L,306L,307L,308L,309L,401L,402L,403L,404L,405L,406L,407L,408L,409L,501L,502L,503L,504L,505L,506L,507L,508L,509L,601L,602L,603L,604L,605L,606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134808Inst : IEnumerable<long>
{
public static readonly long[] Value=A134808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134808.Bytes);
public long this[int i]=>Value[i];

public static A134808Inst Instance=new A134808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134809
{
public static readonly long[] Value={ 101L,103L,107L,109L,307L,401L,409L,503L,509L,601L,607L,701L,709L,809L,907L,11027L,11047L,11057L,11059L,11069L,11071L,11083L,11087L,11093L,12011L,12037L,12041L,12043L,12049L,12071L,12073L,12097L,13033L,13037L,13043L,13049L,13063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134809Inst : IEnumerable<long>
{
public static readonly long[] Value=A134809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134809.Bytes);
public long this[int i]=>Value[i];

public static A134809Inst Instance=new A134809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134810
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,121L,232L,343L,454L,565L,676L,787L,898L,12321L,23432L,34543L,45654L,56765L,67876L,78987L,1234321L,2345432L,3456543L,4567654L,5678765L,6789876L,123454321L,234565432L,345676543L,456787654L,567898765L,12345654321L,23456765432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134810Inst : IEnumerable<long>
{
public static readonly long[] Value=A134810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134810.Bytes);
public long this[int i]=>Value[i];

public static A134810Inst Instance=new A134810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134811
{
public static readonly long[] Value={ 2L,3L,5L,7L,787L,34543L,345676543L,34567876543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134811Inst : IEnumerable<long>
{
public static readonly long[] Value=A134811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134811.Bytes);
public long this[int i]=>Value[i];

public static A134811Inst Instance=new A134811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134812
{
public static readonly long[] Value={ 0L,1L,-1L,1L,2L,-2L,8L,4L,8L,40L,32L,112L,224L,352L,896L,1600L,3200L,6784L,12800L,26368L,52736L,103936L,210944L,418816L,837632L,1681408L,3350528L,6713344L,13426688L,26828800L,53706752L,107364352L,214728704L,429555712L,858914816L,1718026240L,3436052480L,6871711744L,13744209920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134812Inst : IEnumerable<long>
{
public static readonly long[] Value=A134812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134812.Bytes);
public long this[int i]=>Value[i];

public static A134812Inst Instance=new A134812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134813
{
public static readonly long[] Value={ 1L,-3L,3L,0L,-6L,12L,-12L,0L,24L,-48L,48L,0L,-96L,192L,-192L,0L,384L,-768L,768L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134813Inst : IEnumerable<long>
{
public static readonly long[] Value=A134813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134813.Bytes);
public long this[int i]=>Value[i];

public static A134813Inst Instance=new A134813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134814
{
public static readonly BigInteger[] Value={ 14L,2125L,303338L,41434850L,5356596165L,677072767779L,83858789929596L,BigInteger.Parse("99101104105107111112114"),BigInteger.Parse("116119121123124128130131133"),BigInteger.Parse("135138140141143146147150151153"),BigInteger.Parse("156158159161163166167169170173175") };
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
public class A134814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134814Inst Instance=new A134814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134815
{
public static readonly long[] Value={ 4L,9L,35L,162L,790L,3923L,19602L,98108L,491242L,2460009L,12319475L,61695247L,308967153L,1547295326L,7748795485L,38805671816L,194337325053L,973233918963L,4873918388052L,24408397608972L,122236325365629L,612154860741196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134815Inst : IEnumerable<long>
{
public static readonly long[] Value=A134815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134815.Bytes);
public long this[int i]=>Value[i];

public static A134815Inst Instance=new A134815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134816
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,7L,9L,12L,16L,21L,28L,37L,49L,65L,86L,114L,151L,200L,265L,351L,465L,616L,816L,1081L,1432L,1897L,2513L,3329L,4410L,5842L,7739L,10252L,13581L,17991L,23833L,31572L,41824L,55405L,73396L,97229L,128801L,170625L,226030L,299426L,396655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134816Inst : IEnumerable<long>
{
public static readonly long[] Value=A134816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134816.Bytes);
public long this[int i]=>Value[i];

public static A134816Inst Instance=new A134816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134817
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,21L,43L,87L,175L,526L,1579L,6317L,25269L,126346L,758077L,4548463L,31839242L,254713937L,2292425434L,22924254341L,252166797752L,3026001573025L,39338020449326L,550732286290565L,8260984294358476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134817Inst : IEnumerable<long>
{
public static readonly long[] Value=A134817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134817.Bytes);
public long this[int i]=>Value[i];

public static A134817Inst Instance=new A134817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134818
{
public static readonly long[] Value={ 1L,3L,9L,37L,146L,772L,4449L,30307L,228605L,1921464L,17652327L,176162548L,1893738334L,21806975279L,267636988052L,3486370839295L,48029272657002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134818Inst : IEnumerable<long>
{
public static readonly long[] Value=A134818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134818.Bytes);
public long this[int i]=>Value[i];

public static A134818Inst Instance=new A134818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134819
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,3L,2L,1L,2L,5L,9L,11L,7L,3L,3L,10L,26L,40L,40L,21L,6L,5L,25L,77L,159L,217L,185L,85L,19L,9L,56L,222L,575L,1031L,1230L,920L,356L,50L,18L,139L,654L,2082L,4679L,7437L,7982L,5308L,1804L,204L,35L,338L,1902L,7244L,19983L,40139L,57771L,56437L,33860L,10064L,832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134819Inst : IEnumerable<long>
{
public static readonly long[] Value=A134819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134819.Bytes);
public long this[int i]=>Value[i];

public static A134819Inst Instance=new A134819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134820
{
public static readonly long[] Value={ 353L,5281L,7703L,9137L,9431L,10939L,11681L,14029L,14489L,17519L,17881L,18077L,18701L,19483L,20719L,21013L,22247L,22961L,24953L,25589L,25913L,26821L,26987L,27893L,28297L,34327L,37273L,39671L,40031L,40129L,42209L,42359L,43397L,43781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134820Inst : IEnumerable<long>
{
public static readonly long[] Value=A134820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134820.Bytes);
public long this[int i]=>Value[i];

public static A134820Inst Instance=new A134820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134821
{
public static readonly BigInteger[] Value={ 1L,12L,4921L,51127323835L,BigInteger.Parse("218857981551141835113634"),BigInteger.Parse("310572853467235677965363821819928450852019"),BigInteger.Parse("1425475594007632231129760415319272779790434025012566981847673007772802") };
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
public class A134821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134821Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134821.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134821.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134821Inst Instance=new A134821Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134822
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,2L,1L,5L,1L,1L,2L,7L,3L,2L,3L,8L,3L,5L,2L,1L,8L,8L,5L,7L,9L,8L,1L,5L,5L,1L,1L,4L,1L,8L,3L,5L,1L,1L,3L,6L,3L,4L,3L,1L,0L,5L,7L,2L,8L,5L,3L,4L,6L,7L,2L,3L,5L,6L,7L,7L,9L,6L,5L,3L,6L,3L,8L,2L,1L,8L,1L,9L,9L,2L,8L,4L,5L,0L,8L,5L,2L,0L,1L,9L,1L,4L,2L,5L,4L,7L,5L,5L,9L,4L,0L,0L,7L,6L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134822Inst : IEnumerable<long>
{
public static readonly long[] Value=A134822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134822.Bytes);
public long this[int i]=>Value[i];

public static A134822Inst Instance=new A134822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134823
{
public static readonly long[] Value={ 4L,11L,63L,409L,2818L,19669L,137725L,965065L,6763525L,47403061L,332233597L,2328528748L,16319989180L,114382129186L,801671598205L,5618686762534L,39379767287245L,276001517369095L,1934415636331069L,13557765514528696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134823Inst : IEnumerable<long>
{
public static readonly long[] Value=A134823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134823.Bytes);
public long this[int i]=>Value[i];

public static A134823Inst Instance=new A134823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134872
{
public static readonly long[] Value={ 6L,28L,248L,2032L,262112L,8388544L,67108736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134872Inst : IEnumerable<long>
{
public static readonly long[] Value=A134872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134872.Bytes);
public long this[int i]=>Value[i];

public static A134872Inst Instance=new A134872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134873
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,31L,37L,43L,71L,73L,113L,127L,131L,137L,151L,173L,211L,223L,257L,271L,277L,281L,311L,317L,431L,457L,523L,541L,547L,557L,577L,727L,757L,821L,853L,1117L,1151L,1171L,1187L,1217L,1223L,1277L,1427L,1451L,1481L,1511L,1523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134873Inst : IEnumerable<long>
{
public static readonly long[] Value=A134873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134873.Bytes);
public long this[int i]=>Value[i];

public static A134873Inst Instance=new A134873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134874
{
public static readonly BigInteger[] Value={ 1L,137L,18769L,2571353L,352275494L,48261760899L,6611863739440L,905825674293229L,124098164230813075L,17001454918435590842UL,BigInteger.Parse("2329200203203553290874"),BigInteger.Parse("319100548313701481849195") };
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
public class A134874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134874Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134874.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134874.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134874Inst Instance=new A134874Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134875
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,5L,7L,6L,6L,7L,11L,7L,13L,9L,8L,8L,17L,9L,19L,9L,10L,13L,23L,10L,10L,15L,12L,11L,29L,11L,31L,12L,14L,19L,12L,12L,37L,21L,16L,13L,41L,13L,43L,15L,14L,25L,47L,14L,14L,15L,20L,17L,53L,15L,16L,15L,22L,31L,59L,16L,61L,33L,16L,16L,18L,17L,67L,21L,26L,17L,71L,17L,73L,39L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134875Inst : IEnumerable<long>
{
public static readonly long[] Value=A134875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134875.Bytes);
public long this[int i]=>Value[i];

public static A134875Inst Instance=new A134875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134876
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,8L,18L,23L,44L,73L,142L,277L,484L,871L,1644L,3060L,5851L,10917L,20776L,39263L,74752L,142521L,271223L,520242L,996486L,1916486L,3686628L,7103236L,13702428L,26469008L,51193351L,99099882L,192044541L,372559804L,723389144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134876Inst : IEnumerable<long>
{
public static readonly long[] Value=A134876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134876.Bytes);
public long this[int i]=>Value[i];

public static A134876Inst Instance=new A134876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134877
{
public static readonly long[] Value={ 1L,2L,8L,7L,0L,3L,7L,0L,9L,6L,6L,4L,1L,6L,8L,1L,8L,1L,4L,7L,1L,1L,3L,2L,0L,2L,9L,7L,5L,5L,8L,2L,0L,4L,2L,5L,9L,0L,4L,2L,1L,6L,9L,5L,5L,3L,4L,0L,2L,2L,2L,0L,8L,1L,0L,2L,6L,7L,9L,8L,7L,6L,5L,9L,2L,6L,9L,0L,9L,9L,7L,3L,0L,0L,3L,5L,1L,8L,6L,6L,5L,4L,1L,9L,3L,0L,7L,3L,6L,8L,0L,1L,0L,8L,8L,0L,8L,3L,9L,3L,7L,7L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134877Inst : IEnumerable<long>
{
public static readonly long[] Value=A134877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134877.Bytes);
public long this[int i]=>Value[i];

public static A134877Inst Instance=new A134877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134878
{
public static readonly long[] Value={ 1L,0L,0L,3L,9L,0L,6L,2L,5L,2L,5L,8L,1L,1L,7L,4L,7L,9L,1L,7L,6L,7L,4L,0L,7L,2L,9L,0L,6L,1L,4L,3L,0L,6L,7L,4L,1L,0L,7L,6L,1L,2L,4L,9L,2L,4L,3L,7L,9L,2L,8L,5L,9L,4L,7L,8L,7L,6L,4L,0L,4L,7L,9L,0L,7L,9L,5L,0L,9L,9L,2L,1L,9L,0L,5L,0L,8L,6L,9L,4L,4L,5L,1L,6L,6L,8L,8L,4L,0L,2L,7L,3L,4L,8L,3L,4L,4L,6L,9L,6L,6L,8L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134878Inst : IEnumerable<long>
{
public static readonly long[] Value=A134878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134878.Bytes);
public long this[int i]=>Value[i];

public static A134878Inst Instance=new A134878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134879
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,5L,9L,6L,0L,4L,6L,4L,4L,7L,7L,5L,3L,9L,0L,6L,2L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,2L,5L,5L,1L,6L,5L,2L,3L,3L,7L,2L,8L,4L,5L,8L,8L,8L,8L,8L,3L,7L,9L,8L,9L,7L,5L,9L,3L,7L,6L,8L,3L,7L,2L,0L,8L,4L,9L,2L,0L,2L,8L,5L,0L,1L,1L,5L,8L,4L,6L,2L,0L,8L,2L,0L,3L,7L,4L,9L,4L,4L,6L,3L,3L,8L,5L,6L,0L,8L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134879Inst : IEnumerable<long>
{
public static readonly long[] Value=A134879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134879.Bytes);
public long this[int i]=>Value[i];

public static A134879Inst Instance=new A134879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134880
{
public static readonly long[] Value={ 2L,5L,3L,9L,0L,6L,3L,0L,9L,6L,0L,4L,6L,4L,4L,7L,7L,5L,4L,4L,4L,8L,3L,5L,1L,0L,8L,6L,2L,4L,2L,7L,5L,2L,2L,1L,7L,0L,0L,3L,7L,2L,6L,4L,0L,0L,4L,4L,1L,8L,1L,3L,1L,3L,3L,3L,7L,0L,7L,2L,6L,6L,4L,5L,8L,5L,4L,1L,1L,9L,7L,7L,3L,3L,5L,5L,9L,0L,7L,7L,9L,3L,6L,0L,9L,7L,6L,6L,9L,0L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134880Inst : IEnumerable<long>
{
public static readonly long[] Value=A134880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134880.Bytes);
public long this[int i]=>Value[i];

public static A134880Inst Instance=new A134880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134881
{
public static readonly long[] Value={ 0L,6L,5L,9L,8L,8L,4L,1L,7L,7L,4L,3L,3L,4L,3L,7L,9L,1L,7L,5L,6L,5L,6L,2L,3L,8L,6L,7L,2L,4L,1L,0L,7L,7L,9L,7L,4L,3L,8L,1L,4L,4L,4L,3L,9L,3L,4L,1L,2L,1L,3L,1L,0L,2L,6L,2L,8L,0L,5L,4L,3L,6L,6L,5L,5L,9L,9L,9L,8L,5L,2L,0L,7L,6L,6L,0L,7L,1L,5L,7L,1L,2L,7L,8L,5L,1L,1L,2L,0L,0L,8L,1L,9L,4L,3L,6L,0L,7L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134881Inst : IEnumerable<long>
{
public static readonly long[] Value=A134881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134881.Bytes);
public long this[int i]=>Value[i];

public static A134881Inst Instance=new A134881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134882
{
public static readonly long[] Value={ 0L,2L,7L,4L,2L,5L,6L,9L,3L,2L,7L,6L,9L,9L,1L,3L,7L,8L,2L,8L,1L,1L,6L,1L,1L,9L,4L,8L,4L,3L,1L,2L,0L,8L,3L,2L,6L,8L,2L,2L,5L,5L,9L,5L,3L,8L,8L,0L,5L,7L,8L,9L,0L,7L,0L,9L,9L,8L,8L,1L,7L,4L,4L,3L,1L,0L,1L,6L,1L,3L,8L,6L,5L,0L,3L,8L,8L,4L,7L,4L,4L,5L,7L,6L,3L,0L,8L,4L,3L,8L,8L,3L,2L,9L,1L,7L,4L,4L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134882Inst : IEnumerable<long>
{
public static readonly long[] Value=A134882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134882.Bytes);
public long this[int i]=>Value[i];

public static A134882Inst Instance=new A134882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134883
{
public static readonly long[] Value={ 7L,3L,9L,9L,4L,7L,9L,4L,3L,4L,9L,5L,4L,6L,5L,5L,1L,2L,2L,5L,6L,0L,2L,5L,5L,3L,0L,7L,3L,4L,9L,9L,4L,7L,8L,2L,0L,5L,6L,1L,1L,0L,6L,6L,5L,7L,4L,2L,2L,4L,3L,9L,6L,2L,8L,7L,4L,5L,4L,5L,6L,5L,1L,9L,9L,9L,8L,0L,4L,3L,0L,8L,5L,4L,0L,8L,4L,8L,8L,1L,0L,2L,8L,9L,7L,3L,9L,5L,3L,1L,1L,2L,0L,7L,1L,2L,1L,5L,6L,8L,2L,0L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134883Inst : IEnumerable<long>
{
public static readonly long[] Value=A134883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134883.Bytes);
public long this[int i]=>Value[i];

public static A134883Inst Instance=new A134883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134884
{
public static readonly BigInteger[] Value={ 3L,1L,27269L,1954390L,385327519L,45035320119L,6682022825588L,881709781234437L,123029167626415695L,16708818725606483602UL,BigInteger.Parse("2298930844925022134207"),BigInteger.Parse("314329661992199488247899"),BigInteger.Parse("43107655899059704928917636") };
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
public class A134884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134884Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134884.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134884.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134884Inst Instance=new A134884Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134885
{
public static readonly long[] Value={ 1L,137L,-1L,-135L,-137L,1L,134L,0L,137L,-1L,-133L,0L,0L,-137L,1L,132L,0L,0L,0L,137L,-1L,-131L,0L,0L,0L,0L,-137L,1L,130L,0L,0L,0L,0L,0L,137L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134885Inst : IEnumerable<long>
{
public static readonly long[] Value=A134885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134885.Bytes);
public long this[int i]=>Value[i];

public static A134885Inst Instance=new A134885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134886
{
public static readonly long[] Value={ 1L,2L,4L,7L,9L,12L,15L,18L,22L,25L,29L,33L,37L,41L,46L,50L,54L,59L,64L,69L,74L,79L,84L,89L,94L,100L,105L,111L,116L,122L,128L,134L,140L,146L,152L,158L,165L,171L,177L,184L,190L,197L,204L,210L,217L,224L,231L,238L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134886Inst : IEnumerable<long>
{
public static readonly long[] Value=A134886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134886.Bytes);
public long this[int i]=>Value[i];

public static A134886Inst Instance=new A134886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134887
{
public static readonly long[] Value={ 1L,5L,15L,32L,56L,89L,131L,183L,246L,321L,407L,507L,619L,746L,887L,1042L,1214L,1401L,1604L,1824L,2062L,2317L,2590L,2881L,3192L,3522L,3871L,4241L,4631L,5041L,5473L,5927L,6402L,6899L,7420L,7962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134887Inst : IEnumerable<long>
{
public static readonly long[] Value=A134887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134887.Bytes);
public long this[int i]=>Value[i];

public static A134887Inst Instance=new A134887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134920
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,6L,3L,1L,10L,34L,45L,-21L,-173L,-181L,406L,1488L,1050L,-4198L,-11931L,-3989L,43513L,97305L,-8008L,-438126L,-781169L,468631L,4335188L,6065206L,-7930890L,-42174786L,-44121989L,106840385L,402942250L,281085066L,-1301476803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134920Inst : IEnumerable<long>
{
public static readonly long[] Value=A134920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134920.Bytes);
public long this[int i]=>Value[i];

public static A134920Inst Instance=new A134920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134921
{
public static readonly long[] Value={ 1L,4L,5L,9L,11L,14L,15L,16L,21L,24L,25L,31L,35L,39L,41L,46L,50L,54L,55L,60L,70L,71L,74L,75L,79L,80L,81L,86L,101L,104L,106L,114L,120L,125L,131L,134L,136L,144L,146L,150L,151L,154L,161L,166L,169L,170L,176L,179L,184L,185L,186L,199L,201L,224L,234L,235L,236L,240L,244L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134921Inst : IEnumerable<long>
{
public static readonly long[] Value=A134921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134921.Bytes);
public long this[int i]=>Value[i];

public static A134921Inst Instance=new A134921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134922
{
public static readonly long[] Value={ 568L,638L,1704L,1914L,1824L,1836L,2840L,3190L,3051L,3219L,3976L,4466L,4185L,4389L,4960L,5236L,5112L,5742L,6102L,6438L,6368L,6764L,7384L,8294L,7749L,8151L,8370L,8778L,8520L,9570L,9120L,9180L,9184L,9724L,9656L,10846L,9760L,11050L,10792L,12122L,11032L,12470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134922Inst : IEnumerable<long>
{
public static readonly long[] Value=A134922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134922.Bytes);
public long this[int i]=>Value[i];

public static A134922Inst Instance=new A134922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134923
{
public static readonly BigInteger[] Value={ 0L,1L,1L,8L,729L,400315553L,BigInteger.Parse("64151935432803278387177768"),BigInteger.Parse("264015418305763603932856608512044494366944180663171394053409979316505418715161") };
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
public class A134923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134923.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134923Inst Instance=new A134923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134924
{
public static readonly long[] Value={ 1L,3L,22L,24L,36L,38L,46L,48L,52L,54L,66L,68L,78L,80L,82L,84L,88L,90L,96L,98L,112L,114L,126L,128L,130L,132L,156L,158L,162L,164L,166L,168L,172L,174L,210L,212L,222L,224L,232L,234L,250L,252L,256L,258L,262L,264L,276L,278L,292L,294L,306L,308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134924Inst : IEnumerable<long>
{
public static readonly long[] Value=A134924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134924.Bytes);
public long this[int i]=>Value[i];

public static A134924Inst Instance=new A134924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134925
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,12L,16L,21L,26L,31L,37L,43L,49L,56L,63L,70L,77L,85L,93L,102L,110L,119L,128L,137L,147L,156L,166L,177L,187L,198L,209L,220L,231L,242L,254L,266L,278L,290L,303L,315L,328L,341L,354L,367L,381L,395L,409L,423L,437L,451L,466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134925Inst : IEnumerable<long>
{
public static readonly long[] Value=A134925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134925.Bytes);
public long this[int i]=>Value[i];

public static A134925Inst Instance=new A134925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134926
{
public static readonly long[] Value={ 11L,12L,18L,19L,23L,24L,26L,27L,33L,34L,39L,40L,41L,42L,44L,45L,48L,49L,56L,57L,63L,64L,65L,66L,78L,79L,81L,82L,83L,84L,86L,87L,105L,106L,111L,112L,116L,117L,125L,126L,128L,129L,131L,132L,138L,139L,146L,147L,153L,154L,158L,159L,165L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134926Inst : IEnumerable<long>
{
public static readonly long[] Value=A134926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134926.Bytes);
public long this[int i]=>Value[i];

public static A134926Inst Instance=new A134926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134927
{
public static readonly long[] Value={ 1L,1L,6L,21L,81L,306L,1161L,4401L,16686L,63261L,239841L,909306L,3447441L,13070241L,49553046L,187869861L,712268721L,2700415746L,10238053401L,38815407441L,147160382526L,557927369901L,2115263257281L,8019571881546L,30404505416481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134927Inst : IEnumerable<long>
{
public static readonly long[] Value=A134927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134927.Bytes);
public long this[int i]=>Value[i];

public static A134927Inst Instance=new A134927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134928
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,14L,16L,18L,20L,28L,30L,32L,40L,42L,44L,58L,60L,62L,70L,72L,74L,100L,102L,104L,106L,108L,110L,136L,138L,140L,148L,150L,152L,178L,180L,182L,190L,192L,194L,196L,198L,200L,226L,228L,230L,238L,240L,242L,268L,270L,272L,280L,282L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134928Inst : IEnumerable<long>
{
public static readonly long[] Value=A134928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134928.Bytes);
public long this[int i]=>Value[i];

public static A134928Inst Instance=new A134928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134929
{
public static readonly long[] Value={ 2L,1L,7L,2L,9L,8L,7L,5L,3L,9L,3L,1L,9L,6L,9L,6L,3L,4L,7L,2L,3L,0L,9L,2L,4L,8L,4L,8L,9L,8L,8L,6L,5L,9L,2L,7L,6L,9L,6L,2L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134929Inst : IEnumerable<long>
{
public static readonly long[] Value=A134929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134929.Bytes);
public long this[int i]=>Value[i];

public static A134929Inst Instance=new A134929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134930
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,28L,30L,32L,40L,42L,44L,58L,60L,62L,70L,72L,74L,100L,102L,104L,106L,108L,110L,136L,138L,140L,148L,150L,152L,178L,180L,182L,190L,192L,194L,196L,198L,200L,226L,228L,230L,238L,240L,242L,268L,270L,272L,280L,282L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134930Inst : IEnumerable<long>
{
public static readonly long[] Value=A134930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134930.Bytes);
public long this[int i]=>Value[i];

public static A134930Inst Instance=new A134930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134931
{
public static readonly long[] Value={ 1L,6L,21L,66L,201L,606L,1821L,5466L,16401L,49206L,147621L,442866L,1328601L,3985806L,11957421L,35872266L,107616801L,322850406L,968551221L,2905653666L,8716961001L,26150883006L,78452649021L,235357947066L,706073841201L,2118221523606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134931Inst : IEnumerable<long>
{
public static readonly long[] Value=A134931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134931.Bytes);
public long this[int i]=>Value[i];

public static A134931Inst Instance=new A134931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134932
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,14L,15L,16L,20L,21L,22L,29L,30L,31L,35L,36L,37L,50L,51L,52L,53L,54L,55L,68L,69L,70L,74L,75L,76L,89L,90L,91L,95L,96L,97L,98L,99L,100L,113L,114L,115L,119L,120L,121L,134L,135L,136L,140L,141L,142L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134932Inst : IEnumerable<long>
{
public static readonly long[] Value=A134932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134932.Bytes);
public long this[int i]=>Value[i];

public static A134932Inst Instance=new A134932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134933
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,14L,15L,16L,20L,21L,22L,29L,30L,31L,35L,36L,37L,50L,51L,52L,53L,54L,55L,68L,69L,70L,74L,75L,76L,89L,90L,91L,95L,96L,97L,98L,99L,100L,113L,114L,115L,119L,120L,121L,134L,135L,136L,140L,141L,142L,155L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134933Inst : IEnumerable<long>
{
public static readonly long[] Value=A134933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134933.Bytes);
public long this[int i]=>Value[i];

public static A134933Inst Instance=new A134933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134934
{
public static readonly long[] Value={ 1L,225L,841L,1849L,3249L,5041L,7225L,9801L,12769L,16129L,19881L,24025L,28561L,33489L,38809L,44521L,50625L,57121L,64009L,71289L,78961L,87025L,95481L,104329L,113569L,123201L,133225L,143641L,154449L,165649L,177241L,189225L,201601L,214369L,227529L,241081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134934Inst : IEnumerable<long>
{
public static readonly long[] Value=A134934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134934.Bytes);
public long this[int i]=>Value[i];

public static A134934Inst Instance=new A134934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134935
{
public static readonly long[] Value={ 21L,26L,37L,60L,76L,93L,101L,122L,126L,133L,149L,151L,166L,191L,192L,201L,214L,247L,257L,266L,276L,288L,296L,311L,331L,336L,346L,359L,366L,368L,373L,379L,394L,406L,416L,431L,434L,435L,441L,451L,453L,474L,476L,478L,489L,492L,499L,526L,533L,534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134935Inst : IEnumerable<long>
{
public static readonly long[] Value=A134935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134935.Bytes);
public long this[int i]=>Value[i];

public static A134935Inst Instance=new A134935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134984
{
public static readonly long[] Value={ 1L,3L,11L,19L,37L,55L,87L,4L,12L,20L,38L,56L,88L,21L,39L,57L,89L,58L,90L,59L,91L,60L,92L,61L,93L,62L,94L,63L,95L,64L,96L,65L,97L,66L,98L,67L,99L,68L,100L,69L,101L,70L,102L,71L,103L,22L,40L,72L,104L,23L,41L,73L,105L,24L,42L,74L,106L,25L,43L,75L,107L,26L,44L,76L,108L,27L,45L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134984Inst : IEnumerable<long>
{
public static readonly long[] Value=A134984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134984.Bytes);
public long this[int i]=>Value[i];

public static A134984Inst Instance=new A134984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134985
{
public static readonly long[] Value={ 5L,6L,7L,13L,17L,171L,174L,378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134985Inst : IEnumerable<long>
{
public static readonly long[] Value=A134985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134985.Bytes);
public long this[int i]=>Value[i];

public static A134985Inst Instance=new A134985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134986
{
public static readonly long[] Value={ 2L,3L,2L,3L,4L,5L,5L,6L,7L,8L,9L,10L,10L,11L,12L,13L,14L,15L,16L,17L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134986Inst : IEnumerable<long>
{
public static readonly long[] Value=A134986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134986.Bytes);
public long this[int i]=>Value[i];

public static A134986Inst Instance=new A134986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134987
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,4L,10L,20L,35L,58L,100L,192L,405L,880L,1874L,3844L,7631L,14886L,29020L,57192L,114249L,230300L,465226L,936948L,1877771L,3748498L,7470532L,14895728L,29749837L,59514152L,119166962L,238627620L,477606935L,955315390L,1909991772L,3818208792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134987Inst : IEnumerable<long>
{
public static readonly long[] Value=A134987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134987.Bytes);
public long this[int i]=>Value[i];

public static A134987Inst Instance=new A134987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134988
{
public static readonly BigInteger[] Value={ 1L,0L,1L,4L,22L,144L,1089L,9308L,88562L,927584L,10603178L,131368648L,1753970380L,25112732512L,383925637137L,6243618722124L,107644162715098L,1961478594977856L,37671587406585006L,760654555198989240L,16110333600696417780UL,BigInteger.Parse("357148428086308848480"),BigInteger.Parse("8271374327887650503130") };
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
public class A134988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134988Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134988.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134988.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134988Inst Instance=new A134988Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134989
{
public static readonly long[] Value={ 0L,20L,32L,95L,207L,720L,1152L,1215L,1287L,3420L,3807L,6255L,6407L,7452L,7767L,18095L,23247L,25920L,41472L,43740L,46332L,46647L,69255L,123120L,137052L,174087L,211815L,217935L,225180L,230652L,268272L,279612L,279927L,651420L,836892L,933120L,1416447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134989Inst : IEnumerable<long>
{
public static readonly long[] Value=A134989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134989.Bytes);
public long this[int i]=>Value[i];

public static A134989Inst Instance=new A134989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134990
{
public static readonly long[] Value={ 8L,15L,10L,13L,12L,11L,14L,9L,16L,7L,18L,5L,20L,3L,22L,1L,24L,-1L,26L,-3L,28L,-5L,30L,-7L,32L,-9L,34L,-11L,36L,-13L,38L,-15L,40L,-17L,42L,-19L,44L,-21L,46L,-23L,48L,-25L,50L,-27L,52L,-29L,54L,-31L,56L,-33L,58L,-35L,60L,-37L,62L,-39L,64L,-41L,66L,-43L,68L,-45L,70L,-47L,72L,-49L,74L,-51L,76L,-53L,78L,-55L,80L,-57L,82L,-59L,84L,-61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134990Inst : IEnumerable<long>
{
public static readonly long[] Value=A134990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134990.Bytes);
public long this[int i]=>Value[i];

public static A134990Inst Instance=new A134990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134991
{
public static readonly long[] Value={ 1L,1L,3L,1L,10L,15L,1L,25L,105L,105L,1L,56L,490L,1260L,945L,1L,119L,1918L,9450L,17325L,10395L,1L,246L,6825L,56980L,190575L,270270L,135135L,1L,501L,22935L,302995L,1636635L,4099095L,4729725L,2027025L,1L,1012L,74316L,1487200L,12122110L,47507460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134991Inst : IEnumerable<long>
{
public static readonly long[] Value=A134991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134991.Bytes);
public long this[int i]=>Value[i];

public static A134991Inst Instance=new A134991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134992
{
public static readonly long[] Value={ 4L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L,25L,25L,25L,26L,26L,26L,26L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134992Inst : IEnumerable<long>
{
public static readonly long[] Value=A134992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134992.Bytes);
public long this[int i]=>Value[i];

public static A134992Inst Instance=new A134992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134993
{
public static readonly long[] Value={ 3L,3L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,22L,22L,22L,22L,23L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134993Inst : IEnumerable<long>
{
public static readonly long[] Value=A134993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134993.Bytes);
public long this[int i]=>Value[i];

public static A134993Inst Instance=new A134993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134994
{
public static readonly long[] Value={ 4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,24L,25L,25L,25L,26L,26L,26L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134994Inst : IEnumerable<long>
{
public static readonly long[] Value=A134994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134994.Bytes);
public long this[int i]=>Value[i];

public static A134994Inst Instance=new A134994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134995
{
public static readonly long[] Value={ 2L,3L,3L,4L,4L,5L,5L,5L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,21L,21L,21L,21L,22L,22L,22L,22L,23L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134995Inst : IEnumerable<long>
{
public static readonly long[] Value=A134995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134995.Bytes);
public long this[int i]=>Value[i];

public static A134995Inst Instance=new A134995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134996
{
public static readonly long[] Value={ 2L,5L,11L,101L,181L,1181L,1811L,18181L,108881L,110881L,118081L,120121L,121021L,121151L,150151L,151051L,151121L,180181L,180811L,181081L,188011L,188801L,1008001L,1022201L,1028011L,1055501L,1058011L,1082801L,1085801L,1088081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134996Inst : IEnumerable<long>
{
public static readonly long[] Value=A134996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134996.Bytes);
public long this[int i]=>Value[i];

public static A134996Inst Instance=new A134996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134997
{
public static readonly long[] Value={ 2L,1L,2L,2L,1L,14L,40L,52L,228L,482L,1592L,4758L,15810L,53202L,197429L,725196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134997Inst : IEnumerable<long>
{
public static readonly long[] Value=A134997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134997.Bytes);
public long this[int i]=>Value[i];

public static A134997Inst Instance=new A134997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134998
{
public static readonly long[] Value={ 2L,5L,11L,101L,181L,18181L,1008001L,1022201L,1055501L,1082801L,1085801L,1180811L,1208021L,1221221L,1250521L,1280821L,1508051L,1520251L,1551551L,1580851L,1802081L,1805081L,1880881L,1881881L,100111001L,100888001L,108101801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134998Inst : IEnumerable<long>
{
public static readonly long[] Value=A134998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134998.Bytes);
public long this[int i]=>Value[i];

public static A134998Inst Instance=new A134998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134999
{
public static readonly long[] Value={ 100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,124L,125L,126L,127L,128L,129L,130L,131L,132L,133L,134L,136L,137L,138L,139L,140L,141L,142L,143L,144L,145L,146L,148L,149L,150L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134999Inst : IEnumerable<long>
{
public static readonly long[] Value=A134999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134999.Bytes);
public long this[int i]=>Value[i];

public static A134999Inst Instance=new A134999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135272
{
public static readonly long[] Value={ 256L,1024L,1792L,1792L,1120L,448L,112L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135272Inst : IEnumerable<long>
{
public static readonly long[] Value=A135272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135272.Bytes);
public long this[int i]=>Value[i];

public static A135272Inst Instance=new A135272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135273
{
public static readonly long[] Value={ 512L,2304L,4608L,5376L,4032L,2016L,672L,144L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135273Inst : IEnumerable<long>
{
public static readonly long[] Value=A135273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135273.Bytes);
public long this[int i]=>Value[i];

public static A135273Inst Instance=new A135273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135274
{
public static readonly long[] Value={ 6L,13L,19L,25L,37L,47L,49L,65L,69L,77L,89L,103L,107L,113L,131L,141L,151L,159L,173L,185L,193L,199L,213L,239L,235L,247L,267L,275L,279L,287L,317L,317L,335L,353L,355L,373L,385L,393L,409L,427L,433L,441L,453L,469L,469L,499L,503L,513L,535L,565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135274Inst : IEnumerable<long>
{
public static readonly long[] Value=A135274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135274.Bytes);
public long this[int i]=>Value[i];

public static A135274Inst Instance=new A135274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135275
{
public static readonly long[] Value={ 0L,1L,7L,13L,21L,27L,37L,41L,53L,65L,69L,75L,95L,101L,95L,121L,127L,143L,153L,161L,169L,187L,185L,207L,223L,231L,235L,251L,263L,275L,269L,305L,299L,321L,343L,345L,361L,373L,385L,391L,409L,425L,433L,445L,457L,459L,479L,493L,507L,517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135275Inst : IEnumerable<long>
{
public static readonly long[] Value=A135275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135275.Bytes);
public long this[int i]=>Value[i];

public static A135275Inst Instance=new A135275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135276
{
public static readonly long[] Value={ 0L,1L,3L,4L,8L,9L,15L,16L,24L,25L,35L,36L,48L,49L,63L,64L,80L,81L,99L,100L,120L,121L,143L,144L,168L,169L,195L,196L,224L,225L,255L,256L,288L,289L,323L,324L,360L,361L,399L,400L,440L,441L,483L,484L,528L,529L,575L,576L,624L,625L,675L,676L,728L,729L,783L,784L,840L,841L,899L,900L,960L,961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135276Inst : IEnumerable<long>
{
public static readonly long[] Value=A135276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135276.Bytes);
public long this[int i]=>Value[i];

public static A135276Inst Instance=new A135276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135277
{
public static readonly long[] Value={ 10L,23L,41L,59L,83L,109L,131L,159L,187L,211L,235L,269L,301L,319L,349L,395L,425L,457L,487L,519L,551L,581L,607L,661L,689L,713L,749L,789L,817L,841L,883L,931L,961L,1015L,1049L,1079L,1119L,1151L,1187L,1229L,1271L,1303L,1331L,1367L,1391L,1433L,1477L,1511L,1553L,1611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135277Inst : IEnumerable<long>
{
public static readonly long[] Value=A135277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135277.Bytes);
public long this[int i]=>Value[i];

public static A135277Inst Instance=new A135277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135278
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,6L,4L,1L,5L,10L,10L,5L,1L,6L,15L,20L,15L,6L,1L,7L,21L,35L,35L,21L,7L,1L,8L,28L,56L,70L,56L,28L,8L,1L,9L,36L,84L,126L,126L,84L,36L,9L,1L,10L,45L,120L,210L,252L,210L,120L,45L,10L,1L,11L,55L,165L,330L,462L,462L,330L,165L,55L,11L,1L,12L,66L,220L,495L,792L,924L,792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135278Inst : IEnumerable<long>
{
public static readonly long[] Value=A135278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135278.Bytes);
public long this[int i]=>Value[i];

public static A135278Inst Instance=new A135278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135279
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,6L,8L,9L,11L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135279Inst : IEnumerable<long>
{
public static readonly long[] Value=A135279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135279.Bytes);
public long this[int i]=>Value[i];

public static A135279Inst Instance=new A135279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A135280
{
public static readonly long[] Value={ 4L,10L,20L,25L,34L,50L,52L,74L,85L,100L,130L,164L,170L,185L,202L,244L,250L,260L,289L,290L,325L,340L,370L,394L,410L,442L,452L,500L,505L,514L,580L,610L,629L,650L,676L,724L,725L,802L,820L,850L,884L,962L,970L,985L,1010L,1060L,1105L,1130L,1154L,1220L,1252L,1285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A135280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A135280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A135280Inst : IEnumerable<long>
{
public static readonly long[] Value=A135280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A135280.Bytes);
public long this[int i]=>Value[i];

public static A135280Inst Instance=new A135280Inst();

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