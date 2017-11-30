using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A109841
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,11L,45L,24L,19L,18L,17L,27L,29L,34L,26L,23L,22L,30L,32L,43L,31L,28L,35L,40L,44L,44L,34L,33L,45L,56L,38L,106L,39L,49L,61L,73L,50L,58L,44L,56L,48L,54L,53L,50L,51L,60L,59L,58L,57L,55L,58L,64L,63L,62L,61L,69L,72L,68L,67L,66L,66L,79L,100L,72L,71L,83L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109841Inst : IEnumerable<long>
{
public static readonly long[] Value=A109841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109841.Bytes);
public long this[int i]=>Value[i];

public static A109841Inst Instance=new A109841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109842
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,34L,12L,6L,4L,2L,11L,12L,16L,7L,3L,1L,8L,9L,19L,6L,2L,8L,12L,15L,14L,3L,1L,12L,22L,3L,70L,2L,11L,22L,33L,9L,16L,1L,12L,3L,8L,6L,2L,2L,10L,8L,6L,4L,1L,3L,8L,6L,4L,2L,9L,11L,6L,4L,2L,1L,13L,33L,4L,2L,13L,7L,3L,29L,2L,8L,1L,32L,9L,2L,8L,7L,3L,11L,2L,11L,44L,1L,77L,2L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109842Inst : IEnumerable<long>
{
public static readonly long[] Value=A109842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109842.Bytes);
public long this[int i]=>Value[i];

