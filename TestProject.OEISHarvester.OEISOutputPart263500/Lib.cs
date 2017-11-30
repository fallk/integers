using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A020592
{
public static readonly long[] Value={ 3L,5L,17L,19L,83L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020592Inst : IEnumerable<long>
{
public static readonly long[] Value=A020592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020592.Bytes);
public long this[int i]=>Value[i];

public static A020592Inst Instance=new A020592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020593
{
public static readonly BigInteger[] Value={ 1L,25L,423L,6053L,79079L,977613L,11662351L,135834661L,1556251287L,17625401981L,197992990559L,2211194243349L,24591484236775L,272666167778029L,3016684939110447L,33322861263616517L,367668910476901943L,4053314434522328157L,BigInteger.Parse("44658211693913532415") };
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
public class A020593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A020593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A020593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A020593Inst Instance=new A020593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020594
{
public static readonly long[] Value={ 1L,26L,460L,6920L,95536L,1254176L,15958720L,199053440L,2450711296L,29915173376L,363095649280L,4390419138560L,52953377222656L,637600367845376L,7668561507696640L,92162065025761280L,1107062216886255616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020594Inst : IEnumerable<long>
{
public static readonly long[] Value=A020594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020594.Bytes);
public long this[int i]=>Value[i];

public static A020594Inst Instance=new A020594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020595
{
public static readonly long[] Value={ 1L,25L,421L,5965L,76741L,929005L,10791061L,121699645L,1342777381L,14569879885L,156038219701L,1653799781725L,17380932862021L,181408804717165L,1882561696208341L,19442349988398205L,199976918230722661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020595Inst : IEnumerable<long>
{
public static readonly long[] Value=A020595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020595.Bytes);
public long this[int i]=>Value[i];

public static A020595Inst Instance=new A020595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020596
{
public static readonly long[] Value={ 3L,7L,11L,13L,17L,19L,23L,29L,31L,37L,47L,67L,71L,73L,79L,97L,127L,157L,167L,197L,241L,337L,367L,397L,487L,523L,569L,787L,1741L,1987L,2437L,2617L,8707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020596Inst : IEnumerable<long>
{
public static readonly long[] Value=A020596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020596.Bytes);
public long this[int i]=>Value[i];

public static A020596Inst Instance=new A020596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020597
{
public static readonly long[] Value={ 2L,7L,11L,13L,17L,19L,29L,37L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020597Inst : IEnumerable<long>
{
public static readonly long[] Value=A020597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020597.Bytes);
public long this[int i]=>Value[i];

public static A020597Inst Instance=new A020597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020598
{
public static readonly long[] Value={ 3L,7L,11L,13L,17L,19L,23L,59L,79L,89L,173L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020598Inst : IEnumerable<long>
{
public static readonly long[] Value=A020598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020598.Bytes);
public long this[int i]=>Value[i];

public static A020598Inst Instance=new A020598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020599
{
public static readonly long[] Value={ 2L,3L,11L,13L,17L,23L,31L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020599Inst : IEnumerable<long>
{
public static readonly long[] Value=A020599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020599.Bytes);
public long this[int i]=>Value[i];

public static A020599Inst Instance=new A020599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020600
{
public static readonly long[] Value={ 3L,7L,11L,13L,17L,19L,23L,31L,41L,43L,61L,67L,71L,73L,103L,163L,223L,311L,313L,373L,521L,523L,823L,1123L,1873L,5623L,20089L,28123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020600Inst : IEnumerable<long>
{
public static readonly long[] Value=A020600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020600.Bytes);
public long this[int i]=>Value[i];

public static A020600Inst Instance=new A020600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020601
{
public static readonly long[] Value={ 2L,13L,19L,37L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020601Inst : IEnumerable<long>
{
public static readonly long[] Value=A020601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020601.Bytes);
public long this[int i]=>Value[i];

public static A020601Inst Instance=new A020601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020602
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,43L,59L,61L,67L,71L,79L,103L,139L,167L,223L,367L,547L,619L,743L,2203L,13219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020602Inst : IEnumerable<long>
{
public static readonly long[] Value=A020602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020602.Bytes);
public long this[int i]=>Value[i];

public static A020602Inst Instance=new A020602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020603
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,47L,53L,61L,67L,71L,73L,83L,89L,97L,103L,107L,113L,131L,137L,149L,157L,179L,191L,193L,211L,227L,251L,277L,283L,317L,347L,367L,373L,397L,431L,443L,503L,587L,647L,683L,727L,827L,863L,947L,1019L,1151L,1163L,1367L,1453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020603Inst : IEnumerable<long>
{
public static readonly long[] Value=A020603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020603.Bytes);
public long this[int i]=>Value[i];

public static A020603Inst Instance=new A020603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020604
{
public static readonly long[] Value={ 5L,11L,13L,17L,19L,23L,29L,37L,53L,59L,67L,71L,73L,89L,101L,107L,109L,137L,149L,181L,191L,229L,241L,269L,277L,293L,349L,353L,409L,421L,433L,521L,541L,613L,661L,829L,911L,1093L,1153L,1319L,1381L,1453L,1621L,1669L,2417L,3253L,8293L,9733L,11681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020604Inst : IEnumerable<long>
{
public static readonly long[] Value=A020604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020604.Bytes);
public long this[int i]=>Value[i];

public static A020604Inst Instance=new A020604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020605
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,19L,23L,37L,61L,73L,223L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020605Inst : IEnumerable<long>
{
public static readonly long[] Value=A020605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020605.Bytes);
public long this[int i]=>Value[i];

public static A020605Inst Instance=new A020605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020606
{
public static readonly long[] Value={ 1L,26L,457L,6782L,91693L,1170218L,14373409L,171896534L,2016642805L,23325176930L,266916367081L,3029497622606L,34167408893437L,383440973924762L,4286324362209073L,47766301010614598L,530982729463501189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020606Inst : IEnumerable<long>
{
public static readonly long[] Value=A020606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020606.Bytes);
public long this[int i]=>Value[i];

public static A020606Inst Instance=new A020606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020607
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020607Inst : IEnumerable<long>
{
public static readonly long[] Value=A020607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020607.Bytes);
public long this[int i]=>Value[i];

public static A020607Inst Instance=new A020607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020608
{
public static readonly long[] Value={ 2L,5L,17L,19L,43L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020608Inst : IEnumerable<long>
{
public static readonly long[] Value=A020608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020608.Bytes);
public long this[int i]=>Value[i];

public static A020608Inst Instance=new A020608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020609
{
public static readonly long[] Value={ 3L,5L,11L,13L,19L,23L,107L,137L,251L,457L,587L,3203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020609Inst : IEnumerable<long>
{
public static readonly long[] Value=A020609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020609.Bytes);
public long this[int i]=>Value[i];

public static A020609Inst Instance=new A020609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020610
{
public static readonly long[] Value={ 2L,3L,11L,13L,17L,19L,23L,31L,37L,41L,43L,73L,83L,257L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020610Inst : IEnumerable<long>
{
public static readonly long[] Value=A020610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020610.Bytes);
public long this[int i]=>Value[i];

public static A020610Inst Instance=new A020610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020611
{
public static readonly long[] Value={ 5L,11L,13L,17L,19L,23L,29L,37L,41L,43L,47L,53L,59L,61L,67L,73L,79L,83L,89L,97L,137L,139L,167L,193L,223L,239L,281L,283L,293L,307L,337L,347L,419L,431L,433L,439L,443L,487L,587L,683L,823L,1567L,1583L,1973L,1987L,2707L,2939L,3023L,3037L,3079L,3733L,4253L,4787L,6703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020611Inst : IEnumerable<long>
{
public static readonly long[] Value=A020611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020611.Bytes);
public long this[int i]=>Value[i];

public static A020611Inst Instance=new A020611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020612
{
public static readonly long[] Value={ 3L,5L,11L,13L,17L,23L,29L,43L,103L,127L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020612Inst : IEnumerable<long>
{
public static readonly long[] Value=A020612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020612.Bytes);
public long this[int i]=>Value[i];

public static A020612Inst Instance=new A020612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020613
{
public static readonly long[] Value={ 2L,5L,11L,17L,23L,31L,43L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020613Inst : IEnumerable<long>
{
public static readonly long[] Value=A020613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020613.Bytes);
public long this[int i]=>Value[i];

public static A020613Inst Instance=new A020613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020614
{
public static readonly long[] Value={ 3L,11L,13L,17L,29L,31L,41L,43L,71L,101L,227L,239L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020614Inst : IEnumerable<long>
{
public static readonly long[] Value=A020614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020614.Bytes);
public long this[int i]=>Value[i];

public static A020614Inst Instance=new A020614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020615
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,59L,67L,83L,89L,97L,103L,109L,131L,137L,179L,199L,233L,373L,1049L,1097L,1223L,1433L,2293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020615Inst : IEnumerable<long>
{
public static readonly long[] Value=A020615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020615.Bytes);
public long this[int i]=>Value[i];

public static A020615Inst Instance=new A020615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020616
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,19L,29L,53L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020616Inst : IEnumerable<long>
{
public static readonly long[] Value=A020616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020616.Bytes);
public long this[int i]=>Value[i];

public static A020616Inst Instance=new A020616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020617
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,23L,29L,31L,41L,43L,47L,53L,59L,61L,67L,71L,79L,89L,103L,107L,113L,127L,139L,181L,193L,223L,233L,241L,251L,331L,347L,349L,379L,397L,491L,571L,607L,653L,683L,827L,859L,907L,1019L,1451L,1741L,1787L,1867L,1889L,1931L,2011L,3023L,3931L,4493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020617Inst : IEnumerable<long>
{
public static readonly long[] Value=A020617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020617.Bytes);
public long this[int i]=>Value[i];

public static A020617Inst Instance=new A020617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020618
{
public static readonly long[] Value={ 3L,7L,11L,13L,17L,23L,29L,31L,47L,53L,59L,61L,67L,79L,109L,127L,541L,619L,661L,743L,877L,1021L,2333L,4957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020618Inst : IEnumerable<long>
{
public static readonly long[] Value=A020618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020618.Bytes);
public long this[int i]=>Value[i];

public static A020618Inst Instance=new A020618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020619
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,17L,19L,23L,29L,31L,41L,47L,59L,61L,71L,73L,79L,127L,137L,167L,191L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020619Inst : IEnumerable<long>
{
public static readonly long[] Value=A020619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020619.Bytes);
public long this[int i]=>Value[i];

public static A020619Inst Instance=new A020619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020620
{
public static readonly long[] Value={ 3L,5L,11L,13L,17L,19L,23L,29L,31L,37L,41L,47L,53L,61L,67L,71L,83L,97L,101L,109L,163L,181L,191L,239L,263L,293L,307L,383L,431L,691L,821L,2111L,2351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020620Inst : IEnumerable<long>
{
public static readonly long[] Value=A020620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020620.Bytes);
public long this[int i]=>Value[i];

public static A020620Inst Instance=new A020620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020733
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,5L,4L,1L,4L,2L,4L,1L,2L,5L,8L,1L,2L,5L,8L,2L,6L,7L,8L,5L,8L,11L,2L,2L,4L,11L,10L,3L,8L,2L,6L,3L,6L,2L,4L,1L,2L,5L,8L,2L,12L,16L,16L,5L,6L,13L,8L,12L,12L,4L,8L,5L,4L,5L,6L,4L,2L,6L,10L,1L,2L,7L,6L,5L,2L,2L,12L,15L,16L,2L,8L,11L,2L,10L,10L,11L,2L,6L,12L,3L,16L,2L,4L,8L,10L,5L,2L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020733Inst : IEnumerable<long>
{
public static readonly long[] Value=A020733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020733.Bytes);
public long this[int i]=>Value[i];

public static A020733Inst Instance=new A020733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020734
{
public static readonly long[] Value={ 4L,10L,25L,63L,159L,402L,1017L,2573L,6510L,16472L,41679L,105461L,266850L,675216L,1708513L,4323086L,10938795L,27678662L,70035898L,177213300L,448406526L,1134612428L,2870933600L,7264383443L,18381221638L,46510390257L,117686215012L,297783895756L,753488830979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020734Inst : IEnumerable<long>
{
public static readonly long[] Value=A020734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020734.Bytes);
public long this[int i]=>Value[i];

public static A020734Inst Instance=new A020734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020735
{
public static readonly long[] Value={ 5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020735Inst : IEnumerable<long>
{
public static readonly long[] Value=A020735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020735.Bytes);
public long this[int i]=>Value[i];

public static A020735Inst Instance=new A020735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020736
{
public static readonly long[] Value={ 5L,8L,13L,22L,38L,66L,115L,201L,352L,617L,1082L,1898L,3330L,5843L,10253L,17992L,31573L,55406L,97230L,170626L,299427L,525457L,922112L,1618193L,2839730L,4983378L,8745218L,15346787L,26931733L,47261896L,82938845L,145547526L,255418102L,448227522L,786584467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020736Inst : IEnumerable<long>
{
public static readonly long[] Value=A020736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020736.Bytes);
public long this[int i]=>Value[i];

public static A020736Inst Instance=new A020736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020737
{
public static readonly long[] Value={ 5L,9L,17L,33L,65L,129L,257L,513L,1025L,2049L,4097L,8193L,16385L,32769L,65537L,131073L,262145L,524289L,1048577L,2097153L,4194305L,8388609L,16777217L,33554433L,67108865L,134217729L,268435457L,536870913L,1073741825L,2147483649L,4294967297L,8589934593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020737Inst : IEnumerable<long>
{
public static readonly long[] Value=A020737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020737.Bytes);
public long this[int i]=>Value[i];

public static A020737Inst Instance=new A020737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020738
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,1L,4L,3L,4L,1L,4L,3L,2L,1L,2L,1L,6L,2L,6L,2L,6L,1L,8L,2L,2L,1L,4L,2L,2L,1L,10L,4L,2L,5L,2L,2L,2L,1L,2L,1L,6L,2L,2L,2L,4L,1L,2L,1L,2L,2L,6L,2L,4L,2L,2L,4L,2L,1L,10L,2L,2L,3L,4L,8L,2L,2L,2L,5L,2L,2L,2L,2L,2L,2L,2L,5L,2L,2L,6L,2L,2L,2L,12L,2L,2L,1L,2L,4L,4L,2L,2L,2L,2L,1L,2L,2L,2L,1L,4L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020738Inst : IEnumerable<long>
{
public static readonly long[] Value=A020738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020738.Bytes);
public long this[int i]=>Value[i];

public static A020738Inst Instance=new A020738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020739
{
public static readonly long[] Value={ 6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020739Inst : IEnumerable<long>
{
public static readonly long[] Value=A020739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020739.Bytes);
public long this[int i]=>Value[i];

public static A020739Inst Instance=new A020739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020740
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,12L,16L,32L,0L,0L,0L,64L,48L,0L,0L,96L,0L,0L,0L,192L,256L,0L,256L,384L,0L,0L,0L,0L,0L,832L,768L,512L,0L,0L,0L,0L,384L,576L,1536L,3072L,2048L,8448L,7680L,5632L,0L,0L,0L,14336L,3584L,0L,0L,3072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020740Inst : IEnumerable<long>
{
public static readonly long[] Value=A020740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020740.Bytes);
public long this[int i]=>Value[i];

public static A020740Inst Instance=new A020740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020741
{
public static readonly long[] Value={ 6L,10L,16L,25L,39L,60L,92L,141L,216L,330L,504L,769L,1173L,1789L,2728L,4159L,6340L,9664L,14730L,22451L,34219L,52155L,79492L,121157L,184660L,281447L,428963L,653797L,996474L,1518759L,2314790L,3528046L,5377208L,8195575L,12491138L,19038142L,29016639L,44225184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020741Inst : IEnumerable<long>
{
public static readonly long[] Value=A020741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020741.Bytes);
public long this[int i]=>Value[i];

public static A020741Inst Instance=new A020741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020742
{
public static readonly long[] Value={ 7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,135L,137L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020742Inst : IEnumerable<long>
{
public static readonly long[] Value=A020742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020742.Bytes);
public long this[int i]=>Value[i];

public static A020742Inst Instance=new A020742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020743
{
public static readonly long[] Value={ 7L,10L,15L,23L,36L,57L,91L,146L,235L,379L,612L,989L,1599L,2586L,4183L,6767L,10948L,17713L,28659L,46370L,75027L,121395L,196420L,317813L,514231L,832042L,1346271L,2178311L,3524580L,5702889L,9227467L,14930354L,24157819L,39088171L,63245988L,102334157L,165580143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020743Inst : IEnumerable<long>
{
public static readonly long[] Value=A020743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020743.Bytes);
public long this[int i]=>Value[i];

public static A020743Inst Instance=new A020743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020744
{
public static readonly long[] Value={ 8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020744Inst : IEnumerable<long>
{
public static readonly long[] Value=A020744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020744.Bytes);
public long this[int i]=>Value[i];

public static A020744Inst Instance=new A020744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020745
{
public static readonly long[] Value={ 3L,5L,8L,12L,18L,27L,40L,59L,87L,128L,188L,276L,405L,594L,871L,1277L,1872L,2744L,4022L,5895L,8640L,12663L,18559L,27200L,39864L,58424L,85625L,125490L,183915L,269541L,395032L,578948L,848490L,1243523L,1822472L,2670963L,3914487L,5736960L,8407924L,12322412L,18059373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020745Inst : IEnumerable<long>
{
public static readonly long[] Value=A020745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020745.Bytes);
public long this[int i]=>Value[i];

public static A020745Inst Instance=new A020745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020746
{
public static readonly long[] Value={ 3L,7L,16L,36L,81L,182L,408L,914L,2047L,4584L,10265L,22986L,51471L,115255L,258081L,577899L,1294040L,2897633L,6488421L,14528964L,32533461L,72849384L,163125366L,365272615L,817923579L,1831505986L,4101133972L,9183316890L,20563412382L,46045882316L,103106587509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020746Inst : IEnumerable<long>
{
public static readonly long[] Value=A020746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020746.Bytes);
public long this[int i]=>Value[i];

public static A020746Inst Instance=new A020746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020747
{
public static readonly long[] Value={ 4L,6L,9L,13L,18L,24L,32L,42L,55L,72L,94L,122L,158L,204L,263L,339L,436L,560L,719L,923L,1184L,1518L,1946L,2494L,3196L,4095L,5246L,6720L,8608L,11026L,14123L,18089L,23168L,29673L,38004L,48674L,62339L,79840L,102254L,130960L,167724L,214808L,275109L,352337L,451244L,577915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020747Inst : IEnumerable<long>
{
public static readonly long[] Value=A020747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020747.Bytes);
public long this[int i]=>Value[i];

public static A020747Inst Instance=new A020747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020748
{
public static readonly long[] Value={ 4L,10L,25L,62L,153L,377L,928L,2284L,5621L,13833L,34042L,83774L,206159L,507335L,1248496L,3072412L,7560869L,18606469L,45788478L,112680418L,277294139L,682390435L,1679287948L,4132543288L,10169735361L,25026602289L,61587720810L,151560619806L,372974046999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020748Inst : IEnumerable<long>
{
public static readonly long[] Value=A020748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020748.Bytes);
public long this[int i]=>Value[i];

public static A020748Inst Instance=new A020748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020749
{
public static readonly long[] Value={ 5L,8L,12L,18L,27L,40L,59L,87L,128L,188L,276L,405L,594L,871L,1277L,1872L,2744L,4022L,5895L,8640L,12663L,18559L,27200L,39864L,58424L,85625L,125490L,183915L,269541L,395032L,578948L,848490L,1243523L,1822472L,2670963L,3914487L,5736960L,8407924L,12322412L,18059373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020749Inst : IEnumerable<long>
{
public static readonly long[] Value=A020749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020749.Bytes);
public long this[int i]=>Value[i];

public static A020749Inst Instance=new A020749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020750
{
public static readonly long[] Value={ 5L,9L,16L,28L,49L,85L,147L,254L,438L,755L,1301L,2241L,3860L,6648L,11449L,19717L,33955L,58474L,100698L,173411L,298629L,514265L,885608L,1525092L,2626337L,4522773L,7788595L,13412614L,23097646L,39776083L,68497749L,117958865L,203135052L,349815584L,602411753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020750Inst : IEnumerable<long>
{
public static readonly long[] Value=A020750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020750.Bytes);
public long this[int i]=>Value[i];

public static A020750Inst Instance=new A020750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020751
{
public static readonly long[] Value={ 6L,9L,13L,18L,24L,32L,42L,55L,72L,94L,122L,158L,204L,263L,339L,436L,560L,719L,923L,1184L,1518L,1946L,2494L,3196L,4095L,5246L,6720L,8608L,11026L,14123L,18089L,23168L,29673L,38004L,48674L,62339L,79840L,102254L,130960L,167724L,214808L,275109L,352337L,451244L,577915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020751Inst : IEnumerable<long>
{
public static readonly long[] Value=A020751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020751.Bytes);
public long this[int i]=>Value[i];

public static A020751Inst Instance=new A020751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020752
{
public static readonly long[] Value={ 7L,10L,14L,19L,25L,32L,40L,50L,62L,76L,93L,113L,137L,166L,201L,243L,293L,353L,425L,511L,614L,737L,884L,1060L,1271L,1524L,1827L,2190L,2625L,3146L,3770L,4517L,5412L,6484L,7768L,9306L,11148L,13354L,15996L,19160L,22949L,27487L,32922L,39431L,47226L,56561L,67741L,81130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020752Inst : IEnumerable<long>
{
public static readonly long[] Value=A020752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020752.Bytes);
public long this[int i]=>Value[i];

public static A020752Inst Instance=new A020752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020753
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,17L,18L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020753Inst : IEnumerable<long>
{
public static readonly long[] Value=A020753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020753.Bytes);
public long this[int i]=>Value[i];

public static A020753Inst Instance=new A020753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020754
{
public static readonly long[] Value={ 1L,3L,7L,47L,241L,843L,22019L,217069L,1092746L,8870023L,221167421L,47255689914L,82462576219L,1043460553363L,79180770078547L,3215226335143217L,23742453640900971L,125781000834058567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020754Inst : IEnumerable<long>
{
public static readonly long[] Value=A020754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020754.Bytes);
public long this[int i]=>Value[i];

public static A020754Inst Instance=new A020754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020755
{
public static readonly long[] Value={ 2L,5L,10L,51L,246L,849L,22026L,217077L,1092755L,8870033L,221167433L,47255689927L,82462576233L,1043460553378L,79180770078563L,3215226335143234L,23742453640900989L,125781000834058586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020755Inst : IEnumerable<long>
{
public static readonly long[] Value=A020755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020755.Bytes);
public long this[int i]=>Value[i];

public static A020755Inst Instance=new A020755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020756
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,9L,10L,11L,12L,13L,15L,16L,18L,20L,21L,22L,24L,25L,27L,28L,29L,30L,31L,34L,36L,37L,38L,39L,42L,43L,45L,46L,48L,49L,51L,55L,56L,57L,58L,60L,61L,64L,65L,66L,67L,69L,70L,72L,73L,76L,78L,79L,81L,83L,84L,87L,88L,90L,91L,92L,93L,94L,97L,99L,100L,101L,102L,105L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020756Inst : IEnumerable<long>
{
public static readonly long[] Value=A020756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020756.Bytes);
public long this[int i]=>Value[i];

public static A020756Inst Instance=new A020756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020757
{
public static readonly long[] Value={ 5L,8L,14L,17L,19L,23L,26L,32L,33L,35L,40L,41L,44L,47L,50L,52L,53L,54L,59L,62L,63L,68L,71L,74L,75L,77L,80L,82L,85L,86L,89L,95L,96L,98L,103L,104L,107L,109L,113L,116L,117L,118L,122L,124L,125L,128L,129L,131L,134L,138L,140L,143L,145L,147L,149L,152L,155L,158L,161L,162L,166L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020757Inst : IEnumerable<long>
{
public static readonly long[] Value=A020757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020757.Bytes);
public long this[int i]=>Value[i];

public static A020757Inst Instance=new A020757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020758
{
public static readonly long[] Value={ 1L,28L,532L,8560L,125776L,1747648L,23401792L,305401600L,3912299776L,49432480768L,618099069952L,7666644643840L,94496470552576L,1158938055589888L,14157139120832512L,172384964172513280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020758Inst : IEnumerable<long>
{
public static readonly long[] Value=A020758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020758.Bytes);
public long this[int i]=>Value[i];

public static A020758Inst Instance=new A020758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020759
{
public static readonly long[] Value={ 1L,9L,6L,3L,5L,1L,0L,0L,2L,6L,0L,2L,1L,4L,2L,3L,4L,7L,9L,4L,4L,0L,9L,7L,6L,3L,3L,2L,9L,9L,8L,7L,5L,5L,5L,6L,7L,1L,9L,3L,1L,5L,9L,6L,0L,4L,6L,6L,0L,4L,3L,4L,1L,0L,7L,0L,4L,7L,1L,2L,7L,2L,5L,3L,8L,7L,1L,6L,5L,4L,9L,7L,0L,7L,1L,7L,0L,5L,4L,1L,0L,2L,1L,4L,8L,6L,7L,3L,7L,1L,7L,2L,8L,4L,5L,8L,4L,1L,2L,4L,5L,9L,8L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020759Inst : IEnumerable<long>
{
public static readonly long[] Value=A020759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020759.Bytes);
public long this[int i]=>Value[i];

public static A020759Inst Instance=new A020759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020760
{
public static readonly long[] Value={ 5L,7L,7L,3L,5L,0L,2L,6L,9L,1L,8L,9L,6L,2L,5L,7L,6L,4L,5L,0L,9L,1L,4L,8L,7L,8L,0L,5L,0L,1L,9L,5L,7L,4L,5L,5L,6L,4L,7L,6L,0L,1L,7L,5L,1L,2L,7L,0L,1L,2L,6L,8L,7L,6L,0L,1L,8L,6L,0L,2L,3L,2L,6L,4L,8L,3L,9L,7L,7L,6L,7L,2L,3L,0L,2L,9L,3L,3L,3L,4L,5L,6L,9L,3L,7L,1L,5L,3L,9L,5L,5L,8L,5L,7L,4L,9L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020760Inst : IEnumerable<long>
{
public static readonly long[] Value=A020760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020760.Bytes);
public long this[int i]=>Value[i];

public static A020760Inst Instance=new A020760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020761
{
public static readonly long[] Value={ 5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020761Inst : IEnumerable<long>
{
public static readonly long[] Value=A020761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020761.Bytes);
public long this[int i]=>Value[i];

public static A020761Inst Instance=new A020761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020762
{
public static readonly long[] Value={ 4L,4L,7L,2L,1L,3L,5L,9L,5L,4L,9L,9L,9L,5L,7L,9L,3L,9L,2L,8L,1L,8L,3L,4L,7L,3L,3L,7L,4L,6L,2L,5L,5L,2L,4L,7L,0L,8L,8L,1L,2L,3L,6L,7L,1L,9L,2L,2L,3L,0L,5L,1L,4L,4L,8L,5L,4L,1L,7L,9L,4L,4L,9L,0L,8L,2L,1L,0L,4L,1L,8L,5L,1L,2L,7L,5L,6L,0L,9L,7L,9L,8L,8L,2L,8L,8L,2L,8L,8L,1L,6L,7L,5L,7L,5L,6L,4L,5L,4L,9L,9L,3L,9L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020762Inst : IEnumerable<long>
{
public static readonly long[] Value=A020762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020762.Bytes);
public long this[int i]=>Value[i];

public static A020762Inst Instance=new A020762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020763
{
public static readonly long[] Value={ 4L,0L,8L,2L,4L,8L,2L,9L,0L,4L,6L,3L,8L,6L,3L,0L,1L,6L,3L,6L,6L,2L,1L,4L,0L,1L,2L,4L,5L,0L,9L,8L,1L,8L,9L,8L,6L,6L,0L,9L,9L,1L,2L,4L,6L,7L,7L,6L,1L,1L,1L,6L,8L,8L,0L,7L,2L,1L,1L,5L,4L,2L,7L,8L,7L,5L,1L,6L,0L,0L,6L,2L,9L,0L,9L,5L,5L,2L,5L,0L,4L,4L,2L,3L,3L,0L,9L,9L,0L,5L,5L,1L,7L,4L,4L,0L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020763Inst : IEnumerable<long>
{
public static readonly long[] Value=A020763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020763.Bytes);
public long this[int i]=>Value[i];

public static A020763Inst Instance=new A020763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020764
{
public static readonly long[] Value={ 3L,7L,7L,9L,6L,4L,4L,7L,3L,0L,0L,9L,2L,2L,7L,2L,2L,7L,2L,1L,4L,5L,1L,6L,5L,3L,6L,2L,3L,4L,1L,8L,0L,0L,6L,0L,8L,1L,5L,7L,5L,1L,3L,1L,1L,8L,6L,8L,9L,2L,1L,4L,5L,4L,3L,3L,8L,3L,3L,3L,4L,9L,4L,1L,7L,1L,5L,8L,1L,2L,6L,0L,4L,6L,1L,4L,6L,9L,0L,8L,9L,6L,8L,0L,0L,5L,6L,1L,2L,6L,6L,3L,9L,2L,2L,0L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020764Inst : IEnumerable<long>
{
public static readonly long[] Value=A020764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020764.Bytes);
public long this[int i]=>Value[i];

public static A020764Inst Instance=new A020764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020765
{
public static readonly long[] Value={ 3L,5L,3L,5L,5L,3L,3L,9L,0L,5L,9L,3L,2L,7L,3L,7L,6L,2L,2L,0L,0L,4L,2L,2L,1L,8L,1L,0L,5L,2L,4L,2L,4L,5L,1L,9L,6L,4L,2L,4L,1L,7L,9L,6L,8L,8L,4L,4L,2L,3L,7L,0L,1L,8L,2L,9L,4L,1L,6L,9L,9L,3L,4L,4L,9L,7L,6L,8L,3L,1L,1L,9L,6L,1L,5L,5L,2L,6L,7L,5L,9L,7L,1L,2L,5L,9L,6L,8L,8L,3L,5L,8L,1L,9L,1L,0L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020765Inst : IEnumerable<long>
{
public static readonly long[] Value=A020765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020765.Bytes);
public long this[int i]=>Value[i];

public static A020765Inst Instance=new A020765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020766
{
public static readonly long[] Value={ 1L,29L,571L,9521L,144907L,2083865L,28847827L,388709777L,5134091323L,66784487561L,858403625443L,10928093824193L,138039056180299L,1732402968047417L,21624191213455219L,268679676312195569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020766Inst : IEnumerable<long>
{
public static readonly long[] Value=A020766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020766.Bytes);
public long this[int i]=>Value[i];

public static A020766Inst Instance=new A020766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020767
{
public static readonly BigInteger[] Value={ 1L,1L,10L,110L,11000L,1111000L,122210000L,13565310000L,13565310000000L,13578875310000000L,13714664063100000000UL,BigInteger.Parse("13865525367794100000000"),BigInteger.Parse("15252077904573510000000000"),BigInteger.Parse("16792537772935434510000000000"),BigInteger.Parse("18639716927958332306100000000000"),BigInteger.Parse("20708725506961707192077100000000000") };
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
public class A020767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A020767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A020767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A020767Inst Instance=new A020767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020768
{
public static readonly long[] Value={ 3L,0L,1L,5L,1L,1L,3L,4L,4L,5L,7L,7L,7L,6L,3L,6L,2L,2L,6L,4L,6L,8L,1L,2L,0L,6L,6L,9L,7L,0L,0L,6L,2L,4L,2L,5L,8L,1L,1L,5L,5L,3L,5L,0L,4L,1L,4L,4L,4L,8L,6L,6L,9L,0L,6L,4L,1L,6L,9L,8L,3L,7L,6L,9L,1L,9L,6L,8L,0L,4L,2L,2L,0L,5L,5L,3L,6L,7L,6L,2L,2L,4L,2L,8L,0L,7L,6L,6L,7L,2L,6L,4L,8L,0L,2L,6L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020768Inst : IEnumerable<long>
{
public static readonly long[] Value=A020768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020768.Bytes);
public long this[int i]=>Value[i];

public static A020768Inst Instance=new A020768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020769
{
public static readonly long[] Value={ 2L,8L,8L,6L,7L,5L,1L,3L,4L,5L,9L,4L,8L,1L,2L,8L,8L,2L,2L,5L,4L,5L,7L,4L,3L,9L,0L,2L,5L,0L,9L,7L,8L,7L,2L,7L,8L,2L,3L,8L,0L,0L,8L,7L,5L,6L,3L,5L,0L,6L,3L,4L,3L,8L,0L,0L,9L,3L,0L,1L,1L,6L,3L,2L,4L,1L,9L,8L,8L,8L,3L,6L,1L,5L,1L,4L,6L,6L,6L,7L,2L,8L,4L,6L,8L,5L,7L,6L,9L,7L,7L,9L,2L,8L,7L,4L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020769Inst : IEnumerable<long>
{
public static readonly long[] Value=A020769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020769.Bytes);
public long this[int i]=>Value[i];

public static A020769Inst Instance=new A020769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020770
{
public static readonly long[] Value={ 2L,7L,7L,3L,5L,0L,0L,9L,8L,1L,1L,2L,6L,1L,4L,5L,6L,1L,0L,0L,9L,1L,7L,0L,8L,6L,6L,7L,2L,8L,4L,9L,9L,6L,8L,8L,1L,7L,3L,1L,7L,6L,6L,5L,9L,5L,2L,6L,5L,5L,7L,4L,0L,0L,9L,7L,7L,7L,2L,7L,1L,5L,8L,1L,7L,1L,3L,2L,0L,5L,3L,4L,4L,8L,4L,0L,7L,7L,7L,2L,6L,5L,5L,4L,2L,0L,1L,4L,6L,7L,8L,4L,7L,5L,7L,6L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020770Inst : IEnumerable<long>
{
public static readonly long[] Value=A020770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020770.Bytes);
public long this[int i]=>Value[i];

public static A020770Inst Instance=new A020770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020771
{
public static readonly long[] Value={ 2L,6L,7L,2L,6L,1L,2L,4L,1L,9L,1L,2L,4L,2L,4L,3L,8L,4L,6L,8L,4L,5L,5L,3L,4L,8L,0L,8L,7L,9L,7L,5L,3L,5L,2L,1L,5L,5L,4L,0L,0L,1L,4L,1L,4L,8L,4L,1L,3L,3L,7L,6L,3L,9L,0L,2L,1L,6L,9L,6L,1L,0L,4L,8L,0L,8L,5L,7L,3L,9L,3L,9L,7L,3L,6L,2L,0L,9L,9L,3L,0L,5L,6L,9L,7L,7L,2L,1L,3L,5L,3L,7L,1L,0L,2L,7L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020771Inst : IEnumerable<long>
{
public static readonly long[] Value=A020771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020771.Bytes);
public long this[int i]=>Value[i];

public static A020771Inst Instance=new A020771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020772
{
public static readonly long[] Value={ 2L,5L,8L,1L,9L,8L,8L,8L,9L,7L,4L,7L,1L,6L,1L,1L,2L,5L,6L,7L,8L,6L,1L,7L,6L,9L,3L,3L,1L,8L,8L,2L,6L,6L,4L,0L,7L,2L,2L,1L,9L,4L,7L,8L,0L,3L,5L,2L,7L,7L,2L,7L,2L,1L,7L,7L,2L,5L,0L,4L,9L,1L,7L,7L,4L,0L,8L,9L,8L,8L,7L,2L,7L,9L,5L,7L,9L,8L,6L,0L,2L,2L,3L,4L,6L,1L,9L,1L,5L,8L,4L,5L,7L,2L,4L,4L,9L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020772Inst : IEnumerable<long>
{
public static readonly long[] Value=A020772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020772.Bytes);
public long this[int i]=>Value[i];

public static A020772Inst Instance=new A020772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020773
{
public static readonly long[] Value={ 2L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020773Inst : IEnumerable<long>
{
public static readonly long[] Value=A020773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020773.Bytes);
public long this[int i]=>Value[i];

public static A020773Inst Instance=new A020773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020774
{
public static readonly long[] Value={ 2L,4L,2L,5L,3L,5L,6L,2L,5L,0L,3L,6L,3L,3L,2L,9L,7L,3L,5L,1L,8L,9L,0L,6L,4L,6L,2L,1L,1L,6L,1L,2L,2L,1L,7L,7L,9L,4L,9L,8L,3L,5L,2L,4L,8L,5L,5L,1L,3L,8L,9L,4L,3L,7L,3L,1L,7L,5L,6L,6L,6L,8L,0L,7L,7L,0L,2L,9L,1L,4L,3L,2L,1L,3L,7L,5L,0L,7L,1L,5L,2L,5L,6L,3L,9L,9L,1L,9L,7L,9L,4L,5L,9L,4L,5L,2L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020774Inst : IEnumerable<long>
{
public static readonly long[] Value=A020774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020774.Bytes);
public long this[int i]=>Value[i];

public static A020774Inst Instance=new A020774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020775
{
public static readonly long[] Value={ 2L,3L,5L,7L,0L,2L,2L,6L,0L,3L,9L,5L,5L,1L,5L,8L,4L,1L,4L,6L,6L,9L,4L,8L,1L,2L,0L,7L,0L,1L,6L,1L,6L,3L,4L,6L,4L,2L,8L,2L,7L,8L,6L,4L,5L,8L,9L,6L,1L,5L,8L,0L,1L,2L,1L,9L,6L,1L,1L,3L,2L,8L,9L,6L,6L,5L,1L,2L,2L,0L,7L,9L,7L,4L,3L,6L,8L,4L,5L,0L,6L,4L,7L,5L,0L,6L,4L,5L,8L,9L,0L,5L,4L,6L,0L,6L,9L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020775Inst : IEnumerable<long>
{
public static readonly long[] Value=A020775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020775.Bytes);
public long this[int i]=>Value[i];

public static A020775Inst Instance=new A020775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020776
{
public static readonly long[] Value={ 2L,2L,9L,4L,1L,5L,7L,3L,3L,8L,7L,0L,5L,6L,1L,7L,6L,5L,9L,0L,7L,2L,0L,9L,5L,7L,8L,0L,9L,7L,8L,7L,4L,5L,0L,8L,3L,7L,5L,6L,3L,1L,7L,8L,5L,5L,3L,8L,5L,4L,9L,7L,3L,3L,5L,2L,0L,5L,4L,4L,4L,2L,8L,3L,2L,4L,1L,8L,7L,2L,2L,7L,8L,0L,0L,1L,6L,6L,2L,1L,5L,0L,3L,4L,5L,3L,4L,6L,9L,2L,4L,1L,3L,2L,6L,0L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020776Inst : IEnumerable<long>
{
public static readonly long[] Value=A020776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020776.Bytes);
public long this[int i]=>Value[i];

public static A020776Inst Instance=new A020776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020777
{
public static readonly long[] Value={ 4L,2L,2L,7L,4L,5L,3L,5L,3L,3L,3L,7L,6L,2L,6L,5L,4L,0L,8L,0L,8L,9L,5L,3L,0L,1L,4L,6L,0L,9L,6L,6L,8L,3L,5L,7L,7L,3L,6L,7L,2L,4L,4L,4L,3L,8L,7L,0L,8L,2L,4L,2L,2L,7L,1L,6L,5L,5L,2L,7L,9L,5L,5L,9L,5L,1L,8L,9L,5L,6L,7L,9L,5L,8L,2L,9L,8L,5L,3L,3L,1L,7L,0L,6L,8L,5L,5L,4L,4L,5L,6L,9L,5L,2L,0L,6L,1L,3L,4L,6L,1L,3L,1L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020777Inst : IEnumerable<long>
{
public static readonly long[] Value=A020777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020777.Bytes);
public long this[int i]=>Value[i];

public static A020777Inst Instance=new A020777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020778
{
public static readonly long[] Value={ 2L,1L,8L,2L,1L,7L,8L,9L,0L,2L,3L,5L,9L,9L,2L,3L,8L,1L,2L,6L,6L,0L,9L,7L,4L,8L,5L,4L,1L,5L,6L,1L,9L,4L,5L,1L,8L,5L,6L,4L,0L,2L,6L,9L,4L,1L,3L,1L,8L,0L,8L,1L,8L,5L,8L,3L,8L,4L,4L,0L,1L,0L,1L,1L,3L,8L,4L,2L,2L,3L,0L,5L,9L,7L,8L,4L,6L,5L,2L,8L,0L,3L,1L,4L,4L,9L,3L,4L,0L,7L,5L,9L,4L,9L,2L,5L,9L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020778Inst : IEnumerable<long>
{
public static readonly long[] Value=A020778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020778.Bytes);
public long this[int i]=>Value[i];

public static A020778Inst Instance=new A020778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020779
{
public static readonly long[] Value={ 2L,1L,3L,2L,0L,0L,7L,1L,6L,3L,5L,5L,6L,1L,0L,4L,3L,4L,2L,9L,8L,4L,3L,7L,7L,3L,2L,4L,3L,3L,8L,3L,9L,3L,7L,6L,3L,9L,0L,3L,7L,4L,0L,1L,6L,0L,6L,4L,1L,6L,9L,8L,7L,0L,6L,1L,8L,4L,4L,0L,9L,9L,5L,0L,4L,6L,2L,2L,8L,3L,9L,2L,3L,9L,7L,8L,7L,4L,5L,3L,2L,7L,9L,4L,6L,4L,1L,6L,1L,8L,0L,0L,2L,7L,9L,7L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020779Inst : IEnumerable<long>
{
public static readonly long[] Value=A020779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020779.Bytes);
public long this[int i]=>Value[i];

public static A020779Inst Instance=new A020779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020780
{
public static readonly long[] Value={ 2L,0L,8L,5L,1L,4L,4L,1L,4L,0L,5L,7L,0L,7L,4L,7L,6L,2L,6L,7L,8L,1L,4L,9L,4L,8L,1L,0L,5L,0L,5L,5L,1L,9L,0L,9L,5L,6L,5L,0L,7L,4L,2L,1L,9L,2L,1L,3L,2L,2L,3L,0L,1L,5L,0L,6L,4L,5L,7L,8L,6L,5L,7L,1L,4L,9L,9L,2L,4L,2L,2L,7L,6L,4L,8L,1L,5L,0L,6L,1L,2L,2L,8L,2L,2L,6L,9L,1L,9L,3L,3L,2L,3L,3L,4L,4L,2L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020780Inst : IEnumerable<long>
{
public static readonly long[] Value=A020780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020780.Bytes);
public long this[int i]=>Value[i];

public static A020780Inst Instance=new A020780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020781
{
public static readonly long[] Value={ 2L,0L,4L,1L,2L,4L,1L,4L,5L,2L,3L,1L,9L,3L,1L,5L,0L,8L,1L,8L,3L,1L,0L,7L,0L,0L,6L,2L,2L,5L,4L,9L,0L,9L,4L,9L,3L,3L,0L,4L,9L,5L,6L,2L,3L,3L,8L,8L,0L,5L,5L,8L,4L,4L,0L,3L,6L,0L,5L,7L,7L,1L,3L,9L,3L,7L,5L,8L,0L,0L,3L,1L,4L,5L,4L,7L,7L,6L,2L,5L,2L,2L,1L,1L,6L,5L,4L,9L,5L,2L,7L,5L,8L,7L,2L,0L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020781Inst : IEnumerable<long>
{
public static readonly long[] Value=A020781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020781.Bytes);
public long this[int i]=>Value[i];

public static A020781Inst Instance=new A020781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020782
{
public static readonly long[] Value={ 1L,24L,385L,5160L,62401L,706104L,7628545L,79669320L,810888001L,8089258584L,79415935105L,769621605480L,7379461252801L,70134974713464L,661651583000065L,6203106293141640L,57847125937972801L,537010118353326744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020782Inst : IEnumerable<long>
{
public static readonly long[] Value=A020782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020782.Bytes);
public long this[int i]=>Value[i];

public static A020782Inst Instance=new A020782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020783
{
public static readonly long[] Value={ 1L,9L,6L,1L,1L,6L,1L,3L,5L,1L,3L,8L,1L,8L,4L,0L,3L,1L,9L,2L,4L,1L,6L,2L,4L,6L,5L,7L,3L,1L,6L,4L,5L,4L,6L,1L,1L,3L,7L,0L,6L,8L,1L,1L,3L,3L,1L,1L,5L,2L,2L,9L,3L,8L,7L,5L,3L,2L,6L,8L,1L,0L,7L,8L,6L,2L,5L,3L,5L,9L,0L,8L,9L,2L,5L,4L,7L,0L,1L,6L,1L,3L,6L,8L,7L,8L,2L,6L,4L,8L,1L,1L,8L,9L,9L,7L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020783Inst : IEnumerable<long>
{
public static readonly long[] Value=A020783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020783.Bytes);
public long this[int i]=>Value[i];

public static A020783Inst Instance=new A020783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020784
{
public static readonly long[] Value={ 1L,9L,2L,4L,5L,0L,0L,8L,9L,7L,2L,9L,8L,7L,5L,2L,5L,4L,8L,3L,6L,3L,8L,2L,9L,2L,6L,8L,3L,3L,9L,8L,5L,8L,1L,8L,5L,4L,9L,2L,0L,0L,5L,8L,3L,7L,5L,6L,7L,0L,8L,9L,5L,8L,6L,7L,2L,8L,6L,7L,4L,4L,2L,1L,6L,1L,3L,2L,5L,8L,9L,0L,7L,6L,7L,6L,4L,4L,4L,4L,8L,5L,6L,4L,5L,7L,1L,7L,9L,8L,5L,2L,8L,5L,8L,3L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020784Inst : IEnumerable<long>
{
public static readonly long[] Value=A020784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020784.Bytes);
public long this[int i]=>Value[i];

public static A020784Inst Instance=new A020784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020785
{
public static readonly long[] Value={ 1L,8L,8L,9L,8L,2L,2L,3L,6L,5L,0L,4L,6L,1L,3L,6L,1L,3L,6L,0L,7L,2L,5L,8L,2L,6L,8L,1L,1L,7L,0L,9L,0L,0L,3L,0L,4L,0L,7L,8L,7L,5L,6L,5L,5L,9L,3L,4L,4L,6L,0L,7L,2L,7L,1L,6L,9L,1L,6L,6L,7L,4L,7L,0L,8L,5L,7L,9L,0L,6L,3L,0L,2L,3L,0L,7L,3L,4L,5L,4L,4L,8L,4L,0L,0L,2L,8L,0L,6L,3L,3L,1L,9L,6L,1L,0L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020785Inst : IEnumerable<long>
{
public static readonly long[] Value=A020785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020785.Bytes);
public long this[int i]=>Value[i];

public static A020785Inst Instance=new A020785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020786
{
public static readonly long[] Value={ 1L,8L,5L,6L,9L,5L,3L,3L,8L,1L,7L,7L,0L,5L,1L,8L,6L,3L,1L,4L,6L,5L,7L,6L,2L,2L,3L,8L,4L,6L,2L,1L,8L,2L,6L,0L,5L,6L,1L,9L,0L,0L,6L,9L,5L,2L,2L,9L,1L,3L,0L,6L,4L,9L,5L,7L,5L,1L,8L,5L,8L,1L,6L,2L,0L,7L,4L,7L,0L,5L,5L,0L,4L,4L,2L,3L,3L,3L,0L,5L,8L,3L,7L,5L,0L,5L,6L,3L,3L,7L,2L,9L,9L,3L,0L,4L,6L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020786Inst : IEnumerable<long>
{
public static readonly long[] Value=A020786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020786.Bytes);
public long this[int i]=>Value[i];

public static A020786Inst Instance=new A020786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020787
{
public static readonly long[] Value={ 1L,8L,2L,5L,7L,4L,1L,8L,5L,8L,3L,5L,0L,5L,5L,3L,7L,1L,1L,5L,2L,3L,2L,3L,2L,6L,0L,9L,3L,3L,6L,0L,0L,7L,1L,1L,3L,1L,7L,5L,8L,1L,5L,6L,4L,9L,9L,9L,3L,2L,7L,7L,5L,1L,4L,0L,8L,9L,6L,4L,8L,1L,6L,5L,7L,7L,4L,9L,7L,7L,5L,9L,0L,4L,0L,9L,0L,7L,5L,7L,7L,9L,3L,3L,6L,1L,9L,4L,7L,8L,7L,2L,1L,2L,9L,0L,2L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020787Inst : IEnumerable<long>
{
public static readonly long[] Value=A020787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020787.Bytes);
public long this[int i]=>Value[i];

public static A020787Inst Instance=new A020787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020788
{
public static readonly long[] Value={ 1L,7L,9L,6L,0L,5L,3L,0L,2L,0L,2L,6L,7L,7L,4L,9L,0L,0L,7L,1L,3L,5L,3L,1L,3L,3L,2L,2L,2L,3L,1L,7L,9L,0L,1L,6L,7L,8L,9L,5L,6L,1L,0L,7L,6L,6L,9L,5L,8L,1L,9L,8L,1L,6L,2L,5L,7L,0L,4L,6L,2L,1L,2L,4L,3L,8L,8L,2L,5L,4L,7L,8L,6L,8L,5L,6L,2L,0L,5L,2L,5L,5L,7L,8L,2L,9L,7L,3L,6L,7L,6L,1L,8L,8L,6L,8L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020788Inst : IEnumerable<long>
{
public static readonly long[] Value=A020788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020788.Bytes);
public long this[int i]=>Value[i];

public static A020788Inst Instance=new A020788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020789
{
public static readonly long[] Value={ 1L,7L,6L,7L,7L,6L,6L,9L,5L,2L,9L,6L,6L,3L,6L,8L,8L,1L,1L,0L,0L,2L,1L,1L,0L,9L,0L,5L,2L,6L,2L,1L,2L,2L,5L,9L,8L,2L,1L,2L,0L,8L,9L,8L,4L,4L,2L,2L,1L,1L,8L,5L,0L,9L,1L,4L,7L,0L,8L,4L,9L,6L,7L,2L,4L,8L,8L,4L,1L,5L,5L,9L,8L,0L,7L,7L,6L,3L,3L,7L,9L,8L,5L,6L,2L,9L,8L,4L,4L,1L,7L,9L,0L,9L,5L,5L,1L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020789Inst : IEnumerable<long>
{
public static readonly long[] Value=A020789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020789.Bytes);
public long this[int i]=>Value[i];

public static A020789Inst Instance=new A020789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020790
{
public static readonly long[] Value={ 1L,7L,4L,0L,7L,7L,6L,5L,5L,9L,5L,5L,6L,9L,7L,8L,3L,8L,1L,7L,7L,2L,9L,1L,2L,5L,6L,6L,1L,2L,6L,9L,4L,8L,2L,7L,8L,2L,4L,8L,5L,6L,4L,9L,8L,7L,2L,6L,7L,5L,1L,2L,8L,3L,8L,6L,9L,6L,9L,3L,2L,5L,6L,6L,8L,3L,8L,1L,5L,1L,7L,3L,3L,7L,7L,4L,9L,7L,1L,0L,9L,9L,0L,9L,9L,1L,2L,8L,8L,9L,8L,6L,6L,5L,6L,9L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020790Inst : IEnumerable<long>
{
public static readonly long[] Value=A020790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020790.Bytes);
public long this[int i]=>Value[i];

public static A020790Inst Instance=new A020790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020791
{
public static readonly long[] Value={ 1L,7L,1L,4L,9L,8L,5L,8L,5L,1L,4L,2L,5L,0L,8L,8L,3L,7L,3L,7L,8L,6L,5L,1L,5L,5L,5L,2L,2L,1L,9L,2L,8L,9L,1L,4L,0L,1L,5L,3L,3L,5L,2L,4L,5L,1L,4L,3L,7L,0L,5L,0L,5L,7L,4L,8L,3L,8L,2L,3L,7L,2L,7L,7L,9L,0L,2L,2L,9L,7L,0L,7L,7L,0L,5L,7L,8L,5L,6L,6L,5L,5L,1L,9L,5L,6L,5L,8L,9L,1L,9L,5L,4L,5L,0L,1L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020791Inst : IEnumerable<long>
{
public static readonly long[] Value=A020791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020791.Bytes);
public long this[int i]=>Value[i];

public static A020791Inst Instance=new A020791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020792
{
public static readonly long[] Value={ 1L,6L,9L,0L,3L,0L,8L,5L,0L,9L,4L,5L,7L,0L,3L,3L,1L,5L,5L,0L,1L,9L,2L,3L,6L,6L,5L,4L,7L,3L,1L,8L,9L,0L,5L,8L,5L,2L,6L,1L,5L,7L,1L,7L,8L,0L,2L,2L,6L,9L,5L,4L,3L,7L,7L,9L,6L,5L,6L,3L,4L,1L,9L,1L,1L,8L,3L,6L,6L,3L,5L,5L,9L,7L,4L,4L,4L,7L,2L,2L,9L,6L,2L,1L,8L,7L,8L,6L,4L,3L,6L,3L,3L,8L,0L,3L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020792Inst : IEnumerable<long>
{
public static readonly long[] Value=A020792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020792.Bytes);
public long this[int i]=>Value[i];

public static A020792Inst Instance=new A020792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020793
{
public static readonly long[] Value={ 1L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020793Inst : IEnumerable<long>
{
public static readonly long[] Value=A020793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020793.Bytes);
public long this[int i]=>Value[i];

public static A020793Inst Instance=new A020793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020794
{
public static readonly long[] Value={ 1L,6L,4L,3L,9L,8L,9L,8L,7L,3L,0L,5L,3L,5L,7L,2L,8L,8L,8L,9L,1L,8L,8L,3L,3L,5L,7L,9L,7L,8L,4L,3L,4L,2L,4L,4L,9L,2L,1L,2L,1L,5L,4L,0L,7L,9L,6L,7L,2L,0L,0L,3L,0L,2L,3L,3L,5L,6L,5L,2L,7L,8L,5L,0L,4L,0L,1L,7L,1L,1L,5L,4L,7L,3L,8L,3L,4L,8L,9L,2L,5L,4L,0L,0L,0L,8L,2L,8L,7L,6L,4L,3L,1L,2L,9L,3L,2L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020794Inst : IEnumerable<long>
{
public static readonly long[] Value=A020794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020794.Bytes);
public long this[int i]=>Value[i];

public static A020794Inst Instance=new A020794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020795
{
public static readonly long[] Value={ 1L,6L,2L,2L,2L,1L,4L,2L,1L,1L,3L,0L,7L,6L,2L,5L,3L,8L,1L,6L,4L,4L,7L,8L,7L,4L,6L,8L,8L,0L,3L,7L,4L,8L,4L,8L,0L,3L,2L,5L,1L,6L,4L,2L,1L,6L,6L,9L,5L,9L,4L,0L,6L,6L,9L,7L,0L,3L,8L,3L,4L,7L,5L,5L,9L,1L,0L,1L,0L,5L,1L,7L,1L,1L,2L,2L,0L,1L,6L,8L,9L,8L,1L,4L,9L,1L,3L,9L,4L,2L,0L,8L,4L,1L,8L,1L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020795Inst : IEnumerable<long>
{
public static readonly long[] Value=A020795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020795.Bytes);
public long this[int i]=>Value[i];

public static A020795Inst Instance=new A020795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020796
{
public static readonly long[] Value={ 1L,6L,0L,1L,2L,8L,1L,5L,3L,8L,0L,5L,0L,8L,7L,1L,3L,3L,4L,8L,3L,2L,5L,3L,6L,6L,9L,7L,6L,7L,6L,8L,7L,0L,3L,7L,4L,6L,3L,4L,0L,9L,2L,3L,0L,2L,0L,4L,9L,1L,4L,2L,6L,4L,3L,1L,9L,3L,0L,6L,9L,7L,2L,5L,7L,9L,7L,3L,3L,6L,2L,0L,5L,2L,7L,7L,8L,2L,4L,2L,3L,0L,9L,3L,1L,6L,2L,4L,6L,4L,4L,1L,5L,9L,3L,1L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020796Inst : IEnumerable<long>
{
public static readonly long[] Value=A020796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020796.Bytes);
public long this[int i]=>Value[i];

public static A020796Inst Instance=new A020796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020813
{
public static readonly long[] Value={ 1L,3L,3L,6L,3L,0L,6L,2L,0L,9L,5L,6L,2L,1L,2L,1L,9L,2L,3L,4L,2L,2L,7L,6L,7L,4L,0L,4L,3L,9L,8L,7L,6L,7L,6L,0L,7L,7L,7L,0L,0L,0L,7L,0L,7L,4L,2L,0L,6L,6L,8L,8L,1L,9L,5L,1L,0L,8L,4L,8L,0L,5L,2L,4L,0L,4L,2L,8L,6L,9L,6L,9L,8L,6L,8L,1L,0L,4L,9L,6L,5L,2L,8L,4L,8L,8L,6L,0L,6L,7L,6L,8L,5L,5L,1L,3L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020813Inst : IEnumerable<long>
{
public static readonly long[] Value=A020813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020813.Bytes);
public long this[int i]=>Value[i];

public static A020813Inst Instance=new A020813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020814
{
public static readonly long[] Value={ 1L,3L,2L,4L,5L,3L,2L,3L,5L,7L,0L,6L,5L,0L,4L,3L,8L,0L,6L,5L,3L,2L,7L,5L,1L,7L,2L,0L,5L,1L,6L,8L,6L,2L,6L,4L,1L,7L,9L,3L,3L,6L,7L,4L,9L,2L,0L,3L,9L,1L,8L,9L,4L,9L,7L,9L,4L,7L,1L,2L,7L,5L,2L,7L,3L,1L,7L,6L,7L,0L,5L,1L,8L,2L,3L,1L,1L,9L,4L,9L,4L,6L,5L,9L,3L,4L,1L,2L,6L,4L,4L,5L,8L,7L,2L,8L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020814Inst : IEnumerable<long>
{
public static readonly long[] Value=A020814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020814.Bytes);
public long this[int i]=>Value[i];

public static A020814Inst Instance=new A020814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020815
{
public static readonly long[] Value={ 1L,3L,1L,3L,0L,6L,4L,3L,2L,8L,5L,9L,7L,2L,2L,5L,5L,6L,6L,4L,9L,3L,3L,4L,6L,7L,2L,8L,8L,2L,0L,4L,0L,0L,5L,1L,8L,1L,6L,5L,6L,3L,8L,8L,9L,5L,2L,6L,6L,6L,5L,4L,9L,0L,8L,4L,3L,9L,7L,3L,8L,6L,6L,2L,1L,5L,8L,6L,8L,1L,4L,0L,6L,4L,4L,3L,6L,2L,0L,9L,0L,4L,2L,4L,8L,6L,6L,7L,1L,9L,2L,1L,3L,5L,7L,1L,5L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020815Inst : IEnumerable<long>
{
public static readonly long[] Value=A020815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020815.Bytes);
public long this[int i]=>Value[i];

public static A020815Inst Instance=new A020815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020816
{
public static readonly long[] Value={ 1L,3L,0L,1L,8L,8L,9L,1L,0L,9L,8L,0L,8L,2L,3L,8L,6L,7L,3L,8L,5L,9L,2L,6L,8L,9L,8L,6L,7L,3L,4L,1L,3L,0L,9L,2L,7L,6L,3L,7L,7L,0L,3L,5L,7L,2L,4L,7L,7L,0L,9L,8L,9L,7L,0L,8L,5L,1L,6L,5L,0L,2L,5L,1L,5L,1L,4L,4L,9L,8L,5L,8L,6L,1L,0L,0L,4L,5L,9L,2L,9L,6L,9L,2L,4L,7L,5L,3L,8L,5L,2L,1L,9L,6L,8L,4L,3L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020816Inst : IEnumerable<long>
{
public static readonly long[] Value=A020816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020816.Bytes);
public long this[int i]=>Value[i];

public static A020816Inst Instance=new A020816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020817
{
public static readonly long[] Value={ 1L,2L,9L,0L,9L,9L,4L,4L,4L,8L,7L,3L,5L,8L,0L,5L,6L,2L,8L,3L,9L,3L,0L,8L,8L,4L,6L,6L,5L,9L,4L,1L,3L,3L,2L,0L,3L,6L,1L,0L,9L,7L,3L,9L,0L,1L,7L,6L,3L,8L,6L,3L,6L,0L,8L,8L,6L,2L,5L,2L,4L,5L,8L,8L,7L,0L,4L,4L,9L,4L,3L,6L,3L,9L,7L,8L,9L,9L,3L,0L,1L,1L,1L,7L,3L,0L,9L,5L,7L,9L,2L,2L,8L,6L,2L,2L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020817Inst : IEnumerable<long>
{
public static readonly long[] Value=A020817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020817.Bytes);
public long this[int i]=>Value[i];

public static A020817Inst Instance=new A020817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020818
{
public static readonly long[] Value={ 1L,2L,8L,0L,3L,6L,8L,7L,9L,9L,3L,2L,8L,9L,5L,9L,7L,3L,6L,7L,4L,2L,5L,7L,7L,4L,9L,7L,6L,6L,5L,4L,2L,6L,4L,6L,1L,2L,4L,0L,7L,0L,5L,7L,6L,0L,1L,0L,6L,3L,2L,1L,8L,5L,2L,4L,8L,8L,0L,7L,2L,7L,4L,7L,5L,7L,2L,2L,5L,9L,9L,3L,2L,6L,1L,2L,5L,7L,8L,2L,0L,5L,6L,4L,3L,5L,1L,3L,6L,1L,5L,1L,2L,5L,7L,3L,8L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020818Inst : IEnumerable<long>
{
public static readonly long[] Value=A020818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020818.Bytes);
public long this[int i]=>Value[i];

public static A020818Inst Instance=new A020818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020819
{
public static readonly long[] Value={ 1L,2L,7L,0L,0L,0L,1L,2L,7L,0L,0L,0L,1L,9L,0L,5L,0L,0L,3L,1L,7L,5L,0L,0L,5L,5L,5L,6L,2L,6L,0L,0L,0L,1L,2L,6L,8L,3L,3L,5L,6L,5L,9L,0L,5L,1L,9L,3L,8L,8L,4L,7L,3L,8L,6L,2L,2L,5L,6L,1L,9L,7L,6L,6L,1L,7L,9L,6L,3L,8L,8L,4L,6L,2L,6L,0L,9L,1L,9L,0L,4L,1L,4L,3L,9L,7L,0L,8L,2L,8L,2L,4L,5L,9L,4L,7L,5L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020819Inst : IEnumerable<long>
{
public static readonly long[] Value=A020819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020819.Bytes);
public long this[int i]=>Value[i];

public static A020819Inst Instance=new A020819Inst();

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