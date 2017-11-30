using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A154805
{
public static readonly BigInteger[] Value={ 1111L,11110000L,111100001111L,1111000011110000L,11110000111100001111UL,BigInteger.Parse("111100001111000011110000"),BigInteger.Parse("1111000011110000111100001111"),BigInteger.Parse("11110000111100001111000011110000"),BigInteger.Parse("111100001111000011110000111100001111") };
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
public class A154805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154805.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154805Inst Instance=new A154805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154806
{
public static readonly ulong[] Value={ 15L,240L,3855L,61680L,986895L,15790320L,252645135L,4042322160L,64677154575L,1034834473200L,16557351571215L,264917625139440L,4238682002231055L,67818912035696880L,1085102592571150095L,17361641481138401520UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154806Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A154806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154806.Bytes);
public ulong this[int i]=>Value[i];

public static A154806Inst Instance=new A154806Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154807
{
public static readonly BigInteger[] Value={ 11111L,1111100000L,111110000011111L,11111000001111100000UL,BigInteger.Parse("1111100000111110000011111"),BigInteger.Parse("111110000011111000001111100000"),BigInteger.Parse("11111000001111100000111110000011111"),BigInteger.Parse("1111100000111110000011111000001111100000"),BigInteger.Parse("111110000011111000001111100000111110000011111") };
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
public class A154807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154807Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154807.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154807.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154807Inst Instance=new A154807Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154808
{
public static readonly BigInteger[] Value={ 31L,992L,31775L,1016800L,32537631L,1041204192L,33318534175L,1066193093600L,34118178995231L,1091781727847392L,34937015291116575L,1117984489315730400L,BigInteger.Parse("35775503658103372831"),BigInteger.Parse("1144816117059307930592"),BigInteger.Parse("36634115745897853778975") };
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
public class A154808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154808Inst Instance=new A154808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154809
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,11L,12L,13L,14L,16L,18L,19L,20L,22L,23L,24L,25L,26L,28L,29L,30L,32L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,64L,66L,67L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154809Inst : IEnumerable<long>
{
public static readonly long[] Value=A154809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154809.Bytes);
public long this[int i]=>Value[i];

public static A154809Inst Instance=new A154809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154810
{
public static readonly long[] Value={ 10L,100L,110L,1000L,1010L,1011L,1100L,1101L,1110L,10000L,10010L,10011L,10100L,10110L,10111L,11000L,11001L,11010L,11100L,11101L,11110L,100000L,100010L,100011L,100100L,100101L,100110L,100111L,101000L,101001L,101010L,101011L,101100L,101110L,101111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154810Inst : IEnumerable<long>
{
public static readonly long[] Value=A154810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154810.Bytes);
public long this[int i]=>Value[i];

public static A154810Inst Instance=new A154810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154811
{
public static readonly long[] Value={ 1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L,1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L,1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L,1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L,1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L,1L,2L,5L,4L,7L,8L,8L,7L,4L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154811Inst : IEnumerable<long>
{
public static readonly long[] Value=A154811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154811.Bytes);
public long this[int i]=>Value[i];

public static A154811Inst Instance=new A154811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154812
{
public static readonly long[] Value={ 2L,11L,13L,19L,23L,29L,31L,41L,47L,59L,61L,67L,79L,97L,103L,107L,109L,113L,157L,163L,167L,191L,193L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,331L,337L,367L,373L,379L,383L,389L,401L,419L,433L,439L,443L,449L,461L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154812Inst : IEnumerable<long>
{
public static readonly long[] Value=A154812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154812.Bytes);
public long this[int i]=>Value[i];

public static A154812Inst Instance=new A154812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154813
{
public static readonly long[] Value={ 2L,11L,41L,43L,59L,101L,127L,173L,211L,223L,241L,263L,307L,311L,313L,317L,389L,419L,487L,557L,601L,613L,617L,619L,647L,673L,677L,727L,739L,751L,757L,761L,827L,839L,853L,857L,883L,929L,953L,971L,1013L,1021L,1033L,1039L,1061L,1091L,1103L,1109L,1123L,1151L,1181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154813Inst : IEnumerable<long>
{
public static readonly long[] Value=A154813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154813.Bytes);
public long this[int i]=>Value[i];

public static A154813Inst Instance=new A154813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154814
{
public static readonly long[] Value={ 1L,0L,5L,0L,5L,9L,8L,1L,4L,0L,1L,4L,8L,7L,7L,4L,1L,9L,1L,9L,1L,5L,6L,2L,7L,4L,7L,4L,2L,6L,0L,3L,2L,2L,8L,8L,2L,4L,0L,2L,6L,4L,6L,3L,7L,8L,8L,2L,7L,6L,7L,9L,2L,3L,9L,5L,6L,8L,1L,7L,0L,2L,6L,4L,4L,3L,0L,7L,8L,4L,1L,9L,9L,9L,9L,0L,0L,7L,0L,1L,8L,5L,1L,5L,0L,0L,6L,3L,4L,3L,6L,0L,7L,2L,6L,3L,3L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154814Inst : IEnumerable<long>
{
public static readonly long[] Value=A154814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154814.Bytes);
public long this[int i]=>Value[i];

public static A154814Inst Instance=new A154814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154815
{
public static readonly long[] Value={ 8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L,4L,5L,2L,1L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154815Inst : IEnumerable<long>
{
public static readonly long[] Value=A154815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154815.Bytes);
public long this[int i]=>Value[i];

public static A154815Inst Instance=new A154815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154816
{
public static readonly long[] Value={ 2L,5L,5L,17L,66L,17L,65L,685L,685L,65L,257L,6572L,16342L,6572L,257L,1025L,60675L,313300L,313300L,60675L,1025L,4097L,549418L,5340455L,10712060L,5340455L,549418L,4097L,16385L,4931825L,84856215L,303945575L,303945575L,84856215L,4931825L,16385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154816Inst : IEnumerable<long>
{
public static readonly long[] Value=A154816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154816.Bytes);
public long this[int i]=>Value[i];

public static A154816Inst Instance=new A154816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154817
{
public static readonly long[] Value={ 6L,23L,23L,76L,230L,76L,237L,1682L,1682L,237L,722L,10543L,23548L,10543L,722L,2179L,60657L,259723L,259723L,60657L,2179L,6552L,331612L,2485288L,4675014L,2485288L,331612L,6552L,19673L,1756340L,21707972L,69413294L,69413294L,21707972L,1756340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154817Inst : IEnumerable<long>
{
public static readonly long[] Value=A154817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154817.Bytes);
public long this[int i]=>Value[i];

public static A154817Inst Instance=new A154817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154818
{
public static readonly long[] Value={ 69636L,70215L,77058L,80892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154818Inst : IEnumerable<long>
{
public static readonly long[] Value=A154818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154818.Bytes);
public long this[int i]=>Value[i];

public static A154818Inst Instance=new A154818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154819
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,1L,10L,1L,1835L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154819Inst : IEnumerable<long>
{
public static readonly long[] Value=A154819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154819.Bytes);
public long this[int i]=>Value[i];

public static A154819Inst Instance=new A154819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154820
{
public static readonly long[] Value={ 4L,13L,25L,28L,31L,40L,46L,52L,55L,64L,82L,103L,130L,133L,205L,208L,250L,256L,265L,280L,289L,298L,301L,310L,313L,331L,349L,394L,400L,406L,439L,448L,460L,484L,493L,502L,505L,520L,526L,550L,562L,589L,598L,604L,625L,640L,652L,679L,697L,769L,796L,802L,820L,829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154820Inst : IEnumerable<long>
{
public static readonly long[] Value=A154820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154820.Bytes);
public long this[int i]=>Value[i];

public static A154820Inst Instance=new A154820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154821
{
public static readonly long[] Value={ 3L,7L,13L,139L,283L,1063L,1759L,1999L,2719L,2917L,3109L,3583L,4057L,4297L,4723L,5059L,5623L,5749L,6079L,6823L,8707L,9199L,9949L,12697L,15193L,15319L,15607L,16249L,16267L,16993L,17827L,18679L,18793L,20359L,20887L,21727L,22147L,23677L,24019L,24169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154821Inst : IEnumerable<long>
{
public static readonly long[] Value=A154821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154821.Bytes);
public long this[int i]=>Value[i];

public static A154821Inst Instance=new A154821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154822
{
public static readonly long[] Value={ 2161L,4951L,6421L,8761L,12241L,13411L,19891L,20731L,24631L,27271L,28411L,30091L,34981L,40471L,42331L,42901L,52021L,53731L,58111L,60631L,63361L,65701L,74611L,83641L,90841L,95101L,98251L,103171L,104851L,119671L,120871L,131731L,132661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154822Inst : IEnumerable<long>
{
public static readonly long[] Value=A154822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154822.Bytes);
public long this[int i]=>Value[i];

public static A154822Inst Instance=new A154822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154823
{
public static readonly long[] Value={ 3L,37L,157L,373L,877L,2083L,3607L,4153L,6043L,6577L,8737L,10993L,11677L,14029L,16333L,18253L,19429L,20023L,20443L,20743L,20899L,21757L,23227L,24733L,24859L,28477L,28687L,29347L,30223L,32203L,32833L,35869L,36529L,37447L,38833L,42073L,43789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154823Inst : IEnumerable<long>
{
public static readonly long[] Value=A154823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154823.Bytes);
public long this[int i]=>Value[i];

public static A154823Inst Instance=new A154823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154824
{
public static readonly long[] Value={ 3L,356647L,500719L,562759L,784513L,837307L,902017L,1003963L,1258903L,1456519L,1893427L,2157457L,2597953L,5771587L,6757843L,6842503L,7731133L,10035397L,11155957L,11929849L,12276643L,13395727L,14139283L,15609367L,16675003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154824Inst : IEnumerable<long>
{
public static readonly long[] Value=A154824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154824.Bytes);
public long this[int i]=>Value[i];

public static A154824Inst Instance=new A154824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154825
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,5L,3L,-21L,-51L,41L,391L,407L,-1927L,-6227L,2507L,49347L,71109L,-236079L,-966129L,9519L,7408497L,13685205L,-32079981L,-167077221L,-60639939L,1209248505L,2761755543L,-4457338681L,-30629783831L,-22124857219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154825Inst : IEnumerable<long>
{
public static readonly long[] Value=A154825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154825.Bytes);
public long this[int i]=>Value[i];

public static A154825Inst Instance=new A154825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154826
{
public static readonly long[] Value={ 1L,0L,2L,3L,8L,3L,2L,0L,9L,9L,2L,3L,9L,2L,6L,1L,9L,5L,7L,5L,5L,0L,7L,1L,0L,7L,1L,5L,4L,5L,9L,2L,0L,9L,0L,8L,1L,6L,1L,9L,7L,6L,7L,5L,1L,9L,0L,3L,5L,6L,0L,4L,5L,6L,9L,0L,7L,4L,0L,6L,1L,7L,2L,3L,7L,1L,8L,4L,7L,6L,8L,7L,9L,0L,8L,8L,6L,8L,9L,9L,7L,8L,0L,5L,8L,9L,1L,0L,3L,3L,5L,4L,1L,1L,8L,1L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154826Inst : IEnumerable<long>
{
public static readonly long[] Value=A154826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154826.Bytes);
public long this[int i]=>Value[i];

public static A154826Inst Instance=new A154826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154827
{
public static readonly long[] Value={ 9L,7L,8L,6L,0L,2L,1L,6L,8L,4L,7L,2L,9L,0L,4L,1L,2L,1L,5L,5L,9L,0L,4L,5L,9L,6L,4L,9L,2L,7L,9L,1L,1L,2L,2L,9L,5L,7L,7L,0L,4L,3L,8L,6L,2L,4L,3L,3L,4L,5L,4L,7L,9L,1L,1L,4L,5L,4L,0L,1L,5L,7L,0L,1L,0L,8L,7L,8L,9L,2L,4L,4L,6L,2L,8L,2L,1L,0L,7L,4L,3L,7L,9L,7L,1L,0L,6L,0L,7L,5L,2L,1L,9L,2L,0L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154827Inst : IEnumerable<long>
{
public static readonly long[] Value=A154827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154827.Bytes);
public long this[int i]=>Value[i];

public static A154827Inst Instance=new A154827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154828
{
public static readonly BigInteger[] Value={ 1L,2L,8L,52L,548L,9852L,323988L,20589852L,2599737428L,658007495452L,334291709264468L,340646270830877852L,BigInteger.Parse("695599447171017236308"),BigInteger.Parse("2844303802537519899994652"),BigInteger.Parse("23277772627131826189210443348") };
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
public class A154828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154828.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154828Inst Instance=new A154828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154829
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,17L,25L,9L,1L,171L,258L,102L,16L,1L,3113L,4635L,1788L,290L,25L,1L,106419L,154048L,54909L,7910L,665L,36L,1L,7035649L,9907933L,3232971L,385669L,26257L,1323L,49L,1L,915028347L,1262093470L,382948336L,37703584L,1889650L,71596L,2380L,64L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154829Inst : IEnumerable<long>
{
public static readonly long[] Value=A154829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154829.Bytes);
public long this[int i]=>Value[i];

public static A154829Inst Instance=new A154829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154830
{
public static readonly long[] Value={ 9L,5L,9L,2L,4L,9L,8L,6L,6L,2L,7L,2L,5L,2L,5L,7L,7L,8L,9L,4L,2L,7L,3L,6L,6L,5L,9L,6L,4L,2L,0L,9L,2L,2L,4L,7L,0L,7L,2L,7L,1L,1L,7L,2L,0L,0L,7L,6L,2L,8L,2L,2L,6L,3L,9L,1L,4L,5L,7L,9L,6L,0L,2L,8L,5L,9L,6L,5L,1L,6L,2L,2L,9L,7L,2L,7L,5L,8L,1L,7L,9L,4L,0L,2L,6L,2L,2L,5L,6L,5L,9L,2L,0L,5L,6L,4L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154830Inst : IEnumerable<long>
{
public static readonly long[] Value=A154830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154830.Bytes);
public long this[int i]=>Value[i];

public static A154830Inst Instance=new A154830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154831
{
public static readonly long[] Value={ 3L,7L,11L,13L,21L,29L,39L,41L,43L,49L,53L,59L,73L,83L,85L,87L,95L,99L,101L,119L,129L,141L,143L,175L,181L,185L,189L,207L,217L,239L,241L,277L,279L,293L,311L,315L,323L,339L,343L,363L,367L,371L,375L,381L,389L,409L,421L,433L,435L,451L,473L,483L,497L,503L,507L,515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154831Inst : IEnumerable<long>
{
public static readonly long[] Value=A154831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154831.Bytes);
public long this[int i]=>Value[i];

public static A154831Inst Instance=new A154831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154832
{
public static readonly long[] Value={ 3L,7L,11L,13L,29L,41L,43L,53L,59L,73L,83L,101L,181L,239L,241L,277L,293L,311L,367L,389L,409L,421L,433L,503L,587L,617L,647L,683L,757L,773L,811L,823L,839L,881L,907L,953L,1019L,1093L,1117L,1187L,1249L,1361L,1471L,1481L,1543L,1553L,1571L,1637L,1667L,1747L,1789L,1847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154832Inst : IEnumerable<long>
{
public static readonly long[] Value=A154832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154832.Bytes);
public long this[int i]=>Value[i];

public static A154832Inst Instance=new A154832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154833
{
public static readonly long[] Value={ 3L,13L,31L,63L,93L,139L,181L,211L,229L,265L,271L,303L,325L,339L,343L,345L,411L,441L,519L,523L,531L,549L,555L,573L,619L,663L,675L,681L,693L,741L,751L,805L,819L,835L,853L,861L,945L,951L,969L,975L,993L,1063L,1071L,1095L,1119L,1143L,1275L,1281L,1305L,1329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154833Inst : IEnumerable<long>
{
public static readonly long[] Value=A154833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154833.Bytes);
public long this[int i]=>Value[i];

public static A154833Inst Instance=new A154833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154834
{
public static readonly long[] Value={ 3L,13L,31L,139L,181L,211L,229L,271L,523L,619L,751L,853L,1063L,1483L,1699L,2791L,3361L,3463L,3541L,3769L,4051L,4201L,4801L,4861L,4903L,5521L,5689L,5701L,6163L,6211L,6763L,6823L,6949L,7621L,8059L,8269L,8389L,8419L,8563L,8689L,8713L,9001L,9103L,9319L,10303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154834Inst : IEnumerable<long>
{
public static readonly long[] Value=A154834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154834.Bytes);
public long this[int i]=>Value[i];

public static A154834Inst Instance=new A154834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154835
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,72L,205L,597L,1770L,5329L,16253L,50112L,155939L,489111L,1544723L,4908164L,15678715L,50323541L,162213311L,524895810L,1704407999L,5552027379L,18137964251L,59412854411L,195090277189L,642056206297L,2117485840188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154835Inst : IEnumerable<long>
{
public static readonly long[] Value=A154835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154835.Bytes);
public long this[int i]=>Value[i];

public static A154835Inst Instance=new A154835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154836
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,36L,104L,311L,955L,2994L,9542L,30818L,100633L,331657L,1101708L,3684785L,12398126L,41936805L,142520868L,486400191L,1666330558L,5728305895L,19754004806L,68317426480L,236893446915L,823435684539L,2868676129248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154836Inst : IEnumerable<long>
{
public static readonly long[] Value=A154836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154836.Bytes);
public long this[int i]=>Value[i];

public static A154836Inst Instance=new A154836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154837
{
public static readonly long[] Value={ 9L,4L,1L,6L,3L,5L,6L,5L,3L,4L,6L,6L,5L,5L,2L,9L,4L,5L,7L,8L,7L,8L,6L,1L,8L,4L,0L,1L,4L,7L,3L,6L,7L,4L,1L,5L,3L,4L,1L,6L,2L,7L,1L,0L,6L,5L,1L,1L,2L,6L,4L,1L,8L,9L,1L,5L,2L,5L,2L,9L,4L,7L,4L,0L,1L,1L,4L,2L,9L,2L,0L,8L,5L,2L,8L,2L,1L,7L,9L,2L,7L,0L,0L,9L,7L,6L,0L,1L,8L,3L,4L,9L,9L,1L,3L,4L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154837Inst : IEnumerable<long>
{
public static readonly long[] Value=A154837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154837.Bytes);
public long this[int i]=>Value[i];

public static A154837Inst Instance=new A154837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154838
{
public static readonly long[] Value={ 9L,2L,5L,5L,1L,2L,8L,5L,2L,6L,3L,9L,0L,3L,6L,6L,9L,7L,0L,5L,4L,7L,9L,0L,8L,0L,4L,3L,9L,0L,5L,6L,1L,9L,8L,3L,5L,6L,3L,8L,6L,2L,0L,2L,9L,4L,9L,4L,2L,6L,3L,4L,4L,7L,3L,5L,8L,4L,7L,1L,1L,7L,6L,4L,5L,4L,0L,9L,8L,2L,1L,6L,1L,2L,0L,6L,3L,3L,5L,3L,8L,8L,5L,5L,8L,6L,2L,3L,3L,6L,1L,7L,9L,0L,1L,5L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154838Inst : IEnumerable<long>
{
public static readonly long[] Value=A154838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154838.Bytes);
public long this[int i]=>Value[i];

public static A154838Inst Instance=new A154838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154839
{
public static readonly long[] Value={ 9L,1L,0L,6L,8L,0L,9L,9L,4L,7L,8L,7L,8L,1L,1L,9L,9L,1L,9L,2L,8L,3L,0L,3L,8L,8L,8L,4L,0L,3L,5L,6L,3L,9L,8L,2L,5L,6L,4L,2L,6L,2L,3L,6L,4L,9L,6L,5L,2L,9L,3L,1L,8L,4L,6L,6L,8L,2L,9L,9L,8L,2L,6L,8L,6L,2L,4L,3L,4L,7L,3L,7L,0L,2L,7L,4L,1L,9L,0L,7L,0L,3L,3L,1L,5L,3L,7L,9L,2L,6L,1L,0L,6L,9L,3L,6L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154839Inst : IEnumerable<long>
{
public static readonly long[] Value=A154839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154839.Bytes);
public long this[int i]=>Value[i];

public static A154839Inst Instance=new A154839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154840
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,2L,1L,7L,1L,2L,3L,4L,5L,6L,7L,8L,9L,9L,8L,7L,6L,5L,4L,3L,2L,1L,19L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,37L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154840Inst : IEnumerable<long>
{
public static readonly long[] Value=A154840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154840.Bytes);
public long this[int i]=>Value[i];

public static A154840Inst Instance=new A154840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154841
{
public static readonly long[] Value={ 8L,8L,4L,7L,3L,6L,7L,4L,3L,9L,9L,9L,7L,7L,7L,4L,6L,6L,0L,3L,4L,9L,0L,6L,6L,6L,1L,9L,3L,7L,4L,6L,2L,0L,7L,8L,5L,8L,5L,3L,7L,6L,8L,4L,7L,3L,9L,9L,1L,2L,7L,1L,3L,9L,1L,6L,0L,9L,1L,7L,5L,1L,4L,6L,2L,7L,8L,3L,4L,4L,8L,8L,1L,1L,4L,8L,7L,4L,7L,5L,9L,2L,1L,8L,9L,6L,3L,5L,6L,4L,3L,1L,0L,6L,0L,2L,3L,7L,1L,7L,1L,0L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154841Inst : IEnumerable<long>
{
public static readonly long[] Value=A154841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154841.Bytes);
public long this[int i]=>Value[i];

public static A154841Inst Instance=new A154841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154842
{
public static readonly long[] Value={ 8L,9L,6L,9L,7L,5L,2L,9L,6L,8L,7L,0L,3L,0L,1L,7L,5L,7L,9L,1L,0L,2L,4L,9L,3L,5L,3L,6L,1L,3L,9L,2L,1L,8L,8L,3L,5L,9L,1L,6L,5L,1L,5L,2L,9L,7L,6L,8L,8L,8L,8L,0L,3L,8L,9L,0L,3L,0L,4L,6L,8L,4L,4L,2L,6L,0L,4L,5L,8L,1L,2L,0L,0L,2L,5L,6L,0L,5L,6L,9L,5L,6L,7L,0L,3L,1L,7L,9L,0L,7L,7L,2L,2L,8L,1L,5L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154842Inst : IEnumerable<long>
{
public static readonly long[] Value=A154842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154842.Bytes);
public long this[int i]=>Value[i];

public static A154842Inst Instance=new A154842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154843
{
public static readonly long[] Value={ 2L,1L,1L,1L,-2L,1L,1L,-1L,-1L,1L,1L,-12L,22L,-12L,1L,1L,14L,-15L,-15L,14L,1L,1L,-135L,359L,-450L,359L,-135L,1L,1L,699L,-1589L,889L,889L,-1589L,699L,1L,1L,-5068L,13390L,-15092L,13538L,-15092L,13390L,-5068L,1L,1L,40284L,-109038L,113588L,-44835L,-44835L,113588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154843Inst : IEnumerable<long>
{
public static readonly long[] Value=A154843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154843.Bytes);
public long this[int i]=>Value[i];

public static A154843Inst Instance=new A154843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154844
{
public static readonly long[] Value={ 2L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,7L,14L,7L,1L,1L,11L,40L,40L,11L,1L,1L,16L,96L,180L,96L,16L,1L,1L,22L,203L,651L,651L,203L,22L,1L,1L,29L,393L,2016L,3402L,2016L,393L,29L,1L,1L,37L,717L,5671L,14721L,14721L,5671L,717L,37L,1L,1L,46L,1261L,15210L,56932L,85050L,56932L,15210L,1261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154844Inst : IEnumerable<long>
{
public static readonly long[] Value=A154844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154844.Bytes);
public long this[int i]=>Value[i];

public static A154844Inst Instance=new A154844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154845
{
public static readonly long[] Value={ 8L,8L,4L,2L,5L,8L,9L,1L,7L,8L,3L,0L,0L,1L,4L,9L,8L,4L,5L,9L,9L,1L,8L,4L,2L,1L,6L,3L,8L,1L,7L,3L,4L,0L,5L,9L,3L,8L,6L,9L,5L,6L,4L,1L,4L,7L,0L,6L,2L,2L,6L,6L,1L,6L,1L,1L,2L,2L,3L,6L,9L,3L,8L,6L,5L,8L,2L,3L,1L,2L,9L,1L,0L,4L,0L,8L,8L,9L,7L,1L,7L,3L,5L,3L,2L,7L,0L,0L,0L,2L,2L,6L,7L,3L,9L,3L,1L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154845Inst : IEnumerable<long>
{
public static readonly long[] Value=A154845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154845.Bytes);
public long this[int i]=>Value[i];

public static A154845Inst Instance=new A154845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154846
{
public static readonly long[] Value={ 8L,7L,2L,4L,1L,7L,1L,6L,7L,9L,4L,2L,1L,2L,6L,2L,3L,6L,9L,1L,7L,3L,5L,1L,2L,2L,5L,7L,7L,3L,5L,5L,3L,5L,5L,4L,5L,1L,0L,6L,4L,1L,7L,0L,1L,9L,9L,7L,9L,9L,9L,0L,7L,0L,4L,5L,8L,9L,5L,2L,6L,2L,5L,8L,5L,6L,7L,3L,6L,9L,5L,2L,6L,0L,0L,3L,9L,6L,9L,4L,0L,3L,9L,1L,9L,6L,7L,0L,8L,5L,6L,7L,5L,2L,8L,8L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154846Inst : IEnumerable<long>
{
public static readonly long[] Value=A154846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154846.Bytes);
public long this[int i]=>Value[i];

public static A154846Inst Instance=new A154846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154847
{
public static readonly long[] Value={ 4L,0L,8L,7L,4L,6L,2L,8L,4L,1L,2L,5L,0L,3L,3L,9L,4L,0L,8L,2L,5L,4L,0L,6L,6L,0L,1L,0L,8L,1L,0L,4L,0L,4L,3L,5L,4L,0L,1L,1L,2L,6L,7L,2L,8L,2L,3L,4L,4L,8L,2L,0L,6L,8L,8L,1L,2L,6L,6L,0L,9L,0L,6L,4L,3L,8L,6L,6L,9L,6L,5L,0L,9L,0L,4L,7L,3L,8L,2L,0L,6L,8L,2L,9L,7L,3L,4L,3L,1L,5L,1L,8L,4L,3L,6L,8L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154847Inst : IEnumerable<long>
{
public static readonly long[] Value=A154847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154847.Bytes);
public long this[int i]=>Value[i];

public static A154847Inst Instance=new A154847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154848
{
public static readonly long[] Value={ 2L,5L,7L,8L,9L,0L,1L,9L,2L,3L,1L,6L,2L,5L,6L,5L,8L,9L,3L,5L,1L,6L,3L,7L,4L,2L,4L,4L,6L,4L,0L,1L,7L,7L,6L,4L,4L,4L,8L,1L,7L,5L,4L,2L,9L,4L,7L,3L,9L,4L,4L,6L,7L,8L,9L,4L,9L,3L,7L,7L,4L,6L,0L,8L,9L,4L,0L,9L,7L,3L,6L,8L,7L,0L,5L,2L,3L,8L,1L,4L,2L,5L,6L,3L,0L,1L,3L,9L,7L,5L,9L,9L,9L,1L,6L,3L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154848Inst : IEnumerable<long>
{
public static readonly long[] Value=A154848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154848.Bytes);
public long this[int i]=>Value[i];

public static A154848Inst Instance=new A154848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154849
{
public static readonly long[] Value={ 2L,0L,4L,3L,7L,3L,1L,4L,2L,0L,6L,2L,5L,1L,6L,9L,7L,0L,4L,1L,2L,7L,0L,3L,3L,0L,0L,5L,4L,0L,5L,2L,0L,2L,1L,7L,7L,0L,0L,5L,6L,3L,3L,6L,4L,1L,1L,7L,2L,4L,1L,0L,3L,4L,4L,0L,6L,3L,3L,0L,4L,5L,3L,2L,1L,9L,3L,3L,4L,8L,2L,5L,4L,5L,2L,3L,6L,9L,1L,0L,3L,4L,1L,4L,8L,6L,7L,1L,5L,7L,5L,9L,2L,1L,8L,4L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154849Inst : IEnumerable<long>
{
public static readonly long[] Value=A154849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154849.Bytes);
public long this[int i]=>Value[i];

public static A154849Inst Instance=new A154849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154850
{
public static readonly long[] Value={ 1L,7L,6L,0L,3L,7L,4L,4L,2L,7L,7L,2L,2L,5L,8L,7L,9L,6L,0L,0L,9L,8L,6L,8L,1L,8L,6L,1L,2L,4L,8L,0L,5L,1L,7L,1L,9L,9L,8L,6L,3L,8L,0L,8L,2L,5L,4L,3L,8L,4L,7L,1L,0L,5L,5L,9L,4L,6L,0L,8L,9L,6L,4L,5L,7L,4L,8L,8L,6L,2L,3L,7L,6L,8L,8L,5L,4L,0L,9L,9L,5L,2L,8L,0L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154850Inst : IEnumerable<long>
{
public static readonly long[] Value=A154850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154850.Bytes);
public long this[int i]=>Value[i];

public static A154850Inst Instance=new A154850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154851
{
public static readonly long[] Value={ 2L,2L,2L,2L,4L,2L,3L,9L,9L,3L,7L,24L,34L,24L,7L,31L,103L,154L,154L,103L,31L,241L,778L,1055L,1036L,1055L,778L,241L,3121L,10127L,12957L,10083L,10083L,12957L,10127L,3121L,65521L,215148L,274724L,184020L,117846L,184020L,274724L,215148L,65521L,2227681L,7378804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154851Inst : IEnumerable<long>
{
public static readonly long[] Value=A154851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154851.Bytes);
public long this[int i]=>Value[i];

public static A154851Inst Instance=new A154851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154852
{
public static readonly long[] Value={ -1L,1L,-2L,0L,2L,-7L,-3L,3L,7L,-20L,-56L,0L,56L,20L,-61L,-415L,-370L,370L,415L,61L,-182L,-2632L,-5710L,0L,5710L,2632L,182L,-547L,-15155L,-64407L,-49735L,49735L,64407L,15155L,547L,-1640L,-82896L,-619696L,-1085840L,0L,1085840L,619696L,82896L,1640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154852Inst : IEnumerable<long>
{
public static readonly long[] Value=A154852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154852.Bytes);
public long this[int i]=>Value[i];

public static A154852Inst Instance=new A154852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154853
{
public static readonly long[] Value={ 1L,-1L,3L,0L,-3L,7L,33L,-33L,-7L,15L,294L,0L,-294L,-15L,31L,1915L,3820L,-3820L,-1915L,-31L,63L,11088L,65115L,0L,-65115L,-11088L,-63L,127L,60725L,783237L,1019935L,-1019935L,-783237L,-60725L,-127L,255L,322794L,8095794L,26928930L,0L,-26928930L,-8095794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154853Inst : IEnumerable<long>
{
public static readonly long[] Value=A154853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154853.Bytes);
public long this[int i]=>Value[i];

public static A154853Inst Instance=new A154853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154854
{
public static readonly long[] Value={ 1L,-1L,4L,0L,-4L,13L,57L,-57L,-13L,40L,688L,0L,-688L,-40L,121L,6115L,11770L,-11770L,-6115L,-121L,364L,48464L,270620L,0L,-270620L,-48464L,-364L,1093L,363965L,4401033L,5613265L,-5613265L,-4401033L,-363965L,-1093L,3280L,2657568L,61590368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154854Inst : IEnumerable<long>
{
public static readonly long[] Value=A154854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154854.Bytes);
public long this[int i]=>Value[i];

public static A154854Inst Instance=new A154854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154855
{
public static readonly long[] Value={ 1L,-1L,5L,0L,-5L,21L,87L,-87L,-21L,85L,1330L,0L,-1330L,-85L,341L,15045L,28160L,-28160L,-15045L,-341L,1365L,152040L,816825L,0L,-816825L,-152040L,-1365L,5461L,1457323L,16786931L,21064365L,-21064365L,-16786931L,-1457323L,-5461L,21845L,13592430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154855Inst : IEnumerable<long>
{
public static readonly long[] Value=A154855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154855.Bytes);
public long this[int i]=>Value[i];

public static A154855Inst Instance=new A154855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154856
{
public static readonly long[] Value={ 1L,5L,8L,1L,2L,4L,6L,4L,7L,4L,6L,0L,4L,5L,6L,9L,2L,1L,0L,8L,4L,5L,8L,2L,3L,9L,8L,7L,0L,2L,4L,3L,2L,2L,8L,1L,2L,4L,1L,3L,1L,8L,4L,8L,9L,2L,7L,0L,6L,0L,2L,0L,9L,8L,1L,3L,0L,6L,8L,0L,5L,5L,3L,3L,4L,7L,0L,4L,0L,0L,0L,5L,6L,6L,2L,7L,7L,6L,4L,3L,9L,2L,5L,8L,6L,4L,6L,9L,9L,4L,7L,8L,7L,3L,7L,5L,4L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154856Inst : IEnumerable<long>
{
public static readonly long[] Value=A154856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154856.Bytes);
public long this[int i]=>Value[i];

public static A154856Inst Instance=new A154856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154857
{
public static readonly long[] Value={ 1L,4L,5L,5L,9L,8L,3L,6L,4L,1L,0L,9L,0L,3L,4L,7L,5L,9L,5L,9L,4L,2L,1L,0L,9L,3L,5L,8L,7L,9L,4L,1L,9L,4L,6L,7L,0L,6L,0L,4L,7L,3L,7L,1L,2L,7L,5L,8L,3L,1L,6L,4L,4L,7L,1L,8L,5L,1L,7L,7L,8L,5L,5L,3L,6L,6L,5L,4L,6L,5L,7L,6L,0L,2L,3L,2L,0L,4L,8L,0L,6L,2L,0L,4L,9L,8L,9L,5L,3L,8L,7L,2L,2L,0L,3L,7L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154857Inst : IEnumerable<long>
{
public static readonly long[] Value=A154857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154857.Bytes);
public long this[int i]=>Value[i];

public static A154857Inst Instance=new A154857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154858
{
public static readonly long[] Value={ 1L,3L,6L,2L,4L,8L,7L,6L,1L,3L,7L,5L,0L,1L,1L,3L,1L,3L,6L,0L,8L,4L,6L,8L,8L,6L,7L,0L,2L,7L,0L,1L,3L,4L,7L,8L,4L,6L,7L,0L,4L,2L,2L,4L,2L,7L,4L,4L,8L,2L,7L,3L,5L,6L,2L,7L,0L,8L,8L,6L,9L,6L,8L,8L,1L,2L,8L,8L,9L,8L,8L,3L,6L,3L,4L,9L,1L,2L,7L,3L,5L,6L,0L,9L,9L,1L,1L,4L,3L,8L,3L,9L,4L,7L,8L,9L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154858Inst : IEnumerable<long>
{
public static readonly long[] Value=A154858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154858.Bytes);
public long this[int i]=>Value[i];

public static A154858Inst Instance=new A154858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154859
{
public static readonly long[] Value={ 1L,2L,8L,9L,4L,5L,0L,9L,6L,1L,5L,8L,1L,2L,8L,2L,9L,4L,6L,7L,5L,8L,1L,8L,7L,1L,2L,2L,3L,2L,0L,0L,8L,8L,8L,2L,2L,2L,4L,0L,8L,7L,7L,1L,4L,7L,3L,6L,9L,7L,2L,3L,3L,9L,4L,7L,4L,6L,8L,8L,7L,3L,0L,4L,4L,7L,0L,4L,8L,6L,8L,4L,3L,5L,2L,6L,1L,9L,0L,7L,1L,2L,8L,1L,5L,0L,6L,9L,8L,7L,9L,9L,9L,5L,8L,1L,8L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154859Inst : IEnumerable<long>
{
public static readonly long[] Value=A154859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154859.Bytes);
public long this[int i]=>Value[i];

public static A154859Inst Instance=new A154859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154860
{
public static readonly long[] Value={ 1L,2L,3L,0L,4L,4L,8L,9L,2L,1L,3L,7L,8L,2L,7L,3L,9L,2L,8L,5L,4L,0L,1L,6L,9L,8L,9L,4L,3L,2L,8L,3L,3L,7L,0L,3L,0L,0L,0L,7L,5L,6L,7L,3L,7L,8L,4L,2L,5L,0L,4L,6L,3L,9L,7L,3L,8L,0L,3L,6L,8L,4L,8L,2L,3L,4L,4L,6L,9L,4L,0L,6L,2L,2L,5L,7L,1L,1L,8L,1L,8L,5L,7L,9L,5L,6L,8L,4L,6L,7L,0L,0L,9L,8L,4L,6L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154860Inst : IEnumerable<long>
{
public static readonly long[] Value=A154860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154860.Bytes);
public long this[int i]=>Value[i];

public static A154860Inst Instance=new A154860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154861
{
public static readonly long[] Value={ 1L,1L,8L,1L,5L,4L,1L,7L,3L,6L,2L,8L,6L,8L,4L,9L,7L,9L,5L,9L,2L,3L,1L,5L,9L,4L,3L,4L,6L,2L,7L,2L,7L,0L,9L,2L,4L,6L,5L,4L,5L,6L,2L,9L,0L,5L,9L,2L,0L,8L,3L,6L,5L,9L,3L,6L,7L,6L,7L,9L,4L,6L,6L,0L,0L,1L,4L,4L,2L,0L,3L,8L,1L,2L,9L,5L,2L,6L,7L,1L,7L,6L,6L,7L,1L,6L,3L,6L,1L,8L,5L,3L,9L,7L,1L,8L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154861Inst : IEnumerable<long>
{
public static readonly long[] Value=A154861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154861.Bytes);
public long this[int i]=>Value[i];

public static A154861Inst Instance=new A154861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154862
{
public static readonly long[] Value={ 1L,1L,9L,21L,45L,51L,65L,105L,133L,153L,209L,243L,247L,325L,357L,385L,413L,459L,495L,531L,675L,707L,729L,789L,805L,845L,891L,913L,951L,981L,1003L,1067L,1083L,1111L,1125L,1203L,1313L,1335L,1347L,1369L,1395L,1417L,1557L,1625L,1703L,1725L,1935L,1967L,2133L,2211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154862Inst : IEnumerable<long>
{
public static readonly long[] Value=A154862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154862.Bytes);
public long this[int i]=>Value[i];

public static A154862Inst Instance=new A154862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154863
{
public static readonly long[] Value={ 13L,23L,47L,53L,61L,79L,83L,89L,103L,107L,151L,179L,181L,197L,227L,257L,277L,281L,283L,311L,313L,331L,347L,353L,389L,409L,569L,601L,607L,631L,643L,647L,653L,701L,709L,739L,743L,761L,769L,797L,821L,823L,827L,829L,857L,859L,877L,881L,883L,929L,947L,991L,997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154863Inst : IEnumerable<long>
{
public static readonly long[] Value=A154863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154863.Bytes);
public long this[int i]=>Value[i];

public static A154863Inst Instance=new A154863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154864
{
public static readonly long[] Value={ 1L,14L,18L,38L,42L,56L,60L,76L,82L,84L,86L,90L,93L,110L,112L,115L,116L,117L,119L,121L,124L,138L,141L,142L,143L,144L,147L,148L,150L,152L,153L,154L,172L,178L,192L,194L,195L,208L,218L,221L,224L,234L,235L,236L,250L,252L,255L,261L,276L,279L,280L,282L,284L,285L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154864Inst : IEnumerable<long>
{
public static readonly long[] Value=A154864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154864.Bytes);
public long this[int i]=>Value[i];

public static A154864Inst Instance=new A154864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154865
{
public static readonly long[] Value={ 2L,3L,22L,23L,25L,52L,55L,56L,57L,59L,62L,72L,73L,75L,77L,78L,85L,332L,333L,334L,336L,337L,338L,342L,345L,346L,348L,352L,354L,355L,356L,357L,363L,364L,365L,366L,367L,372L,373L,375L,376L,378L,382L,383L,384L,385L,386L,388L,389L,392L,393L,398L,423L,424L,425L,426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154865Inst : IEnumerable<long>
{
public static readonly long[] Value=A154865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154865.Bytes);
public long this[int i]=>Value[i];

public static A154865Inst Instance=new A154865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154866
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,31L,37L,41L,43L,53L,71L,73L,83L,113L,131L,137L,139L,149L,151L,157L,167L,191L,193L,199L,211L,241L,251L,271L,281L,331L,347L,349L,353L,359L,397L,491L,521L,541L,569L,571L,577L,593L,599L,613L,631L,659L,661L,691L,719L,733L,743L,773L,797L,821L,853L,857L,859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154866Inst : IEnumerable<long>
{
public static readonly long[] Value=A154866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154866.Bytes);
public long this[int i]=>Value[i];

public static A154866Inst Instance=new A154866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154867
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,8L,12L,8L,1L,1L,16L,35L,35L,16L,1L,1L,32L,105L,130L,105L,32L,1L,1L,64L,322L,490L,490L,322L,64L,1L,1L,128L,994L,1967L,2100L,1967L,994L,128L,1L,1L,256L,3061L,8232L,9597L,9597L,8232L,3061L,256L,1L,1L,512L,9375L,34855L,48405L,45654L,48405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154867Inst : IEnumerable<long>
{
public static readonly long[] Value=A154867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154867.Bytes);
public long this[int i]=>Value[i];

public static A154867Inst Instance=new A154867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154868
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,23L,31L,37L,47L,53L,67L,71L,73L,89L,103L,107L,109L,113L,131L,137L,139L,149L,151L,157L,167L,191L,193L,199L,227L,229L,233L,239L,251L,257L,269L,271L,277L,293L,331L,347L,349L,353L,359L,397L,449L,467L,491L,499L,503L,509L,521L,523L,541L,547L,569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154868Inst : IEnumerable<long>
{
public static readonly long[] Value=A154868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154868.Bytes);
public long this[int i]=>Value[i];

public static A154868Inst Instance=new A154868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154869
{
public static readonly long[] Value={ 6L,26L,26L,230L,100L,230L,3092L,857L,857L,3092L,53032L,13671L,4816L,13671L,53032L,1094774L,285588L,64514L,64514L,285588L,1094774L,26402826L,7001142L,1517286L,474132L,1517286L,7001142L,26402826L,728697032L,195578147L,43758387L,8678237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154869Inst : IEnumerable<long>
{
public static readonly long[] Value=A154869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154869.Bytes);
public long this[int i]=>Value[i];

public static A154869Inst Instance=new A154869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154870
{
public static readonly long[] Value={ 7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L,-7L,-5L,-1L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154870Inst : IEnumerable<long>
{
public static readonly long[] Value=A154870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154870.Bytes);
public long this[int i]=>Value[i];

public static A154870Inst Instance=new A154870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154871
{
public static readonly long[] Value={ 3470187L,3554463L,3887058L,4328241L,4497738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154871Inst : IEnumerable<long>
{
public static readonly long[] Value=A154871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154871.Bytes);
public long this[int i]=>Value[i];

public static A154871Inst Instance=new A154871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154872
{
public static readonly long[] Value={ 5L,7L,13L,20L,30L,31L,32L,33L,35L,37L,45L,47L,53L,54L,67L,105L,112L,113L,115L,121L,125L,133L,135L,152L,157L,167L,200L,201L,202L,203L,205L,207L,210L,211L,215L,217L,220L,221L,222L,225L,227L,230L,231L,232L,233L,235L,237L,245L,247L,250L,251L,255L,257L,270L,271L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154872Inst : IEnumerable<long>
{
public static readonly long[] Value=A154872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154872.Bytes);
public long this[int i]=>Value[i];

public static A154872Inst Instance=new A154872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154873
{
public static readonly long[] Value={ 643905L,680061L,720558L,775113L,840501L,878613L,984927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154873Inst : IEnumerable<long>
{
public static readonly long[] Value=A154873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154873.Bytes);
public long this[int i]=>Value[i];

public static A154873Inst Instance=new A154873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154874
{
public static readonly long[] Value={ 2158479L,2190762L,2205528L,2219322L,2301615L,2330397L,2336268L,2345811L,2358828L,2359026L,2367609L,2388534L,2389119L,2389638L,2397132L,2428986L,2504736L,2524974L,2536152L,2583258L,2590125L,2607222L,2620827L,2622012L,2647866L,2649369L,2658636L,2671593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154874Inst : IEnumerable<long>
{
public static readonly long[] Value=A154874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154874.Bytes);
public long this[int i]=>Value[i];

public static A154874Inst Instance=new A154874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154875
{
public static readonly long[] Value={ 17824719L,17940018L,18027474L,18197931L,18326025L,18798396L,18915888L,18929424L,19027455L,19149462L,19180275L,19196064L,19235673L,19311297L,19322913L,19324275L,19328322L,19455918L,19522575L,19757886L,19793664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154875Inst : IEnumerable<long>
{
public static readonly long[] Value=A154875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154875.Bytes);
public long this[int i]=>Value[i];

public static A154875Inst Instance=new A154875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154876
{
public static readonly long[] Value={ 8691229761L,8776040742L,8800099059L,8812428855L,8813522223L,8815323864L,8823675177L,8886940968L,9239038038L,9324907263L,9480130515L,9500938647L,9643844169L,9801034758L,9857840688L,9872688021L,9962545842L,9970902252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154876Inst : IEnumerable<long>
{
public static readonly long[] Value=A154876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154876.Bytes);
public long this[int i]=>Value[i];

public static A154876Inst Instance=new A154876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154877
{
public static readonly long[] Value={ 16L,22L,61L,79L,97L,106L,115L,127L,151L,160L,172L,202L,217L,220L,229L,235L,238L,253L,271L,283L,292L,325L,328L,352L,382L,388L,445L,454L,457L,475L,511L,523L,532L,544L,547L,574L,601L,610L,709L,712L,721L,745L,754L,790L,823L,832L,838L,883L,907L,922L,970L,1006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154877Inst : IEnumerable<long>
{
public static readonly long[] Value=A154877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154877.Bytes);
public long this[int i]=>Value[i];

public static A154877Inst Instance=new A154877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154878
{
public static readonly long[] Value={ 7L,19L,34L,37L,43L,58L,67L,70L,85L,88L,91L,109L,118L,124L,139L,142L,145L,148L,154L,157L,166L,169L,175L,178L,181L,184L,187L,190L,193L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154878Inst : IEnumerable<long>
{
public static readonly long[] Value=A154878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154878.Bytes);
public long this[int i]=>Value[i];

public static A154878Inst Instance=new A154878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154879
{
public static readonly long[] Value={ 3L,-2L,4L,0L,8L,8L,24L,40L,88L,168L,344L,680L,1368L,2728L,5464L,10920L,21848L,43688L,87384L,174760L,349528L,699048L,1398104L,2796200L,5592408L,11184808L,22369624L,44739240L,89478488L,178956968L,357913944L,715827880L,1431655768L,2863311528L,5726623064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154879Inst : IEnumerable<long>
{
public static readonly long[] Value=A154879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154879.Bytes);
public long this[int i]=>Value[i];

public static A154879Inst Instance=new A154879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154880
{
public static readonly long[] Value={ 2L,67L,239L,241L,283L,331L,547L,577L,769L,829L,1033L,1171L,1399L,1447L,1493L,1601L,1621L,1759L,1933L,2011L,2213L,2243L,2377L,2591L,2609L,2707L,2713L,2749L,2887L,3259L,3511L,3541L,3769L,3793L,3823L,3853L,3911L,4241L,4271L,4373L,4391L,4423L,4651L,4673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154880Inst : IEnumerable<long>
{
public static readonly long[] Value=A154880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154880.Bytes);
public long this[int i]=>Value[i];

public static A154880Inst Instance=new A154880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154881
{
public static readonly long[] Value={ 17L,19L,23L,53L,263L,293L,811L,839L,1277L,1279L,1283L,1373L,1607L,1619L,1877L,3413L,3527L,3593L,3967L,4127L,4423L,4637L,4943L,5273L,5471L,5839L,6029L,6271L,6473L,6529L,7127L,7219L,7237L,7307L,7741L,8237L,8273L,8293L,8513L,8761L,9109L,9323L,9473L,9587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154881Inst : IEnumerable<long>
{
public static readonly long[] Value=A154881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154881.Bytes);
public long this[int i]=>Value[i];

public static A154881Inst Instance=new A154881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154882
{
public static readonly BigInteger[] Value={ 2L,4L,12L,120L,7560L,8648640L,1927522396800L,BigInteger.Parse("4747472432036420486400"),BigInteger.Parse("128438082648984172330026178330296384000"),BigInteger.Parse("6184173455628205993842062057864303743050691444602955105860128640000") };
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
public class A154882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154882Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154882.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154882.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154882Inst Instance=new A154882Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154883
{
public static readonly long[] Value={ 3L,7L,15L,1L,292L,2L,14L,84L,13L,4L,6L,99L,5L,8L,12L,16L,161L,45L,22L,24L,10L,26L,42L,9L,57L,18L,19L,30L,28L,20L,120L,23L,21L,127L,29L,11L,48L,436L,58L,34L,44L,20776L,94L,55L,32L,50L,43L,72L,33L,27L,36L,106L,17L,141L,39L,125L,41L,37L,25L,47L,61L,376L,107L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154883Inst : IEnumerable<long>
{
public static readonly long[] Value=A154883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154883.Bytes);
public long this[int i]=>Value[i];

public static A154883Inst Instance=new A154883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154884
{
public static readonly long[] Value={ 1L,1L,4L,0L,1L,6L,8L,9L,2L,5L,1L,7L,7L,9L,0L,6L,1L,9L,5L,6L,6L,0L,4L,9L,9L,4L,8L,6L,1L,5L,6L,2L,1L,4L,9L,1L,0L,9L,7L,6L,5L,2L,7L,5L,4L,7L,5L,9L,7L,2L,8L,8L,9L,7L,7L,5L,5L,6L,9L,6L,0L,5L,4L,7L,5L,8L,6L,6L,4L,9L,5L,2L,5L,1L,2L,7L,2L,5L,9L,8L,3L,3L,0L,2L,2L,3L,6L,5L,2L,5L,7L,5L,7L,1L,6L,1L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154884Inst : IEnumerable<long>
{
public static readonly long[] Value=A154884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154884.Bytes);
public long this[int i]=>Value[i];

public static A154884Inst Instance=new A154884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154885
{
public static readonly long[] Value={ 1L,1L,0L,4L,5L,8L,8L,4L,1L,4L,5L,0L,9L,7L,4L,0L,3L,3L,7L,4L,3L,2L,4L,0L,5L,8L,4L,9L,2L,7L,1L,5L,9L,5L,4L,4L,6L,0L,4L,2L,0L,3L,1L,7L,6L,8L,3L,6L,3L,7L,2L,1L,7L,3L,6L,3L,3L,0L,6L,5L,9L,3L,2L,1L,2L,6L,6L,3L,6L,5L,2L,2L,7L,3L,9L,2L,6L,3L,0L,4L,0L,8L,6L,0L,3L,4L,3L,3L,4L,9L,5L,8L,7L,1L,7L,1L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154885Inst : IEnumerable<long>
{
public static readonly long[] Value=A154885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154885.Bytes);
public long this[int i]=>Value[i];

public static A154885Inst Instance=new A154885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154886
{
public static readonly BigInteger[] Value={ 1L,5L,51L,655L,20980L,578779L,46097340L,2889706132L,485416306983L,68334145684271L,24330218582223815L,3847311627258606534L,BigInteger.Parse("2716890193805515507433"),BigInteger.Parse("1270766589764097820833691"),BigInteger.Parse("2188031110546839992589840986"),BigInteger.Parse("1331298554328475793875243619997") };
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
public class A154886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154886.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154886Inst Instance=new A154886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154887
{
public static readonly long[] Value={ 1L,2L,11L,71L,838L,7915L,181443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154887Inst : IEnumerable<long>
{
public static readonly long[] Value=A154887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154887.Bytes);
public long this[int i]=>Value[i];

public static A154887Inst Instance=new A154887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154888
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,16L,24L,37L,48L,71L,88L,133L,284L,435L,472L,773L,826L,1835L,4369L,5546L,5649L,9924L,16465L,19944L,32324L,75913L,76168L,140802L,141141L,238514L,537697L,598296L,2556065L,4674085L,4674844L,4985386L,9716587L,23983712L,23984971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154888Inst : IEnumerable<long>
{
public static readonly long[] Value=A154888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154888.Bytes);
public long this[int i]=>Value[i];

public static A154888Inst Instance=new A154888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154889
{
public static readonly long[] Value={ 1L,0L,7L,3L,5L,7L,0L,2L,1L,4L,7L,3L,6L,2L,0L,7L,7L,0L,9L,4L,6L,8L,1L,4L,9L,0L,8L,7L,4L,5L,0L,0L,0L,4L,8L,7L,0L,6L,9L,0L,3L,4L,4L,5L,6L,7L,3L,9L,7L,4L,5L,8L,4L,8L,0L,5L,8L,5L,6L,7L,4L,3L,6L,2L,7L,6L,6L,7L,6L,5L,2L,8L,9L,8L,5L,4L,3L,9L,0L,4L,2L,8L,6L,5L,0L,0L,9L,2L,0L,4L,1L,0L,0L,3L,9L,1L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154889Inst : IEnumerable<long>
{
public static readonly long[] Value=A154889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154889.Bytes);
public long this[int i]=>Value[i];

public static A154889Inst Instance=new A154889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154890
{
public static readonly long[] Value={ 3L,6L,4L,8L,8L,16L,24L,48L,88L,176L,344L,688L,1368L,2736L,5464L,10928L,21848L,43696L,87384L,174768L,349528L,699056L,1398104L,2796208L,5592408L,11184816L,22369624L,44739248L,89478488L,178956976L,357913944L,715827888L,1431655768L,2863311536L,5726623064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154890Inst : IEnumerable<long>
{
public static readonly long[] Value=A154890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154890.Bytes);
public long this[int i]=>Value[i];

public static A154890Inst Instance=new A154890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154891
{
public static readonly long[] Value={ 1L,2L,4L,9L,12L,21L,24L,30L,42L,45L,57L,60L,75L,84L,90L,105L,135L,150L,165L,195L,210L,255L,315L,330L,390L,420L,525L,630L,735L,825L,840L,945L,1050L,1155L,1365L,1575L,1680L,1785L,1995L,2100L,2145L,2205L,2310L,2625L,2730L,3045L,3255L,3465L,3990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154891Inst : IEnumerable<long>
{
public static readonly long[] Value=A154891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154891.Bytes);
public long this[int i]=>Value[i];

public static A154891Inst Instance=new A154891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154892
{
public static readonly long[] Value={ 1L,0L,4L,6L,2L,1L,8L,9L,1L,5L,3L,2L,9L,9L,5L,3L,2L,8L,5L,4L,0L,7L,1L,3L,1L,1L,1L,2L,1L,4L,5L,8L,9L,2L,1L,8L,3L,6L,8L,9L,3L,8L,5L,7L,2L,5L,5L,9L,5L,0L,3L,8L,7L,6L,5L,3L,8L,2L,9L,8L,3L,1L,9L,1L,7L,8L,3L,4L,6L,7L,0L,6L,9L,5L,7L,4L,1L,0L,6L,9L,1L,7L,9L,8L,9L,8L,5L,6L,3L,3L,4L,9L,3L,1L,8L,1L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154892Inst : IEnumerable<long>
{
public static readonly long[] Value=A154892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154892.Bytes);
public long this[int i]=>Value[i];

public static A154892Inst Instance=new A154892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154893
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,16L,17L,19L,23L,29L,31L,36L,37L,41L,43L,47L,48L,53L,59L,61L,64L,67L,71L,73L,79L,80L,81L,83L,89L,97L,100L,101L,103L,107L,109L,112L,113L,120L,127L,131L,137L,139L,144L,149L,151L,157L,162L,163L,167L,168L,173L,176L,179L,181L,191L,193L,196L,197L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154893Inst : IEnumerable<long>
{
public static readonly long[] Value=A154893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154893.Bytes);
public long this[int i]=>Value[i];

public static A154893Inst Instance=new A154893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154894
{
public static readonly long[] Value={ 8L,21L,34L,55L,377L,610L,987L,4181L,10946L,17711L,46368L,75025L,121393L,1346269L,3524578L,5702887L,9227465L,24157817L,39088169L,63245986L,165580141L,701408733L,1134903170L,1836311903L,7778742049L,12586269025L,20365011074L,53316291173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154894Inst : IEnumerable<long>
{
public static readonly long[] Value=A154894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154894.Bytes);
public long this[int i]=>Value[i];

public static A154894Inst Instance=new A154894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154895
{
public static readonly long[] Value={ 6L,28L,8128L,137438691328L,2305843008139952128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154895Inst : IEnumerable<long>
{
public static readonly long[] Value=A154895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154895.Bytes);
public long this[int i]=>Value[i];

public static A154895Inst Instance=new A154895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154896
{
public static readonly BigInteger[] Value={ 3L,23L,487L,8115L,33550311L,8589869023L,137438691291L,2305843008139952067L,BigInteger.Parse("2658455991569831744654692615953842055"),BigInteger.Parse("191561942608236107294793378084303638130997321548169039") };
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
public class A154896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154896Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154896.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154896.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154896Inst Instance=new A154896Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154897
{
public static readonly long[] Value={ 1L,0L,2L,1L,8L,6L,5L,7L,1L,0L,3L,1L,2L,5L,8L,4L,8L,5L,2L,0L,6L,3L,5L,1L,6L,5L,0L,2L,7L,0L,2L,6L,0L,1L,0L,8L,8L,5L,0L,2L,8L,1L,6L,8L,2L,0L,5L,8L,6L,2L,0L,5L,1L,7L,2L,0L,3L,1L,6L,5L,2L,2L,6L,6L,0L,9L,6L,6L,7L,4L,1L,2L,7L,2L,6L,1L,8L,4L,5L,5L,1L,7L,0L,7L,4L,3L,3L,5L,7L,8L,7L,9L,6L,0L,9L,2L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154897Inst : IEnumerable<long>
{
public static readonly long[] Value=A154897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154897.Bytes);
public long this[int i]=>Value[i];

public static A154897Inst Instance=new A154897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154898
{
public static readonly long[] Value={ 9L,8L,0L,2L,2L,4L,5L,4L,5L,9L,6L,5L,8L,2L,6L,5L,8L,6L,1L,3L,3L,3L,6L,8L,1L,0L,5L,0L,4L,8L,7L,6L,3L,6L,1L,1L,5L,4L,2L,1L,7L,5L,7L,3L,7L,1L,1L,0L,3L,8L,0L,8L,9L,2L,7L,0L,7L,2L,2L,2L,6L,9L,1L,3L,4L,5L,6L,3L,7L,5L,7L,5L,6L,9L,9L,0L,9L,9L,6L,2L,2L,3L,0L,9L,2L,0L,4L,5L,9L,9L,8L,3L,2L,6L,5L,5L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154898Inst : IEnumerable<long>
{
public static readonly long[] Value=A154898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154898.Bytes);
public long this[int i]=>Value[i];

public static A154898Inst Instance=new A154898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154899
{
public static readonly long[] Value={ 9L,6L,2L,2L,2L,5L,1L,8L,5L,8L,8L,5L,2L,5L,4L,1L,2L,8L,6L,3L,6L,6L,8L,0L,0L,9L,1L,7L,0L,1L,6L,3L,2L,7L,7L,7L,4L,2L,0L,7L,5L,1L,1L,1L,2L,3L,5L,6L,8L,3L,0L,1L,4L,9L,7L,8L,0L,6L,2L,2L,3L,5L,0L,4L,6L,9L,0L,7L,7L,9L,1L,0L,5L,7L,5L,0L,6L,4L,7L,9L,5L,8L,9L,5L,7L,6L,0L,3L,6L,3L,4L,1L,3L,0L,7L,0L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154899Inst : IEnumerable<long>
{
public static readonly long[] Value=A154899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154899.Bytes);
public long this[int i]=>Value[i];

public static A154899Inst Instance=new A154899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154900
{
public static readonly long[] Value={ 9L,4L,5L,7L,4L,9L,8L,4L,8L,5L,6L,5L,4L,1L,5L,9L,0L,6L,2L,7L,7L,0L,0L,5L,1L,4L,9L,2L,0L,7L,4L,1L,2L,7L,7L,5L,4L,4L,8L,9L,6L,7L,2L,6L,9L,7L,7L,5L,2L,3L,9L,3L,1L,8L,2L,6L,2L,4L,2L,2L,8L,0L,2L,1L,1L,8L,7L,0L,6L,5L,7L,2L,6L,2L,8L,9L,4L,4L,3L,1L,0L,3L,0L,3L,8L,1L,0L,4L,4L,1L,8L,5L,0L,5L,1L,7L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154900Inst : IEnumerable<long>
{
public static readonly long[] Value=A154900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154900.Bytes);
public long this[int i]=>Value[i];

public static A154900Inst Instance=new A154900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154901
{
public static readonly long[] Value={ 9L,3L,0L,5L,9L,3L,6L,8L,1L,6L,0L,7L,0L,1L,8L,8L,8L,4L,5L,1L,1L,1L,3L,4L,7L,7L,6L,7L,8L,6L,6L,5L,0L,2L,4L,9L,3L,1L,8L,7L,9L,3L,0L,0L,0L,7L,8L,4L,0L,7L,5L,3L,6L,5L,5L,9L,8L,5L,2L,6L,0L,2L,3L,7L,6L,4L,8L,3L,1L,2L,9L,7L,4L,5L,0L,1L,8L,8L,5L,8L,9L,4L,2L,5L,6L,7L,6L,9L,3L,8L,8L,2L,8L,0L,9L,4L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154901Inst : IEnumerable<long>
{
public static readonly long[] Value=A154901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154901.Bytes);
public long this[int i]=>Value[i];

public static A154901Inst Instance=new A154901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154902
{
public static readonly long[] Value={ 9L,1L,6L,5L,8L,8L,2L,9L,8L,8L,6L,9L,2L,1L,2L,5L,7L,4L,2L,3L,8L,0L,3L,7L,1L,4L,4L,0L,6L,7L,2L,7L,5L,4L,1L,0L,2L,3L,1L,5L,4L,4L,9L,2L,3L,4L,6L,3L,9L,9L,2L,3L,5L,2L,9L,6L,2L,8L,2L,1L,2L,2L,5L,3L,0L,8L,4L,9L,3L,8L,0L,5L,9L,7L,6L,8L,1L,6L,0L,4L,2L,5L,2L,2L,9L,2L,5L,9L,5L,3L,3L,1L,1L,6L,9L,7L,4L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154902Inst : IEnumerable<long>
{
public static readonly long[] Value=A154902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154902.Bytes);
public long this[int i]=>Value[i];

public static A154902Inst Instance=new A154902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154903
{
public static readonly long[] Value={ 9L,0L,3L,5L,9L,3L,8L,6L,7L,1L,6L,8L,6L,0L,5L,8L,6L,4L,5L,6L,3L,8L,2L,4L,8L,7L,3L,7L,5L,6L,5L,8L,1L,8L,4L,3L,8L,4L,0L,0L,7L,0L,1L,3L,6L,2L,6L,1L,8L,1L,9L,1L,8L,8L,7L,6L,0L,1L,5L,5L,8L,0L,0L,2L,7L,6L,9L,6L,7L,7L,2L,3L,3L,6L,0L,6L,7L,2L,0L,2L,2L,0L,0L,2L,5L,8L,8L,1L,9L,7L,4L,1L,5L,4L,1L,6L,4L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154903Inst : IEnumerable<long>
{
public static readonly long[] Value=A154903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154903.Bytes);
public long this[int i]=>Value[i];

public static A154903Inst Instance=new A154903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154904
{
public static readonly long[] Value={ 8L,9L,1L,4L,9L,3L,1L,8L,9L,0L,0L,8L,0L,7L,4L,4L,5L,7L,3L,7L,6L,0L,3L,8L,8L,8L,3L,3L,8L,1L,9L,8L,1L,4L,2L,0L,1L,7L,9L,5L,8L,1L,4L,6L,3L,3L,8L,6L,0L,8L,3L,0L,2L,5L,2L,5L,8L,9L,9L,5L,0L,6L,9L,5L,9L,6L,1L,1L,1L,5L,0L,6L,3L,8L,0L,7L,2L,7L,8L,8L,2L,5L,7L,9L,4L,4L,2L,6L,7L,1L,3L,7L,6L,9L,9L,5L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154904Inst : IEnumerable<long>
{
public static readonly long[] Value=A154904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154904.Bytes);
public long this[int i]=>Value[i];

public static A154904Inst Instance=new A154904Inst();

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