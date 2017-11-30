using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A065145
{
public static readonly long[] Value={ 11L,41L,97L,163L,251L,367L,491L,641L,811L,1009L,1213L,1447L,1693L,19603L,2251L,25601L,2897L,32401L,3613L,4001L,44101L,48407L,5297L,57601L,6257L,6761L,7297L,7841L,8419L,9001L,9613L,10243L,10891L,115601L,12251L,12967L,13691L,14447L,15217L,16001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065145Inst : IEnumerable<long>
{
public static readonly long[] Value=A065145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065145.Bytes);
public long this[int i]=>Value[i];

public static A065145Inst Instance=new A065145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065146
{
public static readonly long[] Value={ 1L,248L,264L,418L,477L,1485L,3080L,3135L,3596L,3828L,5396L,10098L,12648L,20026L,21318L,22152L,23374L,24882L,35074L,35343L,39105L,41656L,44660L,49938L,55154L,56536L,61344L,71145L,74613L,86304L,87087L,104931L,118296L,124605L,129504L,130356L,147560L,150195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065146Inst : IEnumerable<long>
{
public static readonly long[] Value=A065146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065146.Bytes);
public long this[int i]=>Value[i];

public static A065146Inst Instance=new A065146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065147
{
public static readonly BigInteger[] Value={ 72L,79L,84L,91L,100L,121L,144L,202L,244L,400L,1210L,10201L,1100100L,BigInteger.Parse("1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111") };
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
public class A065147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A065147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065147Inst Instance=new A065147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065148
{
public static readonly long[] Value={ 15L,20L,35L,95L,104L,143L,207L,255L,287L,319L,323L,464L,539L,650L,890L,899L,1023L,1034L,1199L,1295L,1349L,1407L,1519L,1763L,1952L,2015L,2204L,2834L,2975L,3599L,4031L,4454L,4607L,5183L,6479L,9215L,9503L,9799L,10403L,11339L,11663L,12095L,12824L,13055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065148Inst : IEnumerable<long>
{
public static readonly long[] Value=A065148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065148.Bytes);
public long this[int i]=>Value[i];

public static A065148Inst Instance=new A065148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065149
{
public static readonly long[] Value={ 10L,33L,65L,136L,145L,261L,385L,451L,897L,946L,1281L,1441L,1665L,1729L,2241L,2353L,3585L,5185L,6721L,7201L,8380L,8911L,8961L,11521L,11782L,12673L,12801L,17101L,18241L,20737L,25201L,26625L,26677L,26937L,29697L,29953L,30721L,30889L,32896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065149Inst : IEnumerable<long>
{
public static readonly long[] Value=A065149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065149.Bytes);
public long this[int i]=>Value[i];

public static A065149Inst Instance=new A065149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065150
{
public static readonly long[] Value={ 1L,12L,15L,35L,56L,78L,95L,140L,143L,172L,190L,248L,264L,287L,315L,319L,323L,357L,418L,477L,588L,594L,675L,812L,814L,840L,899L,910L,1045L,1107L,1118L,1131L,1199L,1208L,1254L,1349L,1420L,1425L,1485L,1495L,1558L,1608L,1672L,1763L,2214L,2261L,2318L,2337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065150Inst : IEnumerable<long>
{
public static readonly long[] Value=A065150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065150.Bytes);
public long this[int i]=>Value[i];

public static A065150Inst Instance=new A065150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065151
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,2L,3L,5L,7L,2L,3L,2L,3L,5L,7L,2L,3L,2L,3L,5L,7L,2L,3L,5L,7L,11L,13L,2L,3L,2L,3L,5L,7L,11L,13L,2L,3L,5L,7L,2L,3L,2L,3L,5L,7L,2L,3L,5L,7L,11L,13L,2L,3L,5L,7L,11L,13L,2L,3L,2L,3L,5L,7L,11L,13L,2L,3L,5L,7L,2L,3L,2L,3L,5L,7L,11L,13L,2L,3L,5L,7L,2L,3L,5L,7L,11L,13L,2L,3L,5L,7L,11L,13L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065151Inst : IEnumerable<long>
{
public static readonly long[] Value=A065151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065151.Bytes);
public long this[int i]=>Value[i];

public static A065151Inst Instance=new A065151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065152
{
public static readonly long[] Value={ 0L,-1L,0L,0L,1L,-1L,3L,0L,2L,0L,5L,-2L,7L,0L,-2L,0L,7L,0L,11L,0L,2L,2L,11L,-4L,8L,2L,6L,0L,15L,-6L,21L,0L,0L,2L,6L,0L,23L,4L,8L,0L,23L,0L,29L,4L,4L,4L,23L,-8L,24L,4L,-2L,4L,27L,0L,16L,0L,12L,8L,29L,-12L,43L,6L,6L,0L,16L,-10L,45L,4L,4L,-6L,45L,0L,47L,6L,0L,8L,28L,-2L,53L,0L,18L,12L,41L,0L,20L,10L,2L,8L,47L,-4L,30L,8L,24L,8L,26L,-16L,63L,6L,20L,8L,59L,-8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065152Inst : IEnumerable<long>
{
public static readonly long[] Value=A065152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065152.Bytes);
public long this[int i]=>Value[i];

public static A065152Inst Instance=new A065152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065153
{
public static readonly long[] Value={ 1L,3L,4L,8L,10L,14L,16L,18L,20L,28L,32L,33L,36L,40L,42L,54L,56L,64L,72L,75L,80L,84L,108L,110L,112L,114L,126L,128L,144L,160L,162L,168L,177L,198L,216L,220L,224L,228L,252L,256L,288L,320L,321L,324L,336L,342L,350L,375L,378L,396L,414L,432L,440L,448L,456L,486L,504L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065153Inst : IEnumerable<long>
{
public static readonly long[] Value=A065153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065153.Bytes);
public long this[int i]=>Value[i];

public static A065153Inst Instance=new A065153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065154
{
public static readonly long[] Value={ 2L,6L,12L,15L,24L,30L,48L,51L,60L,66L,70L,78L,90L,96L,102L,105L,120L,130L,132L,138L,140L,150L,154L,156L,165L,170L,174L,180L,190L,192L,204L,210L,230L,234L,238L,240L,246L,255L,260L,264L,266L,270L,276L,280L,282L,290L,300L,308L,312L,315L,318L,330L,340L,345L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065154Inst : IEnumerable<long>
{
public static readonly long[] Value=A065154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065154.Bytes);
public long this[int i]=>Value[i];

public static A065154Inst Instance=new A065154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065155
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,34L,35L,37L,38L,39L,41L,43L,44L,45L,46L,47L,49L,50L,52L,53L,55L,57L,58L,59L,61L,62L,63L,65L,67L,68L,69L,71L,73L,74L,76L,77L,79L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L,103L,104L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065155Inst : IEnumerable<long>
{
public static readonly long[] Value=A065155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065155.Bytes);
public long this[int i]=>Value[i];

public static A065155Inst Instance=new A065155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065156
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,11L,14L,18L,19L,22L,23L,27L,29L,31L,38L,41L,43L,44L,46L,47L,49L,54L,58L,59L,62L,67L,71L,76L,79L,81L,82L,83L,86L,94L,98L,101L,103L,107L,116L,118L,121L,123L,124L,127L,129L,131L,134L,139L,142L,151L,158L,161L,162L,163L,166L,167L,179L,181L,191L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065156Inst : IEnumerable<long>
{
public static readonly long[] Value=A065156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065156.Bytes);
public long this[int i]=>Value[i];

public static A065156Inst Instance=new A065156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065157
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,4L,6L,10L,4L,5L,8L,15L,8L,5L,6L,10L,36L,12L,18L,6L,7L,12L,45L,16L,27L,20L,7L,8L,14L,54L,20L,68L,30L,42L,8L,9L,16L,63L,24L,85L,72L,63L,16L,9L,10L,18L,136L,28L,102L,90L,292L,24L,34L,10L,11L,20L,153L,32L,119L,108L,365L,32L,51L,36L,11L,12L,22L,170L,36L,264L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065157Inst : IEnumerable<long>
{
public static readonly long[] Value=A065157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065157.Bytes);
public long this[int i]=>Value[i];

public static A065157Inst Instance=new A065157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065158
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,5L,4L,1L,2L,5L,4L,5L,1L,2L,9L,4L,9L,6L,1L,2L,9L,4L,9L,10L,7L,1L,2L,9L,4L,17L,10L,21L,8L,1L,2L,9L,4L,17L,18L,21L,8L,9L,1L,2L,17L,4L,17L,18L,73L,8L,17L,10L,1L,2L,17L,4L,17L,18L,73L,8L,17L,18L,11L,1L,2L,17L,4L,33L,18L,73L,8L,33L,18L,37L,12L,1L,2L,17L,4L,33L,34L,73L,8L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065158Inst : IEnumerable<long>
{
public static readonly long[] Value=A065158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065158.Bytes);
public long this[int i]=>Value[i];

public static A065158Inst Instance=new A065158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065159
{
public static readonly long[] Value={ 0L,1L,4L,15L,16L,85L,108L,511L,64L,585L,660L,5819L,816L,7085L,7644L,65535L,256L,4369L,4644L,78451L,5200L,87381L,91564L,1531639L,6336L,105625L,109876L,1825659L,118384L,1961821L,2029500L,33554431L,1024L,33825L,34884L,1149155L,37008L,1217189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065159Inst : IEnumerable<long>
{
public static readonly long[] Value=A065159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065159.Bytes);
public long this[int i]=>Value[i];

public static A065159Inst Instance=new A065159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065160
{
public static readonly long[] Value={ 1L,2L,5L,4L,17L,18L,73L,8L,65L,66L,529L,68L,545L,546L,4369L,16L,257L,258L,4129L,260L,4161L,4162L,66593L,264L,4225L,4226L,67617L,4228L,67649L,67650L,1082401L,32L,1025L,1026L,32833L,1028L,32897L,32898L,1052737L,1032L,33025L,33026L,1056833L,33028L,1056897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065160Inst : IEnumerable<long>
{
public static readonly long[] Value=A065160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065160.Bytes);
public long this[int i]=>Value[i];

public static A065160Inst Instance=new A065160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065161
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,60L,138L,336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065161Inst : IEnumerable<long>
{
public static readonly long[] Value=A065161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065161.Bytes);
public long this[int i]=>Value[i];

public static A065161Inst Instance=new A065161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065162
{
public static readonly BigInteger[] Value={ 1L,1L,3L,84L,392700L,134303400L,144049802170012200L,BigInteger.Parse("20408430429061596071366416200") };
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
public class A065162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065162Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A065162.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065162Inst Instance=new A065162Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065163
{
public static readonly long[] Value={ 1L,1L,3L,7L,25L,216L,963L,23435L,92225L,2729205L,17313348L,182553725L,4235194171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065163Inst : IEnumerable<long>
{
public static readonly long[] Value=A065163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065163.Bytes);
public long this[int i]=>Value[i];

public static A065163Inst Instance=new A065163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065164
{
public static readonly long[] Value={ 2L,4L,1L,6L,3L,8L,5L,10L,7L,12L,9L,14L,11L,16L,13L,18L,15L,20L,17L,22L,19L,24L,21L,26L,23L,28L,25L,30L,27L,32L,29L,34L,31L,36L,33L,38L,35L,40L,37L,42L,39L,44L,41L,46L,43L,48L,45L,50L,47L,52L,49L,54L,51L,56L,53L,58L,55L,60L,57L,62L,59L,64L,61L,66L,63L,68L,65L,70L,67L,72L,69L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065164Inst : IEnumerable<long>
{
public static readonly long[] Value=A065164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065164.Bytes);
public long this[int i]=>Value[i];

public static A065164Inst Instance=new A065164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065165
{
public static readonly long[] Value={ 4L,6L,2L,8L,1L,10L,3L,12L,5L,14L,7L,16L,9L,18L,11L,20L,13L,22L,15L,24L,17L,26L,19L,28L,21L,30L,23L,32L,25L,34L,27L,36L,29L,38L,31L,40L,33L,42L,35L,44L,37L,46L,39L,48L,41L,50L,43L,52L,45L,54L,47L,56L,49L,58L,51L,60L,53L,62L,55L,64L,57L,66L,59L,68L,61L,70L,63L,72L,65L,74L,67L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065165Inst : IEnumerable<long>
{
public static readonly long[] Value=A065165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065165.Bytes);
public long this[int i]=>Value[i];

public static A065165Inst Instance=new A065165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065166
{
public static readonly long[] Value={ 6L,8L,4L,10L,2L,12L,1L,14L,3L,16L,5L,18L,7L,20L,9L,22L,11L,24L,13L,26L,15L,28L,17L,30L,19L,32L,21L,34L,23L,36L,25L,38L,27L,40L,29L,42L,31L,44L,33L,46L,35L,48L,37L,50L,39L,52L,41L,54L,43L,56L,45L,58L,47L,60L,49L,62L,51L,64L,53L,66L,55L,68L,57L,70L,59L,72L,61L,74L,63L,76L,65L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065166Inst : IEnumerable<long>
{
public static readonly long[] Value=A065166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065166.Bytes);
public long this[int i]=>Value[i];

public static A065166Inst Instance=new A065166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065167
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,4L,1L,6L,6L,5L,6L,2L,8L,8L,6L,3L,8L,4L,10L,10L,7L,8L,1L,10L,6L,12L,12L,8L,5L,10L,2L,12L,8L,14L,14L,9L,10L,3L,12L,4L,14L,10L,16L,16L,10L,7L,12L,1L,14L,6L,16L,12L,18L,18L,11L,12L,5L,14L,2L,16L,8L,18L,14L,20L,20L,12L,9L,14L,3L,16L,4L,18L,10L,20L,16L,22L,22L,13L,14L,7L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065167Inst : IEnumerable<long>
{
public static readonly long[] Value=A065167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065167.Bytes);
public long this[int i]=>Value[i];

public static A065167Inst Instance=new A065167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065168
{
public static readonly long[] Value={ 3L,1L,5L,2L,7L,4L,9L,6L,11L,8L,13L,10L,15L,12L,17L,14L,19L,16L,21L,18L,23L,20L,25L,22L,27L,24L,29L,26L,31L,28L,33L,30L,35L,32L,37L,34L,39L,36L,41L,38L,43L,40L,45L,42L,47L,44L,49L,46L,51L,48L,53L,50L,55L,52L,57L,54L,59L,56L,61L,58L,63L,60L,65L,62L,67L,64L,69L,66L,71L,68L,73L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065168Inst : IEnumerable<long>
{
public static readonly long[] Value=A065168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065168.Bytes);
public long this[int i]=>Value[i];

public static A065168Inst Instance=new A065168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065169
{
public static readonly long[] Value={ 5L,3L,7L,1L,9L,2L,11L,4L,13L,6L,15L,8L,17L,10L,19L,12L,21L,14L,23L,16L,25L,18L,27L,20L,29L,22L,31L,24L,33L,26L,35L,28L,37L,30L,39L,32L,41L,34L,43L,36L,45L,38L,47L,40L,49L,42L,51L,44L,53L,46L,55L,48L,57L,50L,59L,52L,61L,54L,63L,56L,65L,58L,67L,60L,69L,62L,71L,64L,73L,66L,75L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065169Inst : IEnumerable<long>
{
public static readonly long[] Value=A065169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065169.Bytes);
public long this[int i]=>Value[i];

public static A065169Inst Instance=new A065169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065170
{
public static readonly long[] Value={ 7L,5L,9L,3L,11L,1L,13L,2L,15L,4L,17L,6L,19L,8L,21L,10L,23L,12L,25L,14L,27L,16L,29L,18L,31L,20L,33L,22L,35L,24L,37L,26L,39L,28L,41L,30L,43L,32L,45L,34L,47L,36L,49L,38L,51L,40L,53L,42L,55L,44L,57L,46L,59L,48L,61L,50L,63L,52L,65L,54L,67L,56L,69L,58L,71L,60L,73L,62L,75L,64L,77L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065170Inst : IEnumerable<long>
{
public static readonly long[] Value=A065170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065170.Bytes);
public long this[int i]=>Value[i];

public static A065170Inst Instance=new A065170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065171
{
public static readonly long[] Value={ 1L,4L,2L,8L,3L,12L,6L,16L,5L,20L,10L,24L,7L,28L,14L,32L,9L,36L,18L,40L,11L,44L,22L,48L,13L,52L,26L,56L,15L,60L,30L,64L,17L,68L,34L,72L,19L,76L,38L,80L,21L,84L,42L,88L,23L,92L,46L,96L,25L,100L,50L,104L,27L,108L,54L,112L,29L,116L,58L,120L,31L,124L,62L,128L,33L,132L,66L,136L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065171Inst : IEnumerable<long>
{
public static readonly long[] Value=A065171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065171.Bytes);
public long this[int i]=>Value[i];

public static A065171Inst Instance=new A065171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065172
{
public static readonly long[] Value={ 1L,3L,5L,2L,9L,7L,13L,4L,17L,11L,21L,6L,25L,15L,29L,8L,33L,19L,37L,10L,41L,23L,45L,12L,49L,27L,53L,14L,57L,31L,61L,16L,65L,35L,69L,18L,73L,39L,77L,20L,81L,43L,85L,22L,89L,47L,93L,24L,97L,51L,101L,26L,105L,55L,109L,28L,113L,59L,117L,30L,121L,63L,125L,32L,129L,67L,133L,34L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065172Inst : IEnumerable<long>
{
public static readonly long[] Value=A065172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065172.Bytes);
public long this[int i]=>Value[i];

public static A065172Inst Instance=new A065172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065173
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,3L,6L,4L,2L,5L,10L,6L,3L,7L,14L,8L,4L,9L,18L,10L,5L,11L,22L,12L,6L,13L,26L,14L,7L,15L,30L,16L,8L,17L,34L,18L,9L,19L,38L,20L,10L,21L,42L,22L,11L,23L,46L,24L,12L,25L,50L,26L,13L,27L,54L,28L,14L,29L,58L,30L,15L,31L,62L,32L,16L,33L,66L,34L,17L,35L,70L,36L,18L,37L,74L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065173Inst : IEnumerable<long>
{
public static readonly long[] Value=A065173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065173.Bytes);
public long this[int i]=>Value[i];

public static A065173Inst Instance=new A065173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065174
{
public static readonly long[] Value={ 1L,6L,2L,12L,4L,10L,3L,24L,8L,14L,7L,20L,5L,18L,11L,48L,16L,22L,15L,28L,13L,26L,19L,40L,9L,30L,23L,36L,21L,34L,27L,96L,32L,38L,31L,44L,29L,42L,35L,56L,25L,46L,39L,52L,37L,50L,43L,80L,17L,54L,47L,60L,45L,58L,51L,72L,41L,62L,55L,68L,53L,66L,59L,192L,64L,70L,63L,76L,61L,74L,67L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065174Inst : IEnumerable<long>
{
public static readonly long[] Value=A065174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065174.Bytes);
public long this[int i]=>Value[i];

public static A065174Inst Instance=new A065174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065175
{
public static readonly long[] Value={ 1L,3L,7L,5L,13L,2L,11L,9L,25L,6L,15L,4L,21L,10L,19L,17L,49L,14L,23L,12L,29L,18L,27L,8L,41L,22L,31L,20L,37L,26L,35L,33L,97L,30L,39L,28L,45L,34L,43L,24L,57L,38L,47L,36L,53L,42L,51L,16L,81L,46L,55L,44L,61L,50L,59L,40L,73L,54L,63L,52L,69L,58L,67L,65L,193L,62L,71L,60L,77L,66L,75L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065175Inst : IEnumerable<long>
{
public static readonly long[] Value=A065175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065175.Bytes);
public long this[int i]=>Value[i];

public static A065175Inst Instance=new A065175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065176
{
public static readonly long[] Value={ 0L,2L,2L,4L,4L,2L,2L,8L,8L,2L,2L,4L,4L,2L,2L,16L,16L,2L,2L,4L,4L,2L,2L,8L,8L,2L,2L,4L,4L,2L,2L,32L,32L,2L,2L,4L,4L,2L,2L,8L,8L,2L,2L,4L,4L,2L,2L,16L,16L,2L,2L,4L,4L,2L,2L,8L,8L,2L,2L,4L,4L,2L,2L,64L,64L,2L,2L,4L,4L,2L,2L,8L,8L,2L,2L,4L,4L,2L,2L,16L,16L,2L,2L,4L,4L,2L,2L,8L,8L,2L,2L,4L,4L,2L,2L,32L,32L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065176Inst : IEnumerable<long>
{
public static readonly long[] Value=A065176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065176.Bytes);
public long this[int i]=>Value[i];

public static A065176Inst Instance=new A065176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065177
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,3L,6L,3L,1L,0L,6L,15L,12L,4L,1L,0L,9L,42L,42L,20L,5L,1L,0L,18L,107L,156L,90L,30L,6L,1L,0L,30L,294L,554L,420L,165L,42L,7L,1L,0L,56L,780L,2028L,1910L,930L,273L,56L,8L,1L,0L,99L,2128L,7350L,8820L,5155L,1806L,420L,72L,9L,1L,0L,186L,5781L,26936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065177Inst : IEnumerable<long>
{
public static readonly long[] Value=A065177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065177.Bytes);
public long this[int i]=>Value[i];

public static A065177Inst Instance=new A065177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065178
{
public static readonly long[] Value={ 1L,2L,6L,15L,42L,107L,294L,780L,2128L,5781L,15918L,43885L,122010L,340323L,954394L,2685930L,7588770L,21507696L,61144062L,174283887L,498012094L,1426213191L,4092816966L,11767176070L,33890202192L,97761428205L,282424564744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065178Inst : IEnumerable<long>
{
public static readonly long[] Value=A065178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065178.Bytes);
public long this[int i]=>Value[i];

public static A065178Inst Instance=new A065178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065179
{
public static readonly long[] Value={ 1L,3L,12L,42L,156L,554L,2028L,7350L,26936L,98874L,365196L,1353520L,5039580L,18831306L,70626140L,265741350L,1002984060L,3796211692L,14406086604L,54801192684L,208932673508L,798218225802L,3055417434732L,11716355452900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065179Inst : IEnumerable<long>
{
public static readonly long[] Value=A065179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065179.Bytes);
public long this[int i]=>Value[i];

public static A065179Inst Instance=new A065179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065180
{
public static readonly long[] Value={ 1L,4L,20L,90L,420L,1910L,8820L,40590L,187880L,871494L,4057620L,18945960L,88738020L,416787030L,1962922276L,9268287390L,43868210820L,208109782580L,989400443220L,4713395564772L,22497100553820L,107572434560790L,515241748300020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065180Inst : IEnumerable<long>
{
public static readonly long[] Value=A065180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065180.Bytes);
public long this[int i]=>Value[i];

public static A065180Inst Instance=new A065180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065181
{
public static readonly long[] Value={ 0L,1L,2L,5L,3L,4L,6L,7L,14L,23L,17L,20L,8L,11L,12L,22L,13L,21L,9L,10L,16L,18L,15L,19L,24L,25L,26L,29L,27L,28L,54L,55L,86L,119L,95L,110L,62L,71L,78L,116L,79L,113L,65L,68L,92L,102L,89L,103L,30L,31L,38L,47L,41L,44L,48L,49L,84L,118L,94L,108L,50L,53L,80L,117L,83L,109L,51L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065181Inst : IEnumerable<long>
{
public static readonly long[] Value=A065181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065181.Bytes);
public long this[int i]=>Value[i];

public static A065181Inst Instance=new A065181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065182
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,3L,6L,7L,12L,18L,19L,13L,14L,16L,8L,22L,20L,10L,21L,23L,11L,17L,15L,9L,24L,25L,26L,28L,29L,27L,48L,49L,72L,96L,97L,73L,74L,76L,50L,100L,98L,52L,99L,101L,53L,77L,75L,51L,54L,55L,60L,66L,67L,61L,30L,31L,84L,108L,109L,85L,78L,91L,36L,115L,102L,42L,103L,114L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065182Inst : IEnumerable<long>
{
public static readonly long[] Value=A065182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065182.Bytes);
public long this[int i]=>Value[i];

public static A065182Inst Instance=new A065182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065183
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,3L,6L,7L,12L,20L,19L,17L,14L,21L,8L,10L,15L,18L,23L,16L,22L,13L,11L,9L,24L,25L,26L,28L,29L,27L,48L,49L,78L,108L,103L,91L,74L,111L,62L,69L,75L,104L,101L,94L,100L,83L,71L,64L,54L,55L,80L,109L,107L,90L,30L,31L,36L,44L,43L,41L,56L,58L,72L,110L,106L,77L,59L,57L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065183Inst : IEnumerable<long>
{
public static readonly long[] Value=A065183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065183.Bytes);
public long this[int i]=>Value[i];

public static A065183Inst Instance=new A065183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065184
{
public static readonly long[] Value={ 0L,1L,2L,5L,3L,4L,6L,7L,14L,23L,15L,22L,8L,21L,12L,16L,19L,11L,17L,10L,9L,13L,20L,18L,24L,25L,26L,29L,27L,28L,54L,55L,86L,119L,87L,118L,56L,117L,84L,88L,115L,59L,89L,58L,57L,85L,116L,114L,30L,31L,80L,107L,81L,106L,48L,49L,60L,67L,61L,66L,74L,92L,38L,113L,47L,101L,112L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065184Inst : IEnumerable<long>
{
public static readonly long[] Value=A065184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065184.Bytes);
public long this[int i]=>Value[i];

public static A065184Inst Instance=new A065184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065185
{
public static readonly long[] Value={ 0L,1L,2L,-2L,-1L,3L,4L,5L,6L,-4L,-3L,7L,-6L,8L,-5L,9L,10L,11L,12L,-8L,-7L,13L,14L,15L,16L,-10L,-9L,17L,-12L,18L,-11L,19L,20L,-13L,21L,22L,23L,-15L,24L,-16L,25L,-14L,-17L,26L,27L,28L,29L,30L,-19L,-18L,31L,32L,33L,-21L,34L,-22L,35L,-20L,-23L,36L,37L,38L,39L,-24L,40L,41L,-25L,42L,-26L,43L,-27L,44L,45L,46L,-29L,47L,-30L,-28L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065185Inst : IEnumerable<long>
{
public static readonly long[] Value=A065185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065185.Bytes);
public long this[int i]=>Value[i];

public static A065185Inst Instance=new A065185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065186
{
public static readonly long[] Value={ 1L,3L,5L,2L,4L,6L,8L,10L,7L,9L,11L,13L,15L,12L,14L,16L,18L,20L,17L,19L,21L,23L,25L,22L,24L,26L,28L,30L,27L,29L,31L,33L,35L,32L,34L,36L,38L,40L,37L,39L,41L,43L,45L,42L,44L,46L,48L,50L,47L,49L,51L,53L,55L,52L,54L,56L,58L,60L,57L,59L,61L,63L,65L,62L,64L,66L,68L,70L,67L,69L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065186Inst : IEnumerable<long>
{
public static readonly long[] Value=A065186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065186.Bytes);
public long this[int i]=>Value[i];

public static A065186Inst Instance=new A065186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065187
{
public static readonly long[] Value={ 1L,4L,2L,5L,3L,6L,9L,7L,10L,8L,11L,14L,12L,15L,13L,16L,19L,17L,20L,18L,21L,24L,22L,25L,23L,26L,29L,27L,30L,28L,31L,34L,32L,35L,33L,36L,39L,37L,40L,38L,41L,44L,42L,45L,43L,46L,49L,47L,50L,48L,51L,54L,52L,55L,53L,56L,59L,57L,60L,58L,61L,64L,62L,65L,63L,66L,69L,67L,70L,68L,71L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065187Inst : IEnumerable<long>
{
public static readonly long[] Value=A065187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065187.Bytes);
public long this[int i]=>Value[i];

public static A065187Inst Instance=new A065187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065188
{
public static readonly long[] Value={ 1L,3L,5L,2L,4L,9L,11L,13L,15L,6L,8L,19L,7L,22L,10L,25L,27L,29L,31L,12L,14L,35L,37L,39L,41L,16L,18L,45L,17L,48L,20L,51L,53L,21L,56L,58L,60L,23L,63L,24L,66L,28L,26L,70L,72L,74L,76L,78L,30L,32L,82L,84L,86L,33L,89L,34L,92L,38L,36L,96L,98L,100L,102L,40L,105L,107L,42L,110L,43L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065188Inst : IEnumerable<long>
{
public static readonly long[] Value=A065188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065188.Bytes);
public long this[int i]=>Value[i];

public static A065188Inst Instance=new A065188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065189
{
public static readonly long[] Value={ 1L,4L,2L,5L,3L,10L,13L,11L,6L,15L,7L,20L,8L,21L,9L,26L,29L,27L,12L,31L,34L,14L,38L,40L,16L,43L,17L,42L,18L,49L,19L,50L,54L,56L,22L,59L,23L,58L,24L,64L,25L,67L,69L,71L,28L,75L,77L,30L,80L,78L,32L,85L,33L,86L,90L,35L,91L,36L,95L,37L,99L,101L,39L,104L,102L,41L,108L,111L,113L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065189Inst : IEnumerable<long>
{
public static readonly long[] Value=A065189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065189.Bytes);
public long this[int i]=>Value[i];

public static A065189Inst Instance=new A065189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065190
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,7L,6L,9L,8L,11L,10L,13L,12L,15L,14L,17L,16L,19L,18L,21L,20L,23L,22L,25L,24L,27L,26L,29L,28L,31L,30L,33L,32L,35L,34L,37L,36L,39L,38L,41L,40L,43L,42L,45L,44L,47L,46L,49L,48L,51L,50L,53L,52L,55L,54L,57L,56L,59L,58L,61L,60L,63L,62L,65L,64L,67L,66L,69L,68L,71L,70L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065190Inst : IEnumerable<long>
{
public static readonly long[] Value=A065190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065190.Bytes);
public long this[int i]=>Value[i];

public static A065190Inst Instance=new A065190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065191
{
public static readonly long[] Value={ 1L,4L,8L,3L,5L,16L,18L,19L,11L,2L,40L,13L,15L,10L,24L,29L,37L,50L,12L,9L,63L,28L,66L,7L,33L,60L,22L,31L,35L,44L,26L,45L,57L,80L,6L,47L,109L,128L,14L,39L,155L,64L,48L,49L,25L,32L,106L,227L,53L,82L,150L,139L,143L,58L,78L,169L,147L,198L,70L,23L,131L,88L,156L,75L,103L,166L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065191Inst : IEnumerable<long>
{
public static readonly long[] Value=A065191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065191.Bytes);
public long this[int i]=>Value[i];

public static A065191Inst Instance=new A065191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065192
{
public static readonly long[] Value={ 1L,4L,8L,16L,18L,19L,40L,50L,63L,66L,80L,109L,128L,155L,227L,282L,297L,373L,460L,508L,561L,644L,691L,810L,930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065192Inst : IEnumerable<long>
{
public static readonly long[] Value=A065192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065192.Bytes);
public long this[int i]=>Value[i];

public static A065192Inst Instance=new A065192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065193
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,11L,18L,21L,23L,34L,37L,38L,41L,48L,71L,92L,93L,98L,143L,153L,162L,173L,186L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065193Inst : IEnumerable<long>
{
public static readonly long[] Value=A065193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065193.Bytes);
public long this[int i]=>Value[i];

public static A065193Inst Instance=new A065193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065194
{
public static readonly long[] Value={ 1L,10L,4L,2L,5L,35L,24L,3L,20L,14L,9L,19L,12L,39L,13L,6L,104L,7L,8L,79L,145L,27L,60L,15L,45L,31L,144L,22L,16L,4339L,28L,46L,25L,70L,29L,479L,17L,2170L,40L,11L,325L,114L,85L,30L,32L,75L,36L,43L,44L,18L,300L,235L,49L,135L,704L,214L,33L,54L,9160L,26L,80L,91L,21L,42L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065194Inst : IEnumerable<long>
{
public static readonly long[] Value=A065194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065194.Bytes);
public long this[int i]=>Value[i];

public static A065194Inst Instance=new A065194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065195
{
public static readonly long[] Value={ 1L,10L,35L,39L,104L,145L,4339L,9160L,11170L,12829L,65104L,87604L,496770L,653645L,830410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065195Inst : IEnumerable<long>
{
public static readonly long[] Value=A065195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065195.Bytes);
public long this[int i]=>Value[i];

public static A065195Inst Instance=new A065195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065196
{
public static readonly long[] Value={ 1L,2L,6L,14L,17L,21L,30L,59L,140L,239L,259L,419L,470L,633L,782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065196Inst : IEnumerable<long>
{
public static readonly long[] Value=A065196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065196.Bytes);
public long this[int i]=>Value[i];

public static A065196Inst Instance=new A065196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065197
{
public static readonly long[] Value={ 1L,5L,90L,117L,154L,446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065197Inst : IEnumerable<long>
{
public static readonly long[] Value=A065197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065197.Bytes);
public long this[int i]=>Value[i];

public static A065197Inst Instance=new A065197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065198
{
public static readonly long[] Value={ 0L,10L,19L,59L,69L,79L,89L,10548L,10677L,10833L,10911L,147996L,150296L,1000689L,1005744L,1007601L,7008899L,9008299L,100239862L,140669390L,1005499526L,10000442119L,10000761554L,10000853648L,10000973037L,10031199494L,10087799570L,1000006412206L,1090604591930L,1600005969190L,100000090745299L,100120849299260L,10000043099946481L,10078083499399210L,10442000392399960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065198Inst : IEnumerable<long>
{
public static readonly long[] Value=A065198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065198.Bytes);
public long this[int i]=>Value[i];

public static A065198Inst Instance=new A065198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065199
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,24L,30L,53L,54L,55L,58L,64L,78L,79L,80L,82L,96L,97L,98L,109L,112L,113L,131L,135L,147L,149L,186L,187L,188L,198L,201L,232L,233L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065199Inst : IEnumerable<long>
{
public static readonly long[] Value=A065199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065199.Bytes);
public long this[int i]=>Value[i];

public static A065199Inst Instance=new A065199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065200
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,46L,47L,49L,50L,51L,53L,54L,55L,57L,58L,59L,61L,62L,64L,65L,66L,67L,69L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,91L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065200Inst : IEnumerable<long>
{
public static readonly long[] Value=A065200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065200.Bytes);
public long this[int i]=>Value[i];

public static A065200Inst Instance=new A065200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065201
{
public static readonly long[] Value={ 12L,20L,24L,28L,36L,40L,44L,45L,48L,52L,56L,60L,63L,68L,72L,76L,80L,84L,88L,90L,92L,96L,99L,100L,104L,108L,112L,116L,117L,120L,124L,126L,132L,135L,136L,140L,144L,148L,152L,153L,156L,160L,164L,168L,171L,172L,175L,176L,180L,184L,188L,189L,192L,196L,198L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065201Inst : IEnumerable<long>
{
public static readonly long[] Value=A065201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065201.Bytes);
public long this[int i]=>Value[i];

public static A065201Inst Instance=new A065201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065202
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065202Inst : IEnumerable<long>
{
public static readonly long[] Value=A065202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065202.Bytes);
public long this[int i]=>Value[i];

public static A065202Inst Instance=new A065202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065203
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,2L,3L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,3L,2L,2L,2L,1L,2L,1L,3L,2L,2L,2L,1L,2L,3L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,1L,2L,3L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065203Inst : IEnumerable<long>
{
public static readonly long[] Value=A065203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065203.Bytes);
public long this[int i]=>Value[i];

public static A065203Inst Instance=new A065203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065204
{
public static readonly long[] Value={ 1L,3L,22L,191L,2206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065204Inst : IEnumerable<long>
{
public static readonly long[] Value=A065204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065204.Bytes);
public long this[int i]=>Value[i];

public static A065204Inst Instance=new A065204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065205
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,1L,0L,0L,0L,5L,0L,0L,0L,1L,0L,3L,0L,0L,0L,0L,0L,7L,0L,0L,0L,3L,0L,2L,0L,0L,0L,0L,0L,10L,0L,0L,0L,0L,0L,3L,0L,2L,0L,0L,0L,34L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,31L,0L,0L,0L,0L,0L,1L,0L,6L,0L,0L,0L,25L,0L,0L,0L,1L,0L,23L,0L,0L,0L,0L,0L,21L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065205Inst : IEnumerable<long>
{
public static readonly long[] Value=A065205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065205.Bytes);
public long this[int i]=>Value[i];

public static A065205Inst Instance=new A065205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065206
{
public static readonly long[] Value={ 10L,12L,13L,14L,15L,16L,17L,18L,20L,21L,23L,24L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,38L,40L,41L,42L,43L,45L,47L,50L,51L,52L,53L,54L,56L,60L,61L,62L,63L,65L,70L,71L,72L,74L,80L,81L,83L,90L,92L,100L,102L,103L,104L,105L,106L,107L,108L,110L,112L,113L,114L,115L,116L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065206Inst : IEnumerable<long>
{
public static readonly long[] Value=A065206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065206.Bytes);
public long this[int i]=>Value[i];

public static A065206Inst Instance=new A065206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065207
{
public static readonly long[] Value={ 19L,28L,37L,39L,46L,48L,49L,57L,58L,64L,67L,73L,75L,76L,82L,84L,85L,91L,93L,94L,109L,119L,129L,139L,149L,150L,152L,153L,154L,159L,160L,162L,163L,169L,170L,172L,173L,179L,189L,208L,218L,219L,228L,229L,238L,239L,248L,250L,251L,253L,258L,259L,260L,261L,268L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065207Inst : IEnumerable<long>
{
public static readonly long[] Value=A065207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065207.Bytes);
public long this[int i]=>Value[i];

public static A065207Inst Instance=new A065207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065208
{
public static readonly long[] Value={ 59L,68L,86L,95L,155L,156L,157L,158L,164L,165L,168L,178L,180L,184L,185L,186L,194L,199L,249L,254L,255L,256L,257L,263L,264L,267L,277L,283L,284L,285L,293L,298L,299L,348L,349L,354L,355L,356L,362L,366L,376L,382L,384L,389L,392L,397L,398L,399L,439L,447L,448L,449L,452L,453L,455L,461L,462L,465L,475L,481L,482L,483L,488L,489L,491L,496L,497L,498L,499L,538L,546L,547L,548L,551L,552L,553L,554L,560L,561L,564L,574L,580L,581L,582L,587L,588L,590L,596L,597L,598L,637L,645L,647L,650L,651L,652L,653L,660L,663L,673L,680L,681L,687L,694L,695L,697L,736L,744L,745L,746L,750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065208Inst : IEnumerable<long>
{
public static readonly long[] Value=A065208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065208.Bytes);
public long this[int i]=>Value[i];

public static A065208Inst Instance=new A065208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065209
{
public static readonly long[] Value={ 69L,78L,87L,96L,174L,175L,183L,192L,195L,273L,274L,280L,290L,291L,294L,372L,381L,390L,471L,472L,480L,492L,539L,570L,571L,579L,591L,599L,629L,638L,649L,670L,678L,679L,690L,698L,699L,728L,729L,748L,749L,769L,778L,789L,798L,819L,827L,836L,839L,847L,876L,877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065209Inst : IEnumerable<long>
{
public static readonly long[] Value=A065209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065209.Bytes);
public long this[int i]=>Value[i];

public static A065209Inst Instance=new A065209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065210
{
public static readonly long[] Value={ 166L,176L,198L,265L,275L,297L,364L,374L,396L,463L,473L,495L,549L,562L,572L,594L,639L,648L,661L,671L,693L,738L,760L,770L,792L,837L,846L,891L,936L,945L,990L,1396L,1486L,1576L,1666L,1697L,1756L,1787L,1791L,1793L,1796L,1846L,1877L,1883L,1886L,1890L,1936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065210Inst : IEnumerable<long>
{
public static readonly long[] Value=A065210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065210.Bytes);
public long this[int i]=>Value[i];

public static A065210Inst Instance=new A065210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065211
{
public static readonly long[] Value={ 79L,97L,182L,281L,380L,779L,799L,889L,977L,988L,997L,1069L,1079L,1159L,1169L,1249L,1259L,1339L,1349L,1429L,1439L,1519L,1529L,1609L,1619L,1699L,1709L,1789L,1799L,1879L,1889L,1896L,1969L,1979L,1986L,2059L,2068L,2078L,2089L,2149L,2158L,2168L,2179L,2239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065211Inst : IEnumerable<long>
{
public static readonly long[] Value=A065211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065211.Bytes);
public long this[int i]=>Value[i];

public static A065211Inst Instance=new A065211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065212
{
public static readonly long[] Value={ 188L,190L,197L,287L,296L,386L,395L,485L,584L,593L,683L,692L,782L,791L,881L,890L,980L,1394L,1484L,1574L,1664L,1754L,1844L,1898L,1934L,1988L,1992L,1994L,1999L,2393L,2483L,2573L,2663L,2753L,2843L,2897L,2933L,2987L,2991L,2993L,2998L,3089L,3179L,3269L,3359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065212Inst : IEnumerable<long>
{
public static readonly long[] Value=A065212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065212.Bytes);
public long this[int i]=>Value[i];

public static A065212Inst Instance=new A065212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065213
{
public static readonly long[] Value={ 193L,391L,490L,589L,688L,886L,985L,1993L,1995L,2994L,3991L,4990L,4992L,5991L,6990L,8059L,8149L,8239L,8329L,8419L,8509L,8599L,8689L,8779L,8869L,8959L,9058L,9069L,9089L,9148L,9159L,9179L,9238L,9249L,9269L,9328L,9359L,9418L,9429L,9508L,9519L,9539L,9598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065213Inst : IEnumerable<long>
{
public static readonly long[] Value=A065213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065213.Bytes);
public long this[int i]=>Value[i];

public static A065213Inst Instance=new A065213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065214
{
public static readonly long[] Value={ 1397L,1487L,1577L,1667L,1757L,1847L,1937L,2396L,2486L,2576L,2666L,2756L,2846L,2936L,2999L,3395L,3485L,3575L,3665L,3755L,3845L,3935L,3998L,4394L,4484L,4574L,4754L,4844L,4934L,4997L,5393L,5483L,5573L,5663L,5753L,5843L,5933L,5996L,6392L,6482L,6572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065214Inst : IEnumerable<long>
{
public static readonly long[] Value=A065214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065214.Bytes);
public long this[int i]=>Value[i];

public static A065214Inst Instance=new A065214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065215
{
public static readonly long[] Value={ 829L,928L,9059L,9149L,9239L,9329L,9419L,9509L,9599L,9689L,9869L,9959L,10634L,10637L,10687L,10716L,10808L,10834L,10838L,10867L,10873L,10898L,10927L,10979L,11398L,11624L,11627L,11677L,11706L,11824L,11828L,11857L,11863L,11888L,11917L,11969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065215Inst : IEnumerable<long>
{
public static readonly long[] Value=A065215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065215.Bytes);
public long this[int i]=>Value[i];

public static A065215Inst Instance=new A065215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065216
{
public static readonly long[] Value={ 167L,266L,365L,563L,662L,761L,860L,7069L,7159L,7249L,7339L,7429L,7519L,7609L,7699L,7789L,7879L,7969L,8068L,8158L,8248L,8428L,8518L,8608L,8698L,8788L,8878L,8968L,9039L,9067L,9129L,9157L,9219L,9247L,9309L,9337L,9399L,9427L,9489L,9517L,9579L,9607L,9697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065216Inst : IEnumerable<long>
{
public static readonly long[] Value=A065216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065216.Bytes);
public long this[int i]=>Value[i];

public static A065216Inst Instance=new A065216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065217
{
public static readonly long[] Value={ 2069L,2159L,2249L,2339L,2429L,2519L,2609L,2699L,2789L,2879L,2969L,3068L,3158L,3248L,3338L,3428L,3518L,3608L,3698L,3788L,3878L,3968L,4067L,4157L,4247L,4337L,4427L,4517L,4607L,4697L,4787L,4877L,4967L,5066L,5156L,5246L,5336L,5426L,5516L,5606L,5696L,5786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065217Inst : IEnumerable<long>
{
public static readonly long[] Value=A065217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065217.Bytes);
public long this[int i]=>Value[i];

public static A065217Inst Instance=new A065217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065218
{
public static readonly long[] Value={ 1L,6L,12L,24L,36L,48L,60L,120L,180L,240L,360L,720L,840L,1260L,1680L,2520L,5040L,7560L,10080L,15120L,20160L,25200L,27720L,45360L,50400L,55440L,83160L,110880L,166320L,221760L,277200L,332640L,498960L,554400L,665280L,720720L,831600L,1081080L,1441440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065218Inst : IEnumerable<long>
{
public static readonly long[] Value=A065218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065218.Bytes);
public long this[int i]=>Value[i];

public static A065218Inst Instance=new A065218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065219
{
public static readonly BigInteger[] Value={ 1L,2L,5L,7L,10L,34L,278L,751L,2157L,22208L,676327L,2225346L,23259536L,265050967L,39161483067L,70455119174849L,776384598617893L,133991542908557129L,BigInteger.Parse("21819590324155207874"),BigInteger.Parse("263763825614848727692"),BigInteger.Parse("12883245190231409112736"),BigInteger.Parse("661394651111310011564685") };
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
public class A065219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A065219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065219Inst Instance=new A065219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065220
{
public static readonly long[] Value={ 0L,0L,-1L,-1L,-1L,0L,2L,6L,13L,25L,45L,78L,132L,220L,363L,595L,971L,1580L,2566L,4162L,6745L,10925L,17689L,28634L,46344L,75000L,121367L,196391L,317783L,514200L,832010L,1346238L,2178277L,3524545L,5702853L,9227430L,14930316L,24157780L,39088131L,63245947L,102334115L,165580100L,267914254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065220Inst : IEnumerable<long>
{
public static readonly long[] Value=A065220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065220.Bytes);
public long this[int i]=>Value[i];

public static A065220Inst Instance=new A065220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065221
{
public static readonly long[] Value={ 1L,2L,5L,4L,9L,3L,10L,18L,5L,15L,26L,3L,16L,30L,45L,10L,27L,45L,64L,14L,35L,57L,80L,12L,37L,63L,90L,1L,30L,60L,91L,123L,11L,45L,80L,116L,153L,15L,54L,94L,135L,177L,10L,54L,99L,145L,192L,240L,42L,92L,143L,195L,248L,15L,70L,126L,183L,241L,300L,30L,91L,153L,216L,280L,345L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065221Inst : IEnumerable<long>
{
public static readonly long[] Value=A065221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065221.Bytes);
public long this[int i]=>Value[i];

public static A065221Inst Instance=new A065221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065222
{
public static readonly long[] Value={ 1L,2L,5L,3L,8L,14L,6L,14L,23L,5L,16L,28L,41L,10L,25L,41L,58L,10L,29L,49L,70L,1L,24L,48L,73L,99L,6L,34L,63L,93L,124L,3L,36L,70L,105L,141L,178L,26L,65L,105L,146L,188L,231L,44L,89L,135L,182L,230L,3L,53L,104L,156L,209L,263L,318L,49L,106L,164L,223L,283L,344L,28L,91L,155L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065222Inst : IEnumerable<long>
{
public static readonly long[] Value=A065222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065222.Bytes);
public long this[int i]=>Value[i];

public static A065222Inst Instance=new A065222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065223
{
public static readonly long[] Value={ 1L,2L,5L,2L,7L,13L,2L,10L,19L,29L,6L,18L,31L,45L,5L,21L,38L,56L,75L,14L,35L,57L,80L,104L,17L,43L,70L,98L,127L,9L,40L,72L,105L,139L,174L,21L,58L,96L,135L,175L,216L,23L,66L,110L,155L,201L,248L,10L,59L,109L,160L,212L,265L,319L,32L,88L,145L,203L,262L,322L,383L,42L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065223Inst : IEnumerable<long>
{
public static readonly long[] Value=A065223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065223.Bytes);
public long this[int i]=>Value[i];

public static A065223Inst Instance=new A065223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065224
{
public static readonly long[] Value={ 1L,2L,5L,1L,6L,12L,19L,6L,15L,25L,36L,8L,21L,35L,50L,1L,18L,36L,55L,75L,96L,22L,45L,69L,94L,120L,14L,42L,71L,101L,132L,164L,21L,55L,90L,126L,163L,201L,15L,55L,96L,138L,181L,225L,270L,36L,83L,131L,180L,230L,281L,333L,45L,99L,154L,210L,267L,325L,384L,36L,97L,159L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065224Inst : IEnumerable<long>
{
public static readonly long[] Value=A065224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065224.Bytes);
public long this[int i]=>Value[i];

public static A065224Inst Instance=new A065224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065225
{
public static readonly long[] Value={ 1L,2L,5L,9L,5L,11L,18L,2L,11L,21L,32L,44L,11L,25L,40L,56L,73L,16L,35L,55L,76L,98L,10L,34L,59L,85L,112L,140L,15L,45L,76L,108L,141L,175L,6L,42L,79L,117L,156L,196L,237L,18L,61L,105L,150L,196L,243L,291L,15L,65L,116L,168L,221L,275L,330L,386L,47L,105L,164L,224L,285L,347L,410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065225Inst : IEnumerable<long>
{
public static readonly long[] Value=A065225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065225.Bytes);
public long this[int i]=>Value[i];

public static A065225Inst Instance=new A065225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065226
{
public static readonly long[] Value={ 1L,2L,5L,9L,4L,10L,17L,25L,7L,17L,28L,40L,1L,15L,30L,46L,63L,81L,15L,35L,56L,78L,101L,125L,24L,50L,77L,105L,134L,164L,20L,52L,85L,119L,154L,190L,227L,33L,72L,112L,153L,195L,238L,282L,30L,76L,123L,171L,220L,270L,321L,3L,56L,110L,165L,221L,278L,336L,395L,4L,65L,127L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065226Inst : IEnumerable<long>
{
public static readonly long[] Value=A065226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065226.Bytes);
public long this[int i]=>Value[i];

public static A065226Inst Instance=new A065226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065227
{
public static readonly long[] Value={ 1L,1L,3L,3L,1L,6L,2L,9L,2L,11L,21L,11L,23L,8L,22L,1L,17L,34L,7L,26L,46L,12L,34L,57L,15L,40L,66L,15L,43L,72L,11L,42L,74L,2L,36L,71L,107L,24L,62L,101L,5L,46L,88L,131L,22L,67L,113L,160L,37L,86L,136L,187L,49L,102L,156L,1L,57L,114L,172L,231L,60L,121L,183L,246L,57L,122L,188L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065227Inst : IEnumerable<long>
{
public static readonly long[] Value=A065227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065227.Bytes);
public long this[int i]=>Value[i];

public static A065227Inst Instance=new A065227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065228
{
public static readonly long[] Value={ 1L,1L,3L,2L,6L,2L,8L,15L,7L,16L,1L,12L,24L,1L,15L,30L,46L,14L,32L,51L,7L,28L,50L,73L,16L,41L,67L,94L,22L,51L,81L,112L,23L,56L,90L,125L,17L,54L,92L,131L,2L,43L,85L,128L,172L,21L,67L,114L,162L,211L,36L,87L,139L,192L,246L,45L,101L,158L,216L,275L,46L,107L,169L,232L,296L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065228Inst : IEnumerable<long>
{
public static readonly long[] Value=A065228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065228.Bytes);
public long this[int i]=>Value[i];

public static A065228Inst Instance=new A065228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065229
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,10L,4L,11L,19L,6L,16L,27L,4L,17L,31L,46L,11L,28L,46L,65L,15L,36L,58L,81L,13L,38L,64L,91L,2L,31L,61L,92L,124L,12L,46L,81L,117L,154L,16L,55L,95L,136L,178L,11L,55L,100L,146L,193L,241L,43L,93L,144L,196L,249L,16L,71L,127L,184L,242L,301L,31L,92L,154L,217L,281L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065229Inst : IEnumerable<long>
{
public static readonly long[] Value=A065229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065229.Bytes);
public long this[int i]=>Value[i];

public static A065229Inst Instance=new A065229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065230
{
public static readonly long[] Value={ 1L,1L,3L,6L,4L,9L,15L,7L,15L,24L,6L,17L,29L,42L,11L,26L,42L,59L,11L,30L,50L,71L,2L,25L,49L,74L,100L,7L,35L,64L,94L,125L,4L,37L,71L,106L,142L,179L,27L,66L,106L,147L,189L,1L,45L,90L,136L,183L,231L,4L,54L,105L,157L,210L,264L,319L,50L,107L,165L,224L,284L,345L,29L,92L,156L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065230Inst : IEnumerable<long>
{
public static readonly long[] Value=A065230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065230.Bytes);
public long this[int i]=>Value[i];

public static A065230Inst Instance=new A065230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065231
{
public static readonly long[] Value={ 1L,1L,3L,6L,3L,8L,14L,3L,11L,20L,30L,7L,19L,32L,46L,6L,22L,39L,57L,76L,15L,36L,58L,81L,105L,18L,44L,71L,99L,128L,10L,41L,73L,106L,140L,175L,22L,59L,97L,136L,176L,217L,24L,67L,111L,156L,202L,249L,11L,60L,110L,161L,213L,266L,320L,33L,89L,146L,204L,263L,323L,384L,43L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065231Inst : IEnumerable<long>
{
public static readonly long[] Value=A065231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065231.Bytes);
public long this[int i]=>Value[i];

public static A065231Inst Instance=new A065231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065232
{
public static readonly long[] Value={ 1L,1L,3L,6L,2L,7L,13L,20L,7L,16L,26L,37L,9L,22L,36L,51L,2L,19L,37L,56L,76L,1L,23L,46L,70L,95L,121L,15L,43L,72L,102L,133L,165L,22L,56L,91L,127L,164L,202L,16L,56L,97L,139L,182L,226L,271L,37L,84L,132L,181L,231L,282L,334L,46L,100L,155L,211L,268L,326L,385L,37L,98L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065232Inst : IEnumerable<long>
{
public static readonly long[] Value=A065232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065232.Bytes);
public long this[int i]=>Value[i];

public static A065232Inst Instance=new A065232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065233
{
public static readonly long[] Value={ 1L,1L,3L,6L,1L,6L,12L,19L,3L,12L,22L,33L,45L,12L,26L,41L,57L,74L,17L,36L,56L,77L,99L,11L,35L,60L,86L,113L,141L,16L,46L,77L,109L,142L,176L,7L,43L,80L,118L,157L,197L,238L,19L,62L,106L,151L,197L,244L,292L,16L,66L,117L,169L,222L,276L,331L,387L,48L,106L,165L,225L,286L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065233Inst : IEnumerable<long>
{
public static readonly long[] Value=A065233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065233.Bytes);
public long this[int i]=>Value[i];

public static A065233Inst Instance=new A065233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065234
{
public static readonly long[] Value={ 1L,1L,3L,6L,10L,5L,11L,18L,26L,8L,18L,29L,41L,2L,16L,31L,47L,64L,82L,16L,36L,57L,79L,102L,126L,25L,51L,78L,106L,135L,165L,21L,53L,86L,120L,155L,191L,228L,34L,73L,113L,154L,196L,239L,283L,31L,77L,124L,172L,221L,271L,322L,4L,57L,111L,166L,222L,279L,337L,396L,5L,66L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065234Inst : IEnumerable<long>
{
public static readonly long[] Value=A065234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065234.Bytes);
public long this[int i]=>Value[i];

public static A065234Inst Instance=new A065234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065235
{
public static readonly long[] Value={ 8925L,32445L,351351L,442365L,159427275L,159587925L,159677175L,159784275L,159837825L,159855675L,159944925L,159962775L,160016325L,160105575L,160266225L,160284075L,160391175L,160444725L,160480425L,160533975L,160551825L,160766025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065235Inst : IEnumerable<long>
{
public static readonly long[] Value=A065235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065235.Bytes);
public long this[int i]=>Value[i];

public static A065235Inst Instance=new A065235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065236
{
public static readonly BigInteger[] Value={ 1L,24L,10080L,15966720L,62270208000L,482718652416000L,6528287055273984000L,BigInteger.Parse("141011000393918054400000"),BigInteger.Parse("4563680016748763912601600000"),BigInteger.Parse("210842016773792892762193920000000") };
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
public class A065236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A065236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065236Inst Instance=new A065236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065237
{
public static readonly long[] Value={ 1L,0L,4L,4L,28L,64L,268L,844L,3100L,10876L,39244L,142432L,518380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065237Inst : IEnumerable<long>
{
public static readonly long[] Value=A065237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065237.Bytes);
public long this[int i]=>Value[i];

public static A065237Inst Instance=new A065237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065238
{
public static readonly long[] Value={ 1L,0L,5L,5L,45L,105L,545L,1825L,7965L,30845L,128945L,527785L,2202785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065238Inst : IEnumerable<long>
{
public static readonly long[] Value=A065238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065238.Bytes);
public long this[int i]=>Value[i];

public static A065238Inst Instance=new A065238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065239
{
public static readonly long[] Value={ 1L,0L,6L,6L,66L,156L,966L,3366L,16986L,70386L,332646L,1484676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065239Inst : IEnumerable<long>
{
public static readonly long[] Value=A065239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065239.Bytes);
public long this[int i]=>Value[i];

public static A065239Inst Instance=new A065239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065240
{
public static readonly long[] Value={ 1L,0L,7L,7L,91L,217L,1561L,5593L,32011L,139363L,732697L,3492265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065240Inst : IEnumerable<long>
{
public static readonly long[] Value=A065240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065240.Bytes);
public long this[int i]=>Value[i];

public static A065240Inst Instance=new A065240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065241
{
public static readonly long[] Value={ 1L,0L,8L,8L,120L,288L,2360L,8632L,55224L,249656L,1443128L,7243552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065241Inst : IEnumerable<long>
{
public static readonly long[] Value=A065241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065241.Bytes);
public long this[int i]=>Value[i];

public static A065241Inst Instance=new A065241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065242
{
public static readonly long[] Value={ 1L,0L,9L,9L,153L,369L,3393L,12609L,89145L,415161L,2614689L,13684977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065242Inst : IEnumerable<long>
{
public static readonly long[] Value=A065242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065242.Bytes);
public long this[int i]=>Value[i];

public static A065242Inst Instance=new A065242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065243
{
public static readonly long[] Value={ 1L,0L,10L,10L,190L,460L,4690L,17650L,136630L,651790L,4439890L,24056020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065243Inst : IEnumerable<long>
{
public static readonly long[] Value=A065243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065243.Bytes);
public long this[int i]=>Value[i];

public static A065243Inst Instance=new A065243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065244
{
public static readonly long[] Value={ 3L,7L,821L,1787L,2111L,3313L,3797L,5527L,6203L,13687L,31397L,40427L,63367L,116797L,137827L,208337L,238967L,247067L,281297L,348553L,723907L,811037L,1048063L,1511017L,1538573L,1771177L,2268317L,3064987L,4298387L,4694923L,5239627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065244Inst : IEnumerable<long>
{
public static readonly long[] Value=A065244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065244.Bytes);
public long this[int i]=>Value[i];

public static A065244Inst Instance=new A065244Inst();

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