public static A109842Inst Instance=new A109842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109843
{
public static readonly long[] Value={ 2L,2L,3L,16L,5L,0L,7L,16L,0L,20L,11L,0L,13L,14L,0L,16L,17L,0L,38L,20L,0L,110L,92L,0L,50L,104L,0L,112L,145L,30L,31L,32L,0L,34L,35L,0L,37L,38L,0L,160L,164L,0L,172L,1100L,0L,92L,188L,0L,98L,50L,0L,104L,106L,0L,110L,112L,0L,754L,118L,0L,305L,124L,0L,128L,130L,0L,134L,136L,0L,70L,71L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109843Inst : IEnumerable<long>
{
public static readonly long[] Value=A109843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109843.Bytes);
public long this[int i]=>Value[i];

public static A109843Inst Instance=new A109843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109844
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,48L,21L,16L,9L,160L,231L,576L,65L,112L,45L,32L,17L,576L,855L,2240L,1365L,12672L,5313L,3840L,225L,416L,567L,1344L,145L,240L,93L,64L,33L,2176L,3255L,8640L,5365L,51072L,22113L,16640L,9225L,161280L,228459L,557568L,61425L,103040L,40185L,27648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109844Inst : IEnumerable<long>
{
public static readonly long[] Value=A109844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109844.Bytes);
public long this[int i]=>Value[i];

public static A109844Inst Instance=new A109844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109845
{
public static readonly BigInteger[] Value={ 2L,3L,5L,31L,929L,863971L,746445024869L,BigInteger.Parse("557180175152428473492031"),BigInteger.Parse("310449747582890872093779269721785644810947012929"),BigInteger.Parse("96379045774280656880008037888192772255684941220159788508646084243678677683026025975278640171971") };
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
public class A109845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109845Inst Instance=new A109845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109846
{
public static readonly long[] Value={ 9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,79L,77L,75L,73L,71L,69L,67L,65L,63L,61L,59L,57L,55L,53L,51L,49L,47L,45L,43L,41L,39L,37L,35L,33L,31L,29L,27L,25L,23L,21L,19L,17L,15L,13L,11L,9L,7L,5L,3L,1L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109846Inst : IEnumerable<long>
{
public static readonly long[] Value=A109846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109846.Bytes);
public long this[int i]=>Value[i];

public static A109846Inst Instance=new A109846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109847
{
public static readonly long[] Value={ 8L,14L,6L,20L,20L,6L,14L,8L,0L,890L,88L,348L,1118L,1190L,420L,1328L,1394L,162L,1520L,1580L,546L,154L,1748L,600L,1850L,1898L,216L,1988L,2030L,690L,2108L,2144L,66L,2210L,2240L,252L,2294L,2318L,780L,2360L,2378L,798L,2408L,220L,270L,2438L,2444L,816L,2450L,2450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109847Inst : IEnumerable<long>
{
public static readonly long[] Value=A109847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109847.Bytes);
public long this[int i]=>Value[i];

public static A109847Inst Instance=new A109847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109848
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,1L,1L,9L,1L,11L,3L,1L,1L,3L,1L,1L,9L,1L,1L,3L,11L,1L,3L,1L,1L,9L,1L,1L,3L,1L,1L,33L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,11L,9L,1L,1L,3L,1L,1L,3L,1L,1L,9L,11L,1L,3L,1L,1L,3L,1L,1L,9L,1L,1L,33L,1L,1L,3L,1L,1L,9L,1L,1L,3L,1L,11L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,11L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,99L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109848Inst : IEnumerable<long>
{
public static readonly long[] Value=A109848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109848.Bytes);
public long this[int i]=>Value[i];

public static A109848Inst Instance=new A109848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109849
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,12L,21L,8L,9L,40L,231L,12L,65L,28L,15L,16L,17L,144L,285L,140L,1365L,132L,5313L,120L,225L,104L,189L,84L,145L,60L,93L,32L,33L,544L,3255L,180L,5365L,1596L,2457L,520L,9225L,840L,228459L,132L,4095L,3220L,13395L,144L,833L,400L,255L,364L,3445L,108L,1155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109849Inst : IEnumerable<long>
{
public static readonly long[] Value=A109849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109849.Bytes);
public long this[int i]=>Value[i];

public static A109849Inst Instance=new A109849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109850
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,9L,12L,15L,16L,17L,32L,33L,60L,63L,64L,65L,104L,120L,125L,128L,129L,252L,255L,256L,257L,512L,513L,912L,972L,1008L,1017L,1020L,1023L,1024L,1025L,2000L,2025L,2040L,2045L,2048L,2049L,4092L,4095L,4096L,4097L,7712L,8160L,8177L,8192L,8193L,16380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109850Inst : IEnumerable<long>
{
public static readonly long[] Value=A109850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109850.Bytes);
public long this[int i]=>Value[i];

public static A109850Inst Instance=new A109850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109851
{
public static readonly BigInteger[] Value={ 1L,2L,1L,2L,4L,14L,74L,494L,3854L,34094L,336494L,3662894L,43579694L,562498094L,7827355694L,116800219694L,1860366043694L,31500985051694L,565032127195694L,10702123827931694L,213443957842651694L,4471022472151771694L,BigInteger.Parse("98137749786952411694"),BigInteger.Parse("2252472478027367131694") };
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
public class A109851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109851Inst Instance=new A109851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109852
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,5L,7L,10L,16L,12L,20L,9L,14L,11L,13L,22L,28L,18L,40L,24L,32L,30L,21L,15L,48L,36L,44L,27L,26L,17L,19L,34L,52L,54L,88L,72L,96L,45L,42L,60L,64L,120L,80L,90L,56L,66L,39L,33L,70L,63L,100L,84L,112L,50L,35L,25L,104L,78L,68L,51L,38L,23L,29L,46L,76L,102L,136L,156L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109852Inst : IEnumerable<long>
{
public static readonly long[] Value=A109852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109852.Bytes);
public long this[int i]=>Value[i];

public static A109852Inst Instance=new A109852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109853
{
public static readonly long[] Value={ 1L,2L,4L,7L,13L,19L,29L,37L,43L,53L,61L,71L,79L,89L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109853Inst : IEnumerable<long>
{
public static readonly long[] Value=A109853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109853.Bytes);
public long this[int i]=>Value[i];

public static A109853Inst Instance=new A109853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109854
{
public static readonly long[] Value={ 20L,110L,110L,20980L,29580L,9860L,150780L,50260L,217490L,657770L,426650L,1999330L,2942960L,1295490L,431830L,437570L,436450L,7564120L,6449730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109854Inst : IEnumerable<long>
{
public static readonly long[] Value=A109854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109854.Bytes);
public long this[int i]=>Value[i];

public static A109854Inst Instance=new A109854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109855
{
public static readonly BigInteger[] Value={ 1L,2L,3L,456L,78910L,1112L,13141516171819202122UL,232425262728L,29303132333435L,3637383940L,BigInteger.Parse("4142434445464748495051525354555657585960616263646566676869707172737475767778798081828384858687888990919293949596979899100101102103104105106") };
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
public class A109855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109855Inst Instance=new A109855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109856
{
public static readonly BigInteger[] Value={ 1L,6L,41L,30864L,2469135782L,20576131516852L,BigInteger.Parse("1763668415730173305930881688457446"),BigInteger.Parse("1543209863763901642689521477400265279053157841"),BigInteger.Parse("137174210112346812683513020213356913693614030314367014703715") };
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
public class A109856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109856Inst Instance=new A109856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109857
{
public static readonly long[] Value={ 1L,4L,2L,7L,5L,3L,12L,10L,8L,6L,17L,15L,13L,11L,9L,24L,22L,20L,18L,16L,14L,31L,29L,27L,25L,23L,21L,19L,40L,38L,36L,34L,32L,30L,28L,26L,49L,47L,45L,43L,41L,39L,37L,35L,33L,60L,58L,56L,54L,52L,50L,48L,46L,44L,42L,71L,69L,67L,65L,63L,61L,59L,57L,55L,53L,51L,84L,82L,80L,78L,76L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109857Inst : IEnumerable<long>
{
public static readonly long[] Value=A109857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109857.Bytes);
public long this[int i]=>Value[i];

public static A109857Inst Instance=new A109857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109858
{
public static readonly long[] Value={ 1L,2L,11L,3L,111L,4L,22L,121L,202L,1111L,2002L,5L,131L,212L,10301L,11111L,20102L,6L,33L,141L,222L,303L,1221L,2112L,3003L,10401L,11211L,12021L,20202L,21012L,30003L,102201L,111111L,120021L,201102L,210012L,300003L,7L,151L,232L,313L,10501L,11311L,12121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109858Inst : IEnumerable<long>
{
public static readonly long[] Value=A109858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109858.Bytes);
public long this[int i]=>Value[i];

public static A109858Inst Instance=new A109858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109859
{
public static readonly long[] Value={ 1L,2L,2L,6L,6L,20L,20L,70L,70L,251L,251L,918L,917L,3404L,3396L,12750L,12705L,48125L,47905L,182735L,181743L,697193L,692924L,2670538L,2652676L,10263255L,10189830L,39554920L,39256570L,152819066L,151616215L,591672286L,586848959L,2295096732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109859Inst : IEnumerable<long>
{
public static readonly long[] Value=A109859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109859.Bytes);
public long this[int i]=>Value[i];

public static A109859Inst Instance=new A109859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109860
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,49L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,143L,149L,151L,157L,163L,167L,169L,173L,179L,181L,187L,191L,193L,197L,199L,209L,211L,221L,223L,227L,229L,233L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109860Inst : IEnumerable<long>
{
public static readonly long[] Value=A109860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109860.Bytes);
public long this[int i]=>Value[i];

public static A109860Inst Instance=new A109860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109861
{
public static readonly long[] Value={ 25L,49L,121L,143L,169L,187L,209L,221L,247L,289L,299L,323L,361L,391L,437L,493L,527L,529L,551L,589L,629L,667L,703L,713L,779L,817L,841L,851L,899L,943L,961L,989L,1073L,1081L,1147L,1189L,1219L,1247L,1271L,1333L,1363L,1369L,1457L,1517L,1537L,1591L,1643L,1681L,1711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109861Inst : IEnumerable<long>
{
public static readonly long[] Value=A109861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109861.Bytes);
public long this[int i]=>Value[i];

public static A109861Inst Instance=new A109861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109862
{
public static readonly long[] Value={ 3L,5L,7L,11L,191L,353L,383L,929L,10601L,11411L,12821L,13931L,14741L,15551L,16061L,16361L,16661L,17471L,30803L,32423L,33533L,36263L,72227L,74747L,75557L,76367L,76667L,93239L,94349L,94649L,94949L,97379L,1028201L,1074701L,1082801L,1300031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109862Inst : IEnumerable<long>
{
public static readonly long[] Value=A109862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109862.Bytes);
public long this[int i]=>Value[i];

public static A109862Inst Instance=new A109862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109863
{
public static readonly long[] Value={ 7L,5L,3L,89L,809L,647L,617L,71L,89399L,88589L,87179L,86069L,85259L,84449L,83939L,83639L,83339L,82529L,69197L,67577L,66467L,63737L,27773L,25253L,24443L,23633L,23333L,6761L,5651L,5351L,5051L,2621L,8971799L,8925299L,8917199L,8699969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109863Inst : IEnumerable<long>
{
public static readonly long[] Value=A109863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109863.Bytes);
public long this[int i]=>Value[i];

public static A109863Inst Instance=new A109863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109864
{
public static readonly long[] Value={ 11L,2L,3L,0L,5L,0L,7L,0L,919L,101L,11L,12421L,131L,14341L,151L,16061L,17471L,181L,191L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,30103L,313L,32323L,33533L,34543L,353L,36263L,373L,383L,39293L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109864Inst : IEnumerable<long>
{
public static readonly long[] Value=A109864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109864.Bytes);
public long this[int i]=>Value[i];

public static A109864Inst Instance=new A109864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109865
{
public static readonly long[] Value={ 3L,2L,1L,1L,0L,0L,2L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109865Inst : IEnumerable<long>
{
public static readonly long[] Value=A109865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109865.Bytes);
public long this[int i]=>Value[i];

public static A109865Inst Instance=new A109865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109866
{
public static readonly long[] Value={ 8L,3L,8L,1L,9L,6L,6L,0L,1L,1L,2L,5L,0L,1L,0L,5L,1L,5L,1L,7L,9L,5L,4L,1L,3L,1L,6L,5L,6L,3L,4L,3L,6L,1L,8L,8L,2L,2L,7L,9L,6L,9L,0L,8L,2L,0L,1L,9L,4L,2L,3L,7L,1L,3L,7L,8L,6L,4L,5L,5L,1L,3L,7L,7L,2L,9L,4L,7L,3L,9L,5L,3L,7L,1L,8L,1L,0L,9L,7L,5L,5L,0L,2L,9L,2L,7L,9L,2L,7L,9L,5L,8L,1L,0L,6L,0L,8L,8L,6L,2L,5L,1L,5L,2L,4L,5L,9L,1L,1L,9L,2L,4L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109866Inst : IEnumerable<long>
{
public static readonly long[] Value=A109866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109866.Bytes);
public long this[int i]=>Value[i];

public static A109866Inst Instance=new A109866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109867
{
public static readonly BigInteger[] Value={ 12L,297L,539055L,12949081200L,BigInteger.Parse("167631138529627443759"),BigInteger.Parse("888408727567955042239409874101472777521040"),BigInteger.Parse("787659989217062162749912989661115208857840881836480202901460330472578518132645989056") };
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
public class A109867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109867Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109867.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109867.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109867Inst Instance=new A109867Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109868
{
public static readonly long[] Value={ 1L,2L,11L,10L,110L,100L,1100L,1000L,11000L,10000L,110000L,100000L,1100000L,1000000L,11000000L,10000000L,110000000L,100000000L,1100000000L,1000000000L,11000000000L,10000000000L,110000000000L,100000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109868Inst : IEnumerable<long>
{
public static readonly long[] Value=A109868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109868.Bytes);
public long this[int i]=>Value[i];

public static A109868Inst Instance=new A109868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109869
{
public static readonly long[] Value={ 1L,2L,14L,67L,116L,189L,482L,761L,18253L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109869Inst : IEnumerable<long>
{
public static readonly long[] Value=A109869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109869.Bytes);
public long this[int i]=>Value[i];

public static A109869Inst Instance=new A109869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109870
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,4L,3L,2L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,0L,1L,2L,2L,2L,2L,5L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,5L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,4L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,3L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109870Inst : IEnumerable<long>
{
public static readonly long[] Value=A109870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109870.Bytes);
public long this[int i]=>Value[i];

public static A109870Inst Instance=new A109870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109871
{
public static readonly long[] Value={ 9L,-1L,8L,7L,6L,5L,4L,3L,2L,82L,-1L,2L,2L,1L,1L,1L,1L,1L,1L,73L,17L,10L,1L,2L,1L,1L,1L,1L,1L,64L,25L,3L,8L,1L,2L,1L,1L,1L,1L,55L,33L,3L,2L,7L,1L,2L,1L,1L,1L,46L,41L,3L,2L,2L,6L,1L,2L,1L,1L,37L,49L,3L,2L,2L,2L,5L,1L,2L,1L,28L,57L,3L,2L,2L,2L,2L,4L,1L,2L,19L,65L,3L,2L,2L,2L,2L,2L,3L,1L,11L,73L,4L,3L,3L,3L,3L,3L,3L,3L,812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109871Inst : IEnumerable<long>
{
public static readonly long[] Value=A109871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109871.Bytes);
public long this[int i]=>Value[i];

public static A109871Inst Instance=new A109871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109872
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,66L,77L,88L,99L,101L,202L,303L,404L,505L,606L,707L,808L,909L,1111L,2222L,3333L,4444L,5555L,6666L,7777L,8888L,9999L,10001L,20002L,30003L,40004L,50005L,60006L,70007L,80008L,90009L,110011L,220022L,330033L,440044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109872Inst : IEnumerable<long>
{
public static readonly long[] Value=A109872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109872.Bytes);
public long this[int i]=>Value[i];

public static A109872Inst Instance=new A109872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109873
{
public static readonly BigInteger[] Value={ 1L,1L,1L,6L,4L,125L,225L,336140L,2458624L,324060912L,8930250000L,835597712998125L,9001015156742400L,BigInteger.Parse("6600661714966989472803"),BigInteger.Parse("68987440762943255933340961"),BigInteger.Parse("28036608657071518646200652343750"),BigInteger.Parse("377177413291384771899817984000000") };
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
public class A109873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109873Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109873.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109873.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109873Inst Instance=new A109873Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109874
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,6L,5L,7L,8L,10L,9L,12L,11L,12L,12L,16L,14L,18L,16L,18L,20L,22L,19L,22L,24L,22L,23L,28L,26L,30L,25L,30L,32L,30L,36L,36L,36L,36L,40L,40L,36L,42L,40L,39L,44L,46L,40L,45L,44L,46L,48L,52L,45L,50L,49L,54L,56L,58L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109874Inst : IEnumerable<long>
{
public static readonly long[] Value=A109874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109874.Bytes);
public long this[int i]=>Value[i];

public static A109874Inst Instance=new A109874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109875
{
public static readonly long[] Value={ 13L,587L,1361L,15227L,118967L,337721L,383267L,512891L,1027331L,1780151L,2303681L,8200391L,9310517L,14666579L,25005089L,29105981L,34824971L,38895497L,40436909L,51819461L,63462977L,65427749L,65599199L,66043091L,75552479L,94671671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109875Inst : IEnumerable<long>
{
public static readonly long[] Value=A109875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109875.Bytes);
public long this[int i]=>Value[i];

public static A109875Inst Instance=new A109875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109876
{
public static readonly long[] Value={ 1L,3L,2L,6L,11L,6L,10L,24L,50L,24L,15L,45L,120L,274L,120L,21L,76L,252L,720L,1764L,720L,28L,119L,476L,1680L,5040L,13068L,5040L,36L,176L,828L,3520L,12960L,40320L,109584L,40320L,45L,249L,1350L,6750L,29880L,113400L,362880L,1026576L,362880L,55L,340L,2090L,12048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109876Inst : IEnumerable<long>
{
public static readonly long[] Value=A109876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109876.Bytes);
public long this[int i]=>Value[i];

public static A109876Inst Instance=new A109876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109877
{
public static readonly ulong[] Value={ 1L,5L,23L,108L,574L,3553L,25451L,207744L,1904010L,19357873L,216180227L,2630384900L,34634700918L,490653944569L,7441157228467L,120286142846816L,2064606497134554L,37499986847250777L,718589662860007003L,14487877657131343316UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109877Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A109877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109877.Bytes);
public ulong this[int i]=>Value[i];

public static A109877Inst Instance=new A109877Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109878
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,2L,6L,12L,4L,6L,24L,60L,20L,10L,24L,120L,360L,120L,60L,36L,120L,720L,2520L,840L,420L,252L,168L,720L,5040L,20160L,6720L,3360L,2016L,1344L,960L,5040L,40320L,181440L,60480L,30240L,18144L,12096L,8640L,6480L,40320L,362880L,1814400L,604800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109878Inst : IEnumerable<long>
{
public static readonly long[] Value=A109878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109878.Bytes);
public long this[int i]=>Value[i];

public static A109878Inst Instance=new A109878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109879
{
public static readonly long[] Value={ 7L,19L,91L,127L,721L,919L,999L,1385L,1727L,3159L,4376L,5409L,5831L,6734L,7271L,9045L,9513L,10647L,11824L,12691L,14491L,15967L,16939L,19441L,19621L,25352L,26973L,27872L,28737L,29783L,31213L,35163L,35929L,36153L,37962L,37973L,38656L,38792L,39636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109879Inst : IEnumerable<long>
{
public static readonly long[] Value=A109879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109879.Bytes);
public long this[int i]=>Value[i];

public static A109879Inst Instance=new A109879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109880
{
public static readonly long[] Value={ 1L,7L,19L,91L,127L,721L,919L,14491L,19441L,113491L,177877L,194311L,778771L,1081801L,1188811L,1767169L,1927207L,1946491L,7027291L,9617671L,16056847L,74775169L,74865061L,96157747L,129869461L,164968921L,167828761L,180676081L,189202267L,757333297L,762202981L,792333757L,1917766117L,7116677191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109880Inst : IEnumerable<long>
{
public static readonly long[] Value=A109880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109880.Bytes);
public long this[int i]=>Value[i];

public static A109880Inst Instance=new A109880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109881
{
public static readonly long[] Value={ 100L,125L,144L,169L,196L,256L,400L,441L,512L,625L,900L,961L,1000L,1024L,1089L,1296L,1369L,1600L,1764L,1936L,2025L,2304L,2401L,2500L,2809L,2916L,3600L,4096L,4761L,4900L,6400L,7056L,8000L,8100L,9025L,9216L,9604L,9801L,10000L,10201L,10404L,10609L,10816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109881Inst : IEnumerable<long>
{
public static readonly long[] Value=A109881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109881.Bytes);
public long this[int i]=>Value[i];

public static A109881Inst Instance=new A109881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109882
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,66L,77L,88L,99L,101L,202L,303L,404L,505L,606L,707L,808L,909L,1001L,2002L,3003L,4004L,5005L,6006L,7007L,8008L,9009L,10001L,20002L,30003L,40004L,50005L,60006L,70007L,80008L,90009L,100001L,200002L,300003L,400004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109882Inst : IEnumerable<long>
{
public static readonly long[] Value=A109882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109882.Bytes);
public long this[int i]=>Value[i];

public static A109882Inst Instance=new A109882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109883
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,0L,6L,1L,5L,2L,10L,2L,12L,4L,6L,1L,16L,6L,18L,8L,10L,8L,22L,0L,19L,10L,14L,0L,28L,3L,30L,1L,18L,14L,22L,11L,36L,16L,22L,10L,40L,9L,42L,4L,12L,20L,46L,12L,41L,7L,30L,6L,52L,15L,38L,20L,34L,26L,58L,2L,60L,28L,22L,1L,46L,21L,66L,10L,42L,31L,70L,9L,72L,34L,26L,12L,58L,27L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109883Inst : IEnumerable<long>
{
public static readonly long[] Value=A109883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109883.Bytes);
public long this[int i]=>Value[i];

public static A109883Inst Instance=new A109883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109884
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,16L,18L,24L,28L,30L,32L,40L,44L,48L,60L,64L,72L,84L,120L,126L,128L,136L,140L,150L,152L,180L,184L,204L,216L,224L,234L,256L,270L,360L,420L,440L,462L,468L,496L,512L,520L,528L,546L,672L,700L,750L,752L,864L,870L,884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109884Inst : IEnumerable<long>
{
public static readonly long[] Value=A109884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109884.Bytes);
public long this[int i]=>Value[i];

public static A109884Inst Instance=new A109884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109885
{
public static readonly long[] Value={ 4L,10L,22L,24L,34L,36L,48L,54L,60L,66L,72L,78L,84L,90L,102L,114L,120L,126L,144L,150L,156L,168L,180L,186L,198L,204L,210L,240L,246L,252L,270L,294L,300L,324L,330L,360L,378L,390L,420L,450L,462L,480L,510L,540L,546L,570L,600L,630L,660L,690L,714L,720L,750L,780L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109885Inst : IEnumerable<long>
{
public static readonly long[] Value=A109885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109885.Bytes);
public long this[int i]=>Value[i];

public static A109885Inst Instance=new A109885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109886
{
public static readonly long[] Value={ 1L,2L,3L,30L,5L,9L,7L,50L,20L,42L,11L,36L,13L,6510L,27L,54L,17L,70620L,19L,25L,46L,66L,23L,168630L,124L,98L,58L,78L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109886Inst : IEnumerable<long>
{
public static readonly long[] Value=A109886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109886.Bytes);
public long this[int i]=>Value[i];

public static A109886Inst Instance=new A109886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109887
{
public static readonly long[] Value={ 3L,4L,10L,20L,44L,60L,583L,677L,947L,1182L,12048L,16018L,74316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109887Inst : IEnumerable<long>
{
public static readonly long[] Value=A109887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109887.Bytes);
public long this[int i]=>Value[i];

public static A109887Inst Instance=new A109887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109888
{
public static readonly long[] Value={ 1L,9L,15L,25L,39L,51L,55L,75L,91L,112L,130L,152L,176L,202L,230L,260L,287L,319L,352L,386L,422L,460L,495L,535L,579L,621L,666L,712L,760L,810L,862L,916L,965L,1022L,1078L,1136L,1196L,1258L,1322L,1385L,1450L,1516L,1584L,1653L,1725L,1795L,1869L,1945L,2022L,2100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109888Inst : IEnumerable<long>
{
public static readonly long[] Value=A109888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109888.Bytes);
public long this[int i]=>Value[i];

public static A109888Inst Instance=new A109888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109889
{
public static readonly long[] Value={ 1L,4L,5L,6L,20L,22L,25L,46L,47L,214L,822L,985L,3273L,3590L,4658L,4768L,17250L,38697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109889Inst : IEnumerable<long>
{
public static readonly long[] Value=A109889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109889.Bytes);
public long this[int i]=>Value[i];

public static A109889Inst Instance=new A109889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109890
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,8L,12L,9L,5L,10L,15L,25L,20L,24L,16L,32L,48L,30L,18L,36L,27L,13L,7L,53L,106L,265L,159L,318L,212L,14L,107L,321L,214L,428L,642L,535L,35L,21L,181L,11L,33L,22L,23L,59L,70L,28L,151L,29L,19L,233L,466L,2563L,699L,932L,40L,26L,38L,31L,61L,39L,49L,98L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109890Inst : IEnumerable<long>
{
public static readonly long[] Value=A109890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109890.Bytes);
public long this[int i]=>Value[i];

public static A109890Inst Instance=new A109890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109891
{
public static readonly long[] Value={ 0L,1L,10L,16L,14L,15L,13L,1011L,1017L,1037L,1027L,1014L,1013L,1028L,100143L,100135L,100145L,100134L,100103L,100195L,100137L,100227L,100114L,100128L,100194L,100107L,100307L,100277L,100413L,100345L,100429L,100215L,100444L,100237L,100433L,100335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109891Inst : IEnumerable<long>
{
public static readonly long[] Value=A109891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109891.Bytes);
public long this[int i]=>Value[i];

public static A109891Inst Instance=new A109891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109892
{
public static readonly BigInteger[] Value={ 2L,6L,84L,20475L,234531275L,199200973555045L,BigInteger.Parse("16481425431663122588749"),BigInteger.Parse("173392935733620216899469862542865"),BigInteger.Parse("300717095810709134168380432250652303057474577") };
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
public class A109892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109892Inst Instance=new A109892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109893
{
public static readonly BigInteger[] Value={ 10L,8855L,182637273L,187913191983517L,BigInteger.Parse("16299312030218924938187"),BigInteger.Parse("173083581780047419995380839040497"),BigInteger.Parse("300642522445723721070400405660702004585922575"),BigInteger.Parse("109109034687569422667248530075550555291614316919209445960161"),BigInteger.Parse("10269669381215922304236773275682334781908421087118493054965910074350106387039") };
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
public class A109893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109893Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109893.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109893.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109893Inst Instance=new A109893Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109894
{
public static readonly BigInteger[] Value={ 1L,20L,4620L,12697776L,159845400L,941432800L,158800433792L,1895312483064000L,BigInteger.Parse("3438271897004237230080"),933561026438040L,2562849175892544L,BigInteger.Parse("640904462719404383808000"),1528364130975L,2352733350786L,BigInteger.Parse("959393282698730880000"),6142080926952L };
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
public class A109894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109894Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109894.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109894.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109894Inst Instance=new A109894Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109895
{
public static readonly long[] Value={ 1L,6L,12L,20L,28L,36L,45L,56L,70L,80L,90L,104L,112L,120L,132L,140L,154L,168L,180L,192L,208L,220L,234L,250L,264L,280L,297L,312L,324L,336L,350L,360L,378L,396L,416L,432L,448L,462L,480L,495L,504L,520L,539L,560L,576L,594L,612L,630L,640L,660L,672L,693L,714L,728L,748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109895Inst : IEnumerable<long>
{
public static readonly long[] Value=A109895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109895.Bytes);
public long this[int i]=>Value[i];

public static A109895Inst Instance=new A109895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109896
{
public static readonly long[] Value={ 4L,5L,7L,7L,7L,8L,10L,13L,9L,9L,13L,7L,7L,11L,7L,13L,13L,11L,11L,15L,11L,13L,15L,13L,15L,16L,14L,11L,11L,13L,9L,17L,17L,19L,15L,15L,13L,17L,14L,8L,15L,18L,20L,15L,17L,17L,17L,9L,19L,11L,20L,20L,13L,19L,19L,15L,15L,9L,14L,14L,17L,16L,15L,18L,13L,20L,14L,14L,14L,17L,15L,15L,15L,21L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109896Inst : IEnumerable<long>
{
public static readonly long[] Value=A109896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109896.Bytes);
public long this[int i]=>Value[i];

public static A109896Inst Instance=new A109896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109897
{
public static readonly BigInteger[] Value={ 120L,55440L,253955520L,4475671200L,33891580800L,7146019520640L,106137499051584000L,BigInteger.Parse("240679032790296606105600"),74684882115043200L,230656425830328960L,BigInteger.Parse("66654064122818055916032000"),171176782669200L,282328002094320L,BigInteger.Parse("126639913316232476160000"),859891329773280L };
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
public class A109897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109897Inst Instance=new A109897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109898
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,40L,0L,0L,3003L,105L,0L,71680L,0L,24192L,2078505L,0L,0L,330L,4216455243L,0L,2788660875L,39536640L,0L,256256L,0L,16380L,6153560492625L,0L,276348105L,15841280L,0L,0L,20228646742486875L,1116288L,0L,1190707200L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109898Inst : IEnumerable<long>
{
public static readonly long[] Value=A109898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109898.Bytes);
public long this[int i]=>Value[i];

public static A109898Inst Instance=new A109898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109899
{
public static readonly BigInteger[] Value={ 3L,2L,105L,12L,27027L,160L,18706545L,15L,1616615L,96768L,55382044433625L,336L,182057820682381875L,158146560L,260015L,495L,BigInteger.Parse("5087360695596105163111875"),12812800L,BigInteger.Parse("39805919884778682846001415625"),576576L,767633625L };
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
public class A109899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109899.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109899Inst Instance=new A109899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109900
{
public static readonly long[] Value={ 0L,1L,3L,8L,15L,27L,42L,64L,90L,125L,165L,216L,273L,343L,420L,512L,612L,729L,855L,1000L,1155L,1331L,1518L,1728L,1950L,2197L,2457L,2744L,3045L,3375L,3720L,4096L,4488L,4913L,5355L,5832L,6327L,6859L,7410L,8000L,8610L,9261L,9933L,10648L,11385L,12167L,12972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109900Inst : IEnumerable<long>
{
public static readonly long[] Value=A109900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109900.Bytes);
public long this[int i]=>Value[i];

public static A109900Inst Instance=new A109900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109901
{
public static readonly BigInteger[] Value={ 1L,1L,4L,84L,8008L,3268760L,5567902560L,39049918716424L,1118770292985239888L,BigInteger.Parse("130276394656770614583240"),BigInteger.Parse("61448471214136179596720592960"),BigInteger.Parse("117118180539414377821494470432491764") };
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
public class A109901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109901Inst Instance=new A109901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109902
{
public static readonly long[] Value={ 13L,19L,23L,31L,79L,97L,103L,109L,409L,709L,907L,1009L,2003L,3001L,9001L,9007L,10009L,40009L,70009L,90001L,90007L,100003L,200003L,400009L,900001L,900007L,1000003L,2000003L,7000009L,20000003L,30000001L,400000009L,1000000009L,4000000009L,9000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109902Inst : IEnumerable<long>
{
public static readonly long[] Value=A109902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109902.Bytes);
public long this[int i]=>Value[i];

public static A109902Inst Instance=new A109902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109903
{
public static readonly ulong[] Value={ 6L,20L,56L,36L,11L,13L,680L,3876L,245157L,34597290L,84672315L,12875774670L,244662670200L,800472431850L,14833897694226L,973469712824056L,48402641245296107L,191724747789809255L,9989690752182277136UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109903Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A109903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109903.Bytes);
public ulong this[int i]=>Value[i];

public static A109903Inst Instance=new A109903Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109904
{
public static readonly BigInteger[] Value={ 5L,7L,13L,43L,463L,53593L,718052371L,128899801874680399L,BigInteger.Parse("4153789730832965126116749598699801"),BigInteger.Parse("4313492281993349218329412357362100514520987205269104143837429352069") };
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
public class A109904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109904Inst Instance=new A109904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109905
{
public static readonly long[] Value={ 0L,2L,3L,5L,7L,0L,13L,17L,19L,17L,31L,37L,43L,41L,37L,61L,73L,73L,89L,101L,109L,113L,131L,109L,157L,89L,181L,197L,211L,0L,241L,257L,271L,281L,307L,181L,337L,353L,379L,401L,421L,433L,463L,449L,487L,521L,547L,577L,601L,617L,631L,677L,701L,0L,757L,769L,811L,761L,859L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109905Inst : IEnumerable<long>
{
public static readonly long[] Value=A109905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109905.Bytes);
public long this[int i]=>Value[i];

public static A109905Inst Instance=new A109905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109906
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,6L,6L,3L,5L,12L,24L,12L,5L,8L,25L,60L,60L,25L,8L,13L,48L,150L,180L,150L,48L,13L,21L,91L,336L,525L,525L,336L,91L,21L,34L,168L,728L,1344L,1750L,1344L,728L,168L,34L,55L,306L,1512L,3276L,5040L,5040L,3276L,1512L,306L,55L,89L,550L,3060L,7560L,13650L,16128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109906Inst : IEnumerable<long>
{
public static readonly long[] Value=A109906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109906.Bytes);
public long this[int i]=>Value[i];

public static A109906Inst Instance=new A109906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109907
{
public static readonly BigInteger[] Value={ 7L,11L,29L,197L,9689L,23469167L,137700449916401L,BigInteger.Parse("4740353476794815041972197893"),BigInteger.Parse("5617737771240172767652929826457529708578746492288409399"),BigInteger.Parse("7889744416604625924469156192031986939513870147397674409917489724005347434748024264638497225986334149357868007") };
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
public class A109907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109907Inst Instance=new A109907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109908
{
public static readonly long[] Value={ 0L,0L,0L,3L,5L,7L,11L,11L,19L,23L,29L,31L,41L,47L,53L,59L,71L,79L,89L,83L,109L,71L,131L,139L,149L,167L,181L,191L,197L,223L,239L,251L,271L,263L,293L,307L,311L,359L,379L,383L,419L,439L,461L,479L,503L,503L,521L,571L,599L,599L,647L,659L,701L,727L,743L,719L,811L,839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109908Inst : IEnumerable<long>
{
public static readonly long[] Value=A109908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109908.Bytes);
public long this[int i]=>Value[i];

public static A109908Inst Instance=new A109908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109909
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,1L,2L,1L,4L,1L,3L,2L,3L,2L,3L,2L,4L,3L,5L,1L,10L,1L,5L,5L,4L,2L,6L,3L,5L,3L,9L,4L,11L,3L,5L,5L,5L,5L,14L,1L,6L,6L,7L,6L,11L,5L,8L,4L,15L,3L,13L,4L,10L,9L,6L,5L,11L,4L,12L,5L,13L,4L,12L,4L,6L,11L,13L,4L,12L,6L,15L,12L,9L,4L,9L,5L,10L,8L,10L,3L,28L,7L,11L,15L,6L,9L,20L,7L,20L,6L,17L,5L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109909Inst : IEnumerable<long>
{
public static readonly long[] Value=A109909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109909.Bytes);
public long this[int i]=>Value[i];

public static A109909Inst Instance=new A109909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109910
{
public static readonly long[] Value={ 9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,8L,88L,78L,68L,58L,48L,38L,28L,18L,8L,7L,87L,77L,67L,57L,47L,37L,27L,17L,7L,6L,86L,76L,66L,56L,46L,36L,26L,16L,6L,5L,85L,75L,65L,55L,45L,35L,25L,15L,5L,4L,84L,74L,64L,54L,44L,34L,24L,14L,4L,3L,83L,73L,63L,53L,43L,33L,23L,13L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109910Inst : IEnumerable<long>
{
public static readonly long[] Value=A109910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109910.Bytes);
public long this[int i]=>Value[i];

public static A109910Inst Instance=new A109910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109911
{
public static readonly long[] Value={ 18L,27L,36L,45L,54L,63L,72L,81L,1098L,1188L,1278L,1368L,1458L,1548L,1638L,1728L,1818L,1908L,2097L,2187L,2277L,2367L,2457L,2547L,2637L,2727L,2817L,2907L,3096L,3186L,3276L,3366L,3456L,3546L,3636L,3726L,3816L,3906L,4095L,4185L,4275L,4365L,4455L,4545L,4635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109911Inst : IEnumerable<long>
{
public static readonly long[] Value=A109911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109911.Bytes);
public long this[int i]=>Value[i];

public static A109911Inst Instance=new A109911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109912
{
public static readonly BigInteger[] Value={ 1L,2L,4L,8L,16L,32L,64L,128L,3456L,127872L,6649344L,1010700288L,46655946694656L,1313038307827703808L,BigInteger.Parse("946546544999554566644656594944"),BigInteger.Parse("183011223033027037132010301880878170112") };
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
public class A109912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109912Inst Instance=new A109912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109913
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,2L,27L,37L,52L,152L,46162L,28143L,720882657693L,193346248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109913Inst : IEnumerable<long>
{
public static readonly long[] Value=A109913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109913.Bytes);
public long this[int i]=>Value[i];

public static A109913Inst Instance=new A109913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109914
{
public static readonly BigInteger[] Value={ 1L,1L,1L,491400L,3546112878000L,143424700959632400L,BigInteger.Parse("10691567972893973348743970911396896000"),BigInteger.Parse("210948344078434820704169472200928966427054605885088717074131707385374604732966434908020301638860800000") };
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
public class A109914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109914.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109914Inst Instance=new A109914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109915
{
public static readonly long[] Value={ 1L,1L,4L,1L,6L,1L,720L,90L,10L,1L,12L,1L,3360L,240L,16L,1L,18L,1L,9240L,462L,22L,1L,11793600L,491400L,19656L,756L,28L,1L,30L,1L,45239040L,1413720L,42840L,1260L,36L,1L,59280L,1560L,40L,1L,42L,1L,91080L,2070L,46L,1L,311875200L,6497400L,132600L,2652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109915Inst : IEnumerable<long>
{
public static readonly long[] Value=A109915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109915.Bytes);
public long this[int i]=>Value[i];

public static A109915Inst Instance=new A109915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109916
{
public static readonly long[] Value={ 7L,8L,5L,1L,5L,3L,4L,4L,5L,7L,1L,0L,3L,4L,1L,0L,3L,3L,7L,4L,5L,4L,7L,2L,9L,9L,9L,0L,4L,5L,0L,1L,4L,1L,2L,7L,3L,5L,1L,6L,5L,1L,9L,9L,4L,5L,2L,2L,0L,8L,3L,0L,9L,9L,8L,7L,4L,7L,3L,2L,3L,0L,7L,1L,9L,1L,4L,2L,4L,7L,5L,2L,4L,6L,0L,7L,7L,2L,3L,3L,8L,1L,5L,2L,3L,5L,6L,2L,1L,9L,2L,2L,1L,5L,8L,4L,2L,6L,0L,6L,2L,4L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109916Inst : IEnumerable<long>
{
public static readonly long[] Value=A109916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109916.Bytes);
public long this[int i]=>Value[i];

public static A109916Inst Instance=new A109916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109917
{
public static readonly long[] Value={ 1L,6L,6L,0L,8L,3L,7L,7L,6L,0L,9L,6L,9L,0L,8L,7L,6L,5L,1L,0L,8L,7L,9L,1L,9L,4L,6L,4L,6L,6L,4L,4L,8L,7L,0L,5L,9L,9L,4L,9L,5L,5L,6L,2L,3L,1L,1L,9L,4L,5L,0L,3L,1L,7L,7L,3L,1L,1L,8L,1L,5L,9L,1L,8L,6L,3L,2L,8L,7L,2L,8L,2L,0L,7L,3L,8L,1L,1L,8L,1L,3L,1L,0L,0L,6L,9L,4L,3L,5L,0L,5L,5L,4L,8L,8L,3L,5L,8L,9L,4L,6L,1L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109917Inst : IEnumerable<long>
{
public static readonly long[] Value=A109917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109917.Bytes);
public long this[int i]=>Value[i];

public static A109917Inst Instance=new A109917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109918
{
public static readonly long[] Value={ 6L,1L,6L,1L,6L,1L,8L,6L,7L,2L,4L,4L,4L,5L,7L,1L,8L,0L,3L,2L,7L,4L,1L,5L,2L,4L,9L,8L,2L,9L,1L,7L,8L,6L,3L,3L,3L,5L,1L,1L,3L,8L,9L,1L,6L,7L,4L,5L,6L,4L,6L,8L,3L,6L,0L,7L,1L,9L,8L,3L,2L,5L,6L,4L,8L,3L,6L,4L,8L,9L,4L,2L,9L,1L,1L,9L,6L,1L,4L,5L,3L,0L,5L,1L,7L,8L,5L,0L,7L,0L,2L,8L,9L,1L,7L,1L,4L,1L,7L,9L,3L,2L,4L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109918Inst : IEnumerable<long>
{
public static readonly long[] Value=A109918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109918.Bytes);
public long this[int i]=>Value[i];

public static A109918Inst Instance=new A109918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109919
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,5L,6L,7L,720L,11L,12L,13L,3360L,17L,18L,19L,9240L,23L,11793600L,29L,30L,31L,45239040L,37L,59280L,41L,42L,43L,91080L,47L,311875200L,53L,549853920L,59L,60L,61L,1072431360L,67L,328440L,71L,72L,73L,2533330800L,79L,531360L,83L,4701090240L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109919Inst : IEnumerable<long>
{
public static readonly long[] Value=A109919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109919.Bytes);
public long this[int i]=>Value[i];

public static A109919Inst Instance=new A109919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109920
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,5L,6L,7L,360L,11L,12L,13L,1680L,17L,18L,19L,4620L,23L,491400L,29L,30L,31L,1884960L,37L,29640L,41L,42L,43L,45540L,47L,12994800L,53L,45821160L,59L,60L,61L,89369280L,67L,164220L,71L,72L,73L,211110900L,79L,265680L,83L,195878760L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109920Inst : IEnumerable<long>
{
public static readonly long[] Value=A109920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109920.Bytes);
public long this[int i]=>Value[i];

public static A109920Inst Instance=new A109920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109921
{
public static readonly long[] Value={ 1L,2L,0L,3L,4L,5L,6L,7L,27L,11L,12L,13L,45L,17L,18L,19L,63L,23L,130L,29L,30L,31L,170L,37L,117L,41L,42L,43L,135L,47L,250L,53L,280L,59L,60L,61L,320L,67L,207L,71L,72L,73L,380L,79L,243L,83L,430L,89L,651L,97L,297L,101L,102L,103L,315L,107L,108L,109L,333L,113L,1560L,127L,387L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109921Inst : IEnumerable<long>
{
public static readonly long[] Value=A109921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109921.Bytes);
public long this[int i]=>Value[i];

public static A109921Inst Instance=new A109921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109922
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,2L,15L,23L,56L,45L,420L,355L,3960L,3432L,3003L,5299L,80080L,71650L,1225224L,1108536L,1007760L,920128L,19399380L,17847429L,82372752L,76271066L,212469400L,197816337L,5354228880L,5008794758L,145568097675L,273491577450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109922Inst : IEnumerable<long>
{
public static readonly long[] Value=A109922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109922.Bytes);
public long this[int i]=>Value[i];

public static A109922Inst Instance=new A109922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109923
{
public static readonly BigInteger[] Value={ 1L,4L,15L,420L,3960L,80080L,1225224L,19399380L,5354228880L,145568097675L,7600186994400L,254425307479200L,9957281351799600L,392482839950100900L,BigInteger.Parse("114779426083185063200"),BigInteger.Parse("5474978624167927514640"),BigInteger.Parse("312603618218620377448800") };
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
public class A109923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109923.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109923Inst Instance=new A109923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109924
{
public static readonly BigInteger[] Value={ 1L,252L,8118L,28382L,536797635L,6180330816L,85770307758L,2889123219882L,535841353148535L,135444949494445310L,BigInteger.Parse("1522312136776312132251") };
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
public class A109924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109924Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109924.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109924.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109924Inst Instance=new A109924Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109925
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,1L,3L,0L,1L,2L,3L,1L,4L,0L,2L,1L,2L,0L,3L,0L,1L,1L,2L,1L,3L,1L,3L,0L,2L,1L,4L,0L,1L,1L,2L,1L,5L,0L,2L,1L,3L,0L,3L,0L,1L,1L,3L,0L,2L,0L,1L,1L,3L,1L,4L,0L,1L,1L,2L,1L,5L,0L,2L,1L,2L,1L,6L,0L,3L,0L,2L,1L,3L,0L,3L,1L,2L,0L,4L,0L,1L,1L,3L,0L,3L,0L,2L,0L,1L,1L,3L,0L,2L,1L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109925Inst : IEnumerable<long>
{
public static readonly long[] Value=A109925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109925.Bytes);
public long this[int i]=>Value[i];

public static A109925Inst Instance=new A109925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109926
{
public static readonly long[] Value={ 1L,3L,4L,15L,21L,45L,75L,465L,1095L,2145L,4935L,14955L,80685L,229845L,1295325L,1575285L,9700575L,20435415L,15054105L,53999715L,2282745465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109926Inst : IEnumerable<long>
{
public static readonly long[] Value=A109926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109926.Bytes);
public long this[int i]=>Value[i];

public static A109926Inst Instance=new A109926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109927
{
public static readonly long[] Value={ 3L,5L,11L,23L,37L,83L,157L,179L,359L,661L,719L,877L,997L,1019L,1237L,1439L,1657L,2039L,2063L,2137L,2459L,2557L,2819L,2903L,2963L,3023L,3061L,3623L,3779L,3803L,3863L,4177L,4261L,4357L,4621L,4919L,5399L,5581L,5639L,6037L,6121L,6217L,6361L,6899L,6983L,7079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109927Inst : IEnumerable<long>
{
public static readonly long[] Value=A109927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109927.Bytes);
public long this[int i]=>Value[i];

public static A109927Inst Instance=new A109927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109928
{
public static readonly long[] Value={ 1L,2L,4L,13L,6L,10L,20L,47L,22L,18L,28L,34L,51L,40L,62L,36L,30L,50L,48L,74L,42L,82L,80L,54L,105L,72L,60L,147L,78L,66L,116L,134L,84L,96L,142L,146L,108L,90L,114L,102L,172L,206L,130L,160L,226L,120L,144L,138L,126L,196L,248L,262L,162L,170L,302L,156L,186L,274L,356L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109928Inst : IEnumerable<long>
{
public static readonly long[] Value=A109928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109928.Bytes);
public long this[int i]=>Value[i];

public static A109928Inst Instance=new A109928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109929
{
public static readonly BigInteger[] Value={ 1L,252L,180081L,855558L,335323533L,1072288822701L,1338059508331L,770589909985077L,97777777779L,98888888889L,BigInteger.Parse("1109887655445567889011") };
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
public class A109929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109929.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109929Inst Instance=new A109929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109930
{
public static readonly BigInteger[] Value={ 2L,242L,24642L,2468642L,1357997531L,1123454543211L,112345656543211L,11234567676543211L,1123456787876543211L,BigInteger.Parse("112345678989876543211"),BigInteger.Parse("1122345678989898765432211"),BigInteger.Parse("11223345678989898987654332211") };
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
public class A109930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109930Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109930.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109930.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109930Inst Instance=new A109930Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109931
{
public static readonly BigInteger[] Value={ 2L,424L,64246L,8642468L,5975335795L,65497555579456L,765439777777934567L,BigInteger.Parse("8765432999999992345678"),BigInteger.Parse("76606769668830703886696760667"),0L };
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
public class A109931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109931Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109931.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109931.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109931Inst Instance=new A109931Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109932
{
public static readonly long[] Value={ 1L,3L,3L,9L,3L,6L,3L,9L,6L,6L,3L,18L,3L,6L,9L,9L,3L,18L,3L,18L,9L,6L,3L,9L,6L,6L,6L,18L,3L,6L,3L,9L,9L,6L,9L,36L,3L,6L,9L,9L,3L,6L,3L,18L,18L,6L,3L,18L,6L,18L,9L,18L,3L,9L,9L,9L,9L,6L,3L,6L,3L,6L,18L,18L,9L,6L,3L,18L,9L,6L,3L,9L,3L,6L,18L,18L,9L,6L,3L,18L,6L,6L,3L,6L,9L,6L,9L,9L,3L,6L,9L,18L,9L,6L,9L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109932Inst : IEnumerable<long>
{
public static readonly long[] Value=A109932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109932.Bytes);
public long this[int i]=>Value[i];

public static A109932Inst Instance=new A109932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109933
{
public static readonly long[] Value={ 1L,3L,9L,53L,79L,159L,237L,477L,711L,4187L,12561L,37683L,265371653L,796114959L,2388344877L,14064697609L,20964360587L,42194092827L,62893081761L,126582278481L,188679245283L,1111111111111L,3333333333333L,9999999999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109933Inst : IEnumerable<long>
{
public static readonly long[] Value=A109933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109933.Bytes);
public long this[int i]=>Value[i];

public static A109933Inst Instance=new A109933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109934
{
public static readonly long[] Value={ 4L,6L,27L,35L,51L,57L,65L,77L,87L,93L,95L,117L,119L,121L,123L,125L,135L,143L,145L,147L,155L,161L,171L,177L,185L,187L,189L,203L,205L,207L,209L,215L,217L,219L,221L,237L,245L,247L,249L,255L,261L,267L,275L,287L,289L,291L,297L,299L,301L,303L,305L,321L,323L,325L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109934Inst : IEnumerable<long>
{
public static readonly long[] Value=A109934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109934.Bytes);
public long this[int i]=>Value[i];

public static A109934Inst Instance=new A109934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109935
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,60L,420L,840L,2520L,2520L,27720L,27720L,859320L,35232120L,598946040L,36535708440L,2594035299240L,23346317693160L,303502130011080L,303502130011080L,303502130011080L,303502130011080L,1214008520044320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109935Inst : IEnumerable<long>
{
public static readonly long[] Value=A109935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109935.Bytes);
public long this[int i]=>Value[i];

public static A109935Inst Instance=new A109935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109936
{
public static readonly long[] Value={ 8L,9L,10L,98L,99L,100L,998L,999L,1000L,1001L,1002L,1003L,1004L,1005L,1006L,1007L,1008L,9974L,9975L,9976L,9977L,9978L,9979L,9980L,9981L,9982L,9983L,9984L,9985L,9986L,9987L,9988L,9989L,9990L,9991L,9992L,9993L,9994L,9995L,9996L,9997L,9998L,9999L,10000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109936Inst : IEnumerable<long>
{
public static readonly long[] Value=A109936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109936.Bytes);
public long this[int i]=>Value[i];

public static A109936Inst Instance=new A109936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109937
{
public static readonly long[] Value={ 3L,3L,11L,33L,11L,19L,27L,17L,69L,51L,25L,49L,65L,57L,47L,123L,5L,13L,89L,49L,217L,35L,139L,263L,135L,207L,201L,539L,345L,67L,59L,69L,69L,603L,91L,225L,123L,191L,59L,137L,227L,145L,137L,83L,17L,153L,73L,225L,65L,207L,443L,557L,347L,321L,131L,595L,371L,307L,159L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109937Inst : IEnumerable<long>
{
public static readonly long[] Value=A109937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109937.Bytes);
public long this[int i]=>Value[i];

public static A109937Inst Instance=new A109937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109938
{
public static readonly long[] Value={ 7L,7L,0L,0L,89L,79L,0L,0L,47L,59L,0L,0L,83L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,809L,619L,857L,0L,227L,509L,787L,823L,557L,0L,907L,0L,653L,0L,347L,359L,0L,383L,773L,0L,797L,0L,0L,0L,0L,467L,479L,0L,503L,0L,0L,0L,0L,0L,563L,0L,587L,0L,0L,0L,0L,0L,0L,0L,0L,0L,719L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109938Inst : IEnumerable<long>
{
public static readonly long[] Value=A109938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109938.Bytes);
public long this[int i]=>Value[i];

public static A109938Inst Instance=new A109938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109939
{
public static readonly long[] Value={ 7L,7L,7L,0L,0L,7L,0L,0L,0L,71L,89L,97L,79L,71L,61L,97L,0L,73L,0L,61L,43L,89L,47L,97L,0L,79L,0L,29L,59L,61L,0L,97L,67L,0L,71L,73L,0L,0L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109939Inst : IEnumerable<long>
{
public static readonly long[] Value=A109939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109939.Bytes);
public long this[int i]=>Value[i];

public static A109939Inst Instance=new A109939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109940
{
public static readonly long[] Value={ 9L,8L,9L,8L,5L,6L,7L,8L,9L,90L,99L,96L,91L,98L,90L,96L,85L,90L,95L,80L,84L,88L,92L,96L,75L,78L,81L,84L,87L,90L,93L,96L,99L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,50L,51L,52L,53L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109940Inst : IEnumerable<long>
{
public static readonly long[] Value=A109940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109940.Bytes);
public long this[int i]=>Value[i];

public static A109940Inst Instance=new A109940Inst();

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