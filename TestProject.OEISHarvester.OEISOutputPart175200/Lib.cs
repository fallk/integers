using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A205657
{
public static readonly BigInteger[] Value={ 7854572L,76028256L,711793356L,10795687000L,183567605276L,2994560119488L,54588666013136L,946322990916328L,17957465680336828L,316121808578717168L,6072355548317464448L,BigInteger.Parse("107584942896241083216"),BigInteger.Parse("2075883483766878489344") };
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
public class A205657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205657.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205657Inst Instance=new A205657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205658
{
public static readonly BigInteger[] Value={ 62623348L,732727336L,9029185188L,186979308144L,4682468347176L,106351019923768L,2904705131186012L,69836058310563888L,1989650257922684392L,BigInteger.Parse("48627125950280766136"),BigInteger.Parse("1406446756952780801628"),BigInteger.Parse("34607286834571007711144") };
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
public class A205658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205658.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205658Inst Instance=new A205658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205659
{
public static readonly long[] Value={ 256L,1976L,2120L,15616L,12296L,17920L,124048L,95008L,75108L,151824L,986388L,839872L,511632L,489984L,1285076L,7854572L,7919128L,5016144L,3227968L,3323532L,10876432L,62623348L,76028256L,57716364L,41013960L,21711080L,23019504L,92062852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205659Inst : IEnumerable<long>
{
public static readonly long[] Value=A205659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205659.Bytes);
public long this[int i]=>Value[i];

public static A205659Inst Instance=new A205659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205660
{
public static readonly long[] Value={ 2120L,12296L,95008L,839872L,7919128L,76028256L,732727336L,7068433736L,68201154272L,658081945168L,6349980210408L,61272516345744L,591233822472776L,5704963557044152L,55048626862970856L,531178036521593464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205660Inst : IEnumerable<long>
{
public static readonly long[] Value=A205660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205660.Bytes);
public long this[int i]=>Value[i];

public static A205660Inst Instance=new A205660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205661
{
public static readonly long[] Value={ 17920L,75108L,511632L,5016144L,57716364L,711793356L,9029185188L,116521192256L,1523282290604L,20129642271816L,268462431802408L,3608677008865208L,48834442304831000L,664621463268289456L,9088721674482016988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205661Inst : IEnumerable<long>
{
public static readonly long[] Value=A205661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205661.Bytes);
public long this[int i]=>Value[i];

public static A205661Inst Instance=new A205661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205662
{
public static readonly BigInteger[] Value={ 151824L,489984L,3227968L,41013960L,639426584L,10795687000L,186979308144L,3289591226152L,58404502956504L,1043705190013648L,18728820730088272L,337062306215296488L,6077539808376264136L,BigInteger.Parse("109725805552567745304") };
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
public class A205662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205662Inst Instance=new A205662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205663
{
public static readonly BigInteger[] Value={ 1285076L,3323532L,21711080L,353779964L,7578064080L,183567605276L,4682468347176L,124579524794520L,3411090643151380L,95602219996726052L,2724704605809032788L,BigInteger.Parse("78683390684511013956"),BigInteger.Parse("2294465096368178137108") };
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
public class A205663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205663Inst Instance=new A205663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205664
{
public static readonly BigInteger[] Value={ 10876432L,23019504L,142040528L,3024213232L,88431310744L,2994560119488L,106351019923768L,3947775200832256L,149503185538394128L,5763112909967382456L,BigInteger.Parse("223893620074913870560"),BigInteger.Parse("8755461346870905553088"),BigInteger.Parse("343348919507562739830432") };
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
public class A205664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205664Inst Instance=new A205664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205665
{
public static readonly BigInteger[] Value={ 92062852L,162377816L,939384668L,26605030292L,1092079388028L,54588666013136L,2904705131186012L,166238466407276348L,9834684014476639808UL,BigInteger.Parse("601829146506334737576"),BigInteger.Parse("37463980727959096279020"),BigInteger.Parse("2369158930358310919375076") };
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
public class A205665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205665Inst Instance=new A205665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205666
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,10L,11L,12L,13L,16L,17L,18L,19L,38L,42L,43L,55L,63L,64L,68L,75L,76L,86L,106L,107L,108L,109L,112L,113L,120L,131L,156L,157L,175L,185L,194L,233L,270L,301L,369L,380L,438L,443L,470L,531L,663L,760L,803L,810L,847L,871L,934L,999L,1021L,1044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205666Inst : IEnumerable<long>
{
public static readonly long[] Value=A205666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205666.Bytes);
public long this[int i]=>Value[i];

public static A205666Inst Instance=new A205666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205667
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,12L,15L,19L,20L,21L,22L,24L,26L,28L,30L,33L,34L,36L,38L,39L,41L,42L,45L,50L,51L,54L,55L,56L,58L,61L,62L,63L,65L,70L,74L,76L,77L,78L,82L,85L,87L,89L,92L,93L,95L,101L,102L,105L,109L,110L,111L,114L,116L,118L,120L,121L,122L,124L,126L,128L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205667Inst : IEnumerable<long>
{
public static readonly long[] Value=A205667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205667.Bytes);
public long this[int i]=>Value[i];

public static A205667Inst Instance=new A205667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205668
{
public static readonly long[] Value={ 2L,3L,5L,97L,401L,787L,907L,1117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205668Inst : IEnumerable<long>
{
public static readonly long[] Value=A205668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205668.Bytes);
public long this[int i]=>Value[i];

public static A205668Inst Instance=new A205668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205669
{
public static readonly long[] Value={ 1L,5L,24L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205669Inst : IEnumerable<long>
{
public static readonly long[] Value=A205669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205669.Bytes);
public long this[int i]=>Value[i];

public static A205669Inst Instance=new A205669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205670
{
public static readonly long[] Value={ 1L,4L,20L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205670Inst : IEnumerable<long>
{
public static readonly long[] Value=A205670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205670.Bytes);
public long this[int i]=>Value[i];

public static A205670Inst Instance=new A205670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205671
{
public static readonly BigInteger[] Value={ 1L,-4L,40L,-656L,15008L,-440896L,15821440L,-670763264L,32806349312L,-1818238034944L,112618994575360L,-7709249275990016L,577965256979161088L,BigInteger.Parse("-47096523207273496576"),BigInteger.Parse("4144654003816138178560"),BigInteger.Parse("-391753493233853247586304") };
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
public class A205671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205671Inst Instance=new A205671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205672
{
public static readonly long[] Value={ 0L,87L,112L,184L,235L,376L,451L,595L,660L,987L,1440L,1575L,1971L,2256L,3055L,3484L,4312L,4687L,6580L,9211L,9996L,12300L,13959L,18612L,21111L,25935L,28120L,39151L,54484L,59059L,72487L,82156L,109275L,123840L,151956L,164691L,228984L,318351L,345016L,423280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205672Inst : IEnumerable<long>
{
public static readonly long[] Value=A205672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205672.Bytes);
public long this[int i]=>Value[i];

public static A205672Inst Instance=new A205672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205673
{
public static readonly long[] Value={ 5L,11L,11L,13L,17L,17L,17L,19L,19L,23L,23L,23L,23L,29L,29L,29L,29L,29L,31L,31L,31L,37L,37L,37L,37L,41L,41L,41L,41L,41L,41L,43L,43L,43L,43L,43L,47L,47L,47L,47L,47L,47L,47L,53L,53L,53L,53L,53L,53L,53L,53L,59L,59L,59L,59L,59L,59L,59L,59L,59L,61L,61L,61L,61L,61L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205673Inst : IEnumerable<long>
{
public static readonly long[] Value=A205673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205673.Bytes);
public long this[int i]=>Value[i];

public static A205673Inst Instance=new A205673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205674
{
public static readonly long[] Value={ 2L,2L,5L,7L,2L,5L,11L,7L,13L,2L,5L,11L,17L,2L,5L,11L,17L,23L,7L,13L,19L,7L,13L,19L,31L,2L,5L,11L,17L,23L,29L,7L,13L,19L,31L,37L,2L,5L,11L,17L,23L,29L,41L,2L,5L,11L,17L,23L,29L,41L,47L,2L,5L,11L,17L,23L,29L,41L,47L,53L,7L,13L,19L,31L,37L,43L,7L,13L,19L,31L,37L,43L,61L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205674Inst : IEnumerable<long>
{
public static readonly long[] Value=A205674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205674.Bytes);
public long this[int i]=>Value[i];

public static A205674Inst Instance=new A205674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205675
{
public static readonly long[] Value={ 1L,3L,2L,2L,5L,4L,2L,4L,2L,7L,6L,4L,2L,9L,8L,6L,4L,2L,8L,6L,4L,10L,8L,6L,2L,13L,12L,10L,8L,6L,4L,12L,10L,8L,4L,2L,15L,14L,12L,10L,8L,6L,2L,17L,16L,14L,12L,10L,8L,4L,2L,19L,18L,16L,14L,12L,10L,6L,4L,2L,18L,16L,14L,10L,8L,6L,20L,18L,16L,12L,10L,8L,2L,23L,22L,20L,18L,16L,14L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205675Inst : IEnumerable<long>
{
public static readonly long[] Value=A205675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205675.Bytes);
public long this[int i]=>Value[i];

public static A205675Inst Instance=new A205675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205676
{
public static readonly long[] Value={ 5L,8L,10L,13L,18L,21L,23L,25L,26L,30L,32L,33L,36L,39L,42L,43L,47L,49L,50L,53L,54L,58L,61L,62L,65L,69L,72L,73L,76L,78L,80L,82L,83L,86L,87L,89L,93L,95L,96L,99L,100L,102L,105L,108L,111L,112L,115L,117L,118L,122L,124L,125L,128L,129L,131L,134L,135L,139L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205676Inst : IEnumerable<long>
{
public static readonly long[] Value=A205676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205676.Bytes);
public long this[int i]=>Value[i];

public static A205676Inst Instance=new A205676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205677
{
public static readonly long[] Value={ 4L,5L,5L,6L,7L,7L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205677Inst : IEnumerable<long>
{
public static readonly long[] Value=A205677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205677.Bytes);
public long this[int i]=>Value[i];

public static A205677Inst Instance=new A205677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205678
{
public static readonly long[] Value={ 2L,2L,4L,3L,3L,6L,2L,4L,5L,2L,4L,5L,8L,3L,6L,7L,2L,4L,5L,8L,9L,3L,6L,7L,10L,3L,6L,7L,10L,12L,2L,4L,5L,8L,9L,11L,2L,4L,5L,8L,9L,11L,14L,3L,6L,7L,10L,12L,13L,2L,4L,5L,8L,9L,11L,14L,15L,3L,6L,7L,10L,12L,13L,16L,2L,4L,5L,8L,9L,11L,14L,15L,17L,2L,4L,5L,8L,9L,11L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205678Inst : IEnumerable<long>
{
public static readonly long[] Value=A205678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205678.Bytes);
public long this[int i]=>Value[i];

public static A205678Inst Instance=new A205678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205679
{
public static readonly long[] Value={ 7L,11L,11L,13L,17L,17L,19L,19L,19L,23L,23L,23L,23L,29L,29L,29L,31L,31L,31L,31L,31L,37L,37L,37L,37L,41L,41L,41L,41L,41L,43L,43L,43L,43L,43L,43L,47L,47L,47L,47L,47L,47L,47L,53L,53L,53L,53L,53L,53L,59L,59L,59L,59L,59L,59L,59L,59L,61L,61L,61L,61L,61L,61L,61L,67L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205679Inst : IEnumerable<long>
{
public static readonly long[] Value=A205679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205679.Bytes);
public long this[int i]=>Value[i];

public static A205679Inst Instance=new A205679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205680
{
public static readonly long[] Value={ 3L,3L,7L,5L,5L,13L,3L,7L,11L,3L,7L,11L,19L,5L,13L,17L,3L,7L,11L,19L,23L,5L,13L,17L,29L,5L,13L,17L,29L,37L,3L,7L,11L,19L,23L,31L,3L,7L,11L,19L,23L,31L,43L,5L,13L,17L,29L,37L,41L,3L,7L,11L,19L,23L,31L,43L,47L,5L,13L,17L,29L,37L,41L,53L,3L,7L,11L,19L,23L,31L,43L,47L,59L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205680Inst : IEnumerable<long>
{
public static readonly long[] Value=A205680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205680.Bytes);
public long this[int i]=>Value[i];

public static A205680Inst Instance=new A205680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205681
{
public static readonly long[] Value={ 4L,8L,4L,8L,12L,4L,16L,12L,8L,20L,16L,12L,4L,24L,16L,12L,28L,24L,20L,12L,8L,32L,24L,20L,8L,36L,28L,24L,12L,4L,40L,36L,32L,24L,20L,12L,44L,40L,36L,28L,24L,16L,4L,48L,40L,36L,24L,16L,12L,56L,52L,48L,40L,36L,28L,16L,12L,56L,48L,44L,32L,24L,20L,8L,64L,60L,56L,48L,44L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205681Inst : IEnumerable<long>
{
public static readonly long[] Value=A205681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205681.Bytes);
public long this[int i]=>Value[i];

public static A205681Inst Instance=new A205681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205682
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,4L,3L,2L,5L,4L,3L,1L,6L,4L,3L,7L,6L,5L,3L,2L,8L,6L,5L,2L,9L,7L,6L,3L,1L,10L,9L,8L,6L,5L,3L,11L,10L,9L,7L,6L,4L,1L,12L,10L,9L,6L,4L,3L,14L,13L,12L,10L,9L,7L,4L,3L,14L,12L,11L,8L,6L,5L,2L,16L,15L,14L,12L,11L,9L,6L,5L,2L,17L,16L,15L,13L,12L,10L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205682Inst : IEnumerable<long>
{
public static readonly long[] Value=A205682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205682.Bytes);
public long this[int i]=>Value[i];

public static A205682Inst Instance=new A205682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205683
{
public static readonly long[] Value={ 4L,12L,16L,19L,30L,34L,44L,50L,56L,59L,62L,71L,77L,80L,84L,87L,92L,95L,98L,103L,107L,111L,114L,119L,128L,130L,141L,147L,149L,154L,157L,160L,165L,168L,176L,182L,184L,189L,192L,196L,199L,204L,206L,218L,220L,227L,233L,237L,240L,245L,247L,252L,261L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205683Inst : IEnumerable<long>
{
public static readonly long[] Value=A205683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205683.Bytes);
public long this[int i]=>Value[i];

public static A205683Inst Instance=new A205683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205684
{
public static readonly long[] Value={ 4L,6L,7L,7L,9L,9L,10L,11L,12L,12L,12L,13L,13L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,18L,18L,18L,19L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,25L,25L,26L,26L,26L,26L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205684Inst : IEnumerable<long>
{
public static readonly long[] Value=A205684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205684.Bytes);
public long this[int i]=>Value[i];

public static A205684Inst Instance=new A205684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205685
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,6L,8L,5L,1L,4L,7L,5L,11L,2L,6L,9L,1L,4L,7L,12L,2L,6L,9L,14L,8L,10L,5L,11L,13L,1L,4L,7L,12L,15L,5L,11L,13L,18L,2L,6L,9L,14L,16L,8L,10L,17L,2L,6L,9L,14L,16L,21L,8L,10L,17L,22L,1L,4L,7L,12L,15L,19L,5L,11L,13L,18L,20L,2L,6L,9L,14L,16L,21L,23L,1L,4L,7L,12L,15L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205685Inst : IEnumerable<long>
{
public static readonly long[] Value=A205685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205685.Bytes);
public long this[int i]=>Value[i];

public static A205685Inst Instance=new A205685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205686
{
public static readonly long[] Value={ 7L,13L,17L,17L,23L,23L,29L,31L,37L,37L,37L,41L,41L,43L,43L,43L,47L,47L,47L,47L,53L,53L,53L,53L,59L,59L,61L,61L,61L,67L,67L,67L,67L,67L,71L,71L,71L,71L,73L,73L,73L,73L,73L,79L,79L,79L,83L,83L,83L,83L,83L,83L,89L,89L,89L,89L,97L,97L,97L,97L,97L,97L,101L,101L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205686Inst : IEnumerable<long>
{
public static readonly long[] Value=A205686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205686.Bytes);
public long this[int i]=>Value[i];

public static A205686Inst Instance=new A205686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205687
{
public static readonly long[] Value={ 2L,3L,2L,7L,3L,13L,19L,11L,2L,7L,17L,11L,31L,3L,13L,23L,2L,7L,17L,37L,3L,13L,23L,43L,19L,29L,11L,31L,41L,2L,7L,17L,37L,47L,11L,31L,41L,61L,3L,13L,23L,43L,53L,19L,29L,59L,3L,13L,23L,43L,53L,73L,19L,29L,59L,79L,2L,7L,17L,37L,47L,67L,11L,31L,41L,61L,71L,3L,13L,23L,43L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205687Inst : IEnumerable<long>
{
public static readonly long[] Value=A205687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205687.Bytes);
public long this[int i]=>Value[i];

public static A205687Inst Instance=new A205687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205688
{
public static readonly long[] Value={ 5L,10L,15L,10L,20L,10L,10L,20L,35L,30L,20L,30L,10L,40L,30L,20L,45L,40L,30L,10L,50L,40L,30L,10L,40L,30L,50L,30L,20L,65L,60L,50L,30L,20L,60L,40L,30L,10L,70L,60L,50L,30L,20L,60L,50L,20L,80L,70L,60L,40L,30L,10L,70L,60L,30L,10L,95L,90L,80L,60L,50L,30L,90L,70L,60L,40L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205688Inst : IEnumerable<long>
{
public static readonly long[] Value=A205688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205688.Bytes);
public long this[int i]=>Value[i];

public static A205688Inst Instance=new A205688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205689
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,2L,4L,7L,6L,4L,6L,2L,8L,6L,4L,9L,8L,6L,2L,10L,8L,6L,2L,8L,6L,10L,6L,4L,13L,12L,10L,6L,4L,12L,8L,6L,2L,14L,12L,10L,6L,4L,12L,10L,4L,16L,14L,12L,8L,6L,2L,14L,12L,6L,2L,19L,18L,16L,12L,10L,6L,18L,14L,12L,8L,6L,20L,18L,16L,12L,10L,6L,4L,21L,20L,18L,14L,12L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205689Inst : IEnumerable<long>
{
public static readonly long[] Value=A205689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205689.Bytes);
public long this[int i]=>Value[i];

public static A205689Inst Instance=new A205689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205690
{
public static readonly long[] Value={ 9L,14L,18L,20L,25L,27L,31L,33L,35L,39L,41L,43L,45L,49L,51L,53L,59L,61L,63L,66L,69L,71L,73L,75L,76L,82L,84L,86L,89L,90L,94L,96L,98L,100L,101L,104L,108L,110L,112L,114L,115L,118L,120L,123L,125L,127L,129L,130L,133L,135L,136L,140L,142L,144L,147L,148L,150L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205690Inst : IEnumerable<long>
{
public static readonly long[] Value=A205690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205690.Bytes);
public long this[int i]=>Value[i];

public static A205690Inst Instance=new A205690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205691
{
public static readonly long[] Value={ 5L,6L,7L,7L,8L,8L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205691Inst : IEnumerable<long>
{
public static readonly long[] Value=A205691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205691.Bytes);
public long this[int i]=>Value[i];

public static A205691Inst Instance=new A205691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205692
{
public static readonly long[] Value={ 3L,4L,3L,5L,4L,6L,3L,5L,7L,3L,5L,7L,9L,4L,6L,8L,4L,6L,8L,11L,3L,5L,7L,9L,10L,4L,6L,8L,11L,12L,3L,5L,7L,9L,10L,13L,3L,5L,7L,9L,10L,13L,15L,3L,5L,7L,9L,10L,13L,15L,16L,4L,6L,8L,11L,12L,14L,4L,6L,8L,11L,12L,14L,18L,3L,5L,7L,9L,10L,13L,15L,16L,17L,4L,6L,8L,11L,12L,14L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205692Inst : IEnumerable<long>
{
public static readonly long[] Value=A205692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205692.Bytes);
public long this[int i]=>Value[i];

public static A205692Inst Instance=new A205692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205693
{
public static readonly long[] Value={ 11L,13L,17L,17L,19L,19L,23L,23L,23L,29L,29L,29L,29L,31L,31L,31L,37L,37L,37L,37L,41L,41L,41L,41L,41L,43L,43L,43L,43L,43L,47L,47L,47L,47L,47L,47L,53L,53L,53L,53L,53L,53L,53L,59L,59L,59L,59L,59L,59L,59L,59L,61L,61L,61L,61L,61L,61L,67L,67L,67L,67L,67L,67L,67L,71L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205693Inst : IEnumerable<long>
{
public static readonly long[] Value=A205693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205693.Bytes);
public long this[int i]=>Value[i];

public static A205693Inst Instance=new A205693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205694
{
public static readonly long[] Value={ 5L,7L,5L,11L,7L,13L,5L,11L,17L,5L,11L,17L,23L,7L,13L,19L,7L,13L,19L,31L,5L,11L,17L,23L,29L,7L,13L,19L,31L,37L,5L,11L,17L,23L,29L,41L,5L,11L,17L,23L,29L,41L,47L,5L,11L,17L,23L,29L,41L,47L,53L,7L,13L,19L,31L,37L,43L,7L,13L,19L,31L,37L,43L,61L,5L,11L,17L,23L,29L,41L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205694Inst : IEnumerable<long>
{
public static readonly long[] Value=A205694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205694.Bytes);
public long this[int i]=>Value[i];

public static A205694Inst Instance=new A205694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205695
{
public static readonly long[] Value={ 6L,6L,12L,6L,12L,6L,18L,12L,6L,24L,18L,12L,6L,24L,18L,12L,30L,24L,18L,6L,36L,30L,24L,18L,12L,36L,30L,24L,12L,6L,42L,36L,30L,24L,18L,6L,48L,42L,36L,30L,24L,12L,6L,54L,48L,42L,36L,30L,18L,12L,6L,54L,48L,42L,30L,24L,18L,60L,54L,48L,36L,30L,24L,6L,66L,60L,54L,48L,42L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205695Inst : IEnumerable<long>
{
public static readonly long[] Value=A205695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205695.Bytes);
public long this[int i]=>Value[i];

public static A205695Inst Instance=new A205695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205696
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,4L,3L,2L,5L,4L,3L,1L,6L,5L,4L,3L,2L,6L,5L,4L,2L,1L,7L,6L,5L,4L,3L,1L,8L,7L,6L,5L,4L,2L,1L,9L,8L,7L,6L,5L,3L,2L,1L,9L,8L,7L,5L,4L,3L,10L,9L,8L,6L,5L,4L,1L,11L,10L,9L,8L,7L,5L,4L,3L,2L,11L,10L,9L,7L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205696Inst : IEnumerable<long>
{
public static readonly long[] Value=A205696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205696.Bytes);
public long this[int i]=>Value[i];

public static A205696Inst Instance=new A205696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205697
{
public static readonly long[] Value={ 17L,24L,29L,47L,52L,56L,64L,72L,88L,94L,99L,110L,122L,127L,131L,139L,144L,151L,158L,169L,181L,185L,192L,197L,201L,207L,211L,219L,222L,237L,244L,256L,261L,268L,271L,282L,289L,299L,302L,307L,311L,317L,321L,328L,333L,340L,343L,349L,352L,360L,363L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205697Inst : IEnumerable<long>
{
public static readonly long[] Value=A205697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205697.Bytes);
public long this[int i]=>Value[i];

public static A205697Inst Instance=new A205697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205698
{
public static readonly long[] Value={ 7L,8L,9L,11L,11L,12L,12L,13L,14L,15L,15L,16L,17L,17L,17L,18L,18L,18L,19L,19L,20L,20L,21L,21L,21L,21L,22L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,26L,26L,26L,26L,26L,27L,27L,27L,27L,27L,28L,28L,28L,28L,29L,29L,29L,30L,30L,30L,31L,31L,31L,31L,32L,32L,32L,32L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205698Inst : IEnumerable<long>
{
public static readonly long[] Value=A205698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205698.Bytes);
public long this[int i]=>Value[i];

public static A205698Inst Instance=new A205698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205699
{
public static readonly long[] Value={ 2L,3L,1L,2L,7L,1L,9L,6L,10L,3L,8L,5L,2L,7L,11L,3L,8L,15L,5L,16L,10L,14L,2L,7L,11L,17L,1L,9L,12L,6L,13L,3L,8L,15L,18L,6L,13L,23L,2L,7L,11L,17L,21L,3L,8L,15L,18L,24L,1L,9L,12L,22L,5L,16L,19L,10L,14L,20L,10L,14L,20L,30L,3L,8L,15L,18L,24L,27L,5L,16L,19L,29L,6L,13L,23L,25L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205699Inst : IEnumerable<long>
{
public static readonly long[] Value=A205699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205699.Bytes);
public long this[int i]=>Value[i];

public static A205699Inst Instance=new A205699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205700
{
public static readonly long[] Value={ 17L,19L,23L,31L,31L,37L,37L,41L,43L,47L,47L,53L,59L,59L,59L,61L,61L,61L,67L,67L,71L,71L,73L,73L,73L,73L,79L,79L,79L,83L,83L,89L,89L,89L,89L,97L,97L,97L,101L,101L,101L,101L,101L,103L,103L,103L,103L,103L,107L,107L,107L,107L,109L,109L,109L,113L,113L,113L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205700Inst : IEnumerable<long>
{
public static readonly long[] Value=A205700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205700.Bytes);
public long this[int i]=>Value[i];

public static A205700Inst Instance=new A205700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205701
{
public static readonly long[] Value={ 3L,5L,2L,3L,17L,2L,23L,13L,29L,5L,19L,11L,3L,17L,31L,5L,19L,47L,11L,53L,29L,43L,3L,17L,31L,59L,2L,23L,37L,13L,41L,5L,19L,47L,61L,13L,41L,83L,3L,17L,31L,59L,73L,5L,19L,47L,61L,89L,2L,23L,37L,79L,11L,53L,67L,29L,43L,71L,29L,43L,71L,113L,5L,19L,47L,61L,89L,103L,11L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205701Inst : IEnumerable<long>
{
public static readonly long[] Value=A205701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205701.Bytes);
public long this[int i]=>Value[i];

public static A205701Inst Instance=new A205701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205702
{
public static readonly long[] Value={ 14L,14L,21L,28L,14L,35L,14L,28L,14L,42L,28L,42L,56L,42L,28L,56L,42L,14L,56L,14L,42L,28L,70L,56L,42L,14L,77L,56L,42L,70L,42L,84L,70L,42L,28L,84L,56L,14L,98L,84L,70L,42L,28L,98L,84L,56L,42L,14L,105L,84L,70L,28L,98L,56L,42L,84L,70L,42L,98L,84L,56L,14L,126L,112L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205702Inst : IEnumerable<long>
{
public static readonly long[] Value=A205702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205702.Bytes);
public long this[int i]=>Value[i];

public static A205702Inst Instance=new A205702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205703
{
public static readonly long[] Value={ 2L,2L,3L,4L,2L,5L,2L,4L,2L,6L,4L,6L,8L,6L,4L,8L,6L,2L,8L,2L,6L,4L,10L,8L,6L,2L,11L,8L,6L,10L,6L,12L,10L,6L,4L,12L,8L,2L,14L,12L,10L,6L,4L,14L,12L,8L,6L,2L,15L,12L,10L,4L,14L,8L,6L,12L,10L,6L,14L,12L,8L,2L,18L,16L,12L,10L,6L,4L,18L,12L,10L,4L,18L,14L,8L,6L,21L,18L,16L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205703Inst : IEnumerable<long>
{
public static readonly long[] Value=A205703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205703.Bytes);
public long this[int i]=>Value[i];

public static A205703Inst Instance=new A205703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205704
{
public static readonly long[] Value={ 8L,13L,23L,26L,32L,39L,42L,49L,54L,58L,61L,65L,73L,80L,83L,86L,95L,100L,102L,108L,111L,115L,117L,122L,125L,128L,134L,139L,142L,146L,148L,152L,155L,158L,161L,167L,170L,175L,180L,182L,186L,197L,203L,214L,219L,221L,225L,230L,233L,236L,239L,245L,248L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205704Inst : IEnumerable<long>
{
public static readonly long[] Value=A205704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205704.Bytes);
public long this[int i]=>Value[i];

public static A205704Inst Instance=new A205704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205705
{
public static readonly long[] Value={ 5L,6L,8L,8L,9L,10L,10L,11L,11L,12L,12L,12L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,22L,22L,22L,22L,22L,23L,23L,23L,23L,23L,23L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,26L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205705Inst : IEnumerable<long>
{
public static readonly long[] Value=A205705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205705.Bytes);
public long this[int i]=>Value[i];

public static A205705Inst Instance=new A205705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205706
{
public static readonly long[] Value={ 2L,3L,2L,5L,4L,3L,6L,4L,9L,3L,6L,10L,7L,2L,5L,8L,4L,9L,11L,3L,6L,10L,12L,2L,5L,8L,14L,3L,6L,10L,12L,16L,2L,5L,8L,14L,17L,4L,9L,11L,15L,7L,13L,4L,9L,11L,15L,20L,2L,5L,8L,14L,17L,19L,7L,13L,21L,7L,13L,21L,24L,3L,6L,10L,12L,16L,18L,4L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205706Inst : IEnumerable<long>
{
public static readonly long[] Value=A205706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205706.Bytes);
public long this[int i]=>Value[i];

public static A205706Inst Instance=new A205706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205707
{
public static readonly long[] Value={ 11L,13L,19L,19L,23L,29L,29L,31L,31L,37L,37L,37L,41L,43L,43L,43L,47L,47L,47L,53L,53L,53L,53L,59L,59L,59L,59L,61L,61L,61L,61L,61L,67L,67L,67L,67L,67L,71L,71L,71L,71L,73L,73L,79L,79L,79L,79L,79L,83L,83L,83L,83L,83L,83L,89L,89L,89L,97L,97L,97L,97L,101L,101L,101L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205707Inst : IEnumerable<long>
{
public static readonly long[] Value=A205707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205707.Bytes);
public long this[int i]=>Value[i];

public static A205707Inst Instance=new A205707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205708
{
public static readonly long[] Value={ 3L,5L,3L,11L,7L,5L,13L,7L,23L,5L,13L,29L,17L,3L,11L,19L,7L,23L,31L,5L,13L,29L,37L,3L,11L,19L,43L,5L,13L,29L,37L,53L,3L,11L,19L,43L,59L,7L,23L,31L,47L,17L,41L,7L,23L,31L,47L,71L,3L,11L,19L,43L,59L,67L,17L,41L,73L,17L,41L,73L,89L,5L,13L,29L,37L,53L,61L,7L,23L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205708Inst : IEnumerable<long>
{
public static readonly long[] Value=A205708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205708.Bytes);
public long this[int i]=>Value[i];

public static A205708Inst Instance=new A205708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205709
{
public static readonly long[] Value={ 8L,8L,16L,8L,16L,24L,16L,24L,8L,32L,24L,8L,24L,40L,32L,24L,40L,24L,16L,48L,40L,24L,16L,56L,48L,40L,16L,56L,48L,32L,24L,8L,64L,56L,48L,24L,8L,64L,48L,40L,24L,56L,32L,72L,56L,48L,32L,8L,80L,72L,64L,40L,24L,16L,72L,48L,16L,80L,56L,24L,8L,96L,88L,72L,64L,48L,40L,96L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205709Inst : IEnumerable<long>
{
public static readonly long[] Value=A205709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205709.Bytes);
public long this[int i]=>Value[i];

public static A205709Inst Instance=new A205709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205710
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,2L,3L,1L,4L,3L,1L,3L,5L,4L,3L,5L,3L,2L,6L,5L,3L,2L,7L,6L,5L,2L,7L,6L,4L,3L,1L,8L,7L,6L,3L,1L,8L,6L,5L,3L,7L,4L,9L,7L,6L,4L,1L,10L,9L,8L,5L,3L,2L,9L,6L,2L,10L,7L,3L,1L,12L,11L,9L,8L,6L,5L,12L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205710Inst : IEnumerable<long>
{
public static readonly long[] Value=A205710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205710.Bytes);
public long this[int i]=>Value[i];

public static A205710Inst Instance=new A205710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205711
{
public static readonly long[] Value={ 7L,31L,37L,41L,51L,63L,69L,75L,82L,92L,96L,101L,112L,123L,129L,133L,140L,150L,159L,164L,178L,187L,198L,202L,214L,224L,228L,232L,236L,241L,246L,260L,269L,273L,280L,290L,294L,298L,301L,305L,310L,315L,323L,331L,336L,344L,358L,367L,371L,375L,386L,390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205711Inst : IEnumerable<long>
{
public static readonly long[] Value=A205711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205711.Bytes);
public long this[int i]=>Value[i];

public static A205711Inst Instance=new A205711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205712
{
public static readonly long[] Value={ 5L,9L,10L,10L,11L,12L,13L,13L,14L,15L,15L,15L,16L,17L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,22L,23L,23L,23L,23L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,26L,26L,27L,27L,27L,28L,28L,28L,28L,29L,29L,29L,30L,30L,30L,30L,31L,31L,31L,31L,32L,32L,32L,32L,32L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205712Inst : IEnumerable<long>
{
public static readonly long[] Value=A205712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205712.Bytes);
public long this[int i]=>Value[i];

public static A205712Inst Instance=new A205712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205713
{
public static readonly long[] Value={ 1L,3L,1L,5L,6L,8L,3L,9L,4L,1L,5L,10L,7L,3L,9L,13L,4L,14L,6L,11L,7L,16L,8L,12L,4L,14L,18L,1L,5L,10L,15L,7L,16L,20L,4L,14L,18L,22L,1L,5L,10L,15L,23L,6L,11L,19L,7L,16L,20L,24L,8L,12L,21L,3L,9L,13L,17L,8L,12L,21L,29L,3L,9L,13L,17L,30L,1L,5L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205713Inst : IEnumerable<long>
{
public static readonly long[] Value=A205713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205713.Bytes);
public long this[int i]=>Value[i];

public static A205713Inst Instance=new A205713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205714
{
public static readonly long[] Value={ 11L,23L,29L,29L,31L,37L,41L,41L,43L,47L,47L,47L,53L,59L,59L,59L,61L,61L,67L,67L,71L,71L,73L,73L,79L,79L,79L,83L,83L,83L,83L,89L,89L,89L,97L,97L,97L,97L,101L,101L,101L,101L,101L,103L,103L,103L,107L,107L,107L,107L,109L,109L,109L,113L,113L,113L,113L,127L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205714Inst : IEnumerable<long>
{
public static readonly long[] Value=A205714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205714.Bytes);
public long this[int i]=>Value[i];

public static A205714Inst Instance=new A205714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205715
{
public static readonly long[] Value={ 2L,5L,2L,11L,13L,19L,5L,23L,7L,2L,11L,29L,17L,5L,23L,41L,7L,43L,13L,31L,17L,53L,19L,37L,7L,43L,61L,2L,11L,29L,47L,17L,53L,71L,7L,43L,61L,79L,2L,11L,29L,47L,83L,13L,31L,67L,17L,53L,71L,89L,19L,37L,73L,5L,23L,41L,59L,19L,37L,73L,109L,5L,23L,41L,59L,113L,2L,11L,29L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205715Inst : IEnumerable<long>
{
public static readonly long[] Value=A205715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205715.Bytes);
public long this[int i]=>Value[i];

public static A205715Inst Instance=new A205715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205716
{
public static readonly long[] Value={ 9L,18L,27L,18L,18L,18L,36L,18L,36L,45L,36L,18L,36L,54L,36L,18L,54L,18L,54L,36L,54L,18L,54L,36L,72L,36L,18L,81L,72L,54L,36L,72L,36L,18L,90L,54L,36L,18L,99L,90L,72L,54L,18L,90L,72L,36L,90L,54L,36L,18L,90L,72L,36L,108L,90L,72L,54L,108L,90L,54L,18L,126L,108L,90L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205716Inst : IEnumerable<long>
{
public static readonly long[] Value=A205716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205716.Bytes);
public long this[int i]=>Value[i];

public static A205716Inst Instance=new A205716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205717
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,2L,4L,2L,4L,5L,4L,2L,4L,6L,4L,2L,6L,2L,6L,4L,6L,2L,6L,4L,8L,4L,2L,9L,8L,6L,4L,8L,4L,2L,10L,6L,4L,2L,11L,10L,8L,6L,2L,10L,8L,4L,10L,6L,4L,2L,10L,8L,4L,12L,10L,8L,6L,12L,10L,6L,2L,14L,12L,10L,8L,2L,15L,14L,12L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205717Inst : IEnumerable<long>
{
public static readonly long[] Value=A205717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205717.Bytes);
public long this[int i]=>Value[i];

public static A205717Inst Instance=new A205717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205718
{
public static readonly long[] Value={ 12L,19L,30L,34L,44L,50L,59L,62L,71L,77L,80L,84L,87L,95L,98L,103L,107L,111L,114L,119L,128L,130L,141L,147L,149L,157L,160L,165L,168L,176L,182L,184L,189L,192L,196L,199L,204L,206L,218L,220L,227L,233L,237L,240L,245L,247L,252L,261L,263L,270L,275L,280L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205718Inst : IEnumerable<long>
{
public static readonly long[] Value=A205718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205718.Bytes);
public long this[int i]=>Value[i];

public static A205718Inst Instance=new A205718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205719
{
public static readonly BigInteger[] Value={ 5L,11L,37L,613L,10949L,63245989L,679891637638612261L,BigInteger.Parse("7308805952221443105020355493"),BigInteger.Parse("13598018856492162040239554477268293"),BigInteger.Parse("453973694165307953197296969697410619233829") };
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
public class A205719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205719.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205719Inst Instance=new A205719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205720
{
public static readonly long[] Value={ 6L,7L,9L,9L,10L,11L,12L,12L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,16L,17L,17L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,25L,26L,26L,26L,26L,26L,27L,27L,27L,27L,27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205720Inst : IEnumerable<long>
{
public static readonly long[] Value=A205720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205720.Bytes);
public long this[int i]=>Value[i];

public static A205720Inst Instance=new A205720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205721
{
public static readonly long[] Value={ 2L,4L,2L,6L,8L,5L,4L,7L,5L,11L,2L,6L,9L,4L,7L,12L,2L,6L,9L,14L,8L,10L,5L,11L,13L,4L,7L,12L,15L,5L,11L,13L,18L,2L,6L,9L,14L,16L,8L,10L,17L,2L,6L,9L,14L,16L,21L,8L,10L,17L,22L,4L,7L,12L,15L,19L,5L,11L,13L,18L,20L,2L,6L,9L,14L,16L,21L,23L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205721Inst : IEnumerable<long>
{
public static readonly long[] Value=A205721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205721.Bytes);
public long this[int i]=>Value[i];

public static A205721Inst Instance=new A205721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205722
{
public static readonly long[] Value={ 13L,17L,23L,23L,29L,31L,37L,37L,41L,41L,43L,43L,43L,47L,47L,47L,53L,53L,53L,53L,59L,59L,61L,61L,61L,67L,67L,67L,67L,71L,71L,71L,71L,73L,73L,73L,73L,73L,79L,79L,79L,83L,83L,83L,83L,83L,83L,89L,89L,89L,89L,97L,97L,97L,97L,97L,101L,101L,101L,101L,101L,103L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205722Inst : IEnumerable<long>
{
public static readonly long[] Value=A205722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205722.Bytes);
public long this[int i]=>Value[i];

public static A205722Inst Instance=new A205722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205723
{
public static readonly long[] Value={ 3L,7L,3L,13L,19L,11L,7L,17L,11L,31L,3L,13L,23L,7L,17L,37L,3L,13L,23L,43L,19L,29L,11L,31L,41L,7L,17L,37L,47L,11L,31L,41L,61L,3L,13L,23L,43L,53L,19L,29L,59L,3L,13L,23L,43L,53L,73L,19L,29L,59L,79L,7L,17L,37L,47L,67L,11L,31L,41L,61L,71L,3L,13L,23L,43L,53L,73L,83L,7L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205723Inst : IEnumerable<long>
{
public static readonly long[] Value=A205723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205723.Bytes);
public long this[int i]=>Value[i];

public static A205723Inst Instance=new A205723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205724
{
public static readonly long[] Value={ 10L,10L,20L,10L,10L,20L,30L,20L,30L,10L,40L,30L,20L,40L,30L,10L,50L,40L,30L,10L,40L,30L,50L,30L,20L,60L,50L,30L,20L,60L,40L,30L,10L,70L,60L,50L,30L,20L,60L,50L,20L,80L,70L,60L,40L,30L,10L,70L,60L,30L,10L,90L,80L,60L,50L,30L,90L,70L,60L,40L,30L,100L,90L,80L,60L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205724Inst : IEnumerable<long>
{
public static readonly long[] Value=A205724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205724.Bytes);
public long this[int i]=>Value[i];

public static A205724Inst Instance=new A205724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205725
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,3L,2L,3L,1L,4L,3L,2L,4L,3L,1L,5L,4L,3L,1L,4L,3L,5L,3L,2L,6L,5L,3L,2L,6L,4L,3L,1L,7L,6L,5L,3L,2L,6L,5L,2L,8L,7L,6L,4L,3L,1L,7L,6L,3L,1L,9L,8L,6L,5L,3L,9L,7L,6L,4L,3L,10L,9L,8L,6L,5L,3L,2L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205725Inst : IEnumerable<long>
{
public static readonly long[] Value=A205725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205725.Bytes);
public long this[int i]=>Value[i];

public static A205725Inst Instance=new A205725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205726
{
public static readonly long[] Value={ 0L,1L,3L,6L,9L,13L,17L,22L,26L,34L,40L,48L,56L,62L,75L,82L,90L,103L,114L,126L,135L,149L,164L,179L,190L,202L,220L,236L,253L,270L,289L,304L,320L,340L,360L,381L,404L,425L,443L,462L,484L,508L,533L,556L,581L,604L,634L,655L,678L,709L,738L,761L,783L,813L,846L,881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205726Inst : IEnumerable<long>
{
public static readonly long[] Value=A205726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205726.Bytes);
public long this[int i]=>Value[i];

public static A205726Inst Instance=new A205726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205727
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,6L,8L,11L,14L,19L,23L,28L,33L,37L,46L,51L,56L,66L,73L,80L,88L,96L,108L,118L,126L,134L,148L,159L,172L,183L,197L,207L,220L,234L,249L,263L,280L,297L,309L,323L,338L,356L,376L,393L,412L,427L,449L,465L,482L,505L,527L,544L,561L,582L,606L,634L,658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205727Inst : IEnumerable<long>
{
public static readonly long[] Value=A205727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205727.Bytes);
public long this[int i]=>Value[i];

public static A205727Inst Instance=new A205727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205728
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,5L,8L,11L,16L,19L,24L,28L,32L,41L,46L,50L,60L,66L,73L,81L,89L,100L,110L,118L,126L,140L,151L,163L,174L,187L,197L,210L,224L,239L,253L,269L,286L,298L,312L,326L,344L,363L,380L,399L,414L,435L,451L,468L,491L,513L,530L,546L,567L,591L,619L,643L,664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205728Inst : IEnumerable<long>
{
public static readonly long[] Value=A205728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205728.Bytes);
public long this[int i]=>Value[i];

public static A205728Inst Instance=new A205728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205729
{
public static readonly BigInteger[] Value={ 81L,978L,14715L,223560L,10821462L,276139080L,34742828298L,1546577050248L,556035975944622L,43620596248679868L,BigInteger.Parse("46584601562741639715"),BigInteger.Parse("6531489127833773748528") };
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
public class A205729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205729Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205729.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205729.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205729Inst Instance=new A205729Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205730
{
public static readonly long[] Value={ 369L,978L,3318L,9198L,34674L,97380L,370008L,1053624L,4060848L,11593452L,44691564L,127862298L,493245942L,1412611194L,5445496374L,15610049862L,60135842922L,172528522548L,664117714260L,1906895501304L,7334482622244L,21076547401356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205730Inst : IEnumerable<long>
{
public static readonly long[] Value=A205730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205730.Bytes);
public long this[int i]=>Value[i];

public static A205730Inst Instance=new A205730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205731
{
public static readonly long[] Value={ 1764L,3888L,14715L,39450L,191766L,526680L,2500875L,6985128L,33846264L,94355988L,454693140L,1269412704L,6131489892L,17111113680L,82584274404L,230506000944L,1112836444476L,3105929013420L,14993191433262L,41846929098264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205731Inst : IEnumerable<long>
{
public static readonly long[] Value=A205731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205731.Bytes);
public long this[int i]=>Value[i];

public static A205731Inst Instance=new A205731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205732
{
public static readonly long[] Value={ 8655L,17532L,80088L,223560L,1421976L,4116576L,25898472L,76594212L,491999118L,1452775596L,9287994096L,27469736568L,175992497334L,520294935264L,3331132695774L,9849664194432L,63077440686552L,186500014153044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205732Inst : IEnumerable<long>
{
public static readonly long[] Value=A205732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205732.Bytes);
public long this[int i]=>Value[i];

public static A205732Inst Instance=new A205732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205733
{
public static readonly long[] Value={ 43155L,80916L,450339L,1302228L,10821462L,33070572L,272838012L,848995332L,7154699736L,22270343580L,186964905354L,582627814044L,4900745635686L,15269506255620L,128370016612560L,400006619221596L,3363513845901534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205733Inst : IEnumerable<long>
{
public static readonly long[] Value=A205733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205733.Bytes);
public long this[int i]=>Value[i];

public static A205733Inst Instance=new A205733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205734
{
public static readonly long[] Value={ 218034L,376314L,2565900L,7713324L,84974904L,276139080L,3069752670L,10194154164L,115813704396L,385448895840L,4369023325002L,14557797869880L,165279265702488L,550701994656732L,6250099464188712L,20826415515026868L,236399003977763112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205734Inst : IEnumerable<long>
{
public static readonly long[] Value=A205734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205734.Bytes);
public long this[int i]=>Value[i];

public static A205734Inst Instance=new A205734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205735
{
public static readonly long[] Value={ 1112664L,1756446L,14781282L,46226928L,677890656L,2333010360L,34742828298L,121870318920L,1855261787808L,6531492721512L,99358559762784L,350143822343004L,5334771490189698L,18802864726854420L,286439175155582670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205735Inst : IEnumerable<long>
{
public static readonly long[] Value=A205735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205735.Bytes);
public long this[int i]=>Value[i];

public static A205735Inst Instance=new A205735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205736
{
public static readonly long[] Value={ 81L,369L,360L,1764L,978L,1683L,8655L,3888L,3318L,7572L,43155L,17532L,14715L,9198L,35577L,218034L,80916L,80088L,39450L,34674L,160218L,1112664L,376314L,450339L,223560L,191766L,97380L,750426L,5722236L,1756446L,2565900L,1302228L,1421976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205736Inst : IEnumerable<long>
{
public static readonly long[] Value=A205736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205736.Bytes);
public long this[int i]=>Value[i];

public static A205736Inst Instance=new A205736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205737
{
public static readonly long[] Value={ 81L,369L,1764L,8655L,43155L,218034L,1112664L,5722236L,29600808L,153794865L,801658320L,4188664470L,21924195099L,114902238879L,602752637715L,3164061809547L,16617483609822L,87305419041021L,458806978246497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205737Inst : IEnumerable<long>
{
public static readonly long[] Value=A205737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205737.Bytes);
public long this[int i]=>Value[i];

public static A205737Inst Instance=new A205737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205738
{
public static readonly long[] Value={ 360L,978L,3888L,17532L,80916L,376314L,1756446L,8212662L,38432652L,179925948L,842504430L,3945403368L,18476947170L,86532335682L,405257580870L,1897955537136L,8888775949212L,41629230515718L,194964278279712L,913086294849486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205738Inst : IEnumerable<long>
{
public static readonly long[] Value=A205738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205738.Bytes);
public long this[int i]=>Value[i];

public static A205738Inst Instance=new A205738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205739
{
public static readonly long[] Value={ 1683L,3318L,14715L,80088L,450339L,2565900L,14781282L,85852548L,502097979L,2953275825L,17454550770L,103577971653L,616733949822L,3682641041940L,22041854965854L,132187997823285L,794047508972499L,4776288839441496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205739Inst : IEnumerable<long>
{
public static readonly long[] Value=A205739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205739.Bytes);
public long this[int i]=>Value[i];

public static A205739Inst Instance=new A205739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205740
{
public static readonly long[] Value={ 7572L,9198L,39450L,223560L,1302228L,7713324L,46226928L,279659868L,1704880890L,10462876284L,64585503408L,400746023364L,2498045547126L,15635322145932L,98216084782716L,618928949286996L,3911199907193244L,24776252730392748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205740Inst : IEnumerable<long>
{
public static readonly long[] Value=A205740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205740.Bytes);
public long this[int i]=>Value[i];

public static A205740Inst Instance=new A205740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205741
{
public static readonly long[] Value={ 35577L,34674L,191766L,1421976L,10821462L,84974904L,677890656L,5534415120L,45731628030L,384859989894L,3269433925416L,28167165751182L,244416911605530L,2142938782409352L,18887852635398972L,167701423759157730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205741Inst : IEnumerable<long>
{
public static readonly long[] Value=A205741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205741.Bytes);
public long this[int i]=>Value[i];

public static A205741Inst Instance=new A205741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205742
{
public static readonly long[] Value={ 160218L,97380L,526680L,4116576L,33070572L,276139080L,2333010360L,20252939448L,177288165936L,1586346079800L,14299637864256L,131222784826716L,1212181534620348L,11354938195735176L,106955852324919060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205742Inst : IEnumerable<long>
{
public static readonly long[] Value=A205742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205742.Bytes);
public long this[int i]=>Value[i];

public static A205742Inst Instance=new A205742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205743
{
public static readonly long[] Value={ 750426L,370008L,2500875L,25898472L,272838012L,3069752670L,34742828298L,413012966010L,4930601123670L,61216679299698L,763397221836603L,9815569401346974L,126753075111195354L,1674419143328404032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205743Inst : IEnumerable<long>
{
public static readonly long[] Value=A205743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205743.Bytes);
public long this[int i]=>Value[i];

public static A205743Inst Instance=new A205743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205744
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,4L,7L,13L,24L,24L,44L,84L,161L,309L,309L,594L,1164L,2284L,4484L,8807L,8807L,17305L,34301L,68008L,134852L,267420L,530356L,530356L,1051905L,2095003L,4172701L,8311101L,16554194L,32973536L,65679652L,65679652L,130828948L,261127540L,521203175L,1040311347L,2076449993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205744Inst : IEnumerable<long>
{
public static readonly long[] Value=A205744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205744.Bytes);
public long this[int i]=>Value[i];

public static A205744Inst Instance=new A205744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205745
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,0L,1L,1L,1L,0L,2L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,2L,1L,2L,0L,1L,1L,2L,0L,1L,1L,1L,0L,2L,1L,1L,0L,1L,1L,2L,0L,1L,1L,2L,0L,2L,1L,1L,0L,1L,1L,2L,0L,2L,1L,1L,0L,2L,1L,1L,0L,1L,1L,2L,0L,2L,1L,1L,0L,1L,1L,1L,0L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205745Inst : IEnumerable<long>
{
public static readonly long[] Value=A205745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205745.Bytes);
public long this[int i]=>Value[i];

public static A205745Inst Instance=new A205745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205746
{
public static readonly BigInteger[] Value={ 14L,284L,8926L,383290L,28155907L,2917623614L,528507252157L,138111752968498L,64850139038419406L,BigInteger.Parse("44000031319042068352") };
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
public class A205746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205746Inst Instance=new A205746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205747
{
public static readonly long[] Value={ 48L,284L,1936L,12384L,82992L,542718L,3602578L,23691830L,156738676L,1033041690L,6824741078L,45020426618L,297261797768L,1961609742846L,12949334504402L,85463493135422L,564128280317020L,3723357621326818L,24576331604189646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205747Inst : IEnumerable<long>
{
public static readonly long[] Value=A205747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205747.Bytes);
public long this[int i]=>Value[i];

public static A205747Inst Instance=new A205747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205748
{
public static readonly long[] Value={ 175L,1074L,8926L,63838L,507035L,3797920L,29561841L,224378004L,1731531322L,13218640560L,101623450551L,777700795868L,5969371745835L,45729619667448L,350767461372176L,2688316203091256L,20614685172668943L,158022715770190920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205748Inst : IEnumerable<long>
{
public static readonly long[] Value=A205748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205748.Bytes);
public long this[int i]=>Value[i];

public static A205748Inst Instance=new A205748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205749
{
public static readonly long[] Value={ 677L,4256L,45985L,383290L,3869807L,34977686L,341919297L,3167656992L,30455717868L,285553796676L,2723341716429L,25674383048106L,243954861350237L,2305675383712232L,21870813304967748L,206946895127931564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205749Inst : IEnumerable<long>
{
public static readonly long[] Value=A205749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205749.Bytes);
public long this[int i]=>Value[i];

public static A205749Inst Instance=new A205749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205750
{
public static readonly long[] Value={ 2709L,16986L,240448L,2244622L,28155907L,292986186L,3496020388L,37842800738L,438825319336L,4848489973070L,55418134307368L,618474318718042L,7019335919990083L,78727055787609808L,890377168567158601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205750Inst : IEnumerable<long>
{
public static readonly long[] Value=A205750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205750.Bytes);
public long this[int i]=>Value[i];

public static A205750Inst Instance=new A205750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205751
{
public static readonly long[] Value={ 11143L,68692L,1320659L,14131118L,233316016L,2917623614L,45262306396L,599332178604L,8912114399864L,121869298507748L,1770968194811994L,24619794382545970L,353501675583395156L,4957479622063690252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205751Inst : IEnumerable<long>
{
public static readonly long[] Value=A205751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205751.Bytes);
public long this[int i]=>Value[i];

public static A205751Inst Instance=new A205751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205752
{
public static readonly BigInteger[] Value={ 46709L,279504L,7401826L,88143754L,1885888870L,26828234464L,528507252157L,8142071823898L,150897062896760L,2433101515248386L,43576907137276890L,720763526062990940L,12660252875952041246UL,BigInteger.Parse("212486499238257674586") };
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
public class A205752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A205752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A205752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A205752Inst Instance=new A205752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205753
{
public static readonly long[] Value={ 14L,48L,74L,175L,284L,413L,677L,1074L,1936L,2268L,2709L,4256L,8926L,12384L,12574L,11143L,16986L,45985L,63838L,82992L,69338L,46709L,68692L,240448L,383290L,507035L,542718L,383440L,198483L,279504L,1320659L,2244622L,3869807L,3797920L,3602578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205753Inst : IEnumerable<long>
{
public static readonly long[] Value=A205753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205753.Bytes);
public long this[int i]=>Value[i];

public static A205753Inst Instance=new A205753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205754
{
public static readonly long[] Value={ 74L,284L,1074L,4256L,16986L,68692L,279504L,1143842L,4699050L,19364230L,79981548L,330948764L,1371291912L,5688057508L,23613366558L,98091679448L,407685449946L,1695079113772L,7050018583818L,29329074681854L,122037419381370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205754Inst : IEnumerable<long>
{
public static readonly long[] Value=A205754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205754.Bytes);
public long this[int i]=>Value[i];

public static A205754Inst Instance=new A205754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205755
{
public static readonly long[] Value={ 413L,1936L,8926L,45985L,240448L,1320659L,7401826L,42660605L,250029914L,1490326011L,8987278254L,54752835613L,336083185542L,2075776885383L,12881680165752L,80247514417805L,501418885256186L,3140749716392509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205755Inst : IEnumerable<long>
{
public static readonly long[] Value=A205755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205755.Bytes);
public long this[int i]=>Value[i];

public static A205755Inst Instance=new A205755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A205756
{
public static readonly long[] Value={ 2268L,12384L,63838L,383290L,2244622L,14131118L,88143754L,572187838L,3709029086L,24613160072L,163670433374L,1104155427184L,7473775678826L,51060113489722L,350078262846120L,2415378206667070L,16720104940755442L,116264115349570420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A205756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A205756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A205756Inst : IEnumerable<long>
{
public static readonly long[] Value=A205756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A205756.Bytes);
public long this[int i]=>Value[i];

public static A205756Inst Instance=new A205756Inst();

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