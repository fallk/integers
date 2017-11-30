using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A090107
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,71L,106L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090107Inst : IEnumerable<long>
{
public static readonly long[] Value=A090107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090107.Bytes);
public long this[int i]=>Value[i];

public static A090107Inst Instance=new A090107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090108
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090108Inst : IEnumerable<long>
{
public static readonly long[] Value=A090108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090108.Bytes);
public long this[int i]=>Value[i];

public static A090108Inst Instance=new A090108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090109
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,85L,92L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090109Inst : IEnumerable<long>
{
public static readonly long[] Value=A090109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090109.Bytes);
public long this[int i]=>Value[i];

public static A090109Inst Instance=new A090109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090110
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,66L,129L,130L,328L,1619L,7509L,29714L,45905L,447588L,509862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090110Inst : IEnumerable<long>
{
public static readonly long[] Value=A090110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090110.Bytes);
public long this[int i]=>Value[i];

public static A090110Inst Instance=new A090110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090111
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,45L,53L,66L,67L,84L,129L,130L,131L,266L,328L,329L,1619L,1620L,2655L,2937L,7509L,7510L,18030L,29283L,29714L,29715L,37630L,42037L,44473L,45905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090111Inst : IEnumerable<long>
{
public static readonly long[] Value=A090111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090111.Bytes);
public long this[int i]=>Value[i];

