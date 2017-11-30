using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A096609
{
public static readonly long[] Value={ 1L,0L,2L,0L,8L,6L,44L,60L,256L,460L,1582L,3360L,10324L,24150L,69652L,172200L,479728L,1225308L,3350972L,8727312L,23638174L,62295420L,167923252L,445808220L,1199180360L,3198756132L,8598547622L,23009417080L,61856381708L,165897510350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096609Inst : IEnumerable<long>
{
public static readonly long[] Value=A096609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096609.Bytes);
public long this[int i]=>Value[i];

public static A096609Inst Instance=new A096609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096610
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,12L,33L,76L,210L,520L,1410L,3590L,9618L,24920L,66521L,174412L,465264L,1229184L,3280458L,8710668L,23271116L,62014876L,165888184L,443255164L,1187255082L,3178905184L,8525398102L,22864654046L,61391533270L,164872981784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096610Inst : IEnumerable<long>
{
public static readonly long[] Value=A096610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096610.Bytes);
public long this[int i]=>Value[i];

public static A096610Inst Instance=new A096610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096611
{
public static readonly long[] Value={ 0L,1L,0L,3L,1L,16L,18L,95L,154L,581L,1160L,3752L,8485L,25208L,61180L,173343L,438242L,1210222L,3134472L,8538629L,22437042L,60690510L,160889234L,433701996L,1156122902L,3112018729L,8325803356L,22402792752L,60084101129L,161701735578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096611Inst : IEnumerable<long>
{
public static readonly long[] Value=A096611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096611.Bytes);
public long this[int i]=>Value[i];

public static A096611Inst Instance=new A096611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096660
{
public static readonly long[] Value={ 223L,593L,811L,6113L,15319L,22123L,22409L,22817L,24859L,32801L,40013L,43853L,47599L,48259L,51329L,56383L,64553L,64579L,77813L,96401L,109169L,109937L,135607L,191899L,229507L,254623L,281609L,379157L,496963L,526963L,530753L,700781L,1090373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096660Inst : IEnumerable<long>
{
public static readonly long[] Value=A096660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096660.Bytes);
public long this[int i]=>Value[i];

public static A096660Inst Instance=new A096660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096661
{
public static readonly long[] Value={ 0L,0L,-1L,1L,-1L,1L,-1L,2L,-1L,0L,-1L,2L,-1L,0L,-1L,1L,-1L,0L,0L,2L,-1L,-1L,-1L,2L,0L,0L,0L,1L,-1L,0L,-1L,2L,-1L,-1L,0L,2L,0L,0L,-2L,1L,-2L,0L,1L,2L,-1L,0L,-2L,2L,0L,0L,-1L,1L,-1L,0L,-1L,3L,-1L,0L,0L,2L,-1L,0L,-2L,0L,-1L,1L,1L,2L,-1L,0L,-3L,2L,0L,0L,0L,1L,-1L,-1L,-1L,2L,-2L,0L,0L,2L,1L,1L,-2L,0L,-1L,0L,0L,1L,-1L,0L,-2L,3L,0L,0L,1L,0L,-1L,0L,-1L,2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096661Inst : IEnumerable<long>
{
public static readonly long[] Value=A096661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096661.Bytes);
public long this[int i]=>Value[i];

public static A096661Inst Instance=new A096661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096662
{
public static readonly BigInteger[] Value={ 3L,6L,21L,231L,26796L,359026206L,64449908476890321L,BigInteger.Parse("2076895351339769460477611370186681"),BigInteger.Parse("2156747150208372213435450937462082366919951682912789656986079991221") };
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
public class A096662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096662Inst Instance=new A096662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096663
{
public static readonly long[] Value={ 1L,-3L,-11L,1L,-137L,61L,-363L,11L,149L,9881L,-83711L,-3391L,-1145993L,1631353L,1821257L,3397L,-42142223L,-1565387L,-275295799L,-20644219L,151619971L,59515289L,-444316699L,-203021927L,374167685L,7248582529L,950047851L,-8741096671L,-9227046511387L,-22795769741183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096663Inst : IEnumerable<long>
{
public static readonly long[] Value=A096663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096663.Bytes);
public long this[int i]=>Value[i];

public static A096663Inst Instance=new A096663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096664
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-55L,-143L,-968167L,-7000033L,-571772647L,-843598411471L,-1263845119891L,-740683182137153L,-474904166544135457L,2379183287545454197L,BigInteger.Parse("237037449673450822122569"),BigInteger.Parse("155015924346163216960553093"),BigInteger.Parse("50568039962561468889366023"),BigInteger.Parse("1801162678607996830733199407999"),BigInteger.Parse("2359789149102567189423591182268559") };
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
public class A096664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096664Inst Instance=new A096664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096665
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,9L,12L,8L,10L,5L,14L,7L,18L,15L,20L,16L,22L,11L,24L,21L,26L,13L,28L,30L,25L,33L,27L,36L,32L,34L,17L,38L,19L,40L,35L,42L,39L,44L,45L,46L,23L,48L,50L,51L,52L,54L,56L,49L,58L,29L,60L,55L,57L,63L,66L,62L,31L,68L,64L,70L,65L,72L,69L,74L,37L,76L,78L,75L,80L,82L,41L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096665Inst : IEnumerable<long>
{
public static readonly long[] Value=A096665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096665.Bytes);
public long this[int i]=>Value[i];

public static A096665Inst Instance=new A096665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096666
{
public static readonly long[] Value={ 1L,2L,5L,3L,10L,4L,12L,8L,6L,9L,18L,7L,22L,11L,14L,16L,31L,13L,33L,15L,20L,17L,41L,19L,25L,21L,27L,23L,50L,24L,57L,29L,26L,30L,35L,28L,65L,32L,37L,34L,71L,36L,75L,38L,39L,40L,85L,42L,48L,43L,44L,45L,95L,46L,52L,47L,53L,49L,104L,51L,108L,56L,54L,59L,61L,55L,119L,58L,63L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096666Inst : IEnumerable<long>
{
public static readonly long[] Value=A096666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096666.Bytes);
public long this[int i]=>Value[i];

public static A096666Inst Instance=new A096666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096667
{
public static readonly long[] Value={ 1L,2L,6L,9L,4L,10L,7L,8L,5L,3L,15L,12L,11L,20L,21L,16L,13L,14L,30L,26L,33L,18L,36L,34L,25L,19L,27L,42L,38L,40L,22L,44L,24L,46L,35L,48L,45L,51L,52L,54L,28L,49L,29L,60L,55L,63L,62L,58L,68L,32L,70L,66L,31L,69L,76L,72L,17L,75L,74L,82L,37L,84L,80L,86L,39L,88L,81L,43L,87L,96L,23L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096667Inst : IEnumerable<long>
{
public static readonly long[] Value=A096667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096667.Bytes);
public long this[int i]=>Value[i];

public static A096667Inst Instance=new A096667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096668
{
public static readonly long[] Value={ 1L,2L,10L,5L,9L,3L,7L,8L,4L,6L,13L,12L,17L,18L,11L,16L,57L,22L,26L,14L,15L,31L,71L,33L,25L,20L,27L,41L,43L,19L,53L,50L,21L,24L,35L,23L,61L,29L,65L,30L,127L,28L,68L,32L,37L,34L,79L,36L,42L,75L,38L,39L,89L,40L,45L,85L,95L,48L,92L,44L,96L,47L,46L,104L,108L,52L,111L,49L,54L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096668Inst : IEnumerable<long>
{
public static readonly long[] Value=A096668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096668.Bytes);
public long this[int i]=>Value[i];

public static A096668Inst Instance=new A096668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096669
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,5L,5L,2L,1L,1L,1L,8L,9L,5L,2L,1L,1L,1L,13L,18L,12L,5L,2L,1L,1L,1L,21L,37L,24L,12L,5L,2L,1L,1L,1L,34L,73L,52L,29L,12L,5L,2L,1L,1L,1L,55L,146L,115L,62L,29L,12L,5L,2L,1L,1L,1L,89L,293L,251L,140L,70L,29L,12L,5L,2L,1L,1L,1L,144L,585L,542L,321L,156L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096669Inst : IEnumerable<long>
{
public static readonly long[] Value=A096669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096669.Bytes);
public long this[int i]=>Value[i];

public static A096669Inst Instance=new A096669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096670
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,2L,5L,5L,1L,1L,1L,2L,5L,9L,8L,1L,1L,1L,2L,5L,12L,18L,13L,1L,1L,1L,2L,5L,12L,24L,37L,21L,1L,1L,1L,2L,5L,12L,29L,52L,73L,34L,1L,1L,1L,2L,5L,12L,29L,62L,115L,146L,55L,1L,1L,1L,2L,5L,12L,29L,70L,140L,251L,293L,89L,1L,1L,1L,2L,5L,12L,29L,70L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096670Inst : IEnumerable<long>
{
public static readonly long[] Value=A096670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096670.Bytes);
public long this[int i]=>Value[i];

public static A096670Inst Instance=new A096670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096671
{
public static readonly BigInteger[] Value={ 1L,6L,40L,1008L,3456L,39916800L,566092800L,100590336000L,355687428096000L,1431118828339200L,2688996956405760000L,BigInteger.Parse("8617338912961658880000"),BigInteger.Parse("224800145555521536000000"),BigInteger.Parse("10888869450418352160768000000"),BigInteger.Parse("8841761993739701954543616000000"),BigInteger.Parse("4500732706172918893117440000000"),BigInteger.Parse("280107019961673757919941754880000000") };
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
public class A096671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096671Inst Instance=new A096671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096672
{
public static readonly long[] Value={ 3L,15L,15L,29L,39L,51L,65L,73L,87L,75L,89L,109L,111L,157L,123L,185L,149L,205L,221L,219L,185L,183L,195L,205L,291L,327L,255L,291L,305L,255L,269L,325L,303L,317L,411L,339L,411L,397L,375L,481L,533L,409L,461L,507L,425L,471L,435L,435L,593L,565L,521L,485L,493L,555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096672Inst : IEnumerable<long>
{
public static readonly long[] Value=A096672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096672.Bytes);
public long this[int i]=>Value[i];

public static A096672Inst Instance=new A096672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096673
{
public static readonly long[] Value={ 5L,37L,41L,75L,113L,145L,183L,195L,229L,221L,255L,303L,325L,375L,365L,447L,435L,519L,555L,557L,543L,545L,577L,591L,745L,785L,733L,773L,807L,761L,795L,879L,901L,939L,1037L,1013L,1105L,1095L,1093L,1227L,1299L,1203L,1275L,1325L,1263L,1313L,1297L,1301L,1479L,1479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096673Inst : IEnumerable<long>
{
public static readonly long[] Value=A096673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096673.Bytes);
public long this[int i]=>Value[i];

public static A096673Inst Instance=new A096673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096674
{
public static readonly long[] Value={ 6L,39L,42L,78L,114L,147L,186L,201L,237L,222L,258L,309L,327L,399L,366L,474L,438L,543L,582L,582L,546L,546L,579L,597L,777L,834L,741L,798L,834L,762L,798L,903L,903L,942L,1086L,1014L,1137L,1119L,1101L,1281L,1374L,1209L,1302L,1374L,1266L,1338L,1299L,1302L,1554L,1533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096674Inst : IEnumerable<long>
{
public static readonly long[] Value=A096674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096674.Bytes);
public long this[int i]=>Value[i];

public static A096674Inst Instance=new A096674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096675
{
public static readonly long[] Value={ 4L,7L,10L,13L,22L,24L,25L,27L,28L,34L,37L,43L,45L,49L,57L,58L,60L,64L,67L,70L,73L,79L,84L,87L,88L,93L,97L,100L,102L,108L,112L,115L,127L,130L,139L,142L,144L,148L,150L,154L,160L,163L,169L,175L,177L,190L,192L,193L,199L,202L,205L,207L,213L,214L,220L,232L,234L,235L,238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096675Inst : IEnumerable<long>
{
public static readonly long[] Value=A096675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096675.Bytes);
public long this[int i]=>Value[i];

public static A096675Inst Instance=new A096675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096708
{
public static readonly long[] Value={ 157L,353L,8233L,23893L,26183L,30197L,63697L,118831L,131041L,150203L,152213L,167033L,198013L,293087L,341303L,383983L,494051L,494723L,534007L,551569L,601949L,603541L,629203L,666697L,671287L,679417L,688907L,768203L,787207L,796867L,826039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096708Inst : IEnumerable<long>
{
public static readonly long[] Value=A096708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096708.Bytes);
public long this[int i]=>Value[i];

public static A096708Inst Instance=new A096708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096709
{
public static readonly long[] Value={ 173L,124991L,232607L,491423L,701489L,1356337L,2455681L,3128803L,5218607L,9459683L,10563461L,13228247L,14606029L,16282921L,18216137L,20378273L,21622201L,35201909L,36549169L,38638969L,39246689L,42074017L,43048039L,48961859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096709Inst : IEnumerable<long>
{
public static readonly long[] Value=A096709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096709.Bytes);
public long this[int i]=>Value[i];

public static A096709Inst Instance=new A096709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096710
{
public static readonly long[] Value={ 98303927L,580868459L,784857323L,857636141L,909894647L,951508837L,1367470823L,1480028171L,1850590099L,2106973159L,2121382079L,2409718043L,2635873907L,2704854637L,3225527099L,3386231579L,3823510039L,3824915671L,3905211517L,4123167667L,4127991383L,4386448117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096710Inst : IEnumerable<long>
{
public static readonly long[] Value=A096710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096710.Bytes);
public long this[int i]=>Value[i];

public static A096710Inst Instance=new A096710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096711
{
public static readonly long[] Value={ 1L,8L,57L,308L,1989L,13161L,94939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096711Inst : IEnumerable<long>
{
public static readonly long[] Value=A096711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096711.Bytes);
public long this[int i]=>Value[i];

public static A096711Inst Instance=new A096711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096712
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-107L,-73L,41897L,3027637L,986527L,-11832720271L,-238031459363L,22592230600813L,2567503517437949L,877962977779386211L,BigInteger.Parse("-72551800185828715163"),BigInteger.Parse("-189312598480126813670107"),BigInteger.Parse("-555004914636991112974483"),BigInteger.Parse("10604546643258382904627047649"),BigInteger.Parse("1588669342302765693238039021451") };
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
public class A096712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096712.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096712Inst Instance=new A096712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096713
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-3L,1L,3L,-6L,1L,15L,-10L,1L,-15L,45L,-15L,1L,-105L,105L,-21L,1L,105L,-420L,210L,-28L,1L,945L,-1260L,378L,-36L,1L,-945L,4725L,-3150L,630L,-45L,1L,-10395L,17325L,-6930L,990L,-55L,1L,10395L,-62370L,51975L,-13860L,1485L,-66L,1L,135135L,-270270L,135135L,-25740L,2145L,-78L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096713Inst : IEnumerable<long>
{
public static readonly long[] Value=A096713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096713.Bytes);
public long this[int i]=>Value[i];

public static A096713Inst Instance=new A096713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096714
{
public static readonly long[] Value={ 2L,3L,3L,8L,1L,0L,7L,4L,1L,0L,4L,5L,9L,7L,6L,7L,0L,3L,8L,4L,8L,9L,1L,9L,7L,2L,5L,2L,4L,4L,6L,7L,3L,5L,4L,4L,0L,6L,3L,8L,5L,4L,0L,1L,4L,5L,6L,7L,2L,3L,8L,7L,8L,5L,2L,4L,8L,3L,8L,5L,4L,4L,3L,7L,2L,1L,3L,6L,6L,8L,0L,0L,2L,7L,0L,0L,2L,8L,3L,6L,4L,7L,7L,8L,2L,1L,6L,4L,0L,4L,1L,7L,3L,1L,3L,2L,9L,3L,2L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096714Inst : IEnumerable<long>
{
public static readonly long[] Value=A096714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096714.Bytes);
public long this[int i]=>Value[i];

public static A096714Inst Instance=new A096714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096715
{
public static readonly long[] Value={ 1L,1L,7L,3L,7L,1L,3L,2L,2L,2L,7L,0L,9L,1L,2L,7L,9L,2L,4L,9L,1L,9L,9L,7L,9L,9L,6L,2L,4L,7L,3L,9L,0L,2L,1L,0L,4L,5L,4L,3L,6L,4L,6L,3L,8L,9L,1L,7L,5L,7L,0L,3L,0L,9L,7L,5L,7L,9L,2L,0L,7L,6L,1L,1L,5L,0L,4L,2L,9L,5L,3L,0L,6L,2L,6L,0L,2L,1L,4L,9L,5L,4L,0L,1L,6L,3L,5L,4L,3L,3L,7L,1L,0L,8L,6L,5L,9L,7L,6L,9L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096715Inst : IEnumerable<long>
{
public static readonly long[] Value=A096715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096715.Bytes);
public long this[int i]=>Value[i];

public static A096715Inst Instance=new A096715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096716
{
public static readonly BigInteger[] Value={ 1L,6L,40L,5040L,24192L,39916800L,6227020800L,37362124800L,355687428096000L,24329020081766400L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("2872446304320552960000"),BigInteger.Parse("5170403347776995328000000"),BigInteger.Parse("2177773890083670432153600000"),BigInteger.Parse("8841761993739701954543616000000"),BigInteger.Parse("249176928914482509628047360000000") };
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
public class A096716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096716Inst Instance=new A096716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096717
{
public static readonly BigInteger[] Value={ 1L,-1L,13L,-341L,18649L,-177761L,1087433L,-4043494549L,1674761567L,-284891766539657L,106410874319325461L,BigInteger.Parse("-48402125366670946877"),BigInteger.Parse("26344930021064765797249"),BigInteger.Parse("-27048608191991004321089"),BigInteger.Parse("6237195766537863970288933"),BigInteger.Parse("-16102066950215127630856787159"),BigInteger.Parse("2258820895862623437612519923989") };
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
public class A096717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096717Inst Instance=new A096717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096718
{
public static readonly BigInteger[] Value={ 1L,6L,120L,5040L,362880L,4435200L,32947200L,145297152000L,69701632000L,13516122267648000L,5676771352412160000L,BigInteger.Parse("2872446304320552960000"),BigInteger.Parse("1723467782592331776000000"),BigInteger.Parse("1935799013407707050803200"),BigInteger.Parse("485144691014524112732160000"),BigInteger.Parse("1353553687930522274522726400000"),BigInteger.Parse("204193242064947360270857011200000") };
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
public class A096718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096718.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096718Inst Instance=new A096718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096719
{
public static readonly BigInteger[] Value={ 1L,-1L,13L,-173L,12409L,-123379L,29518679L,-889424791L,92273231203L,3836321172631L,22487012578592981L,2865860401219263691L,BigInteger.Parse("35970731592390474409"),BigInteger.Parse("277817773865257308429491"),BigInteger.Parse("1687365015862907602230599"),BigInteger.Parse("22415401434548677685890690591"),BigInteger.Parse("5789220720660809183499012532793"),BigInteger.Parse("2838956049184596030388390046497291") };
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
public class A096719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096719.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096719Inst Instance=new A096719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096720
{
public static readonly BigInteger[] Value={ 1L,6L,120L,5040L,362880L,13305600L,2075673600L,435891456000L,13173608448000L,13516122267648000L,5676771352412160000L,BigInteger.Parse("2872446304320552960000"),BigInteger.Parse("14243535393325056000000"),BigInteger.Parse("241974876675963381350400000"),BigInteger.Parse("949196134593634133606400000"),BigInteger.Parse("20303305318957834117840896000000"),BigInteger.Parse("4288058083363894565687997235200000") };
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
public class A096720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096720Inst Instance=new A096720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096721
{
public static readonly BigInteger[] Value={ 0L,0L,0L,-1L,13L,-2329L,3749L,-1405132357L,41223659L,-3230487913L,87420689313263L,-92876785811395309L,6545378422138547141L,BigInteger.Parse("-76226954122169434345117"),BigInteger.Parse("13717355610784766550119"),BigInteger.Parse("-152042860419225571514252591"),BigInteger.Parse("325359516347299085987218014617"),BigInteger.Parse("-501994552683503696983628163720749"),BigInteger.Parse("226141284010354023120430917899293") };
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
public class A096721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096721.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096721Inst Instance=new A096721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096722
{
public static readonly BigInteger[] Value={ 1L,1L,1L,30L,756L,75600L,199584L,54486432000L,2421619200L,151227648000L,5913303492096000L,5203707073044480000L,BigInteger.Parse("512936840057241600000"),BigInteger.Parse("5041143264082570444800000"),BigInteger.Parse("1238175538546596249600000"),BigInteger.Parse("11695452372671563431936000000"),BigInteger.Parse("33500453776280426294437478400000"),BigInteger.Parse("44295044437526341433756221440000000") };
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
public class A096722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096722.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096722Inst Instance=new A096722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096723
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,13L,16L,32L,64L,71L,103L,541L,1091L,1367L,1627L,4177L,9011L,9551L,36913L,43063L,49681L,57917L,483611L,877843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096723Inst : IEnumerable<long>
{
public static readonly long[] Value=A096723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096723.Bytes);
public long this[int i]=>Value[i];

public static A096723Inst Instance=new A096723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096788
{
public static readonly long[] Value={ 9L,15L,21L,33L,35L,39L,51L,63L,65L,69L,75L,81L,95L,99L,105L,111L,119L,125L,135L,141L,153L,155L,165L,183L,189L,209L,215L,219L,221L,231L,243L,245L,249L,261L,273L,285L,299L,303L,309L,315L,321L,323L,329L,341L,345L,363L,369L,371L,375L,393L,405L,411L,413L,429L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096788Inst : IEnumerable<long>
{
public static readonly long[] Value=A096788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096788.Bytes);
public long this[int i]=>Value[i];

public static A096788Inst Instance=new A096788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096789
{
public static readonly long[] Value={ 1L,5L,9L,0L,6L,3L,6L,8L,5L,4L,6L,3L,7L,3L,2L,9L,0L,6L,3L,3L,8L,2L,2L,5L,4L,4L,2L,4L,9L,9L,9L,6L,6L,6L,2L,4L,7L,9L,5L,4L,4L,7L,8L,1L,5L,9L,4L,9L,5L,5L,3L,6L,6L,4L,7L,1L,3L,2L,2L,8L,7L,9L,8L,4L,6L,0L,8L,5L,4L,5L,0L,3L,7L,5L,3L,5L,3L,6L,1L,1L,8L,5L,1L,1L,6L,1L,2L,2L,1L,4L,7L,5L,9L,4L,2L,2L,8L,9L,2L,5L,2L,3L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096789Inst : IEnumerable<long>
{
public static readonly long[] Value=A096789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096789.Bytes);
public long this[int i]=>Value[i];

public static A096789Inst Instance=new A096789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096790
{
public static readonly long[] Value={ 4801L,9547L,9601L,11311L,11317L,11941L,11953L,13033L,13327L,13669L,13711L,13963L,13999L,14011L,14251L,14293L,14341L,14347L,14389L,14401L,15091L,15427L,15679L,15727L,15973L,16057L,16063L,16069L,16111L,16267L,16363L,16411L,16447L,16453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096790Inst : IEnumerable<long>
{
public static readonly long[] Value=A096790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096790.Bytes);
public long this[int i]=>Value[i];

public static A096790Inst Instance=new A096790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096791
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,2L,2L,3L,4L,5L,6L,7L,9L,11L,14L,16L,19L,23L,27L,32L,38L,45L,52L,61L,71L,83L,96L,111L,128L,148L,170L,195L,224L,256L,293L,334L,380L,432L,491L,556L,630L,713L,805L,908L,1024L,1152L,1295L,1455L,1632L,1829L,2048L,2291L,2560L,2859L,3189L,3554L,3958L,4404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096791Inst : IEnumerable<long>
{
public static readonly long[] Value=A096791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096791.Bytes);
public long this[int i]=>Value[i];

public static A096791Inst Instance=new A096791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096792
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,3L,4L,5L,6L,8L,9L,11L,13L,16L,19L,23L,27L,32L,38L,44L,52L,61L,71L,82L,96L,111L,128L,148L,170L,195L,224L,256L,292L,334L,380L,432L,491L,557L,630L,713L,805L,908L,1024L,1152L,1295L,1455L,1632L,1829L,2049L,2291L,2560L,2859L,3189L,3554L,3959L,4404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096792Inst : IEnumerable<long>
{
public static readonly long[] Value=A096792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096792.Bytes);
public long this[int i]=>Value[i];

public static A096792Inst Instance=new A096792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096793
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,4L,0L,1L,3L,0L,10L,0L,1L,0L,21L,0L,20L,0L,1L,12L,0L,84L,0L,35L,0L,1L,0L,120L,0L,252L,0L,56L,0L,1L,55L,0L,660L,0L,630L,0L,84L,0L,1L,0L,715L,0L,2640L,0L,1386L,0L,120L,0L,1L,273L,0L,5005L,0L,8580L,0L,2772L,0L,165L,0L,1L,0L,4368L,0L,25025L,0L,24024L,0L,5148L,0L,220L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096793Inst : IEnumerable<long>
{
public static readonly long[] Value=A096793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096793.Bytes);
public long this[int i]=>Value[i];

public static A096793Inst Instance=new A096793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096794
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,4L,2L,4L,0L,8L,6L,8L,12L,0L,16L,18L,26L,24L,32L,0L,32L,57L,80L,84L,64L,80L,0L,64L,186L,260L,264L,240L,160L,192L,0L,128L,622L,864L,880L,768L,640L,384L,448L,0L,256L,2120L,2932L,2976L,2624L,2080L,1632L,896L,1024L,0L,512L,7338L,10112L,10248L,9024L,7280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096794Inst : IEnumerable<long>
{
public static readonly long[] Value=A096794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096794.Bytes);
public long this[int i]=>Value[i];

public static A096794Inst Instance=new A096794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096795
{
public static readonly long[] Value={ 1L,3L,11L,25L,137L,1019L,2143L,6709L,76319L,1019867L,2084779L,36161963L,699329537L,16317371911L,82657705331L,250947687593L,7357796373397L,230420777138107L,465354165304139L,17362507669146743L,717205745892079663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096795Inst : IEnumerable<long>
{
public static readonly long[] Value=A096795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096795.Bytes);
public long this[int i]=>Value[i];

public static A096795Inst Instance=new A096795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096796
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,8L,13L,23L,41L,74L,135L,257L,491L,941L,1808L,3481L,6827L,13397L,26303L,51665L,101522L,199563L,395645L,784463L,1555529L,3084755L,6117845L,12134168L,24068773L,47937983L,95480321L,190176179L,378796829L,754508903L,1502899961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096796Inst : IEnumerable<long>
{
public static readonly long[] Value=A096796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096796.Bytes);
public long this[int i]=>Value[i];

public static A096796Inst Instance=new A096796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096797
{
public static readonly long[] Value={ 1L,3L,1L,8L,0L,1L,16L,-1L,0L,1L,34L,-15L,0L,0L,1L,54L,-40L,3L,0L,0L,1L,104L,-119L,21L,0L,0L,0L,1L,156L,-260L,88L,-1L,0L,0L,0L,1L,261L,-576L,305L,-27L,0L,0L,0L,0L,1L,382L,-1111L,850L,-155L,3L,0L,0L,0L,0L,1L,615L,-2167L,2167L,-638L,33L,0L,0L,0L,0L,0L,1L,842L,-3854L,5056L,-2164L,240L,-1L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096797Inst : IEnumerable<long>
{
public static readonly long[] Value=A096797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096797.Bytes);
public long this[int i]=>Value[i];

public static A096797Inst Instance=new A096797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096798
{
public static readonly long[] Value={ 1L,2L,1L,3L,0L,1L,5L,0L,0L,1L,7L,-6L,0L,0L,1L,11L,-13L,2L,0L,0L,1L,15L,-34L,9L,0L,0L,0L,1L,22L,-65L,33L,0L,0L,0L,0L,1L,30L,-128L,102L,-12L,0L,0L,0L,0L,1L,42L,-225L,255L,-62L,2L,0L,0L,0L,0L,1L,56L,-394L,591L,-232L,15L,0L,0L,0L,0L,0L,1L,77L,-649L,1265L,-721L,100L,0L,0L,0L,0L,0L,0L,1L,101L,-1064L,2559L,-1972L,455L,-18L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096798Inst : IEnumerable<long>
{
public static readonly long[] Value=A096798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096798.Bytes);
public long this[int i]=>Value[i];

public static A096798Inst Instance=new A096798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096799
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,-2L,3L,0L,1L,1L,1L,-2L,4L,0L,1L,1L,-8L,12L,-4L,5L,0L,1L,1L,23L,-51L,25L,-5L,6L,0L,1L,1L,-164L,361L,-192L,50L,-6L,7L,0L,1L,1L,1255L,-2856L,1630L,-484L,87L,-7L,8L,0L,1L,1L,-12108L,27795L,-16292L,5065L,-1026L,140L,-8L,9L,0L,1L,1L,136061L,-315068L,188665L,-60125L,12604L,-1925L,212L,-9L,10L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096799Inst : IEnumerable<long>
{
public static readonly long[] Value=A096799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096799.Bytes);
public long this[int i]=>Value[i];

public static A096799Inst Instance=new A096799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096800
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,2L,1L,0L,1L,4L,-5L,5L,0L,1L,2L,2L,-5L,6L,0L,1L,6L,-28L,28L,-7L,7L,0L,1L,4L,90L,-136L,49L,-8L,8L,0L,1L,6L,-738L,1082L,-432L,90L,-9L,9L,0L,1L,4L,6279L,-9525L,4075L,-969L,145L,-10L,10L,0L,1L,10L,-66594L,101915L,-44803L,11143L,-1881L,220L,-11L,11L,0L,1L,4L,816362L,-1260268L,565988L,-144300L,25207L,-3300L,318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096800Inst : IEnumerable<long>
{
public static readonly long[] Value=A096800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096800.Bytes);
public long this[int i]=>Value[i];

public static A096800Inst Instance=new A096800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096801
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,1L,1L,0L,7L,3L,1L,1L,0L,26L,10L,4L,1L,1L,0L,124L,44L,13L,5L,1L,1L,0L,640L,218L,68L,16L,6L,1L,1L,0L,3695L,1208L,332L,99L,19L,7L,1L,1L,0L,23231L,7403L,2100L,457L,138L,22L,8L,1L,1L,0L,156572L,48663L,12566L,3518L,579L,186L,25L,9L,1L,1L,0L,1133838L,346636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096801Inst : IEnumerable<long>
{
public static readonly long[] Value=A096801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096801.Bytes);
public long this[int i]=>Value[i];

public static A096801Inst Instance=new A096801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096802
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,42L,188L,950L,5362L,33361L,222120L,1600145L,12069976L,98105654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096802Inst : IEnumerable<long>
{
public static readonly long[] Value=A096802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096802.Bytes);
public long this[int i]=>Value[i];

public static A096802Inst Instance=new A096802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096803
{
public static readonly long[] Value={ 1L,1L,2L,7L,26L,124L,640L,3695L,23231L,156572L,1133838L,8635777L,70212042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096803Inst : IEnumerable<long>
{
public static readonly long[] Value=A096803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096803.Bytes);
public long this[int i]=>Value[i];

public static A096803Inst Instance=new A096803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096836
{
public static readonly long[] Value={ 3L,3L,1L,2L,3L,1L,1L,2L,3L,1L,3L,1L,1L,3L,1L,0L,7L,5L,1L,3L,0L,2L,2L,2L,1L,0L,0L,0L,2L,3L,3L,2L,4L,0L,2L,1L,3L,1L,5L,2L,0L,2L,4L,4L,2L,1L,3L,3L,3L,1L,0L,0L,0L,1L,2L,2L,1L,0L,1L,4L,4L,1L,2L,5L,2L,1L,4L,2L,3L,3L,2L,3L,3L,2L,1L,1L,2L,3L,1L,4L,4L,0L,4L,0L,2L,2L,0L,2L,3L,2L,6L,0L,3L,4L,4L,1L,1L,4L,0L,0L,4L,3L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096836Inst : IEnumerable<long>
{
public static readonly long[] Value=A096836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096836.Bytes);
public long this[int i]=>Value[i];

public static A096836Inst Instance=new A096836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096837
{
public static readonly long[] Value={ 0L,3L,3L,2L,2L,2L,3L,2L,2L,1L,0L,1L,3L,3L,1L,2L,1L,0L,6L,1L,2L,2L,3L,1L,1L,3L,3L,1L,0L,3L,2L,4L,2L,2L,4L,3L,2L,1L,5L,1L,1L,2L,3L,1L,3L,0L,2L,1L,3L,2L,1L,0L,4L,1L,2L,2L,2L,2L,1L,0L,1L,3L,2L,1L,0L,0L,2L,1L,3L,1L,1L,2L,1L,0L,2L,3L,5L,3L,3L,0L,3L,2L,2L,4L,4L,0L,6L,2L,1L,2L,1L,3L,3L,2L,1L,3L,2L,2L,1L,4L,1L,6L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096837Inst : IEnumerable<long>
{
public static readonly long[] Value=A096837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096837.Bytes);
public long this[int i]=>Value[i];

public static A096837Inst Instance=new A096837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096838
{
public static readonly long[] Value={ 2L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,1L,2L,2L,2L,3L,2L,2L,2L,1L,2L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,2L,3L,4L,4L,3L,1L,3L,4L,4L,4L,3L,2L,2L,3L,3L,3L,3L,4L,3L,3L,1L,3L,4L,4L,3L,2L,2L,3L,3L,4L,2L,2L,3L,3L,3L,2L,2L,2L,1L,2L,2L,2L,3L,3L,3L,2L,3L,4L,4L,3L,1L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096838Inst : IEnumerable<long>
{
public static readonly long[] Value=A096838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096838.Bytes);
public long this[int i]=>Value[i];

public static A096838Inst Instance=new A096838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096839
{
public static readonly long[] Value={ 0L,3L,2L,3L,2L,1L,2L,3L,2L,3L,0L,2L,3L,4L,3L,2L,2L,0L,2L,2L,2L,3L,1L,3L,2L,3L,2L,1L,1L,1L,1L,3L,3L,3L,4L,5L,3L,3L,1L,3L,0L,1L,1L,2L,3L,2L,3L,3L,2L,1L,2L,3L,2L,2L,2L,1L,3L,4L,0L,2L,2L,3L,1L,3L,4L,3L,3L,1L,1L,2L,1L,2L,2L,4L,1L,2L,2L,3L,1L,1L,3L,2L,1L,1L,2L,1L,3L,2L,2L,2L,3L,2L,2L,3L,1L,2L,3L,2L,3L,2L,2L,1L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096839Inst : IEnumerable<long>
{
public static readonly long[] Value=A096839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096839.Bytes);
public long this[int i]=>Value[i];

public static A096839Inst Instance=new A096839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096840
{
public static readonly long[] Value={ 1L,6L,3L,2L,14L,36L,117L,1652L,9582L,41361L,908637L,36284185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096840Inst : IEnumerable<long>
{
public static readonly long[] Value=A096840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096840.Bytes);
public long this[int i]=>Value[i];

public static A096840Inst Instance=new A096840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096841
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,43L,146L,365L,438L,443L,803L,887L,2221L,4442L,6663L,8887L,87876L,88183L,153837L,250244L,285597L,292860L,296294L,302877L,307674L,344268L,351612L,380718L,403398L,423260L,441821L,444443L,550238L,579038L,584438L,588974L,593163L,600363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096841Inst : IEnumerable<long>
{
public static readonly long[] Value=A096841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096841.Bytes);
public long this[int i]=>Value[i];

public static A096841Inst Instance=new A096841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096842
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,8L,44L,222L,444L,888L,444L,888L,888L,2222L,6666L,8888L,8888L,222222L,88888L,222222L,444444L,444444L,888888L,444444L,444444L,666666L,888888L,888888L,888888L,888888L,888888L,444444L,444444L,888888L,888888L,888888L,888888L,888888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096842Inst : IEnumerable<long>
{
public static readonly long[] Value=A096842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096842.Bytes);
public long this[int i]=>Value[i];

public static A096842Inst Instance=new A096842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096843
{
public static readonly BigInteger[] Value={ 2L,3L,5L,7L,43L,443L,887L,2221L,8887L,444443L,888887L,444444443L,888888887L,444444444443L,888888888887L,222222222222222221L,BigInteger.Parse("444444444444444444444444444443"),BigInteger.Parse("44444444444444444444444444444443") };
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
public class A096843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096843Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A096843.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A096843.Bytes);
public BigInteger this[int i]=>Value[i];

public static A096843Inst Instance=new A096843Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096844
{
public static readonly long[] Value={ 0L,10L,30L,50L,70L,90L,100L,101L,103L,105L,107L,109L,110L,130L,150L,170L,190L,300L,301L,303L,305L,307L,309L,310L,330L,350L,370L,390L,500L,501L,503L,505L,507L,509L,510L,530L,550L,570L,590L,700L,701L,703L,705L,707L,709L,710L,730L,750L,770L,900L,901L,903L,905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096844Inst : IEnumerable<long>
{
public static readonly long[] Value=A096844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096844.Bytes);
public long this[int i]=>Value[i];

public static A096844Inst Instance=new A096844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096845
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,12L,30L,32L,183L,297L,492L,41316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096845Inst : IEnumerable<long>
{
public static readonly long[] Value=A096845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096845.Bytes);
public long this[int i]=>Value[i];

public static A096845Inst Instance=new A096845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096846
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,12L,72L,118L,124L,190L,244L,304L,357L,1422L,2691L,5538L,7581L,21906L,32176L,44358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096846Inst : IEnumerable<long>
{
public static readonly long[] Value=A096846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096846.Bytes);
public long this[int i]=>Value[i];

public static A096846Inst Instance=new A096846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096847
{
public static readonly long[] Value={ 3L,4L,8L,36L,100L,128L,324L,400L,1296L,1600L,1936L,2116L,3364L,4356L,10404L,11236L,20736L,22500L,26244L,27556L,28900L,30976L,38416L,40000L,52900L,53824L,57600L,60516L,88804L,93636L,107584L,108900L,115600L,123904L,125316L,129600L,211600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096847Inst : IEnumerable<long>
{
public static readonly long[] Value=A096847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096847.Bytes);
public long this[int i]=>Value[i];

public static A096847Inst Instance=new A096847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096848
{
public static readonly long[] Value={ 2L,5L,17L,233L,683L,769L,4013L,5039L,28649L,29663L,24917L,15173L,24179L,105509L,252971L,81083L,871289L,941429L,639701L,199193L,713681L,768389L,873569L,1300813L,1308299L,1019687L,4459667L,1477139L,642779L,3953591L,2040443L,8445707L,4906973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096848Inst : IEnumerable<long>
{
public static readonly long[] Value=A096848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096848.Bytes);
public long this[int i]=>Value[i];

public static A096848Inst Instance=new A096848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096849
{
public static readonly long[] Value={ 3L,5L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096849Inst : IEnumerable<long>
{
public static readonly long[] Value=A096849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096849.Bytes);
public long this[int i]=>Value[i];

public static A096849Inst Instance=new A096849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096850
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,24L,30L,48L,60L,72L,96L,128L,240L,432L,480L,576L,720L,864L,1200L,1280L,1512L,1536L,1728L,1800L,1860L,2016L,2560L,2880L,3024L,3456L,3840L,6912L,10368L,14080L,15552L,15840L,18144L,27648L,30976L,32768L,34560L,41472L,42240L,48384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096850Inst : IEnumerable<long>
{
public static readonly long[] Value=A096850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096850.Bytes);
public long this[int i]=>Value[i];

public static A096850Inst Instance=new A096850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096851
{
public static readonly long[] Value={ 10L,14L,18L,20L,22L,26L,28L,32L,34L,36L,38L,40L,42L,44L,46L,50L,52L,54L,56L,58L,62L,64L,66L,68L,70L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096851Inst : IEnumerable<long>
{
public static readonly long[] Value=A096851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096851.Bytes);
public long this[int i]=>Value[i];

public static A096851Inst Instance=new A096851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096868
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,20L,25L,30L,35L,40L,42L,48L,49L,50L,60L,70L,75L,100L,125L,150L,175L,200L,210L,240L,245L,250L,300L,350L,375L,500L,625L,750L,875L,1000L,1050L,1200L,1225L,1250L,1500L,1750L,1875L,2500L,3125L,3750L,4375L,5000L,5250L,6000L,6125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096868Inst : IEnumerable<long>
{
public static readonly long[] Value=A096868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096868.Bytes);
public long this[int i]=>Value[i];

public static A096868Inst Instance=new A096868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096869
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,8L,40L,6L,2L,10L,2L,38L,28L,12L,118L,12L,8L,20L,60L,20L,46L,78L,6L,2L,102L,272L,80L,246L,6L,80L,102L,36L,116L,10L,36L,10L,238L,32L,20L,6L,78L,412L,88L,426L,118L,172L,48L,58L,112L,8L,56L,430L,90L,136L,240L,30L,140L,232L,162L,40L,226L,48L,116L,60L,690L,146L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096869Inst : IEnumerable<long>
{
public static readonly long[] Value=A096869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096869.Bytes);
public long this[int i]=>Value[i];

public static A096869Inst Instance=new A096869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096870
{
public static readonly long[] Value={ 4L,2L,2L,18L,2L,20L,10L,2L,14L,52L,8L,18L,58L,58L,72L,4L,20L,74L,84L,58L,14L,18L,82L,168L,28L,50L,168L,84L,8L,138L,112L,82L,2L,28L,2L,62L,34L,50L,74L,24L,8L,54L,204L,22L,428L,40L,118L,200L,72L,40L,30L,42L,284L,44L,114L,268L,80L,18L,4L,74L,142L,182L,140L,112L,214L,152L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096870Inst : IEnumerable<long>
{
public static readonly long[] Value=A096870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096870.Bytes);
public long this[int i]=>Value[i];

public static A096870Inst Instance=new A096870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096871
{
public static readonly ulong[] Value={ 2L,1L,3L,5L,86L,75L,1393L,2494L,162402L,148157L,7489051L,13853391L,2009866406L,1878178855L,185066460993L,174321510430L,89622746262146L,28317869903523L,13807296146243251L,26310320926601689L,10551742962933162102UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096871Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A096871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096871.Bytes);
public ulong this[int i]=>Value[i];

public static A096871Inst Instance=new A096871Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096872
{
public static readonly long[] Value={ 1L,1L,1L,4L,8L,8L,33L,56L,56L,105L,105L,105L,532L,532L,735L,735L,735L,735L,1995L,1995L,1995L,1995L,1995L,1995L,9555L,9555L,9555L,10672L,13975L,13975L,13975L,13975L,13975L,13975L,13975L,13975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096872Inst : IEnumerable<long>
{
public static readonly long[] Value=A096872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096872.Bytes);
public long this[int i]=>Value[i];

public static A096872Inst Instance=new A096872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096873
{
public static readonly long[] Value={ 1L,1L,1L,8L,73L,174L,22270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096873Inst : IEnumerable<long>
{
public static readonly long[] Value=A096873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096873.Bytes);
public long this[int i]=>Value[i];

public static A096873Inst Instance=new A096873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096874
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,1L,-1L,-1L,1L,0L,-1L,3L,-2L,-1L,1L,0L,-1L,-1L,5L,-3L,-1L,1L,0L,3L,-5L,-1L,7L,-4L,-1L,1L,0L,4L,-10L,4L,-2L,9L,-5L,-1L,1L,0L,-17L,121L,-146L,42L,-5L,11L,-6L,-1L,1L,0L,-27L,-662L,1155L,-591L,130L,-11L,13L,-7L,-1L,1L,0L,118L,5952L,-10015L,5327L,-1662L,294L,-21L,15L,-8L,-1L,1L,0L,267L,-70266L,113346L,-57476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096874Inst : IEnumerable<long>
{
public static readonly long[] Value=A096874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096874.Bytes);
public long this[int i]=>Value[i];

public static A096874Inst Instance=new A096874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096875
{
public static readonly long[] Value={ 1L,0L,1L,0L,-2L,1L,0L,1L,-2L,1L,0L,3L,-1L,-2L,1L,0L,-6L,9L,-3L,-2L,1L,0L,-3L,-7L,15L,-5L,-2L,1L,0L,23L,-27L,-6L,21L,-7L,-2L,1L,0L,9L,15L,-32L,-5L,27L,-9L,-2L,1L,0L,-141L,360L,-267L,16L,-6L,33L,-11L,-2L,1L,0L,-74L,-1603L,2691L,-1216L,161L,-11L,39L,-13L,-2L,1L,0L,1139L,10961L,-20469L,11512L,-3489L,457L,-22L,45L,-15L,-2L,1L,0L,1119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096875Inst : IEnumerable<long>
{
public static readonly long[] Value=A096875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096875.Bytes);
public long this[int i]=>Value[i];

public static A096875Inst Instance=new A096875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096876
{
public static readonly long[] Value={ 1L,1L,-1L,0L,1L,-1L,-1L,3L,4L,-17L,-27L,118L,267L,-917L,-3409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096876Inst : IEnumerable<long>
{
public static readonly long[] Value=A096876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096876.Bytes);
public long this[int i]=>Value[i];

public static A096876Inst Instance=new A096876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096877
{
public static readonly long[] Value={ 1L,-2L,-10L,0L,-130L,256L,236L,0L,-22730L,81920L,327668L,0L,777260L,0L,-7180840L,0L,-1051237338L,4362076160L,22662123300L,0L,227431418372L,-549755813888L,-1598030872600L,0L,-7086115747780L,-32435593019392L,-311555637408376L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096877Inst : IEnumerable<long>
{
public static readonly long[] Value=A096877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096877.Bytes);
public long this[int i]=>Value[i];

public static A096877Inst Instance=new A096877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096878
{
public static readonly long[] Value={ 2L,5L,3L,7L,13L,11L,73L,71L,31L,29L,37L,17L,47L,97L,113L,43L,67L,191L,109L,79L,23L,347L,367L,101L,83L,181L,197L,269L,463L,311L,277L,167L,163L,107L,139L,149L,233L,379L,41L,617L,613L,131L,127L,137L,179L,283L,281L,491L,439L,53L,211L,643L,953L,661L,659L,229L,227L,709L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096878Inst : IEnumerable<long>
{
public static readonly long[] Value=A096878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096878.Bytes);
public long this[int i]=>Value[i];

public static A096878Inst Instance=new A096878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096879
{
public static readonly long[] Value={ 1L,4L,9L,16L,5L,18L,35L,16L,63L,10L,77L,36L,13L,56L,135L,32L,289L,18L,209L,100L,63L,176L,115L,144L,175L,26L,405L,56L,319L,90L,31L,128L,495L,34L,245L,72L,481L,38L,351L,40L,779L,126L,43L,704L,45L,184L,47L,240L,637L,50L,357L,520L,53L,486L,55L,392L,285L,58L,767L,120L,793L,992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096879Inst : IEnumerable<long>
{
public static readonly long[] Value=A096879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096879.Bytes);
public long this[int i]=>Value[i];

public static A096879Inst Instance=new A096879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096880
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,47L,53L,67L,41L,23L,43L,79L,103L,257L,271L,191L,109L,37L,113L,61L,29L,31L,149L,379L,349L,263L,229L,59L,97L,367L,461L,211L,173L,409L,443L,313L,311L,739L,653L,83L,661L,659L,139L,137L,193L,397L,587L,307L,163L,467L,433L,431L,337L,107L,227L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096880Inst : IEnumerable<long>
{
public static readonly long[] Value=A096880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096880.Bytes);
public long this[int i]=>Value[i];

public static A096880Inst Instance=new A096880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096881
{
public static readonly long[] Value={ 1L,4L,17L,68L,289L,1156L,4913L,19652L,83521L,334084L,1419857L,5679428L,24137569L,96550276L,410338673L,1641354692L,6975757441L,27903029764L,118587876497L,474351505988L,2015993900449L,8063975601796L,34271896307633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096881Inst : IEnumerable<long>
{
public static readonly long[] Value=A096881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096881.Bytes);
public long this[int i]=>Value[i];

public static A096881Inst Instance=new A096881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096882
{
public static readonly long[] Value={ 1L,7L,50L,350L,2500L,17500L,125000L,875000L,6250000L,43750000L,312500000L,2187500000L,15625000000L,109375000000L,781250000000L,5468750000000L,39062500000000L,273437500000000L,1953125000000000L,13671875000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096882Inst : IEnumerable<long>
{
public static readonly long[] Value=A096882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096882.Bytes);
public long this[int i]=>Value[i];

public static A096882Inst Instance=new A096882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A096883
{
public static readonly long[] Value={ 1L,10L,101L,1010L,10201L,102010L,1030301L,10303010L,104060401L,1040604010L,10510100501L,105101005010L,1061520150601L,10615201506010L,107213535210701L,1072135352107010L,10828567056280801L,108285670562808010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A096883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A096883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A096883Inst : IEnumerable<long>
{
public static readonly long[] Value=A096883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A096883.Bytes);
public long this[int i]=>Value[i];

public static A096883Inst Instance=new A096883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124456
{
public static readonly long[] Value={ 1L,2L,77L,319L,323L,1517L,3021L,4757L,6479L,7221L,8159L,8229L,9797L,11663L,12597L,13629L,13869L,14429L,14949L,16637L,18407L,19043L,19437L,23407L,24947L,25437L,30049L,30621L,34943L,34989L,35207L,39203L,43677L,44099L,47519L,51983L,53663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124456Inst : IEnumerable<long>
{
public static readonly long[] Value=A124456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124456.Bytes);
public long this[int i]=>Value[i];

public static A124456Inst Instance=new A124456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124457
{
public static readonly long[] Value={ 6L,2L,5L,4L,7L,0L,0L,9L,5L,1L,9L,3L,6L,3L,2L,8L,7L,1L,6L,4L,0L,2L,0L,7L,4L,6L,1L,1L,3L,5L,8L,2L,8L,5L,2L,4L,9L,9L,2L,9L,6L,7L,7L,5L,3L,4L,0L,4L,7L,7L,9L,3L,1L,8L,8L,7L,4L,5L,0L,2L,9L,8L,8L,9L,7L,2L,2L,8L,9L,0L,3L,6L,5L,7L,9L,4L,2L,3L,5L,8L,4L,9L,4L,6L,1L,7L,6L,9L,0L,7L,1L,8L,5L,4L,6L,5L,0L,8L,1L,1L,2L,3L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124457Inst : IEnumerable<long>
{
public static readonly long[] Value=A124457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124457.Bytes);
public long this[int i]=>Value[i];

public static A124457Inst Instance=new A124457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124458
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,3L,4L,2L,1L,3L,5L,5L,2L,1L,3L,7L,7L,6L,2L,1L,3L,8L,12L,9L,7L,2L,1L,3L,10L,15L,18L,11L,8L,2L,1L,3L,11L,22L,24L,25L,13L,9L,2L,1L,3L,13L,26L,40L,35L,33L,15L,10L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124458Inst : IEnumerable<long>
{
public static readonly long[] Value=A124458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124458.Bytes);
public long this[int i]=>Value[i];

public static A124458Inst Instance=new A124458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124459
{
public static readonly long[] Value={ 2L,3L,2L,3L,5L,2L,3L,8L,7L,2L,3L,11L,15L,9L,2L,3L,14L,26L,24L,11L,2L,3L,17L,40L,50L,35L,13L,2L,3L,20L,57L,90L,85L,48L,15L,2L,3L,23L,77L,147L,175L,133L,63L,17L,2L,3L,26L,100L,224L,322L,308L,196L,80L,19L,2L,3L,29L,126L,324L,546L,630L,504L,276L,99L,21L,2L,3L,32L,155L,450L,870L,1176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124459Inst : IEnumerable<long>
{
public static readonly long[] Value=A124459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124459.Bytes);
public long this[int i]=>Value[i];

public static A124459Inst Instance=new A124459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124460
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,4L,1L,1L,4L,8L,9L,1L,1L,5L,13L,23L,23L,1L,1L,6L,19L,44L,73L,66L,1L,1L,7L,26L,73L,162L,251L,210L,1L,1L,8L,34L,111L,302L,637L,919L,731L,1L,1L,9L,43L,159L,506L,1325L,2622L,3549L,2744L,1L,1L,10L,53L,218L,788L,2437L,6032L,11188L,14371L,10959L,1L,1L,11L,64L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124460Inst : IEnumerable<long>
{
public static readonly long[] Value=A124460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124460.Bytes);
public long this[int i]=>Value[i];

public static A124460Inst Instance=new A124460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124461
{
public static readonly long[] Value={ 1L,2L,4L,9L,23L,66L,210L,731L,2744L,10959L,46058L,202028L,919386L,4321837L,20916763L,103958935L,529512396L,2759340117L,14690668955L,79813438230L,442057104246L,2493917931493L,14320972817368L,83652035642564L,496769855224824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124461Inst : IEnumerable<long>
{
public static readonly long[] Value=A124461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124461.Bytes);
public long this[int i]=>Value[i];

public static A124461Inst Instance=new A124461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124462
{
public static readonly long[] Value={ 1L,3L,8L,23L,73L,251L,919L,3549L,14371L,60720L,266481L,1209807L,5662008L,27238884L,134391046L,678739990L,3503708942L,18462855900L,99211177417L,543161148837L,3027439667989L,17167987227428L,98995692542858L,580166879766649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124462Inst : IEnumerable<long>
{
public static readonly long[] Value=A124462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124462.Bytes);
public long this[int i]=>Value[i];

public static A124462Inst Instance=new A124462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124463
{
public static readonly long[] Value={ 1L,4L,13L,44L,162L,637L,2622L,11188L,49293L,223768L,1044661L,5006126L,24580704L,123464593L,633467893L,3315948760L,17690431736L,96101620364L,531196784996L,2985589206506L,17053375055317L,98942675518256L,582858713958087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124463Inst : IEnumerable<long>
{
public static readonly long[] Value=A124463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124463.Bytes);
public long this[int i]=>Value[i];

public static A124463Inst Instance=new A124463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124464
{
public static readonly long[] Value={ 1L,5L,19L,73L,302L,1325L,6032L,28193L,134825L,659011L,3290110L,16764206L,87103106L,461090076L,2484768459L,13621130998L,75906831145L,429768775851L,2470872560536L,14418770507660L,85367306874021L,512604419523512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124464Inst : IEnumerable<long>
{
public static readonly long[] Value=A124464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124464.Bytes);
public long this[int i]=>Value[i];

public static A124464Inst Instance=new A124464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124465
{
public static readonly long[] Value={ 1L,6L,26L,111L,506L,2437L,12118L,61499L,317485L,1666371L,8891543L,48221602L,265708512L,1486905853L,8446728295L,48690214869L,284692228671L,1687855348715L,10143257898587L,61768997909283L,381059689323080L,2380852983417944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124465Inst : IEnumerable<long>
{
public static readonly long[] Value=A124465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124465.Bytes);
public long this[int i]=>Value[i];

public static A124465Inst Instance=new A124465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124466
{
public static readonly long[] Value={ 1L,7L,34L,159L,788L,4117L,22143L,121079L,670811L,3764758L,21408813L,123367344L,720303998L,4260491461L,25523584313L,154835572102L,950950450917L,5911757419002L,37193168793829L,236764641742504L,1524754216743136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124466Inst : IEnumerable<long>
{
public static readonly long[] Value=A124466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124466.Bytes);
public long this[int i]=>Value[i];

public static A124466Inst Instance=new A124466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124467
{
public static readonly long[] Value={ 1L,2L,8L,44L,302L,2437L,22143L,220663L,2377322L,27462836L,338270681L,4422338285L,61114545578L,889542935517L,13593252066134L,217461100417945L,3632859088845390L,63233532604594586L,1144455373221119025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124467Inst : IEnumerable<long>
{
public static readonly long[] Value=A124467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124467.Bytes);
public long this[int i]=>Value[i];

public static A124467Inst Instance=new A124467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124468
{
public static readonly long[] Value={ 1L,3L,13L,73L,506L,4117L,37703L,378529L,4106995L,47766886L,592228264L,7791350900L,108323265571L,1585742194947L,24364012940723L,391780319558565L,6577005078357973L,115010285695135090L,2090723838361780991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124468Inst : IEnumerable<long>
{
public static readonly long[] Value=A124468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124468.Bytes);
public long this[int i]=>Value[i];

public static A124468Inst Instance=new A124468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124469
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,8L,6L,1L,1L,22L,28L,11L,1L,1L,65L,120L,81L,20L,1L,1L,209L,500L,494L,219L,37L,1L,1L,730L,2088L,2733L,1812L,578L,70L,1L,1L,2743L,8884L,14411L,12904L,6299L,1518L,135L,1L,1L,10958L,38803L,74484L,84424L,56590L,21384L,4007L,264L,1L,1L,46057L,174366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124469Inst : IEnumerable<long>
{
public static readonly long[] Value=A124469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124469.Bytes);
public long this[int i]=>Value[i];

public static A124469Inst Instance=new A124469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124470
{
public static readonly long[] Value={ 1L,2L,5L,16L,63L,288L,1461L,8013L,46896L,290916L,1905162L,13131193L,95005565L,719862361L,5700083435L,47075439047L,404760508374L,3617018777976L,33539368302476L,322222320833572L,3202873385842352L,32895350423011349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124470Inst : IEnumerable<long>
{
public static readonly long[] Value=A124470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124470.Bytes);
public long this[int i]=>Value[i];

public static A124470Inst Instance=new A124470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124471
{
public static readonly long[] Value={ 52L,61L,4L,13L,20L,29L,36L,45L,14L,3L,62L,51L,46L,35L,30L,19L,53L,60L,5L,12L,21L,28L,37L,44L,11L,6L,59L,54L,43L,38L,27L,22L,55L,58L,7L,10L,23L,26L,39L,42L,9L,8L,57L,56L,41L,40L,25L,24L,50L,63L,2L,15L,18L,31L,34L,47L,16L,1L,64L,49L,48L,33L,32L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124471Inst : IEnumerable<long>
{
public static readonly long[] Value=A124471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124471.Bytes);
public long this[int i]=>Value[i];

public static A124471Inst Instance=new A124471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A124488
{
public static readonly long[] Value={ 3L,45L,6450L,18000L,22785L,41790L,54180L,77385L,87675L,98385L,103005L,104520L,151515L,187005L,210210L,244590L,256620L,320775L,329175L,354795L,382875L,387975L,431385L,495540L,509355L,528510L,632775L,763815L,804870L,810540L,812175L,849285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A124488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A124488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A124488Inst : IEnumerable<long>
{
public static readonly long[] Value=A124488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A124488.Bytes);
public long this[int i]=>Value[i];

public static A124488Inst Instance=new A124488Inst();

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