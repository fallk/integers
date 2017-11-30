using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A100541
{
public static readonly long[] Value={ -1L,12L,19L,-1L,14L,-1L,28L,27L,23L,33L,-1L,35L,-1L,26L,-1L,45L,44L,44L,43L,29L,51L,-1L,54L,-1L,53L,-1L,32L,-1L,66L,65L,65L,64L,64L,63L,46L,73L,-1L,77L,-1L,76L,-1L,75L,-1L,50L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100541Inst : IEnumerable<long>
{
public static readonly long[] Value=A100541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100541.Bytes);
public long this[int i]=>Value[i];

public static A100541Inst Instance=new A100541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100542
{
public static readonly long[] Value={ 5L,1L,9L,10L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,136L,153L,171L,190L,210L,231L,253L,276L,300L,325L,351L,378L,406L,435L,465L,496L,528L,561L,595L,630L,666L,703L,741L,780L,820L,861L,903L,946L,990L,1035L,1081L,1128L,1176L,1225L,1275L,1326L,1378L,1431L,1485L,1540L,1596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100542Inst : IEnumerable<long>
{
public static readonly long[] Value=A100542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100542.Bytes);
public long this[int i]=>Value[i];

public static A100542Inst Instance=new A100542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100543
{
public static readonly BigInteger[] Value={ 1L,3L,3L,0L,10L,12L,1L,24L,25L,32L,116L,12L,412L,109L,126L,2389L,12497L,28772L,126L,72795L,247786L,770213L,BigInteger.Parse("159378001963452599312"),2169128L,-26L,311L,378L,789L,10015050L,75L,74253544L,7881195L,BigInteger.Parse("2461717833658872781238383813854943728") };
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
public class A100543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100543.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100543Inst Instance=new A100543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100544
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,2L,1L,0L,1L,1L,1L,1L,1L,2L,1L,0L,1L,2L,0L,1L,0L,2L,2L,2L,1L,2L,1L,1L,2L,1L,0L,1L,1L,1L,0L,1L,2L,8L,14L,4L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,0L,4L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,3L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100544Inst : IEnumerable<long>
{
public static readonly long[] Value=A100544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100544.Bytes);
public long this[int i]=>Value[i];

public static A100544Inst Instance=new A100544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100545
{
public static readonly long[] Value={ 7L,19L,50L,131L,343L,898L,2351L,6155L,16114L,42187L,110447L,289154L,757015L,1981891L,5188658L,13584083L,35563591L,93106690L,243756479L,638162747L,1670731762L,4374032539L,11451365855L,29980065026L,78488829223L,205486422643L,537970438706L,1408424893475L,3687304241719L,9653487831682L,25273159253327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100545Inst : IEnumerable<long>
{
public static readonly long[] Value=A100545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100545.Bytes);
public long this[int i]=>Value[i];

public static A100545Inst Instance=new A100545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100546
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,18L,19L,23L,24L,29L,30L,31L,37L,41L,42L,43L,47L,53L,59L,61L,66L,67L,71L,73L,78L,79L,83L,89L,97L,101L,102L,103L,107L,109L,113L,114L,127L,131L,137L,138L,139L,149L,151L,157L,163L,167L,173L,174L,179L,181L,186L,191L,193L,197L,199L,211L,222L,223L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100546Inst : IEnumerable<long>
{
public static readonly long[] Value=A100546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100546.Bytes);
public long this[int i]=>Value[i];

public static A100546Inst Instance=new A100546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100547
{
public static readonly long[] Value={ 9L,9L,9L,9L,9L,3L,3L,3L,3L,7L,0L,3L,8L,4L,4L,4L,4L,4L,7L,2L,8L,6L,8L,6L,8L,4L,5L,7L,8L,8L,7L,8L,0L,6L,0L,9L,0L,1L,2L,8L,0L,8L,6L,0L,1L,6L,4L,9L,5L,9L,3L,8L,2L,2L,0L,1L,4L,3L,7L,7L,8L,1L,4L,6L,6L,6L,8L,9L,9L,9L,9L,7L,4L,4L,5L,1L,3L,9L,8L,3L,4L,8L,5L,1L,4L,3L,5L,8L,0L,7L,1L,7L,6L,1L,4L,6L,8L,6L,8L,8L,9L,8L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100547Inst : IEnumerable<long>
{
public static readonly long[] Value=A100547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100547.Bytes);
public long this[int i]=>Value[i];

public static A100547Inst Instance=new A100547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100548
{
public static readonly BigInteger[] Value={ 1L,1L,1L,28L,2539L,847126L,987474781L,4267529230672L,71328353711113801L,BigInteger.Parse("4706871807383903992060"),BigInteger.Parse("1236666872833000506726110479"),BigInteger.Parse("1297665884376581511952494336126664") };
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
public class A100548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100548.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100548Inst Instance=new A100548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100549
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,3L,2L,2L,2L,5L,2L,3L,2L,3L,2L,2L,2L,3L,3L,2L,3L,3L,2L,2L,2L,5L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,5L,3L,3L,2L,3L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,3L,7L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,2L,5L,5L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,3L,2L,2L,2L,5L,2L,3L,3L,3L,2L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100549Inst : IEnumerable<long>
{
public static readonly long[] Value=A100549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100549.Bytes);
public long this[int i]=>Value[i];

public static A100549Inst Instance=new A100549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100550
{
public static readonly long[] Value={ 0L,1L,2L,4L,11L,25L,59L,142L,335L,796L,1892L,4489L,10661L,25315L,60104L,142717L,338870L,804616L,1910507L,4536349L,10771211L,25575430L,60726899L,144191392L,342371480L,812934961L,1930252097L,4583236459L,10882545536L,25839774745L,61354575194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100550Inst : IEnumerable<long>
{
public static readonly long[] Value=A100550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100550.Bytes);
public long this[int i]=>Value[i];

public static A100550Inst Instance=new A100550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100551
{
public static readonly long[] Value={ 1L,2L,-2L,3L,-8L,4L,4L,-20L,24L,-8L,5L,-40L,84L,-64L,16L,6L,-70L,224L,-288L,160L,-32L,7L,-112L,504L,-960L,880L,-384L,64L,8L,-168L,1008L,-2640L,3520L,-2496L,896L,-128L,9L,-240L,1848L,-6336L,11440L,-11648L,6720L,-2048L,256L,10L,-330L,3168L,-13728L,32032L,-43680L,35840L,-17408L,4608L,-512L,11L,-440L,5148L,-27456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100551Inst : IEnumerable<long>
{
public static readonly long[] Value=A100551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100551.Bytes);
public long this[int i]=>Value[i];

public static A100551Inst Instance=new A100551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100552
{
public static readonly long[] Value={ 2L,3L,5L,7L,23L,37L,53L,73L,5323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100552Inst : IEnumerable<long>
{
public static readonly long[] Value=A100552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100552.Bytes);
public long this[int i]=>Value[i];

public static A100552Inst Instance=new A100552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100553
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,17L,23L,31L,37L,53L,71L,73L,1117L,1123L,1153L,1171L,1373L,1723L,1753L,2311L,2371L,3137L,5323L,7331L,11172311L,11175323L,11231723L,11531123L,11711123L,11711753L,13737331L,17231171L,17532311L,23111723L,23711153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100553Inst : IEnumerable<long>
{
public static readonly long[] Value=A100553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100553.Bytes);
public long this[int i]=>Value[i];

public static A100553Inst Instance=new A100553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100554
{
public static readonly long[] Value={ 5L,7L,6L,6L,7L,4L,0L,4L,7L,4L,6L,8L,5L,8L,1L,1L,7L,4L,1L,3L,4L,0L,5L,0L,7L,9L,4L,7L,5L,0L,0L,0L,0L,4L,9L,0L,4L,4L,5L,6L,5L,6L,2L,6L,6L,4L,0L,3L,8L,1L,6L,6L,6L,5L,5L,7L,5L,0L,6L,2L,4L,8L,4L,3L,9L,0L,1L,5L,4L,2L,4L,7L,9L,1L,8L,3L,1L,0L,0L,2L,1L,7L,4L,3L,5L,6L,5L,5L,5L,1L,7L,5L,9L,3L,9L,5L,4L,9L,1L,8L,7L,6L,5L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100554Inst : IEnumerable<long>
{
public static readonly long[] Value=A100554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100554.Bytes);
public long this[int i]=>Value[i];

public static A100554Inst Instance=new A100554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100555
{
public static readonly long[] Value={ 1L,4L,9L,9L,9L,16L,16L,16L,25L,25L,25L,25L,25L,36L,36L,36L,36L,36L,49L,49L,49L,49L,49L,49L,49L,64L,64L,64L,64L,64L,64L,64L,81L,81L,81L,81L,81L,81L,81L,81L,81L,100L,100L,100L,100L,100L,100L,100L,100L,100L,121L,121L,121L,121L,121L,121L,121L,121L,121L,121L,121L,144L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100555Inst : IEnumerable<long>
{
public static readonly long[] Value=A100555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100555.Bytes);
public long this[int i]=>Value[i];

public static A100555Inst Instance=new A100555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100556
{
public static readonly long[] Value={ 9L,15L,39L,75L,81L,735L,1311L,1881L,3201L,3225L,11795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100556Inst : IEnumerable<long>
{
public static readonly long[] Value=A100556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100556.Bytes);
public long this[int i]=>Value[i];

public static A100556Inst Instance=new A100556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100557
{
public static readonly long[] Value={ 11L,19L,41L,73L,113L,163L,227L,337L,461L,577L,761L,883L,1013L,1249L,1567L,1801L,2053L,2381L,2593L,2887L,3299L,3697L,4337L,4919L,5231L,5519L,5843L,6173L,7177L,8363L,9007L,9533L,10357L,11251L,11863L,12799L,13613L,14447L,15493L,16223L,17291L,18433L,19013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100557Inst : IEnumerable<long>
{
public static readonly long[] Value=A100557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100557.Bytes);
public long this[int i]=>Value[i];

public static A100557Inst Instance=new A100557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100558
{
public static readonly long[] Value={ 11L,23L,47L,83L,131L,191L,263L,397L,563L,709L,953L,1091L,1289L,1531L,1867L,2129L,2389L,2729L,2963L,3259L,3659L,4099L,4787L,5387L,5693L,6101L,6473L,6803L,7829L,8999L,9697L,10247L,11117L,12041L,12703L,13669L,14549L,15439L,16573L,17321L,18461L,19661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100558Inst : IEnumerable<long>
{
public static readonly long[] Value=A100558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100558.Bytes);
public long this[int i]=>Value[i];

public static A100558Inst Instance=new A100558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100559
{
public static readonly long[] Value={ 5L,29L,71L,79L,131L,179L,269L,349L,457L,569L,719L,971L,1171L,1327L,1601L,1913L,2269L,2593L,2999L,3539L,4099L,4549L,5231L,5717L,6529L,7297L,7879L,8779L,9791L,10711L,11867L,12809L,14081L,15269L,16561L,17863L,19463L,20771L,22541L,24329L,25913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100559Inst : IEnumerable<long>
{
public static readonly long[] Value=A100559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100559.Bytes);
public long this[int i]=>Value[i];

public static A100559Inst Instance=new A100559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100560
{
public static readonly long[] Value={ 1L,1L,3L,4L,17L,13L,77L,128L,167L,73L,319L,1294L,30697L,28211L,8707L,9728L,17587L,18181L,6517513L,3084316L,5855671L,2786599L,244579999L,116918176L,560006983L,134354573L,3099540819L,745984697L,83423830027L,80530073893L,2412760934249L,4669066440704L,565308230449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100560Inst : IEnumerable<long>
{
public static readonly long[] Value=A100560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100560.Bytes);
public long this[int i]=>Value[i];

public static A100560Inst Instance=new A100560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100561
{
public static readonly long[] Value={ 1L,1L,2L,3L,12L,10L,60L,105L,140L,63L,280L,1155L,27720L,25740L,8008L,9009L,16380L,17017L,6126120L,2909907L,5542680L,2645370L,232792560L,111546435L,535422888L,128707425L,2974571600L,717084225L,80313433200L,77636318760L,2329089562800L,4512611027925L,546983154900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100561Inst : IEnumerable<long>
{
public static readonly long[] Value=A100561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100561.Bytes);
public long this[int i]=>Value[i];

public static A100561Inst Instance=new A100561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100562
{
public static readonly long[] Value={ 7L,8L,9L,10L,11L,12L,14L,16L,18L,22L,24L,25L,28L,30L,33L,36L,37L,38L,40L,42L,45L,46L,50L,51L,52L,56L,57L,58L,60L,61L,64L,66L,67L,68L,70L,72L,77L,78L,81L,82L,84L,85L,86L,88L,92L,93L,94L,96L,100L,102L,105L,106L,108L,112L,114L,117L,122L,123L,126L,128L,130L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100562Inst : IEnumerable<long>
{
public static readonly long[] Value=A100562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100562.Bytes);
public long this[int i]=>Value[i];

public static A100562Inst Instance=new A100562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100563
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,2L,0L,0L,1L,2L,0L,1L,0L,1L,2L,1L,1L,1L,0L,2L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,2L,0L,0L,1L,1L,2L,2L,0L,0L,2L,1L,2L,0L,1L,0L,1L,1L,2L,1L,3L,0L,2L,1L,0L,0L,1L,1L,2L,1L,0L,0L,0L,2L,0L,2L,1L,2L,1L,0L,3L,1L,0L,1L,1L,0L,2L,2L,2L,0L,0L,0L,1L,2L,1L,3L,1L,0L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100563Inst : IEnumerable<long>
{
public static readonly long[] Value=A100563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100563.Bytes);
public long this[int i]=>Value[i];

public static A100563Inst Instance=new A100563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100564
{
public static readonly long[] Value={ 3L,5L,17L,23L,29L,53L,83L,89L,113L,149L,173L,197L,257L,263L,269L,293L,317L,353L,359L,383L,389L,419L,449L,467L,479L,503L,509L,557L,563L,569L,593L,617L,653L,659L,677L,683L,773L,797L,809L,827L,857L,863L,887L,947L,977L,983L,1049L,1097L,1109L,1217L,1223L,1229L,1283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100564Inst : IEnumerable<long>
{
public static readonly long[] Value=A100564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100564.Bytes);
public long this[int i]=>Value[i];

public static A100564Inst Instance=new A100564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100565
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,5L,2L,4L,3L,5L,2L,8L,2L,5L,5L,5L,2L,8L,2L,8L,5L,5L,2L,11L,3L,5L,4L,8L,2L,15L,2L,6L,5L,5L,5L,13L,2L,5L,5L,11L,2L,15L,2L,8L,8L,5L,2L,14L,3L,8L,5L,8L,2L,11L,5L,11L,5L,5L,2L,25L,2L,5L,8L,7L,5L,15L,2L,8L,5L,15L,2L,18L,2L,5L,8L,8L,5L,15L,2L,14L,5L,5L,2L,25L,5L,5L,5L,11L,2L,25L,5L,8L,5L,5L,5L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100565Inst : IEnumerable<long>
{
public static readonly long[] Value=A100565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100565.Bytes);
public long this[int i]=>Value[i];

public static A100565Inst Instance=new A100565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100566
{
public static readonly long[] Value={ 11L,26L,42L,70L,99L,125L,154L,183L,231L,264L,309L,363L,389L,414L,490L,537L,580L,649L,692L,727L,786L,824L,935L,978L,1023L,1080L,1128L,1170L,1220L,1311L,1401L,1436L,1533L,1605L,1647L,1734L,1807L,1855L,1917L,1986L,2053L,2131L,2200L,2250L,2312L,2407L,2501L,2583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100566Inst : IEnumerable<long>
{
public static readonly long[] Value=A100566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100566.Bytes);
public long this[int i]=>Value[i];

public static A100566Inst Instance=new A100566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100567
{
public static readonly long[] Value={ 3L,11L,17L,41L,59L,83L,109L,157L,179L,211L,241L,283L,331L,367L,401L,461L,509L,563L,587L,617L,709L,773L,797L,877L,919L,991L,1031L,1087L,1153L,1201L,1217L,1409L,1433L,1471L,1499L,1597L,1621L,1723L,1741L,1823L,1847L,2027L,2063L,2099L,2221L,2341L,2351L,2417L,2477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100567Inst : IEnumerable<long>
{
public static readonly long[] Value=A100567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100567.Bytes);
public long this[int i]=>Value[i];

public static A100567Inst Instance=new A100567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100568
{
public static readonly BigInteger[] Value={ 1L,1L,4L,48L,2064L,167280L,23136480L,4824953280L,1417422988800L,557894688341760L,283527366696806400L,BigInteger.Parse("180770613278509900800"),BigInteger.Parse("141310830114906688051200"),BigInteger.Parse("132919668653581764822067200"),BigInteger.Parse("148111929489204170921816985600") };
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
public class A100568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100568Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100568.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100568.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100568Inst Instance=new A100568Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100569
{
public static readonly BigInteger[] Value={ 1L,1L,1L,9L,337L,37889L,11410545L,9368733289L,21760617258977L,146872848650637249L,BigInteger.Parse("2927557787922534645793"),BigInteger.Parse("173801937725990883065857673"),BigInteger.Parse("30857177979379449393077427767217") };
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
public class A100569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100569Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100569.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100569.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100569Inst Instance=new A100569Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100570
{
public static readonly long[] Value={ 1L,2L,3L,12L,17L,28L,32L,72L,108L,117L,297L,657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100570Inst : IEnumerable<long>
{
public static readonly long[] Value=A100570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100570.Bytes);
public long this[int i]=>Value[i];

public static A100570Inst Instance=new A100570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100571
{
public static readonly long[] Value={ 8L,27L,64L,125L,216L,343L,729L,1000L,1331L,1728L,2197L,2744L,3375L,4096L,4913L,5832L,6859L,8000L,9261L,10648L,12167L,13824L,15625L,17576L,19683L,21952L,24389L,27000L,29791L,32768L,35937L,39304L,42875L,46656L,50653L,54872L,59319L,64000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100571Inst : IEnumerable<long>
{
public static readonly long[] Value=A100571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100571.Bytes);
public long this[int i]=>Value[i];

public static A100571Inst Instance=new A100571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100572
{
public static readonly long[] Value={ 5L,19L,41L,89L,163L,271L,19L,631L,677L,1103L,1237L,1879L,2053L,3049L,3299L,4229L,5333L,5857L,7219L,7607L,9859L,11117L,12577L,14173L,16417L,16223L,20477L,22679L,25409L,26833L,30509L,32771L,36887L,39989L,43759L,47911L,52127L,56237L,60013L,65657L,69691L,74887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100572Inst : IEnumerable<long>
{
public static readonly long[] Value=A100572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100572.Bytes);
public long this[int i]=>Value[i];

public static A100572Inst Instance=new A100572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100573
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,1L,0L,5L,2L,0L,0L,1L,0L,3L,4L,9L,0L,1L,0L,11L,0L,5L,0L,1L,0L,0L,8L,15L,2L,1L,0L,17L,10L,3L,0L,1L,0L,9L,2L,21L,0L,1L,0L,3L,14L,11L,0L,1L,6L,5L,16L,27L,0L,1L,0L,29L,4L,0L,8L,1L,0L,15L,20L,2L,0L,1L,0L,35L,2L,17L,4L,1L,0L,3L,0L,39L,0L,1L,12L,41L,26L,9L,0L,1L,6L,21L,28L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100573Inst : IEnumerable<long>
{
public static readonly long[] Value=A100573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100573.Bytes);
public long this[int i]=>Value[i];

public static A100573Inst Instance=new A100573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100574
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,1L,0L,5L,2L,0L,0L,7L,0L,1L,4L,9L,0L,5L,0L,11L,0L,3L,0L,3L,0L,0L,8L,15L,2L,5L,0L,17L,10L,3L,0L,5L,0L,7L,4L,21L,0L,13L,0L,23L,14L,9L,0L,25L,6L,1L,16L,27L,0L,2L,0L,29L,2L,0L,8L,9L,0L,13L,20L,5L,0L,1L,0L,35L,22L,15L,4L,11L,0L,11L,0L,39L,0L,4L,12L,41L,26L,3L,0L,7L,6L,19L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100574Inst : IEnumerable<long>
{
public static readonly long[] Value=A100574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100574.Bytes);
public long this[int i]=>Value[i];

public static A100574Inst Instance=new A100574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100575
{
public static readonly long[] Value={ 0L,0L,1L,8L,44L,208L,912L,3840L,15808L,64256L,259328L,1042432L,4180992L,16748544L,67047424L,268304384L,1073463296L,4294377472L,17178624000L,68716855296L,274872401920L,1099500093440L,4398022393856L,17592135712768L,70368639320064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100575Inst : IEnumerable<long>
{
public static readonly long[] Value=A100575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100575.Bytes);
public long this[int i]=>Value[i];

public static A100575Inst Instance=new A100575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100576
{
public static readonly long[] Value={ 1L,3L,1L,5L,2L,1L,3L,4L,9L,1L,11L,5L,1L,8L,15L,2L,1L,17L,10L,3L,1L,9L,2L,21L,1L,3L,14L,11L,1L,6L,5L,16L,27L,1L,29L,4L,8L,1L,15L,20L,2L,1L,35L,2L,17L,4L,1L,3L,39L,1L,12L,41L,26L,9L,1L,6L,21L,28L,45L,14L,1L,5L,8L,3L,1L,11L,2L,51L,1L,3L,34L,5L,1L,18L,27L,10L,57L,10L,1L,59L,38L,29L,1L,40L,3L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100576Inst : IEnumerable<long>
{
public static readonly long[] Value=A100576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100576.Bytes);
public long this[int i]=>Value[i];

public static A100576Inst Instance=new A100576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100577
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,8L,2L,8L,4L,8L,2L,32L,2L,8L,8L,16L,2L,32L,2L,32L,8L,8L,2L,128L,4L,8L,8L,32L,2L,128L,2L,32L,8L,8L,8L,256L,2L,8L,8L,128L,2L,128L,2L,32L,32L,8L,2L,512L,4L,32L,8L,32L,2L,128L,8L,128L,8L,8L,2L,2048L,2L,8L,32L,64L,8L,128L,2L,32L,8L,128L,2L,2048L,2L,8L,32L,32L,8L,128L,2L,512L,16L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100577Inst : IEnumerable<long>
{
public static readonly long[] Value=A100577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100577.Bytes);
public long this[int i]=>Value[i];

public static A100577Inst Instance=new A100577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100578
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,5L,6L,4L,1L,8L,11L,10L,5L,1L,13L,20L,19L,15L,6L,1L,21L,37L,36L,29L,21L,7L,1L,34L,68L,69L,56L,41L,28L,8L,1L,55L,125L,134L,109L,80L,55L,36L,9L,1L,89L,230L,258L,214L,157L,108L,71L,45L,10L,1L,144L,423L,497L,423L,310L,213L,140L,89L,55L,11L,1L,233L,778L,958L,831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100578Inst : IEnumerable<long>
{
public static readonly long[] Value=A100578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100578.Bytes);
public long this[int i]=>Value[i];

public static A100578Inst Instance=new A100578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100579
{
public static readonly long[] Value={ 1L,125L,7L,49L,158L,17L,58L,2L,1L,1L,125L,7L,49L,158L,17L,58L,2L,1L,1L,125L,7L,49L,158L,17L,58L,2L,1L,1L,125L,7L,49L,158L,17L,58L,2L,1L,1L,125L,7L,49L,158L,17L,58L,2L,1L,1L,125L,7L,49L,158L,17L,58L,2L,1L,1L,125L,7L,49L,158L,17L,58L,2L,1L,1L,125L,7L,49L,158L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100579Inst : IEnumerable<long>
{
public static readonly long[] Value=A100579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100579.Bytes);
public long this[int i]=>Value[i];

public static A100579Inst Instance=new A100579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100580
{
public static readonly long[] Value={ 11L,101L,100111001L,110111011L,111010111L,1100011100011L,1100101010011L,1101010101011L,1110110110111L,1110111110111L,100110101011001L,101000010000101L,101011000110101L,101110000011101L,110011101110011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100580Inst : IEnumerable<long>
{
public static readonly long[] Value=A100580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100580.Bytes);
public long this[int i]=>Value[i];

public static A100580Inst Instance=new A100580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100581
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,3L,4L,7L,11L,18L,29L,47L,75L,123L,197L,321L,514L,836L,1343L,2181L,3508L,5692L,9167L,14865L,23959L,38838L,62635L,101503L,163773L,265344L,428291L,693791L,1120191L,1814345L,2930173L,4745365L,7665395L,12412755L,20054413L,32471888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100581Inst : IEnumerable<long>
{
public static readonly long[] Value=A100581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100581.Bytes);
public long this[int i]=>Value[i];

public static A100581Inst Instance=new A100581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100582
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,3L,5L,8L,13L,20L,34L,54L,88L,141L,230L,368L,599L,962L,1562L,2512L,4077L,6562L,10644L,17149L,27804L,44827L,72655L,117201L,189907L,306473L,496500L,801528L,1298303L,2096510L,3395454L,5484273L,8881231L,14347563L,23232342L,37537787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100582Inst : IEnumerable<long>
{
public static readonly long[] Value=A100582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100582.Bytes);
public long this[int i]=>Value[i];

public static A100582Inst Instance=new A100582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100583
{
public static readonly long[] Value={ 0L,8L,44L,124L,268L,492L,816L,1256L,1832L,2560L,3460L,4548L,5844L,7364L,9128L,11152L,13456L,16056L,18972L,22220L,25820L,29788L,34144L,38904L,44088L,49712L,55796L,62356L,69412L,76980L,85080L,93728L,102944L,112744L,123148L,134172L,145836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100583Inst : IEnumerable<long>
{
public static readonly long[] Value=A100583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100583.Bytes);
public long this[int i]=>Value[i];

public static A100583Inst Instance=new A100583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100584
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,1L,0L,3L,1L,7L,4L,19L,17L,63L,77L,217L,326L,815L,1435L,3533L,7227L,17709L,39704L,97010L,228123L,561216L,1366962L,3423504L,8601350L,22000341L,56612480L,147248370L,384885631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100584Inst : IEnumerable<long>
{
public static readonly long[] Value=A100584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100584.Bytes);
public long this[int i]=>Value[i];

public static A100584Inst Instance=new A100584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100585
{
public static readonly long[] Value={ 3L,4L,5L,6L,8L,10L,13L,17L,22L,29L,38L,50L,66L,88L,117L,156L,208L,277L,369L,492L,656L,874L,1165L,1553L,2070L,2760L,3680L,4906L,6541L,8721L,11628L,15504L,20672L,27562L,36749L,48998L,65330L,87106L,116141L,154854L,206472L,275296L,367061L,489414L,652552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100585Inst : IEnumerable<long>
{
public static readonly long[] Value=A100585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100585.Bytes);
public long this[int i]=>Value[i];

public static A100585Inst Instance=new A100585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100586
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,9L,11L,14L,17L,21L,26L,32L,40L,50L,62L,77L,96L,120L,150L,187L,234L,292L,365L,456L,570L,712L,890L,1112L,1390L,1737L,2171L,2714L,3392L,4240L,5300L,6625L,8281L,10351L,12939L,16174L,20217L,25271L,31589L,39486L,49357L,61696L,77120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100586Inst : IEnumerable<long>
{
public static readonly long[] Value=A100586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100586.Bytes);
public long this[int i]=>Value[i];

public static A100586Inst Instance=new A100586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100587
{
public static readonly long[] Value={ 1L,3L,3L,7L,3L,15L,3L,15L,7L,15L,3L,63L,3L,15L,15L,31L,3L,63L,3L,63L,15L,15L,3L,255L,7L,15L,15L,63L,3L,255L,3L,63L,15L,15L,15L,511L,3L,15L,15L,255L,3L,255L,3L,63L,63L,15L,3L,1023L,7L,63L,15L,63L,3L,255L,15L,255L,15L,15L,3L,4095L,3L,15L,63L,127L,15L,255L,3L,63L,15L,255L,3L,4095L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100587Inst : IEnumerable<long>
{
public static readonly long[] Value=A100587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100587.Bytes);
public long this[int i]=>Value[i];

public static A100587Inst Instance=new A100587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100588
{
public static readonly BigInteger[] Value={ 1L,3L,13L,55L,885L,14175L,3628885L,928994815L,60882604217685L,3990002350010269695L,BigInteger.Parse("17136929604257253605596550485") };
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
public class A100588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100588.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100588Inst Instance=new A100588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100589
{
public static readonly long[] Value={ 13L,31L,47L,61L,107L,151L,173L,197L,211L,227L,283L,347L,383L,433L,541L,557L,607L,647L,673L,691L,751L,773L,827L,853L,883L,977L,991L,1031L,1091L,1201L,1303L,1373L,1627L,1741L,1783L,1907L,1933L,1997L,2029L,2161L,2207L,2269L,2297L,2311L,2371L,2447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100589Inst : IEnumerable<long>
{
public static readonly long[] Value=A100589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100589.Bytes);
public long this[int i]=>Value[i];

public static A100589Inst Instance=new A100589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100590
{
public static readonly long[] Value={ 19L,29L,43L,59L,73L,89L,103L,127L,149L,167L,193L,223L,277L,317L,359L,461L,509L,523L,593L,643L,797L,823L,877L,1019L,1123L,1153L,1297L,1327L,1367L,1409L,1493L,1543L,1559L,1613L,1667L,1753L,1777L,1811L,1847L,1877L,1993L,2099L,2203L,2293L,2309L,2411L,2503L,2609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100590Inst : IEnumerable<long>
{
public static readonly long[] Value=A100590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100590.Bytes);
public long this[int i]=>Value[i];

public static A100590Inst Instance=new A100590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100591
{
public static readonly long[] Value={ 1L,4L,7L,10L,35L,25L,49L,61L,121L,140L,211L,268L,224L,392L,472L,517L,565L,529L,707L,1006L,1039L,994L,1213L,989L,1274L,1717L,1769L,1822L,2047L,2272L,2419L,2573L,2642L,3029L,3149L,3152L,3848L,3359L,4199L,4019L,4307L,4847L,5027L,4877L,5492L,6077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100591Inst : IEnumerable<long>
{
public static readonly long[] Value=A100591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100591.Bytes);
public long this[int i]=>Value[i];

public static A100591Inst Instance=new A100591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100592
{
public static readonly long[] Value={ 1L,8L,18L,30L,43L,48L,60L,72L,91L,108L,132L,155L,120L,144L,192L,168L,216L,236L,227L,180L,320L,340L,240L,252L,348L,300L,324L,336L,488L,484L,456L,396L,614L,360L,524L,548L,706L,468L,536L,656L,628L,420L,624L,576L,612L,588L,540L,600L,648L,768L,732L,800L,832L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100592Inst : IEnumerable<long>
{
public static readonly long[] Value=A100592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100592.Bytes);
public long this[int i]=>Value[i];

public static A100592Inst Instance=new A100592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100593
{
public static readonly long[] Value={ 33L,62L,105L,122L,135L,174L,285L,214L,294L,315L,318L,366L,525L,405L,394L,474L,498L,585L,495L,529L,765L,645L,735L,693L,945L,705L,761L,825L,1155L,1109L,901L,989L,1049L,1123L,1365L,1063L,1121L,1181L,1243L,1129L,1231L,1169L,1349L,1485L,1399L,1577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100593Inst : IEnumerable<long>
{
public static readonly long[] Value=A100593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100593.Bytes);
public long this[int i]=>Value[i];

public static A100593Inst Instance=new A100593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100594
{
public static readonly long[] Value={ 6L,90L,945L,9450L,93555L,924041L,9121612L,90030844L,888579011L,8769948429L,86555983552L,854273468992L,8431341566236L,83214006759229L,821289329637860L,8105800788023426L,80001047145799660L,789578687036411293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100594Inst : IEnumerable<long>
{
public static readonly long[] Value=A100594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100594.Bytes);
public long this[int i]=>Value[i];

public static A100594Inst Instance=new A100594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100595
{
public static readonly long[] Value={ 9L,10L,17L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100595Inst : IEnumerable<long>
{
public static readonly long[] Value=A100595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100595.Bytes);
public long this[int i]=>Value[i];

public static A100595Inst Instance=new A100595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100596
{
public static readonly long[] Value={ 2L,8L,15L,33L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100596Inst : IEnumerable<long>
{
public static readonly long[] Value=A100596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100596.Bytes);
public long this[int i]=>Value[i];

public static A100596Inst Instance=new A100596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100597
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,14L,49L,258L,1385L,1342L,-13739L,1727362L,20549165L,-892047378L,-13084315271L,979519187138L,16158974238545L,-1747908612654946L,-32246548780758179L,4903305033480792642L,BigInteger.Parse("100032668564662494485"),BigInteger.Parse("-20685044415403212103730"),BigInteger.Parse("-462550882810484735564351") };
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
public class A100597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100597.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100597Inst Instance=new A100597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100598
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100598Inst : IEnumerable<long>
{
public static readonly long[] Value=A100598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100598.Bytes);
public long this[int i]=>Value[i];

public static A100598Inst Instance=new A100598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100599
{
public static readonly long[] Value={ 7L,14L,16L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100599Inst : IEnumerable<long>
{
public static readonly long[] Value=A100599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100599.Bytes);
public long this[int i]=>Value[i];

public static A100599Inst Instance=new A100599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100600
{
public static readonly long[] Value={ 3L,4L,29L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100600Inst : IEnumerable<long>
{
public static readonly long[] Value=A100600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100600.Bytes);
public long this[int i]=>Value[i];

public static A100600Inst Instance=new A100600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100601
{
public static readonly long[] Value={ 9L,1001L,50L,333L,1001L,100L,333L,11L,5L,9L,1001L,50L,333L,1001L,100L,333L,11L,5L,9L,1001L,50L,333L,1001L,100L,333L,11L,5L,9L,1001L,50L,333L,1001L,100L,333L,11L,5L,9L,1001L,50L,333L,1001L,100L,333L,11L,5L,9L,1001L,50L,333L,1001L,100L,333L,11L,5L,9L,1001L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100601Inst : IEnumerable<long>
{
public static readonly long[] Value=A100601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100601.Bytes);
public long this[int i]=>Value[i];

public static A100601Inst Instance=new A100601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100602
{
public static readonly long[] Value={ 6L,8L,11L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100602Inst : IEnumerable<long>
{
public static readonly long[] Value=A100602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100602.Bytes);
public long this[int i]=>Value[i];

public static A100602Inst Instance=new A100602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100603
{
public static readonly long[] Value={ 1L,2L,4L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100603Inst : IEnumerable<long>
{
public static readonly long[] Value=A100603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100603.Bytes);
public long this[int i]=>Value[i];

public static A100603Inst Instance=new A100603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100604
{
public static readonly long[] Value={ 2L,3L,4L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100604Inst : IEnumerable<long>
{
public static readonly long[] Value=A100604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100604.Bytes);
public long this[int i]=>Value[i];

public static A100604Inst Instance=new A100604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100605
{
public static readonly long[] Value={ 1L,2L,4L,10L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100605Inst : IEnumerable<long>
{
public static readonly long[] Value=A100605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100605.Bytes);
public long this[int i]=>Value[i];

public static A100605Inst Instance=new A100605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100606
{
public static readonly long[] Value={ 0L,3L,26L,111L,324L,755L,1518L,2751L,4616L,7299L,11010L,15983L,22476L,30771L,41174L,54015L,69648L,88451L,110826L,137199L,168020L,203763L,244926L,292031L,345624L,406275L,474578L,551151L,636636L,731699L,837030L,953343L,1081376L,1221891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100606Inst : IEnumerable<long>
{
public static readonly long[] Value=A100606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100606.Bytes);
public long this[int i]=>Value[i];

public static A100606Inst Instance=new A100606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100607
{
public static readonly long[] Value={ 223L,227L,233L,257L,277L,337L,353L,373L,523L,557L,577L,727L,733L,757L,773L,1123L,1153L,1327L,1373L,1723L,1733L,1753L,1777L,1933L,1973L,2113L,2137L,2213L,2237L,2243L,2267L,2273L,2293L,2297L,2311L,2333L,2341L,2347L,2357L,2371L,2377L,2383L,2389L,2417L,2437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100607Inst : IEnumerable<long>
{
public static readonly long[] Value=A100607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100607.Bytes);
public long this[int i]=>Value[i];

public static A100607Inst Instance=new A100607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100608
{
public static readonly long[] Value={ 1L,6L,8L,4L,0L,9L,5L,9L,0L,0L,1L,0L,6L,6L,2L,2L,5L,0L,0L,3L,3L,9L,6L,3L,3L,7L,0L,8L,8L,6L,4L,3L,0L,7L,3L,6L,3L,6L,4L,1L,3L,5L,3L,5L,3L,3L,9L,2L,0L,0L,4L,5L,6L,2L,7L,3L,7L,7L,0L,1L,6L,4L,2L,6L,8L,9L,4L,4L,7L,5L,6L,7L,5L,0L,5L,0L,1L,7L,4L,6L,6L,8L,9L,3L,6L,1L,6L,9L,1L,8L,6L,4L,7L,4L,8L,7L,8L,9L,3L,7L,9L,6L,1L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100608Inst : IEnumerable<long>
{
public static readonly long[] Value=A100608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100608.Bytes);
public long this[int i]=>Value[i];

public static A100608Inst Instance=new A100608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100609
{
public static readonly long[] Value={ 1L,3L,5L,0L,5L,4L,3L,6L,0L,4L,3L,2L,2L,1L,1L,2L,4L,1L,8L,0L,4L,7L,0L,9L,8L,3L,2L,4L,6L,5L,9L,7L,4L,8L,3L,6L,8L,6L,6L,1L,4L,6L,7L,3L,3L,2L,0L,5L,8L,3L,6L,4L,0L,4L,6L,6L,5L,6L,0L,2L,9L,1L,6L,6L,2L,8L,0L,9L,4L,7L,1L,9L,0L,4L,4L,1L,2L,4L,5L,8L,4L,5L,3L,8L,1L,5L,9L,0L,7L,8L,9L,4L,6L,5L,2L,5L,1L,9L,2L,4L,2L,6L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100609Inst : IEnumerable<long>
{
public static readonly long[] Value=A100609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100609.Bytes);
public long this[int i]=>Value[i];

public static A100609Inst Instance=new A100609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100610
{
public static readonly long[] Value={ 5L,8L,5L,7L,6L,9L,1L,8L,9L,7L,4L,0L,1L,0L,6L,8L,7L,5L,4L,4L,0L,4L,4L,1L,4L,4L,2L,4L,0L,7L,8L,8L,3L,7L,6L,8L,4L,9L,2L,8L,2L,7L,3L,5L,2L,1L,0L,5L,9L,2L,6L,8L,9L,0L,2L,4L,0L,2L,4L,8L,3L,5L,2L,1L,8L,2L,2L,7L,6L,1L,2L,2L,2L,7L,8L,8L,0L,2L,3L,3L,7L,2L,7L,7L,2L,7L,9L,3L,0L,1L,0L,4L,2L,1L,0L,2L,3L,0L,6L,4L,5L,4L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100610Inst : IEnumerable<long>
{
public static readonly long[] Value=A100610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100610.Bytes);
public long this[int i]=>Value[i];

public static A100610Inst Instance=new A100610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100611
{
public static readonly long[] Value={ 3L,59L,8L,1L,2L,1L,1L,1L,1L,1L,2L,6L,1L,1L,3L,2L,1L,7L,1L,3L,2L,8L,5L,1L,3L,2L,6L,1L,2L,2L,2L,7L,1L,1L,3L,1L,10L,3L,1L,1L,3L,1L,1L,1L,2L,2L,3L,1L,1L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L,5L,9L,2L,1L,21L,3L,1L,1L,2L,1L,13L,1L,3L,1L,1L,1L,1L,2L,2L,1L,3L,5L,1L,1L,2L,1L,3L,1L,1L,6L,4L,2L,1L,2L,1L,2L,9L,5L,16L,4L,1L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100611Inst : IEnumerable<long>
{
public static readonly long[] Value=A100611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100611.Bytes);
public long this[int i]=>Value[i];

public static A100611Inst Instance=new A100611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100612
{
public static readonly long[] Value={ 0L,1L,4L,6L,1L,10L,13L,9L,21L,17L,2L,5L,4L,16L,18L,13L,28L,22L,65L,68L,55L,20L,27L,76L,80L,13L,50L,43L,65L,109L,56L,81L,93L,134L,82L,10L,131L,4L,30L,104L,29L,170L,104L,165L,9L,122L,130L,42L,225L,50L,69L,12L,128L,60L,147L,52L,16L,56L,7L,218L,154L,264L,198L,48L,299L,205L,251L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100612Inst : IEnumerable<long>
{
public static readonly long[] Value=A100612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100612.Bytes);
public long this[int i]=>Value[i];

public static A100612Inst Instance=new A100612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100613
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,13L,14L,21L,26L,37L,38L,53L,54L,69L,82L,97L,98L,121L,122L,145L,162L,185L,186L,217L,226L,253L,270L,301L,302L,345L,346L,377L,402L,437L,458L,505L,506L,545L,574L,621L,622L,681L,682L,729L,770L,817L,818L,881L,894L,953L,990L,1045L,1046L,1117L,1146L,1209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100613Inst : IEnumerable<long>
{
public static readonly long[] Value=A100613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100613.Bytes);
public long this[int i]=>Value[i];

public static A100613Inst Instance=new A100613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100614
{
public static readonly long[] Value={ 3L,4L,5L,8L,9L,10L,11L,30L,76L,163L,271L,273L,354L,721L,1796L,3733L,4769L,9316L,12221L,41532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100614Inst : IEnumerable<long>
{
public static readonly long[] Value=A100614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100614.Bytes);
public long this[int i]=>Value[i];

public static A100614Inst Instance=new A100614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100615
{
public static readonly long[] Value={ 1L,-1L,5L,-1L,1L,1L,-5L,-1L,7L,3L,-15L,-5L,7601L,691L,-91L,-35L,3617L,3617L,-745739L,-43867L,3317609L,1222277L,-5981591L,-854513L,5436374093L,1181820455L,-213827575L,-76977927L,213745149261L,23749461029L,-249859397004145L,-8615841276005L,238988952277727L,84802531453387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100615Inst : IEnumerable<long>
{
public static readonly long[] Value=A100615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100615.Bytes);
public long this[int i]=>Value[i];

public static A100615Inst Instance=new A100615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100616
{
public static readonly long[] Value={ 1L,1L,6L,2L,10L,6L,42L,6L,30L,10L,22L,6L,2730L,210L,6L,2L,34L,30L,798L,42L,330L,110L,46L,6L,2730L,546L,6L,2L,290L,30L,14322L,462L,510L,170L,2L,6L,54834L,51870L,6L,2L,4510L,330L,1806L,42L,690L,46L,94L,6L,46410L,6630L,66L,22L,530L,30L,798L,798L,174L,290L,118L,6L,56786730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100616Inst : IEnumerable<long>
{
public static readonly long[] Value=A100616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100616.Bytes);
public long this[int i]=>Value[i];

public static A100616Inst Instance=new A100616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100617
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100617Inst : IEnumerable<long>
{
public static readonly long[] Value=A100617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100617.Bytes);
public long this[int i]=>Value[i];

public static A100617Inst Instance=new A100617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100618
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,6L,6L,7L,8L,8L,8L,9L,10L,11L,11L,12L,13L,14L,14L,15L,15L,15L,15L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,23L,23L,24L,24L,25L,25L,26L,27L,28L,28L,29L,29L,29L,29L,30L,31L,32L,32L,33L,34L,35L,35L,35L,36L,36L,36L,37L,38L,39L,39L,40L,41L,42L,42L,43L,43L,43L,43L,44L,45L,46L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100618Inst : IEnumerable<long>
{
public static readonly long[] Value=A100618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100618.Bytes);
public long this[int i]=>Value[i];

public static A100618Inst Instance=new A100618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100619
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,1L,2L,3L,1L,1L,1L,2L,1L,2L,3L,1L,1L,1L,2L,1L,2L,3L,1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,1L,2L,3L,1L,1L,1L,2L,1L,2L,3L,1L,1L,1L,2L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,1L,2L,3L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100619Inst : IEnumerable<long>
{
public static readonly long[] Value=A100619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100619.Bytes);
public long this[int i]=>Value[i];

public static A100619Inst Instance=new A100619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100620
{
public static readonly BigInteger[] Value={ 0L,1L,1L,1L,7L,19L,41L,751L,989L,2857L,16067L,434293L,1364651L,8181904909L,90241897L,5044289L,15043611773L,5026792806787L,203732352169L,69028763155644023L,1145302367137L,1022779523247467L,396760150748100749L,BigInteger.Parse("750218743980105669781"),35200969735190093L };
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
public class A100620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100620.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100620Inst Instance=new A100620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100621
{
public static readonly BigInteger[] Value={ 1L,2L,6L,8L,90L,288L,840L,17280L,28350L,89600L,598752L,17418240L,63063000L,402361344000L,5003856000L,295206912L,976924698750L,342372925440000L,15209113920000L,5377993912811520000L,96852084769440L,89903156428800000L,BigInteger.Parse("37556196837868800000"),BigInteger.Parse("73570956727261593600000") };
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
public class A100621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100621.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100621Inst Instance=new A100621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100622
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,94L,1286L,22876L,499612L,12925340L,386356924L,13099953016L,496719289496L,20825694943912L,956599393819720L,47772070664027984L,2577034852683364816L,BigInteger.Parse("149335440671982405136"),BigInteger.Parse("9251650217381166689552"),BigInteger.Parse("610194993478502245703200"),BigInteger.Parse("42688019374465782644235424") };
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
public class A100622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100622.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100622Inst Instance=new A100622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100623
{
public static readonly long[] Value={ 1L,2L,8L,66L,308L,2612L,25988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100623Inst : IEnumerable<long>
{
public static readonly long[] Value=A100623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100623.Bytes);
public long this[int i]=>Value[i];

public static A100623Inst Instance=new A100623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100624
{
public static readonly long[] Value={ 0L,3L,10L,27L,62L,135L,282L,589L,1204L,2437L,4904L,9847L,19734L,39511L,79066L,158187L,316430L,632919L,1265898L,2531865L,5063800L,10127673L,20255420L,40510931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100624Inst : IEnumerable<long>
{
public static readonly long[] Value=A100624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100624.Bytes);
public long this[int i]=>Value[i];

public static A100624Inst Instance=new A100624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100625
{
public static readonly long[] Value={ 0L,4L,16L,48L,114L,250L,528L,1090L,2216L,4472L,9000L,18038L,36116L,72276L,144598L,289254L,578568L,1157200L,2314468L,4629010L,9258112L,18516288L,37032642L,74065368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100625Inst : IEnumerable<long>
{
public static readonly long[] Value=A100625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100625.Bytes);
public long this[int i]=>Value[i];

public static A100625Inst Instance=new A100625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100626
{
public static readonly BigInteger[] Value={ 32L,128L,2048L,32768L,8388608L,134217728L,34359738368L,549755813888L,140737488355328L,576460752303423488L,9223372036854775808UL,BigInteger.Parse("37778931862957161709568"),BigInteger.Parse("9671406556917033397649408"),BigInteger.Parse("154742504910672534362390528"),BigInteger.Parse("39614081257132168796771975168"),BigInteger.Parse("162259276829213363391578010288128") };
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
public class A100626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100626Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100626.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100626.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100626Inst Instance=new A100626Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100627
{
public static readonly BigInteger[] Value={ 243L,2187L,177147L,14348907L,94143178827L,7625597484987L,50031545098999707L,4052555153018976267L,BigInteger.Parse("26588814358957503287787"),BigInteger.Parse("14130386091738734504764811067"),BigInteger.Parse("1144561273430837494885949696427"),BigInteger.Parse("608266787713357709119683992618861307"),BigInteger.Parse("3990838394187339929534246675572349035227") };
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
public class A100627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100627.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100627Inst Instance=new A100627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100628
{
public static readonly BigInteger[] Value={ 128L,1024L,65536L,4194304L,17179869184L,1099511627776L,4503599627370496L,288230376151711744L,BigInteger.Parse("1180591620717411303424"),BigInteger.Parse("309485009821345068724781056"),BigInteger.Parse("19807040628566084398385987584"),BigInteger.Parse("5192296858534827628530496329220096") };
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
public class A100628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100628.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100628Inst Instance=new A100628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100629
{
public static readonly BigInteger[] Value={ 2048L,65536L,67108864L,68719476736L,72057594037927936L,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("77371252455336267181195264"),BigInteger.Parse("79228162514264337593543950336"),BigInteger.Parse("83076749736557242056487941267521536"),BigInteger.Parse("89202980794122492566142873090593446023921664") };
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
public class A100629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100629Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100629.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100629.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100629Inst Instance=new A100629Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100630
{
public static readonly long[] Value={ 1L,2L,5L,6L,14L,23L,24L,54L,86L,119L,120L,264L,414L,566L,719L,720L,1560L,2424L,3294L,4166L,5039L,5040L,10800L,16680L,22584L,28494L,34406L,40319L,40320L,85680L,131760L,177960L,224184L,270414L,316646L,362879L,362880L,766080L,1174320L,1583280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100630Inst : IEnumerable<long>
{
public static readonly long[] Value=A100630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100630.Bytes);
public long this[int i]=>Value[i];

public static A100630Inst Instance=new A100630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100631
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,8L,12L,8L,1L,1L,16L,32L,32L,16L,1L,1L,32L,80L,104L,80L,32L,1L,1L,64L,192L,304L,304L,192L,64L,1L,1L,128L,448L,832L,1008L,832L,448L,128L,1L,1L,256L,1024L,2176L,3072L,3072L,2176L,1024L,256L,1L,1L,512L,2304L,5504L,8832L,10272L,8832L,5504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100631Inst : IEnumerable<long>
{
public static readonly long[] Value=A100631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100631.Bytes);
public long this[int i]=>Value[i];

public static A100631Inst Instance=new A100631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100632
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,7L,8L,7L,1L,18L,29L,27L,26L,1L,60L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100632Inst : IEnumerable<long>
{
public static readonly long[] Value=A100632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100632.Bytes);
public long this[int i]=>Value[i];

public static A100632Inst Instance=new A100632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100633
{
public static readonly long[] Value={ 257L,523L,1123L,1153L,1327L,1373L,1723L,1753L,1973L,2113L,2137L,2237L,2293L,2297L,2311L,2341L,2347L,2357L,2371L,2377L,2383L,2389L,2417L,2437L,2473L,2477L,2531L,2543L,2579L,2593L,2617L,2677L,2711L,2713L,2719L,2729L,2731L,2741L,2753L,2767L,2789L,2797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100633Inst : IEnumerable<long>
{
public static readonly long[] Value=A100633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100633.Bytes);
public long this[int i]=>Value[i];

public static A100633Inst Instance=new A100633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100634
{
public static readonly long[] Value={ 0L,2L,6L,6L,22L,22L,86L,86L,86L,86L,1110L,1110L,5206L,5206L,5206L,5206L,70742L,70742L,332886L,332886L,332886L,332886L,4527190L,4527190L,4527190L,4527190L,4527190L,4527190L,272962646L,272962646L,1346704470L,1346704470L,1346704470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100634Inst : IEnumerable<long>
{
public static readonly long[] Value=A100634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100634.Bytes);
public long this[int i]=>Value[i];

public static A100634Inst Instance=new A100634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100635
{
public static readonly long[] Value={ 1L,7L,7L,17L,7L,49L,7L,31L,17L,49L,7L,119L,7L,49L,49L,49L,7L,119L,7L,119L,49L,49L,7L,217L,17L,49L,31L,119L,7L,343L,7L,71L,49L,49L,49L,289L,7L,49L,49L,217L,7L,343L,7L,119L,119L,49L,7L,343L,17L,119L,49L,119L,7L,217L,49L,217L,49L,49L,7L,833L,7L,49L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100635Inst : IEnumerable<long>
{
public static readonly long[] Value=A100635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100635.Bytes);
public long this[int i]=>Value[i];

public static A100635Inst Instance=new A100635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100636
{
public static readonly BigInteger[] Value={ 256L,262144L,1125899906842624L,BigInteger.Parse("316912650057057350374175801344"),BigInteger.Parse("7067388259113537318333190002971674063309935587502475832486424805170479104") };
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
public class A100636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100636Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A100636.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A100636.Bytes);
public BigInteger this[int i]=>Value[i];

public static A100636Inst Instance=new A100636Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100637
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,9L,10L,11L,11L,12L,13L,14L,15L,15L,16L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,23L,24L,24L,24L,25L,26L,27L,28L,29L,30L,30L,30L,30L,30L,31L,32L,32L,33L,34L,34L,34L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100637Inst : IEnumerable<long>
{
public static readonly long[] Value=A100637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100637.Bytes);
public long this[int i]=>Value[i];

public static A100637Inst Instance=new A100637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100638
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,15L,22L,37L,54L,81L,118L,199L,290L,435L,634L,1069L,1558L,2337L,3406L,5743L,8370L,12555L,18298L,30853L,44966L,67449L,98302L,165751L,241570L,362355L,528106L,890461L,1297782L,1946673L,2837134L,4783807L,6972050L,10458075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100638Inst : IEnumerable<long>
{
public static readonly long[] Value=A100638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100638.Bytes);
public long this[int i]=>Value[i];

public static A100638Inst Instance=new A100638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100639
{
public static readonly long[] Value={ 7L,9L,7L,1L,3L,1L,9L,7L,3L,7L,3L,1L,3L,3L,7L,1L,7L,3L,9L,9L,1L,9L,1L,3L,1L,3L,7L,1L,3L,1L,7L,7L,7L,7L,3L,7L,3L,7L,9L,1L,7L,3L,9L,3L,7L,3L,1L,7L,1L,7L,1L,3L,7L,9L,1L,1L,7L,9L,7L,1L,7L,9L,3L,1L,1L,1L,7L,9L,1L,3L,3L,1L,7L,9L,7L,9L,3L,1L,7L,1L,7L,9L,7L,7L,1L,9L,9L,9L,3L,9L,3L,9L,7L,9L,3L,9L,1L,7L,3L,9L,1L,3L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100639Inst : IEnumerable<long>
{
public static readonly long[] Value=A100639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100639.Bytes);
public long this[int i]=>Value[i];

public static A100639Inst Instance=new A100639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A100640
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,3L,3L,1L,7L,16L,2L,16L,7L,19L,25L,25L,25L,25L,19L,41L,9L,9L,34L,9L,9L,41L,751L,3577L,49L,2989L,2989L,49L,3577L,751L,989L,2944L,-464L,5248L,-454L,5248L,-464L,2944L,989L,2857L,15741L,27L,1209L,2889L,2889L,1209L,27L,15741L,2857L,16067L,26575L,-16175L,5675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A100640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A100640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A100640Inst : IEnumerable<long>
{
public static readonly long[] Value=A100640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A100640.Bytes);
public long this[int i]=>Value[i];

public static A100640Inst Instance=new A100640Inst();

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