public static A090111Inst Instance=new A090111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090112
{
public static readonly long[] Value={ 0L,1L,4L,2L,3L,3L,4L,4L,0L,0L,5L,5L,6L,6L,0L,0L,7L,7L,8L,8L,0L,0L,9L,9L,0L,0L,0L,0L,10L,10L,11L,11L,0L,0L,0L,0L,12L,12L,0L,0L,13L,13L,14L,14L,0L,0L,15L,15L,0L,0L,0L,0L,16L,16L,0L,0L,0L,0L,17L,17L,18L,18L,0L,0L,0L,0L,19L,19L,0L,0L,20L,20L,21L,21L,0L,0L,0L,0L,22L,22L,0L,0L,23L,23L,0L,0L,0L,0L,24L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090112Inst : IEnumerable<long>
{
public static readonly long[] Value=A090112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090112.Bytes);
public long this[int i]=>Value[i];

public static A090112Inst Instance=new A090112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090113
{
public static readonly long[] Value={ 0L,1L,4L,4L,6L,3L,8L,4L,4L,0L,5L,5L,12L,6L,6L,0L,7L,7L,16L,8L,8L,0L,9L,9L,9L,0L,0L,0L,10L,10L,22L,11L,11L,0L,0L,0L,12L,12L,12L,0L,13L,13L,28L,14L,14L,0L,15L,15L,15L,0L,0L,0L,16L,16L,16L,0L,0L,0L,17L,17L,36L,18L,18L,0L,0L,0L,19L,19L,19L,0L,20L,20L,42L,21L,21L,0L,0L,0L,22L,22L,22L,0L,23L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090113Inst : IEnumerable<long>
{
public static readonly long[] Value=A090113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090113.Bytes);
public long this[int i]=>Value[i];

public static A090113Inst Instance=new A090113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090114
{
public static readonly BigInteger[] Value={ 1L,2L,24L,360L,30240L,665280L,57657600L,1764322560L,180503769600L,47621141568000L,2180547008640000L,599555620984320000L,BigInteger.Parse("74931129164795904000"),BigInteger.Parse("4608264443634948096000"),BigInteger.Parse("669187660275478536192000") };
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
public class A090114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090114Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090114.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090114Inst Instance=new A090114Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090115
{
public static readonly long[] Value={ 1L,1L,4L,15L,252L,924L,11440L,43758L,497420L,13123110L,54627300L,1251677700L,12033222880L,52860229080L,511738760544L,10363194502115L,197548686920970L,925029565741050L,17302625882942400L,161884603662657876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090115Inst : IEnumerable<long>
{
public static readonly long[] Value=A090115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090115.Bytes);
public long this[int i]=>Value[i];

public static A090115Inst Instance=new A090115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090164
{
public static readonly long[] Value={ 1L,4L,10L,20L,38L,80L,174L,372L,762L,1540L,3072L,6196L,12356L,24516L,48179L,94356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090164Inst : IEnumerable<long>
{
public static readonly long[] Value=A090164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090164.Bytes);
public long this[int i]=>Value[i];

public static A090164Inst Instance=new A090164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090165
{
public static readonly long[] Value={ 1L,3L,6L,14L,32L,66L,134L,280L,585L,1214L,2462L,4946L,9861L,19600L,38688L,76086L,148435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090165Inst : IEnumerable<long>
{
public static readonly long[] Value=A090165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090165.Bytes);
public long this[int i]=>Value[i];

public static A090165Inst Instance=new A090165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090166
{
public static readonly long[] Value={ 1L,2L,4L,9L,20L,37L,63L,122L,232L,431L,781L,1392L,2494L,4442L,7854L,13899L,24215L,41802L,71167L,119888L,198363L,323206L,515778L,811000L,1248011L,1885279L,2782396L,4009722L,5621354L,7647872L,10065800L,12760413L,15570786L,18171606L,20299876L,21587248L,21841159L,20906905L,18899357L,16058335L,12772603L,9515217L,6583181L,4242753L,2503873L,1350268L,643245L,270303L,92311L,27116L,5390L,1115L,86L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090166Inst : IEnumerable<long>
{
public static readonly long[] Value=A090166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090166.Bytes);
public long this[int i]=>Value[i];

public static A090166Inst Instance=new A090166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090167
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,20L,36L,60L,95L,155L,258L,426L,688L,1106L,1723L,2615L,3901L,5885L,8851L,13205L,19508L,28593L,41179L,58899L,83582L,118109L,165136L,228596L,312542L,423797L,568233L,755727L,994641L,1296097L,1667002L,2119476L,2660415L,3300586L,4038877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090167Inst : IEnumerable<long>
{
public static readonly long[] Value=A090167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090167.Bytes);
public long this[int i]=>Value[i];

public static A090167Inst Instance=new A090167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090168
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,4L,5L,6L,7L,7L,9L,9L,10L,11L,12L,12L,14L,14L,15L,16L,17L,17L,19L,19L,20L,21L,22L,22L,24L,24L,25L,26L,27L,27L,29L,29L,30L,31L,32L,32L,34L,34L,35L,36L,37L,37L,39L,39L,40L,41L,42L,42L,44L,44L,45L,46L,47L,47L,49L,49L,50L,51L,52L,52L,54L,54L,55L,56L,57L,57L,59L,59L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090168Inst : IEnumerable<long>
{
public static readonly long[] Value=A090168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090168.Bytes);
public long this[int i]=>Value[i];

public static A090168Inst Instance=new A090168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090169
{
public static readonly long[] Value={ 0L,1L,4L,6L,8L,10L,13L,14L,17L,19L,21L,23L,26L,27L,30L,32L,34L,36L,39L,40L,43L,45L,47L,49L,52L,53L,56L,58L,60L,62L,65L,66L,69L,71L,73L,75L,78L,79L,82L,84L,86L,88L,91L,92L,95L,97L,99L,101L,104L,105L,108L,110L,112L,114L,117L,118L,121L,123L,125L,127L,130L,131L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090169Inst : IEnumerable<long>
{
public static readonly long[] Value=A090169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090169.Bytes);
public long this[int i]=>Value[i];

public static A090169Inst Instance=new A090169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090170
{
public static readonly long[] Value={ 1L,3L,5L,10L,17L,31L,56L,101L,180L,321L,572L,1019L,1814L,3232L,5757L,10254L,18263L,32528L,57936L,103188L,183786L,327336L,583010L,1038383L,1849436L,3293980L,5866817L,10449227L,18610830L,33147236L,59037629L,105150293L,187280286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090170Inst : IEnumerable<long>
{
public static readonly long[] Value=A090170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090170.Bytes);
public long this[int i]=>Value[i];

public static A090170Inst Instance=new A090170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090171
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090171Inst : IEnumerable<long>
{
public static readonly long[] Value=A090171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090171.Bytes);
public long this[int i]=>Value[i];

public static A090171Inst Instance=new A090171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090172
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090172Inst : IEnumerable<long>
{
public static readonly long[] Value=A090172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090172.Bytes);
public long this[int i]=>Value[i];

public static A090172Inst Instance=new A090172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090173
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090173Inst : IEnumerable<long>
{
public static readonly long[] Value=A090173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090173.Bytes);
public long this[int i]=>Value[i];

public static A090173Inst Instance=new A090173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090174
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090174Inst : IEnumerable<long>
{
public static readonly long[] Value=A090174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090174.Bytes);
public long this[int i]=>Value[i];

public static A090174Inst Instance=new A090174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090175
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,1L,2L,3L,4L,5L,6L,7L,8L,8L,9L,10L,11L,0L,1L,2L,3L,4L,5L,4L,5L,6L,7L,8L,9L,10L,11L,12L,0L,12L,13L,0L,1L,2L,3L,4L,5L,6L,7L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,12L,13L,14L,15L,0L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090175Inst : IEnumerable<long>
{
public static readonly long[] Value=A090175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090175.Bytes);
public long this[int i]=>Value[i];

public static A090175Inst Instance=new A090175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090176
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,3L,1L,1L,1L,3L,1L,3L,1L,3L,3L,3L,1L,6L,3L,3L,3L,6L,3L,6L,3L,6L,6L,6L,3L,10L,6L,6L,6L,10L,6L,10L,6L,10L,10L,10L,6L,15L,10L,10L,10L,15L,10L,15L,10L,15L,15L,15L,10L,21L,15L,15L,15L,21L,15L,21L,15L,21L,21L,21L,15L,28L,21L,21L,21L,28L,21L,28L,21L,28L,28L,28L,21L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090176Inst : IEnumerable<long>
{
public static readonly long[] Value=A090176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090176.Bytes);
public long this[int i]=>Value[i];

public static A090176Inst Instance=new A090176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090177
{
public static readonly long[] Value={ 610L,1276L,1287L,1327L,1506L,1942L,1976L,2608L,2971L,3038L,3274L,3484L,3940L,4187L,4491L,4606L,4749L,4945L,5272L,5938L,6398L,6460L,6478L,6540L,6604L,6819L,7270L,7936L,8171L,8534L,8602L,8609L,8713L,9268L,9759L,9882L,9902L,9934L,10021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090177Inst : IEnumerable<long>
{
public static readonly long[] Value=A090177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090177.Bytes);
public long this[int i]=>Value[i];

public static A090177Inst Instance=new A090177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090178
{
public static readonly long[] Value={ 2L,4L,6L,9L,12L,17L,20L,25L,28L,33L,40L,43L,50L,55L,58L,63L,70L,77L,80L,87L,92L,95L,102L,107L,114L,123L,128L,131L,136L,139L,144L,159L,164L,171L,174L,185L,188L,195L,202L,207L,214L,221L,224L,235L,238L,243L,246L,259L,272L,277L,280L,285L,292L,295L,306L,313L,320L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090178Inst : IEnumerable<long>
{
public static readonly long[] Value=A090178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090178.Bytes);
public long this[int i]=>Value[i];

public static A090178Inst Instance=new A090178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090179
{
public static readonly long[] Value={ 37L,37L,103L,59L,131L,37L,67L,37L,283L,59L,37L,101L,37L,67L,691L,37L,59L,157L,37L,37L,67L,59L,617L,103L,37L,593L,37L,37L,59L,101L,37L,67L,157L,37L,149L,59L,233L,37L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090179Inst : IEnumerable<long>
{
public static readonly long[] Value=A090179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090179.Bytes);
public long this[int i]=>Value[i];

public static A090179Inst Instance=new A090179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090276
{
public static readonly BigInteger[] Value={ 2L,7L,3L,33L,9L,77L,33L,999L,1111111L,3L,33L,777777L,111111111L,77L,333333L,111L,99999999L,3333333333L,777777L,1L,BigInteger.Parse("33333333333333333333"),BigInteger.Parse("999999999999999999999999999999999999"),99999999L,BigInteger.Parse("999999999999999999999999999999999999999999"),BigInteger.Parse("3333333333333333333333333") };
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
public class A090276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090276Inst Instance=new A090276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090277
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,3L,3L,1L,1L,3L,3L,2L,2L,4L,4L,1L,1L,4L,4L,3L,3L,2L,2L,1L,1L,2L,2L,4L,4L,3L,3L,1L,1L,3L,3L,2L,2L,4L,4L,1L,1L,4L,4L,3L,3L,2L,2L,1L,1L,2L,2L,4L,4L,3L,3L,1L,1L,3L,3L,2L,2L,4L,4L,1L,1L,4L,4L,3L,3L,2L,2L,1L,1L,2L,2L,4L,4L,3L,3L,1L,1L,3L,3L,2L,2L,4L,4L,1L,1L,4L,4L,3L,3L,2L,2L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090277Inst : IEnumerable<long>
{
public static readonly long[] Value=A090277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090277.Bytes);
public long this[int i]=>Value[i];

public static A090277Inst Instance=new A090277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090278
{
public static readonly long[] Value={ 2L,1L,4L,2L,3L,4L,1L,3L,3L,1L,2L,3L,4L,2L,1L,4L,4L,1L,3L,4L,2L,3L,1L,2L,2L,1L,4L,2L,3L,4L,1L,3L,3L,1L,2L,3L,4L,2L,1L,4L,4L,1L,3L,4L,2L,3L,1L,2L,2L,1L,4L,2L,3L,4L,1L,3L,3L,1L,2L,3L,4L,2L,1L,4L,4L,1L,3L,4L,2L,3L,1L,2L,2L,1L,4L,2L,3L,4L,1L,3L,3L,1L,2L,3L,4L,2L,1L,4L,4L,1L,3L,4L,2L,3L,1L,2L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090278Inst : IEnumerable<long>
{
public static readonly long[] Value=A090278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090278.Bytes);
public long this[int i]=>Value[i];

public static A090278Inst Instance=new A090278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090279
{
public static readonly long[] Value={ 3L,4L,1L,3L,2L,1L,4L,2L,4L,2L,1L,4L,3L,1L,2L,3L,2L,3L,1L,2L,4L,1L,3L,4L,3L,4L,1L,3L,2L,1L,4L,2L,4L,2L,1L,4L,3L,1L,2L,3L,2L,3L,1L,2L,4L,1L,3L,4L,3L,4L,1L,3L,2L,1L,4L,2L,4L,2L,1L,4L,3L,1L,2L,3L,2L,3L,1L,2L,4L,1L,3L,4L,3L,4L,1L,3L,2L,1L,4L,2L,4L,2L,1L,4L,3L,1L,2L,3L,2L,3L,1L,2L,4L,1L,3L,4L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090279Inst : IEnumerable<long>
{
public static readonly long[] Value=A090279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090279.Bytes);
public long this[int i]=>Value[i];

public static A090279Inst Instance=new A090279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090280
{
public static readonly long[] Value={ 4L,3L,3L,1L,1L,2L,2L,4L,2L,4L,4L,1L,1L,3L,3L,2L,3L,2L,2L,1L,1L,4L,4L,3L,4L,3L,3L,1L,1L,2L,2L,4L,2L,4L,4L,1L,1L,3L,3L,2L,3L,2L,2L,1L,1L,4L,4L,3L,4L,3L,3L,1L,1L,2L,2L,4L,2L,4L,4L,1L,1L,3L,3L,2L,3L,2L,2L,1L,1L,4L,4L,3L,4L,3L,3L,1L,1L,2L,2L,4L,2L,4L,4L,1L,1L,3L,3L,2L,3L,2L,2L,1L,1L,4L,4L,3L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090280Inst : IEnumerable<long>
{
public static readonly long[] Value=A090280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090280.Bytes);
public long this[int i]=>Value[i];

public static A090280Inst Instance=new A090280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090281
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,3L,2L,1L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090281Inst : IEnumerable<long>
{
public static readonly long[] Value=A090281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090281.Bytes);
public long this[int i]=>Value[i];

public static A090281Inst Instance=new A090281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090282
{
public static readonly long[] Value={ 2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090282Inst : IEnumerable<long>
{
public static readonly long[] Value=A090282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090282.Bytes);
public long this[int i]=>Value[i];

public static A090282Inst Instance=new A090282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090283
{
public static readonly long[] Value={ 3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090283Inst : IEnumerable<long>
{
public static readonly long[] Value=A090283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090283.Bytes);
public long this[int i]=>Value[i];

public static A090283Inst Instance=new A090283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090284
{
public static readonly long[] Value={ 4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L,1L,1L,2L,3L,4L,3L,4L,4L,3L,2L,1L,1L,2L,2L,1L,1L,2L,3L,4L,4L,3L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090284Inst : IEnumerable<long>
{
public static readonly long[] Value=A090284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090284.Bytes);
public long this[int i]=>Value[i];

public static A090284Inst Instance=new A090284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090285
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,1L,5L,15L,7L,1L,14L,56L,37L,10L,1L,42L,210L,176L,68L,13L,1L,132L,792L,794L,392L,108L,16L,1L,429L,3003L,3473L,2063L,731L,157L,19L,1L,1430L,11440L,14893L,10254L,4395L,1220L,215L,22L,1L,4862L,43758L,63004L,49024L,24465L,8249L,1886L,282L,25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090285Inst : IEnumerable<long>
{
public static readonly long[] Value=A090285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090285.Bytes);
public long this[int i]=>Value[i];

public static A090285Inst Instance=new A090285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090286
{
public static readonly long[] Value={ 11L,17L,107L,1487L,16067L,19427L,21017L,22277L,43787L,55337L,144167L,165707L,166847L,195737L,201827L,225347L,247607L,268817L,326147L,347987L,361217L,397757L,465167L,518807L,536447L,633467L,633797L,661097L,768197L,795797L,829727L,857957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090286Inst : IEnumerable<long>
{
public static readonly long[] Value=A090286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090286.Bytes);
public long this[int i]=>Value[i];

public static A090286Inst Instance=new A090286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090287
{
public static readonly BigInteger[] Value={ 101L,313L,727L,131L,11411L,151L,777767777L,373L,181L,191L,9109L,0L,7127L,331333L,991499L,1151L,3163L,1171L,1181L,9199L,1201L,112111L,0L,1231L,7247L,3253L,BigInteger.Parse("7777777777267777777777"),1111271111L,11128111L,1291L,1301L,3313L,1321L,0L,3343L,333533L,1361L,3373L,1381L };
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
public class A090287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090287Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090287.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090287.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090287Inst Instance=new A090287Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090288
{
public static readonly long[] Value={ 2L,10L,22L,38L,58L,82L,110L,142L,178L,218L,262L,310L,362L,418L,478L,542L,610L,682L,758L,838L,922L,1010L,1102L,1198L,1298L,1402L,1510L,1622L,1738L,1858L,1982L,2110L,2242L,2378L,2518L,2662L,2810L,2962L,3118L,3278L,3442L,3610L,3782L,3958L,4138L,4322L,4510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090288Inst : IEnumerable<long>
{
public static readonly long[] Value=A090288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090288.Bytes);
public long this[int i]=>Value[i];

public static A090288Inst Instance=new A090288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090289
{
public static readonly BigInteger[] Value={ 0L,7L,5L,3L,89L,0L,83L,0L,977L,71L,0L,0L,59L,0L,53L,47L,41L,0L,0L,29L,0L,0L,17L,11L,3L,999999999899L,0L,999999893L,0L,887L,0L,BigInteger.Parse("9999999999999999999869"),863L,0L,9851L,0L,0L,0L,9833L,827L,821L,0L,809L,0L,9803L,0L,0L,0L,773L,0L,9767L,761L,0L,9749L,743L };
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
public class A090289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090289.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090289Inst Instance=new A090289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090290
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,0L,2L,0L,3L,2L,0L,0L,2L,0L,2L,2L,2L,0L,0L,2L,0L,0L,2L,2L,2L,12L,0L,9L,0L,3L,0L,22L,3L,0L,4L,0L,0L,0L,4L,3L,3L,0L,3L,0L,4L,0L,0L,0L,3L,0L,4L,3L,0L,4L,3L,18L,11L,0L,0L,3L,0L,5L,0L,4L,0L,3L,0L,0L,3L,0L,3L,3L,0L,0L,0L,3L,5L,0L,3L,0L,5L,0L,3L,0L,0L,3L,4L,0L,4L,0L,4L,3L,0L,3L,0L,4L,3L,3L,0L,0L,0L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090290Inst : IEnumerable<long>
{
public static readonly long[] Value=A090290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090290.Bytes);
public long this[int i]=>Value[i];

public static A090290Inst Instance=new A090290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090291
{
public static readonly long[] Value={ 1L,2L,5L,9L,35L,62L,195L,126L,186L,28L,230L,57L,26L,170L,280L,270L,265L,1008L,56L,398L,473L,376L,32L,581L,3204L,903L,898L,206L,1581L,2330L,2012L,370L,1512L,2119L,1548L,345L,646L,3481L,241L,1871L,2763L,995L,2304L,460L,633L,2338L,3801L,5138L,4472L,973L,4117L,2286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090291Inst : IEnumerable<long>
{
public static readonly long[] Value=A090291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090291.Bytes);
public long this[int i]=>Value[i];

public static A090291Inst Instance=new A090291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090324
{
public static readonly long[] Value={ 6L,13L,10L,27L,21L,18L,55L,43L,37L,34L,111L,87L,75L,69L,66L,223L,175L,151L,139L,133L,130L,447L,351L,303L,279L,267L,261L,258L,895L,703L,607L,559L,535L,523L,517L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090324Inst : IEnumerable<long>
{
public static readonly long[] Value=A090324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090324.Bytes);
public long this[int i]=>Value[i];

public static A090324Inst Instance=new A090324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090325
{
public static readonly long[] Value={ 8L,4L,6L,10L,15L,9L,14L,12L,16L,18L,22L,20L,25L,21L,24L,26L,28L,27L,30L,32L,33L,34L,35L,36L,38L,39L,42L,40L,46L,44L,49L,48L,45L,50L,51L,52L,54L,56L,55L,58L,63L,57L,62L,60L,65L,64L,68L,66L,70L,69L,72L,74L,76L,75L,77L,78L,81L,80L,82L,84L,85L,86L,87L,88L,90L,92L,91L,94L,93L,95L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090325Inst : IEnumerable<long>
{
public static readonly long[] Value=A090325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090325.Bytes);
public long this[int i]=>Value[i];

public static A090325Inst Instance=new A090325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090326
{
public static readonly long[] Value={ 1L,4L,15L,54L,185L,608L,1939L,6058L,18669L,57012L,173063L,523262L,1577953L,4750216L,14283387L,42915666L,128878037L,386896220L,1161212911L,3484687270L,10456158921L,31372671024L,94126401635L,282395982074L,847221500605L,2541731610628L,7625329049559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090326Inst : IEnumerable<long>
{
public static readonly long[] Value=A090326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090326.Bytes);
public long this[int i]=>Value[i];

public static A090326Inst Instance=new A090326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090327
{
public static readonly long[] Value={ 1L,4L,11L,30L,83L,234L,671L,1950L,5723L,16914L,50231L,149670L,446963L,1336794L,4002191L,11990190L,35937803L,107747874L,323112551L,969075510L,2906702243L,8719058154L,26155077311L,78461037630L,235374724283L,706107395634L,2118288632471L,6354798788550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090327Inst : IEnumerable<long>
{
public static readonly long[] Value=A090327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090327.Bytes);
public long this[int i]=>Value[i];

public static A090327Inst Instance=new A090327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090328
{
public static readonly long[] Value={ 1L,4L,12L,35L,103L,306L,914L,2737L,8205L,24608L,73816L,221439L,664307L,1992910L,5978718L,17936141L,53808409L,161425212L,484275620L,1452826843L,4358480511L,13075441514L,39226324522L,117678973545L,353036920613L,1059110761816L,3177332285424L,9531996856247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090328Inst : IEnumerable<long>
{
public static readonly long[] Value=A090328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090328.Bytes);
public long this[int i]=>Value[i];

public static A090328Inst Instance=new A090328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090329
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,1L,3L,1L,4L,1L,2L,2L,4L,1L,4L,1L,4L,2L,3L,1L,6L,1L,2L,2L,4L,1L,5L,1L,5L,1L,3L,1L,7L,1L,3L,2L,6L,1L,5L,1L,4L,3L,3L,1L,8L,1L,4L,2L,4L,1L,6L,2L,6L,2L,2L,1L,8L,1L,2L,3L,6L,1L,5L,1L,5L,1L,5L,1L,9L,1L,3L,2L,5L,1L,6L,1L,8L,2L,3L,1L,8L,2L,3L,2L,6L,1L,7L,1L,4L,2L,3L,2L,10L,1L,3L,2L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090329Inst : IEnumerable<long>
{
public static readonly long[] Value=A090329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090329.Bytes);
public long this[int i]=>Value[i];

public static A090329Inst Instance=new A090329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090330
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,2L,0L,2L,0L,3L,0L,1L,1L,3L,0L,3L,0L,3L,1L,2L,0L,5L,0L,1L,1L,3L,0L,4L,0L,4L,0L,2L,0L,6L,0L,2L,1L,5L,0L,4L,0L,3L,2L,2L,0L,7L,0L,3L,1L,3L,0L,5L,1L,5L,1L,1L,0L,7L,0L,1L,2L,5L,0L,4L,0L,4L,0L,4L,0L,8L,0L,2L,1L,4L,0L,5L,0L,7L,1L,2L,0L,7L,1L,2L,1L,5L,0L,6L,0L,3L,1L,2L,1L,9L,0L,2L,1L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090330Inst : IEnumerable<long>
{
public static readonly long[] Value=A090330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090330.Bytes);
public long this[int i]=>Value[i];

public static A090330Inst Instance=new A090330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090331
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,4L,1L,5L,1L,6L,1L,7L,3L,8L,1L,9L,1L,10L,1L,11L,1L,12L,1L,13L,3L,14L,1L,15L,1L,16L,1L,17L,1L,18L,1L,19L,1L,20L,1L,21L,1L,22L,5L,23L,1L,24L,1L,25L,3L,26L,1L,27L,1L,28L,3L,29L,1L,30L,1L,31L,7L,32L,1L,33L,1L,34L,1L,35L,1L,36L,1L,37L,1L,38L,1L,39L,1L,40L,1L,41L,1L,42L,5L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090331Inst : IEnumerable<long>
{
public static readonly long[] Value=A090331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090331.Bytes);
public long this[int i]=>Value[i];

public static A090331Inst Instance=new A090331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090332
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,13L,17L,19L,23L,25L,29L,31L,33L,35L,37L,41L,43L,47L,49L,53L,59L,61L,65L,67L,69L,71L,73L,77L,79L,83L,89L,91L,97L,101L,103L,107L,109L,113L,125L,127L,129L,131L,133L,137L,139L,141L,143L,145L,149L,151L,155L,157L,161L,163L,167L,169L,173L,179L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090332Inst : IEnumerable<long>
{
public static readonly long[] Value=A090332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090332.Bytes);
public long this[int i]=>Value[i];

public static A090332Inst Instance=new A090332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090333
{
public static readonly long[] Value={ 1L,9L,25L,33L,35L,49L,65L,69L,77L,91L,125L,129L,133L,141L,143L,145L,155L,161L,169L,209L,247L,259L,265L,267L,287L,289L,295L,299L,301L,305L,319L,323L,329L,341L,343L,361L,371L,377L,391L,395L,403L,407L,437L,451L,473L,481L,485L,493L,505L,515L,519L,527L,529L,533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090333Inst : IEnumerable<long>
{
public static readonly long[] Value=A090333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090333.Bytes);
public long this[int i]=>Value[i];

public static A090333Inst Instance=new A090333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090334
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,27L,28L,30L,32L,34L,36L,38L,39L,40L,42L,44L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,66L,68L,70L,72L,74L,75L,76L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,92L,93L,94L,95L,96L,98L,99L,100L,102L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090334Inst : IEnumerable<long>
{
public static readonly long[] Value=A090334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090334.Bytes);
public long this[int i]=>Value[i];

public static A090334Inst Instance=new A090334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090335
{
public static readonly ulong[] Value={ 1L,2L,33L,2093L,239723L,29918977L,17597346187L,17155385292853L,10633323942990239L,15790705299133143889UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090335Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A090335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090335.Bytes);
public ulong this[int i]=>Value[i];

public static A090335Inst Instance=new A090335Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090336
{
public static readonly BigInteger[] Value={ 1L,0L,-8L,24L,64L,-480L,-3968L,34944L,354304L,-4062720L,-51734528L,724568064L,11070521344L,-183240744960L,-3266330329088L,62382319632384L,1270842139869184L,-27507470234419200L,-630424777639067648L,15250953398036987904UL,BigInteger.Parse("388362339077349965824") };
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
public class A090336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090336Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090336.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090336.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090336Inst Instance=new A090336Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090337
{
public static readonly ulong[] Value={ 1L,11L,99L,1089L,9801L,107811L,970299L,10673289L,96059601L,1056655611L,9509900499L,104608905489L,941480149401L,10356281643411L,93206534790699L,1025271882697689L,9227446944279201L,101501916387071211L,913517247483640899L,10048689722320049889UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090337Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A090337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090337.Bytes);
public ulong this[int i]=>Value[i];

public static A090337Inst Instance=new A090337Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090338
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,6L,43L,922L,38609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090338Inst : IEnumerable<long>
{
public static readonly long[] Value=A090338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090338.Bytes);
public long this[int i]=>Value[i];

public static A090338Inst Instance=new A090338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090339
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,6L,43L,922L,38612L,3113660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090339Inst : IEnumerable<long>
{
public static readonly long[] Value=A090339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090339.Bytes);
public long this[int i]=>Value[i];

public static A090339Inst Instance=new A090339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090372
{
public static readonly long[] Value={ 1L,6L,22L,174L,1479L,16808L,201834L,2631594L,35965555L,512062566L,7528425420L,113708935808L,1756853846316L,27676951028496L,443411345677658L,7209139541742750L,118738765611199983L,1978360119497335826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090372Inst : IEnumerable<long>
{
public static readonly long[] Value=A090372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090372.Bytes);
public long this[int i]=>Value[i];

public static A090372Inst Instance=new A090372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090373
{
public static readonly BigInteger[] Value={ 1L,10L,60L,875L,14600L,303814L,6846180L,165740155L,4221248540L,112001557620L,3071766596524L,86596464513410L,2498536503831640L,73533104142072810L,2201538635362482480L,BigInteger.Parse("66907117946947479163"),BigInteger.Parse("2060374053699504740000") };
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
public class A090373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090373Inst Instance=new A090373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090374
{
public static readonly BigInteger[] Value={ 1L,10L,160L,3200L,72960L,1813504L,47923200L,1325629440L,37991219200L,1120005652480L,33789432561664L,1039157228994560L,32480974549811200L,1029463445864448000L,BigInteger.Parse("33023079530417356800"),BigInteger.Parse("1070513886720329515008"),BigInteger.Parse("35026358912891580579840"),BigInteger.Parse("1155516042520241436098560") };
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
public class A090374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090374Inst Instance=new A090374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090375
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,17L,40L,93L,224L,538L,1344L,3352L,8448L,21573L,54912L,143037L,366080L,968083L,2489344L,6664856L,17199104L,46515759L,120393728L,328382874L,852017152L,2340706462L,6085836800L,16822999572L,43818024960L,121777594508L,317680680960L,887053276477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090375Inst : IEnumerable<long>
{
public static readonly long[] Value=A090375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090375.Bytes);
public long this[int i]=>Value[i];

public static A090375Inst Instance=new A090375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090376
{
public static readonly long[] Value={ 1L,4L,15L,80L,362L,1832L,8994L,46384L,238838L,1257824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090376Inst : IEnumerable<long>
{
public static readonly long[] Value=A090376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090376.Bytes);
public long this[int i]=>Value[i];

public static A090376Inst Instance=new A090376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090377
{
public static readonly long[] Value={ 1L,2L,4L,10L,26L,66L,173L,456L,1230L,3318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090377Inst : IEnumerable<long>
{
public static readonly long[] Value=A090377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090377.Bytes);
public long this[int i]=>Value[i];

public static A090377Inst Instance=new A090377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090378
{
public static readonly long[] Value={ 1L,3L,7L,19L,53L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090378Inst : IEnumerable<long>
{
public static readonly long[] Value=A090378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090378.Bytes);
public long this[int i]=>Value[i];

public static A090378Inst Instance=new A090378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090379
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,2L,1L,1L,1L,3L,1L,4L,2L,2L,2L,5L,2L,6L,3L,3L,3L,7L,3L,3L,3L,3L,3L,8L,4L,9L,4L,4L,4L,4L,4L,10L,5L,5L,5L,11L,5L,12L,6L,6L,6L,13L,6L,6L,6L,6L,6L,14L,7L,7L,7L,7L,7L,15L,7L,16L,8L,8L,8L,8L,8L,17L,8L,8L,8L,18L,9L,19L,9L,9L,9L,9L,9L,20L,10L,10L,10L,21L,10L,10L,10L,10L,10L,22L,11L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090379Inst : IEnumerable<long>
{
public static readonly long[] Value=A090379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090379.Bytes);
public long this[int i]=>Value[i];

public static A090379Inst Instance=new A090379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090380
{
public static readonly long[] Value={ 1L,17L,265L,4737L,99721L,2934889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090380Inst : IEnumerable<long>
{
public static readonly long[] Value=A090380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090380.Bytes);
public long this[int i]=>Value[i];

public static A090380Inst Instance=new A090380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090381
{
public static readonly long[] Value={ 1L,6L,19L,36L,61L,90L,127L,168L,217L,270L,331L,396L,469L,546L,631L,720L,817L,918L,1027L,1140L,1261L,1386L,1519L,1656L,1801L,1950L,2107L,2268L,2437L,2610L,2791L,2976L,3169L,3366L,3571L,3780L,3997L,4218L,4447L,4680L,4921L,5166L,5419L,5676L,5941L,6210L,6487L,6768L,7057L,7350L,7651L,7956L,8269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090381Inst : IEnumerable<long>
{
public static readonly long[] Value=A090381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090381.Bytes);
public long this[int i]=>Value[i];

public static A090381Inst Instance=new A090381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090382
{
public static readonly long[] Value={ 6L,32L,102L,259L,540L,1041L,1842L,3170L,5286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090382Inst : IEnumerable<long>
{
public static readonly long[] Value=A090382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090382.Bytes);
public long this[int i]=>Value[i];

public static A090382Inst Instance=new A090382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090383
{
public static readonly long[] Value={ 4L,7L,8L,8L,10L,11L,8L,12L,10L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090383Inst : IEnumerable<long>
{
public static readonly long[] Value=A090383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090383.Bytes);
public long this[int i]=>Value[i];

public static A090383Inst Instance=new A090383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090384
{
public static readonly long[] Value={ 4L,7L,10L,13L,14L,13L,16L,17L,20L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090384Inst : IEnumerable<long>
{
public static readonly long[] Value=A090384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090384.Bytes);
public long this[int i]=>Value[i];

public static A090384Inst Instance=new A090384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090385
{
public static readonly long[] Value={ 7L,8L,11L,14L,15L,20L,21L,22L,25L,28L,31L,32L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090385Inst : IEnumerable<long>
{
public static readonly long[] Value=A090385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090385.Bytes);
public long this[int i]=>Value[i];

public static A090385Inst Instance=new A090385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090386
{
public static readonly long[] Value={ 0L,24L,64L,126L,217L,345L,519L,749L,1046L,1422L,1890L,2464L,3159L,3991L,4977L,6135L,7484L,9044L,10836L,12882L,15205L,17829L,20779L,24081L,27762L,31850L,36374L,41364L,46851L,52867L,59445L,66619L,74424L,82896L,92072L,101990L,112689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090386Inst : IEnumerable<long>
{
public static readonly long[] Value=A090386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090386.Bytes);
public long this[int i]=>Value[i];

public static A090386Inst Instance=new A090386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090387
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,4L,5L,2L,1L,2L,3L,4L,2L,2L,1L,3L,2L,4L,3L,2L,4L,2L,3L,4L,2L,4L,1L,2L,2L,4L,1L,2L,4L,2L,3L,2L,2L,2L,5L,3L,3L,4L,3L,2L,4L,4L,1L,4L,2L,2L,1L,2L,2L,2L,7L,4L,4L,2L,3L,4L,4L,2L,1L,2L,2L,2L,3L,4L,4L,2L,1L,5L,2L,2L,1L,4L,2L,4L,1L,2L,2L,4L,3L,4L,2L,4L,1L,2L,3L,2L,9L,2L,4L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090387Inst : IEnumerable<long>
{
public static readonly long[] Value=A090387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090387.Bytes);
public long this[int i]=>Value[i];

public static A090387Inst Instance=new A090387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090420
{
public static readonly long[] Value={ 2L,3L,5L,7L,10L,13L,14L,15L,17L,19L,21L,22L,30L,37L,41L,42L,53L,54L,55L,58L,62L,67L,70L,73L,78L,81L,85L,86L,89L,90L,97L,101L,103L,107L,111L,115L,117L,122L,131L,137L,139L,141L,143L,149L,150L,159L,163L,165L,166L,169L,170L,177L,193L,197L,199L,211L,214L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090420Inst : IEnumerable<long>
{
public static readonly long[] Value=A090420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090420.Bytes);
public long this[int i]=>Value[i];

public static A090420Inst Instance=new A090420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090421
{
public static readonly long[] Value={ 2L,3L,5L,7L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,29L,30L,31L,37L,41L,42L,43L,45L,46L,47L,53L,54L,55L,58L,59L,61L,62L,63L,67L,70L,71L,73L,78L,79L,81L,83L,85L,86L,87L,89L,90L,91L,93L,94L,95L,97L,101L,103L,107L,109L,111L,113L,115L,117L,118L,119L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090421Inst : IEnumerable<long>
{
public static readonly long[] Value=A090421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090421.Bytes);
public long this[int i]=>Value[i];

public static A090421Inst Instance=new A090421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090422
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,37L,41L,53L,67L,73L,89L,97L,101L,103L,107L,131L,137L,139L,149L,163L,193L,197L,199L,211L,227L,257L,263L,269L,277L,281L,293L,307L,311L,313L,331L,389L,397L,401L,409L,419L,421L,443L,449L,461L,521L,523L,547L,557L,569L,571L,577L,587L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090422Inst : IEnumerable<long>
{
public static readonly long[] Value=A090422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090422.Bytes);
public long this[int i]=>Value[i];

public static A090422Inst Instance=new A090422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090423
{
public static readonly long[] Value={ 11L,23L,29L,31L,43L,47L,59L,61L,71L,79L,83L,109L,113L,127L,151L,157L,167L,173L,179L,181L,191L,223L,229L,233L,239L,241L,251L,271L,283L,317L,337L,347L,349L,353L,359L,367L,373L,379L,383L,431L,433L,439L,457L,463L,467L,479L,487L,491L,499L,503L,509L,541L,563L,599L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090423Inst : IEnumerable<long>
{
public static readonly long[] Value=A090423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090423.Bytes);
public long this[int i]=>Value[i];

public static A090423Inst Instance=new A090423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090424
{
public static readonly long[] Value={ 2L,11L,23L,47L,175L,95L,189L,375L,191L,381L,763L,1015L,751L,383L,765L,1023L,1407L,2045L,767L,8123L,1919L,5999L,1533L,5623L,4063L,3067L,3007L,3039L,1535L,6013L,6077L,8183L,7935L,11247L,3069L,12023L,12143L,6139L,6015L,6111L,6127L,3071L,6079L,6135L,7679L,32507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090424Inst : IEnumerable<long>
{
public static readonly long[] Value=A090424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090424.Bytes);
public long this[int i]=>Value[i];

public static A090424Inst Instance=new A090424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090425
{
public static readonly long[] Value={ 1L,6L,2L,3L,5L,4L,4L,3L,4L,5L,5L,3L,6L,4L,4L,3L,5L,5L,4L,2L,3L,5L,4L,3L,6L,6L,4L,4L,5L,5L,4L,6L,4L,4L,4L,6L,4L,6L,6L,6L,6L,4L,4L,6L,3L,4L,3L,6L,6L,4L,6L,6L,6L,5L,7L,6L,7L,6L,6L,6L,7L,5L,6L,6L,6L,7L,5L,5L,5L,4L,4L,7L,5L,5L,5L,7L,7L,4L,7L,4L,5L,3L,4L,6L,6L,6L,7L,6L,6L,4L,7L,7L,4L,5L,5L,4L,6L,3L,6L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090425Inst : IEnumerable<long>
{
public static readonly long[] Value=A090425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090425.Bytes);
public long this[int i]=>Value[i];

public static A090425Inst Instance=new A090425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090426
{
public static readonly long[] Value={ 0L,1L,2L,8L,28L,88L,277L,872L,2742L,8615L,27066L,85032L,267137L,839236L,2636539L,8282934L,26021606L,81749286L,256822957L,806833116L,2534740992L,7963123679L,25016890850L,78592880512L,246906816042L,775680639401L,2436872598274L,7655661052474L,24050968520828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090426Inst : IEnumerable<long>
{
public static readonly long[] Value=A090426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090426.Bytes);
public long this[int i]=>Value[i];

public static A090426Inst Instance=new A090426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090427
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,7L,13L,24L,43L,76L,137L,244L,435L,774L,1379L,2457L,4377L,7796L,13886L,24732L,44050L,78456L,139736L,248880L,443274L,789503L,1406162L,2504477L,4460655L,7944750L,14150175L,25202487L,44887455L,79947808L,142392836L,253611954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090427Inst : IEnumerable<long>
{
public static readonly long[] Value=A090427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090427.Bytes);
public long this[int i]=>Value[i];

public static A090427Inst Instance=new A090427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090428
{
public static readonly long[] Value={ 1L,6L,9L,10L,12L,15L,16L,21L,28L,36L,45L,55L,64L,66L,70L,81L,91L,105L,120L,145L,153L,171L,176L,190L,196L,210L,225L,231L,276L,280L,325L,378L,400L,435L,441L,477L,496L,540L,561L,595L,616L,630L,651L,703L,715L,780L,833L,861L,936L,946L,1035L,1089L,1105L,1128L,1216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090428Inst : IEnumerable<long>
{
public static readonly long[] Value=A090428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090428.Bytes);
public long this[int i]=>Value[i];

public static A090428Inst Instance=new A090428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090429
{
public static readonly long[] Value={ 100L,101L,110L,111L,112L,121L,122L,211L,212L,221L,222L,223L,232L,233L,322L,323L,332L,333L,334L,343L,344L,433L,434L,443L,444L,445L,454L,455L,544L,545L,554L,555L,556L,565L,566L,655L,656L,665L,666L,667L,676L,677L,766L,767L,776L,777L,778L,787L,788L,877L,878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090429Inst : IEnumerable<long>
{
public static readonly long[] Value=A090429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090429.Bytes);
public long this[int i]=>Value[i];

public static A090429Inst Instance=new A090429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090430
{
public static readonly long[] Value={ 2L,11L,13L,23L,41L,43L,53L,67L,71L,73L,83L,97L,101L,113L,127L,131L,157L,173L,191L,233L,251L,263L,277L,281L,293L,307L,337L,349L,353L,367L,379L,383L,397L,409L,439L,443L,457L,487L,499L,503L,547L,557L,563L,577L,587L,607L,617L,619L,631L,647L,661L,677L,691L,709L,739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090430Inst : IEnumerable<long>
{
public static readonly long[] Value=A090430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090430.Bytes);
public long this[int i]=>Value[i];

public static A090430Inst Instance=new A090430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090431
{
public static readonly long[] Value={ -1L,-1L,-2L,-3L,3L,2L,-1L,-2L,4L,-10L,-2L,-7L,-1L,-2L,-5L,-1L,-6L,2L,-3L,-6L,-7L,-12L,-6L,-11L,-9L,6L,5L,2L,1L,-2L,-6L,0L,-5L,-6L,-6L,2L,-3L,1L,-2L,-7L,-12L,-4L,-4L,-5L,-8L,-9L,7L,5L,2L,-8L,-2L,-7L,1L,1L,-4L,0L,-5L,3L,-2L,-5L,-6L,-6L,-1L,5L,4L,1L,6L,1L,1L,-9L,-3L,-8L,-6L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090431Inst : IEnumerable<long>
{
public static readonly long[] Value=A090431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090431.Bytes);
public long this[int i]=>Value[i];

public static A090431Inst Instance=new A090431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090432
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,29L,31L,37L,41L,43L,47L,53L,59L,67L,71L,73L,79L,83L,89L,97L,113L,127L,137L,139L,149L,157L,167L,173L,179L,181L,191L,193L,197L,199L,229L,233L,239L,257L,269L,277L,281L,283L,293L,307L,349L,353L,359L,367L,373L,379L,383L,389L,397L,409L,419L,439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090432Inst : IEnumerable<long>
{
public static readonly long[] Value=A090432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090432.Bytes);
public long this[int i]=>Value[i];

public static A090432Inst Instance=new A090432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090433
{
public static readonly long[] Value={ 11L,13L,23L,61L,101L,103L,107L,109L,151L,163L,211L,223L,227L,241L,251L,271L,311L,313L,317L,331L,337L,347L,401L,421L,431L,433L,443L,461L,503L,509L,521L,523L,701L,911L,1009L,1013L,1021L,1031L,1033L,1051L,1061L,1063L,1103L,1109L,1117L,1123L,1129L,1151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090433Inst : IEnumerable<long>
{
public static readonly long[] Value=A090433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090433.Bytes);
public long this[int i]=>Value[i];

public static A090433Inst Instance=new A090433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090434
{
public static readonly long[] Value={ 2L,83L,113L,1019L,2221L,4273L,9467L,13001L,15923L,19141L,19991L,34403L,60661L,62929L,67589L,74891L,79967L,82567L,83443L,86993L,107843L,109849L,115979L,117017L,123341L,151483L,189067L,197083L,233743L,242647L,244147L,254777L,362473L,384773L,419473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090434Inst : IEnumerable<long>
{
public static readonly long[] Value=A090434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090434.Bytes);
public long this[int i]=>Value[i];

public static A090434Inst Instance=new A090434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090435
{
public static readonly long[] Value={ 1L,-1L,6L,1L,-48L,147L,-5L,1584L,-24255L,50176L,1L,-1980L,121275L,-1003520L,1571724L,-41L,496980L,-113458275L,2950635520L,-16174611684L,20412000000L,45182L,-3322062810L,2744728561050L,-206756932157440L,3081396966348393L,-12443694076800000L,13160600037440625L,-1294492177294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090435Inst : IEnumerable<long>
{
public static readonly long[] Value=A090435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090435.Bytes);
public long this[int i]=>Value[i];

public static A090435Inst Instance=new A090435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090500
{
public static readonly long[] Value={ 1L,2L,5L,6L,9L,12L,15L,16L,18L,19L,20L,23L,24L,28L,29L,34L,39L,44L,47L,48L,53L,60L,61L,62L,71L,74L,77L,84L,89L,96L,99L,100L,101L,106L,114L,119L,127L,128L,129L,136L,143L,148L,153L,158L,163L,176L,177L,178L,179L,180L,193L,200L,207L,208L,209L,210L,213L,220L,231L,238L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090500Inst : IEnumerable<long>
{
public static readonly long[] Value=A090500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090500.Bytes);
public long this[int i]=>Value[i];

public static A090500Inst Instance=new A090500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090501
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,4L,5L,4L,5L,5L,5L,6L,6L,8L,8L,8L,9L,9L,10L,11L,10L,11L,12L,13L,13L,14L,14L,16L,15L,15L,16L,16L,18L,18L,19L,18L,19L,20L,20L,22L,22L,22L,24L,24L,25L,23L,24L,24L,28L,26L,28L,27L,27L,26L,28L,30L,30L,31L,29L,31L,30L,31L,32L,34L,33L,33L,34L,34L,37L,35L,37L,36L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090501Inst : IEnumerable<long>
{
public static readonly long[] Value=A090501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090501.Bytes);
public long this[int i]=>Value[i];

public static A090501Inst Instance=new A090501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090502
{
public static readonly long[] Value={ 6L,20L,28L,32L,52L,56L,68L,152L,174L,176L,184L,186L,208L,212L,248L,266L,268L,272L,292L,322L,328L,338L,464L,470L,472L,476L,518L,534L,536L,578L,582L,585L,590L,602L,606L,650L,656L,658L,666L,670L,686L,710L,754L,772L,788L,790L,804L,814L,836L,846L,848L,894L,988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090502Inst : IEnumerable<long>
{
public static readonly long[] Value=A090502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090502.Bytes);
public long this[int i]=>Value[i];

public static A090502Inst Instance=new A090502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090503
{
public static readonly long[] Value={ 7L,13L,15L,21L,31L,40L,57L,63L,73L,85L,91L,121L,127L,133L,156L,183L,255L,273L,307L,341L,364L,381L,400L,511L,553L,585L,651L,757L,781L,820L,871L,993L,1023L,1057L,1093L,1365L,1407L,1464L,1723L,1893L,2047L,2257L,2380L,2451L,2801L,2863L,3280L,3541L,3783L,3906L,4095L,4161L,4369L,4557L,4681L,5113L,5220L,5403L,5461L,6321L,6643L,6973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090503Inst : IEnumerable<long>
{
public static readonly long[] Value=A090503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090503.Bytes);
public long this[int i]=>Value[i];

public static A090503Inst Instance=new A090503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090504
{
public static readonly long[] Value={ 1L,3L,7L,21L,27L,39L,101L,169L,239L,247L,263L,291L,381L,391L,447L,489L,509L,531L,619L,699L,821L,981L,1011L,1267L,1367L,1483L,1691L,1777L,2241L,2351L,2403L,2859L,4153L,4793L,5299L,5513L,5553L,5673L,5797L,6813L,7491L,7721L,7861L,8073L,8363L,8409L,9781L,9879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090504Inst : IEnumerable<long>
{
public static readonly long[] Value=A090504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090504.Bytes);
public long this[int i]=>Value[i];

public static A090504Inst Instance=new A090504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090505
{
public static readonly BigInteger[] Value={ 13L,137L,13721L,1372127L,137212739L,137212739101L,137212739101169L,137212739101169239L,BigInteger.Parse("137212739101169239247"),BigInteger.Parse("137212739101169239247263"),BigInteger.Parse("137212739101169239247263291"),BigInteger.Parse("137212739101169239247263291381") };
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
public class A090505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090505.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090505Inst Instance=new A090505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090506
{
public static readonly long[] Value={ 11L,23L,31L,419L,523L,63L,741L,81L,933L,1077L,117L,1257L,137L,1441L,1523L,16111L,1731L,1829L,1977L,20091L,21151L,221L,23059L,24059L,2569L,2621L,2769L,2883L,2913L,3087L,319L,32099L,33033L,3483L,35193L,3607L,37841L,3859L,39489L,4083L,41333L,42213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090506Inst : IEnumerable<long>
{
public static readonly long[] Value=A090506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090506.Bytes);
public long this[int i]=>Value[i];

public static A090506Inst Instance=new A090506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090507
{
public static readonly BigInteger[] Value={ 11L,1123L,112331L,112331419L,112331419523L,11233141952363L,11233141952363741L,1123314195236374181L,BigInteger.Parse("1123314195236374181933"),BigInteger.Parse("11233141952363741819331077"),BigInteger.Parse("11233141952363741819331077117") };
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
public class A090507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090507Inst Instance=new A090507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090508
{
public static readonly long[] Value={ 2L,3L,51L,71L,1137L,1321L,1727L,1947L,2383L,2919L,311L,3723L,4173L,43197L,47307L,531L,59103L,6117L,67279L,7191L,73457L,79159L,8379L,8913L,97697L,1011483L,10399L,107151L,10959L,113529L,12713L,1311171L,137649L,139101L,149107L,1511229L,15743L,163639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090508Inst : IEnumerable<long>
{
public static readonly long[] Value=A090508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090508.Bytes);
public long this[int i]=>Value[i];

public static A090508Inst Instance=new A090508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090509
{
public static readonly BigInteger[] Value={ 2L,23L,2351L,235171L,2351711137L,23517111371321L,235171113713211727L,BigInteger.Parse("2351711137132117271947"),BigInteger.Parse("23517111371321172719472383"),BigInteger.Parse("235171113713211727194723832919"),BigInteger.Parse("235171113713211727194723832919311"),BigInteger.Parse("2351711137132117271947238329193113723") };
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
public class A090509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A090509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A090509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A090509Inst Instance=new A090509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A090510
{
public static readonly long[] Value={ 2L,3L,509L,79L,1163L,13033L,1721L,19L,233L,29569L,3119L,37057L,410171L,43003L,47111L,5323L,59219L,61291L,670223L,710911L,73331L,795793L,83399L,894709L,975581L,101383L,1033079L,1071937L,109073L,1130257L,1276397L,1313911L,1378673L,1395469L,1491233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A090510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A090510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A090510Inst : IEnumerable<long>
{
public static readonly long[] Value=A090510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A090510.Bytes);
public long this[int i]=>Value[i];

public static A090510Inst Instance=new A090510Inst();

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