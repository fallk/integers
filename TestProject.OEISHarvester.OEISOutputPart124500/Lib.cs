using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A153805
{
public static readonly long[] Value={ 2L,8L,1L,7L,1L,8L,1L,7L,1L,5L,4L,0L,9L,5L,4L,7L,6L,4L,6L,3L,9L,7L,1L,2L,5L,2L,8L,6L,4L,7L,3L,3L,7L,5L,0L,2L,2L,4L,2L,7L,5L,2L,9L,0L,6L,3L,0L,0L,0L,4L,0L,4L,2L,5L,0L,3L,3L,0L,3L,2L,3L,7L,2L,2L,7L,5L,9L,2L,3L,3L,6L,9L,6L,4L,6L,4L,5L,2L,4L,0L,5L,4L,2L,8L,6L,1L,7L,8L,2L,1L,4L,7L,4L,8L,3L,3L,5L,7L,2L,5L,7L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153805Inst : IEnumerable<long>
{
public static readonly long[] Value=A153805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153805.Bytes);
public long this[int i]=>Value[i];

public static A153805Inst Instance=new A153805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153806
{
public static readonly long[] Value={ 0L,101L,609L,808L,906L,11011L,16091L,18081L,19061L,61019L,66099L,68089L,69069L,81018L,86098L,88088L,89068L,91016L,96096L,98086L,99066L,1110111L,1160911L,1180811L,1190611L,1610191L,1660991L,1680891L,1690691L,1810181L,1860981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153806Inst : IEnumerable<long>
{
public static readonly long[] Value=A153806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153806.Bytes);
public long this[int i]=>Value[i];

public static A153806Inst Instance=new A153806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153807
{
public static readonly long[] Value={ 101L,16091L,1160911L,1180811L,1190611L,1690691L,1880881L,1960961L,1990661L,6110119L,6610199L,6860989L,166906991L,168101891L,169609691L,188906881L,189808681L,196906961L,199609661L,616906919L,661609199L,666101999L,668609899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153807Inst : IEnumerable<long>
{
public static readonly long[] Value=A153807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153807.Bytes);
public long this[int i]=>Value[i];

public static A153807Inst Instance=new A153807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153808
{
public static readonly long[] Value={ 0L,8L,64L,168L,320L,520L,768L,1064L,1408L,1800L,2240L,2728L,3264L,3848L,4480L,5160L,5888L,6664L,7488L,8360L,9280L,10248L,11264L,12328L,13440L,14600L,15808L,17064L,18368L,19720L,21120L,22568L,24064L,25608L,27200L,28840L,30528L,32264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153808Inst : IEnumerable<long>
{
public static readonly long[] Value=A153808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153808.Bytes);
public long this[int i]=>Value[i];

public static A153808Inst Instance=new A153808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153809
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,22L,23L,24L,25L,26L,27L,29L,31L,33L,34L,35L,36L,37L,38L,39L,41L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,61L,63L,64L,65L,66L,67L,68L,69L,71L,73L,75L,76L,77L,78L,79L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153809Inst : IEnumerable<long>
{
public static readonly long[] Value=A153809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153809.Bytes);
public long this[int i]=>Value[i];

public static A153809Inst Instance=new A153809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153810
{
public static readonly long[] Value={ 4L,2L,2L,7L,8L,4L,3L,3L,5L,0L,9L,8L,4L,6L,7L,1L,3L,9L,3L,9L,3L,4L,8L,7L,9L,0L,9L,9L,1L,7L,5L,9L,7L,5L,6L,8L,9L,5L,7L,8L,4L,0L,6L,6L,4L,0L,6L,0L,0L,7L,6L,4L,0L,1L,1L,9L,4L,2L,3L,2L,7L,6L,5L,1L,1L,5L,1L,3L,2L,2L,7L,3L,2L,2L,2L,3L,3L,5L,3L,2L,9L,0L,6L,3L,0L,5L,2L,9L,3L,6L,7L,0L,8L,2L,5L,3L,2L,5L,0L,4L,8L,5L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153810Inst : IEnumerable<long>
{
public static readonly long[] Value=A153810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153810.Bytes);
public long this[int i]=>Value[i];

public static A153810Inst Instance=new A153810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153811
{
public static readonly long[] Value={ 2L,25L,25L,2L,1496L,2L,2L,26248L,26248L,2L,2L,28910L,2042176L,28910L,2L,2L,32352L,47217646L,47217646L,32352L,2L,2L,36674L,109695598L,4505535452L,109695598L,36674L,2L,2L,41976L,195465072L,129741992950L,129741992950L,195465072L,41976L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153811Inst : IEnumerable<long>
{
public static readonly long[] Value=A153811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153811.Bytes);
public long this[int i]=>Value[i];

public static A153811Inst Instance=new A153811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153812
{
public static readonly long[] Value={ 5L,11L,59L,79L,89L,109L,131L,191L,199L,241L,269L,359L,389L,431L,439L,661L,691L,829L,859L,1019L,1109L,1181L,1249L,1319L,1439L,1621L,1759L,1789L,1831L,1949L,1979L,2011L,2081L,2111L,2179L,2341L,2371L,2389L,2441L,2459L,2671L,2699L,2861L,2999L,3169L,3229L,3251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153812Inst : IEnumerable<long>
{
public static readonly long[] Value=A153812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153812.Bytes);
public long this[int i]=>Value[i];

public static A153812Inst Instance=new A153812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153813
{
public static readonly long[] Value={ 8L,3L,6L,8L,2L,8L,8L,3L,6L,9L,5L,3L,3L,8L,9L,5L,2L,9L,5L,7L,3L,1L,3L,2L,2L,4L,3L,1L,1L,3L,6L,5L,6L,8L,0L,9L,3L,1L,4L,3L,8L,3L,0L,1L,2L,7L,8L,9L,4L,1L,9L,2L,0L,3L,9L,1L,8L,0L,8L,8L,0L,1L,0L,2L,2L,4L,8L,2L,9L,5L,1L,5L,7L,2L,1L,4L,0L,2L,6L,7L,7L,2L,4L,2L,0L,9L,1L,6L,5L,2L,0L,5L,1L,0L,8L,9L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153813Inst : IEnumerable<long>
{
public static readonly long[] Value=A153813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153813.Bytes);
public long this[int i]=>Value[i];

public static A153813Inst Instance=new A153813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153814
{
public static readonly long[] Value={ 1001L,2002L,3003L,4004L,5005L,6006L,7007L,8008L,9009L,10010L,11011L,12012L,13013L,14014L,15015L,16016L,17017L,18018L,19019L,20020L,21021L,22022L,23023L,24024L,25025L,26026L,27027L,28028L,29029L,30030L,31031L,32032L,33033L,34034L,35035L,36036L,37037L,38038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153814Inst : IEnumerable<long>
{
public static readonly long[] Value=A153814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153814.Bytes);
public long this[int i]=>Value[i];

public static A153814Inst Instance=new A153814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153815
{
public static readonly long[] Value={ 127L,136L,196L,213L,233L,256L,289L,368L,379L,380L,399L,401L,462L,509L,519L,531L,568L,580L,596L,619L,627L,639L,655L,669L,693L,696L,705L,716L,729L,767L,779L,795L,796L,809L,820L,849L,858L,871L,888L,965L,994L,996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153815Inst : IEnumerable<long>
{
public static readonly long[] Value=A153815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153815.Bytes);
public long this[int i]=>Value[i];

public static A153815Inst Instance=new A153815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153816
{
public static readonly BigInteger[] Value={ 1L,29L,542L,7967L,105225L,1308095L,15639310L,181976675L,2075608136L,23314508721L,258729364359L,2843136431305L,30989792180446L,335482200606705L,3610664794156597L,38665075822637767L,412235037037411453L,4378193158484415385L,BigInteger.Parse("46340359465948601163") };
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
public class A153816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153816Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153816.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153816.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153816Inst Instance=new A153816Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153817
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,10L,13L,18L,22L,28L,33L,42L,48L,57L,65L,74L,83L,95L,105L,118L,130L,142L,155L,171L,185L,200L,216L,232L,248L,270L,286L,307L,325L,345L,365L,390L,409L,433L,454L,480L,502L,532L,555L,583L,610L,636L,665L,695L,723L,753L,784L,814L,847L,880L,913L,947L,981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153817Inst : IEnumerable<long>
{
public static readonly long[] Value=A153817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153817.Bytes);
public long this[int i]=>Value[i];

public static A153817Inst Instance=new A153817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153818
{
public static readonly long[] Value={ 1L,5L,12L,22L,35L,53L,72L,96L,123L,153L,184L,222L,260L,304L,351L,402L,453L,510L,568L,633L,697L,765L,839L,916L,994L,1077L,1164L,1252L,1342L,1443L,1535L,1641L,1747L,1856L,1969L,2083L,2200L,2321L,2447L,2579L,2705L,2844L,2979L,3123L,3269L,3417L,3570L,3726L,3881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153818Inst : IEnumerable<long>
{
public static readonly long[] Value=A153818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153818.Bytes);
public long this[int i]=>Value[i];

public static A153818Inst Instance=new A153818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153819
{
public static readonly long[] Value={ 16L,34L,88L,232L,610L,1600L,4192L,10978L,28744L,75256L,197026L,515824L,1350448L,3535522L,9256120L,24232840L,63442402L,166094368L,434840704L,1138427746L,2980442536L,7802899864L,20428257058L,53481871312L,140017356880L,366570199330L,959693241112L,2512509524008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153819Inst : IEnumerable<long>
{
public static readonly long[] Value=A153819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153819.Bytes);
public long this[int i]=>Value[i];

public static A153819Inst Instance=new A153819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153820
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,9L,60L,368L,2218L,13496L,84010L,538885L,3576885L,24624234L,176021146L,1306975716L,10078487587L,80670305273L,669699040920L,5760761324172L,51293043905644L,472213256230868L,4489889820251839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153820Inst : IEnumerable<long>
{
public static readonly long[] Value=A153820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153820.Bytes);
public long this[int i]=>Value[i];

public static A153820Inst Instance=new A153820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153821
{
public static readonly long[] Value={ 2L,5L,5L,2L,76L,2L,2L,438L,438L,2L,2L,704L,10908L,704L,2L,2L,1126L,103592L,103592L,1126L,2L,2L,1740L,320142L,3545032L,320142L,1740L,2L,2L,2582L,794802L,47373814L,47373814L,794802L,2582L,2L,2L,3688L,1757864L,224887000L,2051605292L,224887000L,1757864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153821Inst : IEnumerable<long>
{
public static readonly long[] Value=A153821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153821.Bytes);
public long this[int i]=>Value[i];

public static A153821Inst Instance=new A153821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153822
{
public static readonly long[] Value={ 2009L,2747L,5699L,10865L,14555L,19475L,21935L,23165L,26117L,28577L,34727L,37187L,41615L,45059L,47519L,51947L,54407L,55637L,56129L,56375L,61049L,67937L,69659L,73595L,78515L,80237L,86387L,94259L,99179L,100409L,101147L,105329L,114677L,118367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153822Inst : IEnumerable<long>
{
public static readonly long[] Value=A153822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153822.Bytes);
public long this[int i]=>Value[i];

public static A153822Inst Instance=new A153822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153823
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,15L,29L,59L,95L,159L,269L,539L,791L,1583L,2591L,4031L,5375L,10751L,14687L,29375L,41039L,60799L,95999L,191999L,242879L,340031L,532223L,677375L,917279L,1834559L,2332799L,4665599L,5529599L,7864319L,12165119L,16422911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153823Inst : IEnumerable<long>
{
public static readonly long[] Value=A153823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153823.Bytes);
public long this[int i]=>Value[i];

public static A153823Inst Instance=new A153823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153824
{
public static readonly ulong[] Value={ 0L,0L,1L,6L,36L,240L,1698L,14304L,118800L,1118160L,11705288L,144092256L,1738439808L,24817158912L,355309325280L,5378578601760L,86081749397280L,1570394279039040L,28281459220193088L,572031558109589760L,11458497230555094720UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153824Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A153824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153824.Bytes);
public ulong this[int i]=>Value[i];

public static A153824Inst Instance=new A153824Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153825
{
public static readonly ulong[] Value={ 0L,0L,0L,3L,29L,225L,1669L,14245L,118705L,1118001L,11705019L,144091717L,1738439017L,24817157329L,355309322689L,5378578597729L,86081749391905L,1570394279028289L,28281459220178401L,572031558109560385L,11458497230555053681UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153825Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A153825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153825.Bytes);
public ulong this[int i]=>Value[i];

public static A153825Inst Instance=new A153825Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153826
{
public static readonly long[] Value={ 0L,2L,22L,23L,24L,25L,26L,91L,276L,277L,278L,279L,280L,281L,282L,283L,284L,285L,286L,287L,288L,289L,290L,291L,292L,293L,294L,295L,296L,297L,298L,395L,531L,634L,876L,1005L,1109L,1228L,1229L,1230L,1231L,1232L,1704L,3608L,3611L,3613L,3615L,3617L,4392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153826Inst : IEnumerable<long>
{
public static readonly long[] Value=A153826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153826.Bytes);
public long this[int i]=>Value[i];

public static A153826Inst Instance=new A153826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153827
{
public static readonly long[] Value={ 0L,2L,8L,22L,23L,24L,25L,26L,45L,71L,91L,115L,119L,121L,125L,127L,276L,277L,278L,279L,280L,281L,282L,283L,284L,285L,286L,287L,288L,289L,290L,291L,292L,293L,294L,295L,296L,297L,298L,395L,396L,397L,398L,399L,514L,525L,526L,531L,532L,633L,634L,635L,636L,637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153827Inst : IEnumerable<long>
{
public static readonly long[] Value=A153827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153827.Bytes);
public long this[int i]=>Value[i];

public static A153827Inst Instance=new A153827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153828
{
public static readonly long[] Value={ 8L,45L,71L,115L,119L,121L,125L,127L,396L,397L,398L,399L,514L,525L,526L,532L,633L,635L,636L,637L,656L,657L,658L,659L,660L,661L,752L,757L,758L,874L,880L,888L,892L,993L,1001L,1120L,1121L,1126L,1127L,1156L,1157L,1168L,1169L,1174L,1175L,1347L,1394L,1395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153828Inst : IEnumerable<long>
{
public static readonly long[] Value=A153828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153828.Bytes);
public long this[int i]=>Value[i];

public static A153828Inst Instance=new A153828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153829
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,21L,27L,46L,68L,73L,74L,83L,84L,87L,88L,92L,114L,149L,169L,183L,184L,189L,190L,199L,202L,203L,225L,251L,252L,254L,261L,262L,268L,269L,270L,271L,299L,400L,515L,537L,539L,573L,575L,591L,593L,638L,753L,871L,894L,895L,990L,995L,996L,1110L,1132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153829Inst : IEnumerable<long>
{
public static readonly long[] Value=A153829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153829.Bytes);
public long this[int i]=>Value[i];

public static A153829Inst Instance=new A153829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153830
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,21L,27L,46L,92L,114L,149L,169L,225L,251L,299L,400L,638L,753L,1233L,1348L,1705L,1823L,1992L,2097L,2335L,2451L,2995L,3128L,3485L,3607L,3677L,3771L,4214L,4307L,4631L,5254L,6692L,7393L,10287L,10988L,13145L,13860L,20353L,21054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153830Inst : IEnumerable<long>
{
public static readonly long[] Value=A153830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153830.Bytes);
public long this[int i]=>Value[i];

public static A153830Inst Instance=new A153830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153831
{
public static readonly long[] Value={ 68L,73L,74L,83L,84L,87L,88L,183L,184L,189L,190L,199L,202L,203L,252L,254L,261L,262L,268L,269L,270L,271L,515L,537L,539L,573L,575L,591L,593L,871L,894L,895L,990L,995L,996L,1110L,1132L,1134L,1466L,1489L,1490L,1585L,1590L,1591L,1600L,1601L,1604L,1605L,2213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153831Inst : IEnumerable<long>
{
public static readonly long[] Value=A153831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153831.Bytes);
public long this[int i]=>Value[i];

public static A153831Inst Instance=new A153831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153832
{
public static readonly long[] Value={ 0L,15L,3617L,3677L,3690L,3721L,3744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153832Inst : IEnumerable<long>
{
public static readonly long[] Value=A153832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153832.Bytes);
public long this[int i]=>Value[i];

public static A153832Inst Instance=new A153832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153833
{
public static readonly long[] Value={ 0L,21L,3613L,3771L,3906L,3929L,3783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153833Inst : IEnumerable<long>
{
public static readonly long[] Value=A153833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153833.Bytes);
public long this[int i]=>Value[i];

public static A153833Inst Instance=new A153833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153834
{
public static readonly long[] Value={ 0L,3L,23L,27L,29L,33L,35L,46L,50L,52L,56L,58L,3655L,3659L,3667L,3677L,3681L,3747L,3751L,3759L,3763L,3771L,277L,281L,283L,287L,289L,299L,301L,305L,307L,311L,313L,323L,325L,329L,331L,335L,337L,347L,349L,353L,355L,359L,361L,396L,400L,402L,406L,408L,418L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153834Inst : IEnumerable<long>
{
public static readonly long[] Value=A153834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153834.Bytes);
public long this[int i]=>Value[i];

public static A153834Inst Instance=new A153834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153835
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,4L,6L,4L,4L,9L,9L,11L,9L,9L,14L,14L,14L,9L,9L,14L,11L,9L,9L,23L,23L,25L,23L,23L,28L,28L,28L,23L,23L,28L,25L,23L,23L,37L,37L,39L,37L,37L,42L,42L,37L,23L,23L,37L,25L,23L,23L,42L,42L,39L,28L,28L,37L,28L,23L,23L,37L,28L,25L,23L,23L,65L,65L,67L,65L,65L,70L,70L,70L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153835Inst : IEnumerable<long>
{
public static readonly long[] Value=A153835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153835.Bytes);
public long this[int i]=>Value[i];

public static A153835Inst Instance=new A153835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153836
{
public static readonly BigInteger[] Value={ 0L,0L,8L,384L,57344L,31457280L,66571993088L,554153860399104L,18302628885633695744UL,BigInteger.Parse("2408406906263519058984960"),BigInteger.Parse("1265174720149658640946904956928"),BigInteger.Parse("2655859843140564331993348872396079104"),BigInteger.Parse("22289856162789153110704890285210544923213824") };
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
public class A153836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153836Inst Instance=new A153836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153837
{
public static readonly long[] Value={ 1791L,1791L,1791L,1791L,1791L,1791L,1791L,1791L,1791L,1791L,1795L,1804L,1865L,1868L,1870L,1913L,1913L,1933L,1920L,1933L,1933L,1951L,1961L,1964L,1967L,1971L,1992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153837Inst : IEnumerable<long>
{
public static readonly long[] Value=A153837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153837.Bytes);
public long this[int i]=>Value[i];

public static A153837Inst Instance=new A153837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153838
{
public static readonly long[] Value={ 1L,3L,6L,9L,12L,21L,24L,27L,30L,45L,66L,69L,84L,105L,156L,192L,195L,222L,273L,366L,504L,528L,531L,558L,717L,912L,1236L,1536L,1539L,1572L,1581L,1797L,2346L,3060L,4008L,4464L,4467L,4500L,4725L,5940L,7752L,10128L,12480L,12483L,12516L,12522L,12741L,12825L,13959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153838Inst : IEnumerable<long>
{
public static readonly long[] Value=A153838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153838.Bytes);
public long this[int i]=>Value[i];

public static A153838Inst Instance=new A153838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153839
{
public static readonly long[] Value={ 1L,5L,5L,2L,7L,4L,2L,6L,3L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153839Inst : IEnumerable<long>
{
public static readonly long[] Value=A153839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153839.Bytes);
public long this[int i]=>Value[i];

public static A153839Inst Instance=new A153839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153840
{
public static readonly long[] Value={ 7L,4L,4L,1L,6L,3L,1L,5L,2L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153840Inst : IEnumerable<long>
{
public static readonly long[] Value=A153840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153840.Bytes);
public long this[int i]=>Value[i];

public static A153840Inst Instance=new A153840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153841
{
public static readonly long[] Value={ 6L,3L,3L,7L,5L,2L,7L,4L,1L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153841Inst : IEnumerable<long>
{
public static readonly long[] Value=A153841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153841.Bytes);
public long this[int i]=>Value[i];

public static A153841Inst Instance=new A153841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153842
{
public static readonly long[] Value={ 5L,2L,2L,6L,4L,1L,6L,3L,7L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153842Inst : IEnumerable<long>
{
public static readonly long[] Value=A153842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153842.Bytes);
public long this[int i]=>Value[i];

public static A153842Inst Instance=new A153842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153843
{
public static readonly long[] Value={ 4L,1L,1L,5L,3L,7L,5L,2L,6L,4L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153843Inst : IEnumerable<long>
{
public static readonly long[] Value=A153843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153843.Bytes);
public long this[int i]=>Value[i];

public static A153843Inst Instance=new A153843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153844
{
public static readonly long[] Value={ 3L,7L,7L,4L,2L,6L,4L,1L,5L,3L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153844Inst : IEnumerable<long>
{
public static readonly long[] Value=A153844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153844.Bytes);
public long this[int i]=>Value[i];

public static A153844Inst Instance=new A153844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153845
{
public static readonly long[] Value={ 2L,6L,6L,3L,1L,5L,3L,7L,4L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153845Inst : IEnumerable<long>
{
public static readonly long[] Value=A153845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153845.Bytes);
public long this[int i]=>Value[i];

public static A153845Inst Instance=new A153845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153846
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,4L,4L,6L,3L,11L,4L,7L,10L,10L,5L,14L,5L,17L,12L,11L,6L,28L,10L,14L,13L,21L,8L,35L,8L,22L,17L,18L,17L,41L,10L,19L,20L,40L,11L,44L,11L,31L,32L,23L,12L,60L,16L,36L,25L,37L,14L,49L,24L,50L,27L,30L,15L,93L,16L,31L,40L,46L,29L,64L,17L,47L,32L,63L,18L,96L,19L,38L,49L,51L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153846Inst : IEnumerable<long>
{
public static readonly long[] Value=A153846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153846.Bytes);
public long this[int i]=>Value[i];

public static A153846Inst Instance=new A153846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153847
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,4L,3L,7L,4L,5L,7L,6L,5L,8L,5L,10L,9L,8L,6L,14L,8L,10L,9L,13L,8L,19L,8L,12L,13L,13L,13L,19L,10L,14L,15L,20L,11L,25L,11L,19L,19L,17L,12L,26L,14L,22L,19L,22L,14L,26L,19L,26L,21L,22L,15L,40L,16L,23L,25L,24L,23L,37L,17L,28L,25L,37L,18L,38L,19L,28L,31L,31L,25L,43L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153847Inst : IEnumerable<long>
{
public static readonly long[] Value=A153847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153847.Bytes);
public long this[int i]=>Value[i];

public static A153847Inst Instance=new A153847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153848
{
public static readonly BigInteger[] Value={ 21L,2121L,212121L,21212121L,2121212121L,212121212121L,21212121212121L,2121212121212121L,212121212121212121L,BigInteger.Parse("21212121212121212121"),BigInteger.Parse("2121212121212121212121"),BigInteger.Parse("212121212121212121212121") };
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
public class A153848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153848Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153848.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153848.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153848Inst Instance=new A153848Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153849
{
public static readonly BigInteger[] Value={ 1L,1L,4L,40L,675L,16023L,488264L,18150408L,798091737L,40691618165L,2372928554920L,156676126511294L,11619829396974162L,961567152709817189L,BigInteger.Parse("88268869225674860344"),BigInteger.Parse("8941327301073770038304"),BigInteger.Parse("994670849523023025795108") };
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
public class A153849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153849Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153849.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153849.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153849Inst Instance=new A153849Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153850
{
public static readonly BigInteger[] Value={ 1L,2L,27L,594L,17180L,603879L,24795645L,1160887350L,60940292571L,3541938123306L,225669592036086L,15634133444509443L,1169781625911185118L,BigInteger.Parse("93989088711427170141"),BigInteger.Parse("8069678384570571946581"),BigInteger.Parse("737204558292074214218778") };
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
public class A153850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153850Inst Instance=new A153850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153851
{
public static readonly BigInteger[] Value={ 1L,1L,6L,57L,683L,9474L,145815L,2430393L,43202448L,810629805L,15938815794L,326653743510L,6949638584208L,153009877730525L,3477623225388063L,81429702521625843L,1961136442605508341L,BigInteger.Parse("48513571089988199157") };
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
public class A153851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153851Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153851.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153851.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153851Inst Instance=new A153851Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153852
{
public static readonly BigInteger[] Value={ 1L,2L,15L,165L,2213L,33693L,561867L,10053141L,190489374L,3788856192L,78613758564L,1693737431667L,37760673462507L,868775517322730L,20583609967109565L,501340716386677815L,12535093359045980151UL,BigInteger.Parse("321360932709750239226") };
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
public class A153852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153852Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153852.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153852.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153852Inst Instance=new A153852Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153853
{
public static readonly BigInteger[] Value={ 1L,3L,27L,339L,5067L,84738L,1536867L,29687772L,603835479L,12831704772L,283320533673L,6473430313902L,152586247226958L,3701535783215857L,92238331155559794L,2357440730629390878L,BigInteger.Parse("61720161749858023305") };
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
public class A153853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153853Inst Instance=new A153853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153854
{
public static readonly BigInteger[] Value={ 1L,4L,42L,594L,9827L,179928L,3545637L,73988631L,1618178067L,36832568283L,868184365137L,21113629246953L,528282055072773L,13569770211307323L,357215846155083585L,9623529095387448543UL,BigInteger.Parse("265025641890780905892") };
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
public class A153854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153854Inst Instance=new A153854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153855
{
public static readonly long[] Value={ 8L,1L,0L,7L,1L,4L,4L,6L,3L,2L,8L,1L,9L,5L,9L,2L,2L,3L,8L,8L,2L,3L,2L,4L,0L,1L,0L,3L,5L,1L,9L,2L,6L,8L,8L,3L,1L,9L,5L,9L,3L,2L,6L,0L,6L,9L,4L,1L,0L,4L,3L,4L,4L,8L,2L,0L,8L,3L,4L,7L,4L,4L,2L,0L,2L,1L,0L,2L,7L,0L,8L,1L,2L,0L,3L,3L,5L,9L,3L,6L,0L,9L,0L,9L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153855Inst : IEnumerable<long>
{
public static readonly long[] Value=A153855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153855.Bytes);
public long this[int i]=>Value[i];

public static A153855Inst Instance=new A153855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153856
{
public static readonly long[] Value={ 7L,8L,7L,9L,4L,8L,6L,0L,5L,1L,1L,1L,5L,8L,0L,6L,4L,3L,9L,3L,6L,7L,2L,0L,6L,0L,5L,6L,9L,5L,2L,4L,2L,1L,6L,1L,8L,0L,1L,9L,8L,4L,7L,8L,4L,1L,2L,0L,7L,5L,9L,4L,2L,9L,6L,7L,6L,1L,2L,7L,6L,9L,8L,3L,2L,3L,0L,8L,8L,1L,4L,9L,9L,9L,2L,5L,5L,2L,6L,3L,8L,8L,6L,2L,5L,4L,7L,5L,7L,7L,0L,5L,4L,4L,7L,5L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153856Inst : IEnumerable<long>
{
public static readonly long[] Value=A153856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153856.Bytes);
public long this[int i]=>Value[i];

public static A153856Inst Instance=new A153856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153857
{
public static readonly long[] Value={ 7L,6L,7L,8L,7L,4L,0L,7L,4L,4L,2L,9L,4L,4L,6L,4L,6L,8L,1L,6L,3L,0L,3L,3L,0L,3L,6L,5L,9L,4L,4L,0L,6L,8L,1L,1L,2L,1L,4L,8L,2L,5L,6L,3L,9L,2L,7L,6L,7L,0L,3L,4L,2L,6L,8L,0L,5L,5L,4L,6L,2L,9L,2L,7L,8L,8L,8L,5L,7L,6L,5L,9L,3L,1L,6L,5L,1L,7L,4L,8L,3L,5L,4L,4L,1L,8L,2L,7L,5L,1L,5L,5L,8L,8L,5L,8L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153857Inst : IEnumerable<long>
{
public static readonly long[] Value=A153857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153857.Bytes);
public long this[int i]=>Value[i];

public static A153857Inst Instance=new A153857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153858
{
public static readonly long[] Value={ 7L,3L,3L,9L,5L,1L,6L,2L,6L,3L,5L,4L,6L,7L,8L,0L,9L,1L,1L,6L,9L,2L,8L,4L,4L,7L,3L,6L,9L,5L,9L,3L,3L,4L,2L,2L,1L,8L,2L,7L,8L,2L,8L,9L,6L,8L,2L,5L,0L,9L,1L,0L,9L,3L,3L,5L,9L,0L,5L,1L,1L,7L,7L,5L,8L,1L,5L,9L,1L,9L,3L,3L,4L,7L,1L,1L,5L,8L,0L,5L,7L,8L,4L,7L,8L,2L,9L,5L,5L,6L,4L,1L,4L,4L,0L,0L,9L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153858Inst : IEnumerable<long>
{
public static readonly long[] Value=A153858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153858.Bytes);
public long this[int i]=>Value[i];

public static A153858Inst Instance=new A153858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153859
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,2L,1L,4L,6L,8L,4L,1L,5L,10L,20L,20L,9L,1L,6L,15L,40L,60L,54L,23L,1L,7L,21L,70L,140L,189L,161L,65L,1L,8L,28L,112L,280L,504L,644L,520L,199L,1L,9L,36L,168L,504L,1134L,1932L,2340L,1791L,654L,1L,10L,45L,240L,840L,2268L,4830L,7800L,8955L,6540L,2296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153859Inst : IEnumerable<long>
{
public static readonly long[] Value=A153859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153859.Bytes);
public long this[int i]=>Value[i];

public static A153859Inst Instance=new A153859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153860
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,-1L,0L,1L,1L,1L,0L,0L,1L,1L,-1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,-1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153860Inst : IEnumerable<long>
{
public static readonly long[] Value=A153860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153860.Bytes);
public long this[int i]=>Value[i];

public static A153860Inst Instance=new A153860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153861
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,3L,6L,4L,1L,4L,10L,10L,5L,1L,5L,15L,20L,15L,6L,1L,6L,21L,35L,35L,21L,7L,1L,7L,28L,56L,70L,56L,28L,8L,1L,8L,36L,84L,126L,126L,84L,36L,9L,1L,9L,45L,120L,210L,252L,210L,120L,45L,10L,1L,10L,55L,165L,330L,462L,462L,330L,165L,55L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153861Inst : IEnumerable<long>
{
public static readonly long[] Value=A153861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153861.Bytes);
public long this[int i]=>Value[i];

public static A153861Inst Instance=new A153861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153862
{
public static readonly BigInteger[] Value={ 1L,1L,3L,5L,21L,55L,233L,377L,987L,317811L,5702887L,39088169L,701408733L,12586269025L,591286729879L,72723460248141L,3416454622906707L,BigInteger.Parse("43566776258854844738105") };
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
public class A153862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153862Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153862.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153862.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153862Inst Instance=new A153862Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153863
{
public static readonly BigInteger[] Value={ 1L,2L,5L,8L,34L,89L,377L,610L,1597L,514229L,9227465L,63245986L,1134903170L,20365011074L,956722026041L,117669030460994L,5527939700884757L,BigInteger.Parse("70492524767089125814114"),BigInteger.Parse("44225333398004061429732838340729878012027363723832270745251370289") };
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
public class A153863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153863.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153863Inst Instance=new A153863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153864
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,2L,2L,3L,2L,2L,2L,6L,3L,1L,2L,2L,6L,6L,7L,2L,2L,2L,6L,6L,14L,9L,1L,2L,2L,6L,6L,14L,18L,17L,2L,2L,2L,6L,6L,14L,18L,34L,25L,1L,2L,2L,6L,6L,14L,18L,34L,50L,43L,2L,2L,2L,6L,6L,14L,18L,34L,50L,86L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153864Inst : IEnumerable<long>
{
public static readonly long[] Value=A153864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153864.Bytes);
public long this[int i]=>Value[i];

public static A153864Inst Instance=new A153864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153865
{
public static readonly BigInteger[] Value={ 2L,3L,8L,13L,55L,144L,610L,987L,2584L,832040L,14930352L,102334155L,1836311903L,32951280099L,1548008755920L,190392490709135L,8944394323791464L,BigInteger.Parse("114059301025943970552219") };
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
public class A153865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153865.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153865Inst Instance=new A153865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153866
{
public static readonly BigInteger[] Value={ 3L,5L,13L,21L,89L,233L,987L,1597L,4181L,1346269L,24157817L,165580141L,2971215073L,53316291173L,2504730781961L,308061521170129L,14472334024676221L,BigInteger.Parse("184551825793033096366333") };
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
public class A153866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153866.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153866Inst Instance=new A153866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153867
{
public static readonly BigInteger[] Value={ 7L,11L,29L,47L,199L,521L,2207L,3571L,9349L,3010349L,54018521L,370248451L,6643838879L,119218851371L,5600748293801L,688846502588399L,32361122672259149L,BigInteger.Parse("412670427844921037470771"),BigInteger.Parse("258899611203303418721656157249445530046830073044201152332257717521") };
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
public class A153867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153867Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153867.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153867.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153867Inst Instance=new A153867Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153868
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,3L,4L,6L,12L,9L,5L,10L,30L,45L,31L,6L,15L,60L,135L,186L,121L,7L,21L,105L,315L,651L,847L,523L,8L,28L,168L,630L,1736L,3388L,4184L,2469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153868Inst : IEnumerable<long>
{
public static readonly long[] Value=A153868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153868.Bytes);
public long this[int i]=>Value[i];

public static A153868Inst Instance=new A153868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153869
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,0L,2L,3L,0L,0L,0L,3L,4L,0L,0L,0L,0L,4L,5L,0L,0L,0L,0L,0L,5L,6L,0L,0L,0L,0L,0L,0L,6L,7L,0L,0L,0L,0L,0L,0L,0L,7L,8L,0L,0L,0L,0L,0L,0L,0L,0L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153869Inst : IEnumerable<long>
{
public static readonly long[] Value=A153869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153869.Bytes);
public long this[int i]=>Value[i];

public static A153869Inst Instance=new A153869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153870
{
public static readonly long[] Value={ 7L,1L,9L,4L,3L,7L,3L,9L,9L,7L,0L,4L,3L,9L,4L,3L,3L,4L,2L,0L,7L,0L,5L,2L,4L,9L,4L,7L,3L,1L,5L,6L,9L,1L,8L,5L,3L,0L,4L,5L,3L,3L,7L,9L,0L,0L,5L,7L,2L,1L,1L,6L,9L,7L,9L,3L,5L,9L,3L,4L,7L,0L,2L,1L,4L,4L,7L,3L,8L,7L,1L,7L,2L,2L,9L,5L,6L,8L,6L,3L,4L,5L,5L,1L,9L,6L,6L,9L,2L,4L,4L,4L,0L,4L,2L,3L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153870Inst : IEnumerable<long>
{
public static readonly long[] Value=A153870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153870.Bytes);
public long this[int i]=>Value[i];

public static A153870Inst Instance=new A153870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153871
{
public static readonly long[] Value={ 7L,0L,6L,2L,2L,6L,7L,4L,0L,0L,9L,9L,9L,1L,4L,7L,0L,9L,3L,4L,0L,8L,9L,6L,3L,8L,0L,1L,1L,0L,5L,2L,5L,5L,6L,1L,5L,0L,6L,2L,2L,0L,3L,2L,9L,8L,8L,3L,4L,4L,8L,1L,4L,1L,8L,6L,4L,3L,9L,7L,1L,0L,5L,5L,0L,8L,5L,7L,1L,9L,0L,6L,3L,9L,6L,1L,6L,3L,4L,4L,5L,2L,5L,7L,3L,2L,0L,1L,3L,7L,6L,2L,4L,3L,5L,0L,9L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153871Inst : IEnumerable<long>
{
public static readonly long[] Value=A153871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153871.Bytes);
public long this[int i]=>Value[i];

public static A153871Inst Instance=new A153871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153872
{
public static readonly long[] Value={ 6L,9L,4L,1L,3L,4L,6L,3L,9L,4L,7L,9L,2L,7L,7L,5L,2L,2L,7L,9L,1L,0L,9L,3L,1L,0L,3L,2L,9L,2L,9L,2L,1L,4L,8L,7L,6L,7L,2L,8L,9L,6L,5L,2L,2L,1L,2L,0L,6L,9L,7L,5L,8L,5L,5L,1L,8L,8L,5L,3L,3L,8L,2L,3L,4L,0L,5L,7L,3L,6L,6L,2L,0L,9L,0L,4L,7L,5L,1L,5L,4L,1L,4L,1L,8L,9L,6L,7L,5L,2L,1L,3L,4L,2L,6L,1L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153872Inst : IEnumerable<long>
{
public static readonly long[] Value=A153872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153872.Bytes);
public long this[int i]=>Value[i];

public static A153872Inst Instance=new A153872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153873
{
public static readonly long[] Value={ 8L,17L,44L,116L,305L,800L,2096L,5489L,14372L,37628L,98513L,257912L,675224L,1767761L,4628060L,12116420L,31721201L,83047184L,217420352L,569213873L,1490221268L,3901449932L,10214128529L,26740935656L,70008678440L,183285099665L,479846620556L,1256254762004L,3288917665457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153873Inst : IEnumerable<long>
{
public static readonly long[] Value=A153873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153873.Bytes);
public long this[int i]=>Value[i];

public static A153873Inst Instance=new A153873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153874
{
public static readonly long[] Value={ 143L,323L,11663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153874Inst : IEnumerable<long>
{
public static readonly long[] Value=A153874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153874.Bytes);
public long this[int i]=>Value[i];

public static A153874Inst Instance=new A153874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153875
{
public static readonly long[] Value={ 0L,3L,39L,108L,210L,345L,513L,714L,948L,1215L,1515L,1848L,2214L,2613L,3045L,3510L,4008L,4539L,5103L,5700L,6330L,6993L,7689L,8418L,9180L,9975L,10803L,11664L,12558L,13485L,14445L,15438L,16464L,17523L,18615L,19740L,20898L,22089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153875Inst : IEnumerable<long>
{
public static readonly long[] Value=A153875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153875.Bytes);
public long this[int i]=>Value[i];

public static A153875Inst Instance=new A153875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153876
{
public static readonly long[] Value={ 1L,4L,11L,29L,68L,160L,364L,820L,1813L,3981L,8674L,18782L,40387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153876Inst : IEnumerable<long>
{
public static readonly long[] Value=A153876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153876.Bytes);
public long this[int i]=>Value[i];

public static A153876Inst Instance=new A153876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153877
{
public static readonly long[] Value={ 6L,12L,30L,36L,48L,54L,84L,114L,120L,132L,162L,204L,210L,246L,258L,264L,324L,390L,426L,462L,468L,510L,546L,558L,594L,600L,624L,660L,666L,672L,678L,708L,786L,804L,810L,846L,852L,930L,960L,1002L,1020L,1056L,1104L,1128L,1170L,1176L,1218L,1254L,1260L,1272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153877Inst : IEnumerable<long>
{
public static readonly long[] Value=A153877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153877.Bytes);
public long this[int i]=>Value[i];

public static A153877Inst Instance=new A153877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153878
{
public static readonly long[] Value={ 2L,3L,3L,2L,44L,2L,2L,310L,310L,2L,2L,728L,9772L,728L,2L,2L,1486L,127680L,127680L,1486L,2L,2L,2684L,564510L,6099016L,564510L,2684L,2L,2L,4422L,1857042L,117489766L,117489766L,1857042L,4422L,2L,2L,6800L,5050056L,789984688L,7480610540L,789984688L,5050056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153878Inst : IEnumerable<long>
{
public static readonly long[] Value=A153878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153878.Bytes);
public long this[int i]=>Value[i];

public static A153878Inst Instance=new A153878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153879
{
public static readonly long[] Value={ 2L,5L,5L,2L,96L,2L,2L,748L,748L,2L,2L,1290L,27416L,1290L,2L,2L,2212L,372786L,372786L,2212L,2L,2L,3614L,1277998L,19936772L,1277998L,3614L,2L,2L,5596L,3471492L,390272910L,390272910L,3471492L,5596L,2L,2L,8258L,8283708L,2093481742L,27296452580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153879Inst : IEnumerable<long>
{
public static readonly long[] Value=A153879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153879.Bytes);
public long this[int i]=>Value[i];

public static A153879Inst Instance=new A153879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153880
{
public static readonly long[] Value={ 0L,2L,6L,8L,12L,14L,24L,26L,30L,32L,36L,38L,48L,50L,54L,56L,60L,62L,72L,74L,78L,80L,84L,86L,120L,122L,126L,128L,132L,134L,144L,146L,150L,152L,156L,158L,168L,170L,174L,176L,180L,182L,192L,194L,198L,200L,204L,206L,240L,242L,246L,248L,252L,254L,264L,266L,270L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153880Inst : IEnumerable<long>
{
public static readonly long[] Value=A153880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153880.Bytes);
public long this[int i]=>Value[i];

public static A153880Inst Instance=new A153880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153881
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153881Inst : IEnumerable<long>
{
public static readonly long[] Value=A153881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153881.Bytes);
public long this[int i]=>Value[i];

public static A153881Inst Instance=new A153881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153882
{
public static readonly long[] Value={ 1L,12L,113L,984L,8305L,69156L,572417L,4725168L,38957089L,321004860L,2644388561L,21781512072L,179402099473L,1477598319444L,12169714749665L,100231029093216L,825511191878977L,6798972400658028L,55996821859648049L,461193717895377720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153882Inst : IEnumerable<long>
{
public static readonly long[] Value=A153882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153882.Bytes);
public long this[int i]=>Value[i];

public static A153882Inst Instance=new A153882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153883
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,12L,13L,15L,16L,18L,19L,24L,25L,27L,28L,30L,31L,36L,37L,39L,40L,42L,43L,60L,61L,63L,64L,66L,67L,72L,73L,75L,76L,78L,79L,84L,85L,87L,88L,90L,91L,96L,97L,99L,100L,102L,103L,120L,121L,123L,124L,126L,127L,132L,133L,135L,136L,138L,139L,144L,145L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153883Inst : IEnumerable<long>
{
public static readonly long[] Value=A153883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153883.Bytes);
public long this[int i]=>Value[i];

public static A153883Inst Instance=new A153883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153884
{
public static readonly long[] Value={ 1L,14L,152L,1512L,14480L,136192L,1269568L,11781504L,109080064L,1008734720L,9322763264L,86134358016L,795679428608L,7349600247808L,67884508610560L,627000709644288L,5791091556155392L,53487250561826816L,494013479394738176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153884Inst : IEnumerable<long>
{
public static readonly long[] Value=A153884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153884.Bytes);
public long this[int i]=>Value[i];

public static A153884Inst Instance=new A153884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153885
{
public static readonly BigInteger[] Value={ 1L,16L,197L,2208L,23705L,249008L,2585533L,26677056L,274286449L,2814636880L,28851289589L,295557057504L,3026686834313L,30989122956272L,317251444075885L,3247664850794112L,33244802412228577L,340304612398804624L,3483430456059387941L,BigInteger.Parse("35656915165420734240") };
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
public class A153885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153885Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153885.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153885.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153885Inst Instance=new A153885Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153886
{
public static readonly BigInteger[] Value={ 1L,18L,248L,3096L,36880L,428544L,4910912L,55827072L,631657984L,7126986240L,80279745536L,903384465408L,10159659716608L,114216655527936L,1283765661040640L,14427316078608384L,162125499175862272L,1821782963191283712L,BigInteger.Parse("20470555400077574144") };
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
public class A153886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153886.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153886Inst Instance=new A153886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153887
{
public static readonly BigInteger[] Value={ 0L,1L,2L,8L,89L,144L,2584L,121393L,196418L,832040L,20365011074L,4052739537881L,8944394323791464L,99194853094755497L,2880067194370816120L,BigInteger.Parse("14028366653498915298923761"),BigInteger.Parse("96151855463018422468774568") };
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
public class A153887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153887Inst Instance=new A153887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153888
{
public static readonly BigInteger[] Value={ 1L,2L,3L,13L,144L,233L,4181L,196418L,317811L,1346269L,32951280099L,6557470319842L,14472334024676221L,160500643816367088L,4660046610375530309L,BigInteger.Parse("22698374052006863956975682"),BigInteger.Parse("155576970220531065681649693") };
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
public class A153888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153888Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153888.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153888.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153888Inst Instance=new A153888Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153889
{
public static readonly BigInteger[] Value={ 1L,3L,5L,21L,233L,377L,6765L,317811L,514229L,2178309L,53316291173L,10610209857723L,23416728348467685L,259695496911122585L,7540113804746346429L,BigInteger.Parse("36726740705505779255899443"),BigInteger.Parse("251728825683549488150424261") };
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
public class A153889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153889Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153889.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153889.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153889Inst Instance=new A153889Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153890
{
public static readonly BigInteger[] Value={ 2L,5L,8L,34L,377L,610L,10946L,514229L,832040L,3524578L,86267571272L,17167680177565L,37889062373143906L,420196140727489673L,12200160415121876738UL,BigInteger.Parse("59425114757512643212875125") };
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
public class A153890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153890Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153890.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153890.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153890Inst Instance=new A153890Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153891
{
public static readonly BigInteger[] Value={ 3L,8L,13L,55L,610L,987L,17711L,832040L,1346269L,5702887L,139583862445L,27777890035288L,61305790721611591L,679891637638612258L,BigInteger.Parse("19740274219868223167"),BigInteger.Parse("96151855463018422468774568"),BigInteger.Parse("659034621587630041982498215") };
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
public class A153891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153891Inst Instance=new A153891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153892
{
public static readonly BigInteger[] Value={ 7L,19L,31L,131L,1453L,2351L,42187L,1981891L,3206767L,13584083L,332484016063L,66165989928299L,146028309791690867L,1619478772188347101L,BigInteger.Parse("47020662244482792763"),BigInteger.Parse("229030451631542624193448579") };
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
public class A153892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153892Inst Instance=new A153892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153893
{
public static readonly long[] Value={ 2L,5L,11L,23L,47L,95L,191L,383L,767L,1535L,3071L,6143L,12287L,24575L,49151L,98303L,196607L,393215L,786431L,1572863L,3145727L,6291455L,12582911L,25165823L,50331647L,100663295L,201326591L,402653183L,805306367L,1610612735L,3221225471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153893Inst : IEnumerable<long>
{
public static readonly long[] Value=A153893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153893.Bytes);
public long this[int i]=>Value[i];

public static A153893Inst Instance=new A153893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153894
{
public static readonly long[] Value={ 4L,9L,19L,39L,79L,159L,319L,639L,1279L,2559L,5119L,10239L,20479L,40959L,81919L,163839L,327679L,655359L,1310719L,2621439L,5242879L,10485759L,20971519L,41943039L,83886079L,167772159L,335544319L,671088639L,1342177279L,2684354559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153894Inst : IEnumerable<long>
{
public static readonly long[] Value=A153894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153894.Bytes);
public long this[int i]=>Value[i];

public static A153894Inst Instance=new A153894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153895
{
public static readonly long[] Value={ 6L,8L,3L,0L,1L,0L,7L,4L,6L,0L,9L,0L,8L,5L,8L,9L,9L,3L,9L,4L,6L,2L,2L,7L,9L,1L,6L,3L,0L,2L,6L,7L,2L,9L,8L,6L,9L,2L,3L,1L,9L,6L,7L,7L,3L,7L,2L,3L,9L,6L,9L,8L,8L,8L,5L,0L,1L,2L,2L,4L,8L,7L,0L,1L,4L,6L,8L,2L,6L,0L,5L,2L,7L,7L,0L,5L,6L,4L,3L,0L,2L,7L,4L,8L,6L,5L,3L,4L,4L,4L,5L,8L,0L,2L,0L,2L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153895Inst : IEnumerable<long>
{
public static readonly long[] Value=A153895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153895.Bytes);
public long this[int i]=>Value[i];

public static A153895Inst Instance=new A153895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153896
{
public static readonly long[] Value={ 1L,2L,1L,2L,6L,6L,12L,54L,68L,200L,1266L,2320L,9256L,81946L,206828L,1160264L,14343496L,50776328L,396238264L,6835424230L,33707147400L,367462965472L,8846443274706L,60917276216360L,926358873081664L,31121060447968362L,298982889913216056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153896Inst : IEnumerable<long>
{
public static readonly long[] Value=A153896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153896.Bytes);
public long this[int i]=>Value[i];

public static A153896Inst Instance=new A153896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153897
{
public static readonly BigInteger[] Value={ 1L,2L,2L,6L,10L,38L,84L,462L,1454L,10978L,47966L,507832L,3102956L,45765610L,389928206L,8030198134L,95507073248L,2744133148026L,45539464036516L,1826082647001502L,42290971759195390L,2366417546297792380L,BigInteger.Parse("76478152220819322380") };
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
public class A153897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A153897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A153897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A153897Inst Instance=new A153897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153898
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,4L,4L,20L,12L,32L,92L,128L,192L,1340L,1080L,3984L,16104L,31168L,66032L,644436L,720896L,3702816L,20885084L,56396000L,167145024L,2277052636L,3551548720L,25448231520L,200265789844L,754613710528L,3122443069456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153898Inst : IEnumerable<long>
{
public static readonly long[] Value=A153898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153898.Bytes);
public long this[int i]=>Value[i];

public static A153898Inst Instance=new A153898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153899
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,4L,6L,13L,17L,34L,101L,146L,325L,1195L,2277L,6460L,27376L,61961L,214755L,1116386L,3024411L,12485340L,79544755L,263062079L,1324332721L,10146383904L,40752385354L,249319033030L,2314746073775L,11234416498141L,83071107149999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153899Inst : IEnumerable<long>
{
public static readonly long[] Value=A153899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153899.Bytes);
public long this[int i]=>Value[i];

public static A153899Inst Instance=new A153899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153900
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,10L,18L,48L,97L,299L,769L,2879L,9061L,41454L,154622L,857522L,3902066L,26137942L,144826739L,1177942368L,7878440446L,77715100928L,630332738835L,7530329483705L,74116147914872L,1073536700395590L,12799994974031763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153900Inst : IEnumerable<long>
{
public static readonly long[] Value=A153900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153900.Bytes);
public long this[int i]=>Value[i];

public static A153900Inst Instance=new A153900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153901
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,2L,7L,3L,6L,15L,12L,17L,63L,47L,86L,272L,269L,423L,2020L,1609L,3902L,14951L,18193L,36083L,200112L,201396L,575152L,2652677L,3907855L,9200561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153901Inst : IEnumerable<long>
{
public static readonly long[] Value=A153901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153901.Bytes);
public long this[int i]=>Value[i];

public static A153901Inst Instance=new A153901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153902
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,2L,4L,8L,9L,13L,28L,40L,68L,188L,247L,498L,1534L,2240L,5457L,19030L,34984L,92787L,351730L,736460L,2179274L,9660082L,22277066L,75466794L,381461162L,984019235L,3823360536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153902Inst : IEnumerable<long>
{
public static readonly long[] Value=A153902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153902.Bytes);
public long this[int i]=>Value[i];

public static A153902Inst Instance=new A153902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153903
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,7L,10L,21L,34L,88L,150L,421L,807L,2708L,6019L,22444L,58037L,245472L,706322L,3364913L,10967191L,59955069L,222028350L,1374087876L,5812458172L,40846719268L,195779164954L,1558347753536L,8466932734756L,76665491618022L,472779311230382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153903Inst : IEnumerable<long>
{
public static readonly long[] Value=A153903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153903.Bytes);
public long this[int i]=>Value[i];

public static A153903Inst Instance=new A153903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A153904
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,2L,2L,4L,3L,5L,6L,8L,8L,24L,15L,28L,52L,66L,85L,246L,226L,453L,898L,1300L,1806L,6204L,5820L,13820L,31156L,51179L,81402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A153904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A153904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A153904Inst : IEnumerable<long>
{
public static readonly long[] Value=A153904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A153904.Bytes);
public long this[int i]=>Value[i];

public static A153904Inst Instance=new A153904Inst();

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