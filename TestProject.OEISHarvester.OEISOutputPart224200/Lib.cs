using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A262582
{
public static readonly BigInteger[] Value={ 1L,12L,123L,1234L,12345L,123456L,1234567L,12345678L,123456789L,12345678910L,1234567891011L,123456789101113L,12345678910111314L,1234567891011131415L,BigInteger.Parse("123456789101113141516"),BigInteger.Parse("12345678910111314151617"),BigInteger.Parse("1234567891011131415161718"),BigInteger.Parse("123456789101113141516171819"),BigInteger.Parse("12345678910111314151617181920") };
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
public class A262582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262582.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262582Inst Instance=new A262582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262583
{
public static readonly BigInteger[] Value={ 0L,24L,936L,42798L,2130456L,111557592L,6041272680L,335089258632L,18922687509960L,1083572842675608L,62744027461625646L,3666433604712457464L,BigInteger.Parse("215879610645469496232"),BigInteger.Parse("12792865816027823374872"),BigInteger.Parse("762278349313657804740840"),BigInteger.Parse("4563834246213383501932253") };
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
public class A262583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262583Inst Instance=new A262583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262584
{
public static readonly BigInteger[] Value={ 0L,12L,468L,21399L,1065228L,55778796L,3020636340L,167544629316L,9461343754980L,541786421337804L,31372013730812823L,1833216802356228732L,BigInteger.Parse("107939805322734748116"),BigInteger.Parse("6396432908013911687436"),BigInteger.Parse("381139174656828902370420") };
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
public class A262584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262584Inst Instance=new A262584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262585
{
public static readonly BigInteger[] Value={ 0L,2L,38L,466L,5826L,76258L,1032442L,14316582L,202116106L,2893451650L,41886157562L,611902123282L,9007199254738L,133439988963010L,1987795697598010L,29752813022112178L,447193795726343002L,6746237832670921766L,BigInteger.Parse("102105221251235572186") };
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
public class A262585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262585Inst Instance=new A262585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262586
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,4L,5L,6L,5L,6L,16L,21L,26L,24L,19L,48L,88L,119L,147L,133L,49L,164L,330L,538L,735L,892L,846L,150L,559L,1302L,2310L,3568L,4830L,5876L,5661L,442L,1952L,5005L,9882L,16500L,24596L,33253L,40490L,39556L,1424L,6872L,19504L,41715L,75387L,120582L,176354L,237336L,290020L,286000L,4522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262586Inst : IEnumerable<long>
{
public static readonly long[] Value=A262586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262586.Bytes);
public long this[int i]=>Value[i];

public static A262586Inst Instance=new A262586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262587
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,13L,17L,31L,32L,37L,43L,73L,101L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262587Inst : IEnumerable<long>
{
public static readonly long[] Value=A262587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262587.Bytes);
public long this[int i]=>Value[i];

public static A262587Inst Instance=new A262587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262588
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262588Inst : IEnumerable<long>
{
public static readonly long[] Value=A262588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262588.Bytes);
public long this[int i]=>Value[i];

public static A262588Inst Instance=new A262588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262589
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,0L,40L,0L,65L,0L,316L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262589Inst : IEnumerable<long>
{
public static readonly long[] Value=A262589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262589.Bytes);
public long this[int i]=>Value[i];

public static A262589Inst Instance=new A262589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262590
{
public static readonly long[] Value={ 0L,2L,6L,18L,62L,210L,728L,2570L,9198L,33288L,121574L,447394L,1657008L,6170930L,23091222L,86767016L,327235610L,1238188770L,4698767640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262590Inst : IEnumerable<long>
{
public static readonly long[] Value=A262590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262590.Bytes);
public long this[int i]=>Value[i];

public static A262590Inst Instance=new A262590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262591
{
public static readonly long[] Value={ 0L,0L,4L,16L,60L,208L,726L,2568L,9196L,33286L,121572L,447392L,1657006L,6170928L,23091220L,86767014L,327235608L,1238188768L,4698767638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262591Inst : IEnumerable<long>
{
public static readonly long[] Value=A262591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262591.Bytes);
public long this[int i]=>Value[i];

public static A262591Inst Instance=new A262591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262592
{
public static readonly long[] Value={ 1L,2L,4L,10L,29L,88L,268L,812L,2449L,7366L,22124L,66406L,199261L,597836L,1793572L,5380792L,16142465L,48427498L,145282612L,435847970L,1307544061L,3922632352L,11767897244L,35303691940L,105911076049L,317733228398L,953199685468L,2859599056702L,8578797170429L,25736391511636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262592Inst : IEnumerable<long>
{
public static readonly long[] Value=A262592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262592.Bytes);
public long this[int i]=>Value[i];

public static A262592Inst Instance=new A262592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262593
{
public static readonly long[] Value={ 1L,-1L,-3L,-1L,13L,63L,237L,879L,3357L,13135L,52061L,207519L,829037L,3314719L,13256973L,53025423L,212098557L,848390319L,3393556477L,13574220095L,54296873421L,217187485439L,868749932077L,3474999717039L,13899998855133L,55599995405583L,222399981605277L,889599926401759L,3558399705585197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262593Inst : IEnumerable<long>
{
public static readonly long[] Value=A262593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262593.Bytes);
public long this[int i]=>Value[i];

public static A262593Inst Instance=new A262593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262594
{
public static readonly long[] Value={ 1L,4L,14L,52L,203L,808L,3232L,12936L,51765L,207100L,828466L,3313964L,13255999L,53024192L,212097028L,848388448L,3393554217L,13574217396L,54296870230L,217187481700L,868749927731L,3474999712024L,13899998849384L,55599995399032L,222399981597853L,889599926393388L,3558399705575802L,14233598822305756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262594Inst : IEnumerable<long>
{
public static readonly long[] Value=A262594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262594.Bytes);
public long this[int i]=>Value[i];

public static A262594Inst Instance=new A262594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262595
{
public static readonly BigInteger[] Value={ 0L,1L,11L,1000110101011L,10111011010111L,100011100010101L,100010100101110011L,BigInteger.Parse("100001010101110001001"),BigInteger.Parse("1100000101011101100011"),BigInteger.Parse("11000100011000111101101"),BigInteger.Parse("101111101001001110111001"),BigInteger.Parse("1000100010011101101000011"),BigInteger.Parse("100000100100011010000010001"),BigInteger.Parse("10001101000001010101111100101") };
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
public class A262595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262595.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262595Inst Instance=new A262595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262596
{
public static readonly BigInteger[] Value={ 0L,1L,1001L,BigInteger.Parse("1001110000010100000111001"),BigInteger.Parse("1000100100011111100010010001"),BigInteger.Parse("10011101111001010011110111001"),BigInteger.Parse("10010101100100000100000100110101001"),BigInteger.Parse("10001010111100100000100000100111101010001"),BigInteger.Parse("10010010000011100010111101000111000001001001") };
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
public class A262596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262596Inst Instance=new A262596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262597
{
public static readonly long[] Value={ 2L,3L,2L,5L,2L,2L,10L,11L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,8L,2L,2L,2L,4L,2L,10L,28L,3L,15L,2L,31L,2L,4L,2L,3L,2L,2L,2L,2L,2L,19L,3L,4L,2L,22L,3L,2L,2L,4L,2L,2L,2L,5L,3L,2L,2L,2L,2L,2L,6L,3L,5L,87L,2L,2L,2L,4L,2L,4L,10L,23L,10L,2L,3L,2L,6L,16L,10L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262597Inst : IEnumerable<long>
{
public static readonly long[] Value=A262597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262597.Bytes);
public long this[int i]=>Value[i];

public static A262597Inst Instance=new A262597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262598
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,6L,9L,15L,2L,5L,6L,16L,2L,6L,9L,21L,2L,10L,25L,45L,2L,57L,495L,609L,2L,637L,21463L,22737L,3L,10L,25L,55L,3L,14L,49L,91L,4L,14L,49L,105L,4L,18L,81L,153L,5L,13L,40L,105L,5L,18L,81L,171L,5L,22L,121L,231L,5L,574L,27881L,30751L,6L,22L,121L,253L,6L,26L,169L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262598Inst : IEnumerable<long>
{
public static readonly long[] Value=A262598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262598.Bytes);
public long this[int i]=>Value[i];

public static A262598Inst Instance=new A262598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262599
{
public static readonly long[] Value={ 2L,1L,4L,6L,8L,3L,9L,10L,14L,12L,22L,5L,21L,18L,16L,20L,32L,7L,27L,24L,26L,11L,46L,30L,33L,28L,38L,36L,58L,15L,62L,34L,44L,40L,39L,42L,57L,54L,45L,48L,55L,13L,49L,50L,52L,23L,94L,60L,86L,66L,64L,56L,106L,19L,75L,70L,63L,29L,118L,17L,77L,31L,74L,68L,104L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262599Inst : IEnumerable<long>
{
public static readonly long[] Value=A262599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262599.Bytes);
public long this[int i]=>Value[i];

public static A262599Inst Instance=new A262599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262600
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,7L,33L,132L,484L,1684L,5661L,18579L,59917L,190696L,600744L,1877256L,5828185L,17998783L,55342617L,169552428L,517884748L,1577812060L,4796682165L,14555626635L,44100374341L,133436026192L,403279293648L,1217616622992L,3673214880049L,11072960931319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262600Inst : IEnumerable<long>
{
public static readonly long[] Value=A262600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262600.Bytes);
public long this[int i]=>Value[i];

public static A262600Inst Instance=new A262600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262601
{
public static readonly BigInteger[] Value={ 1L,6L,66L,1176L,31320L,1174320L,59184720L,3866728320L,318176449920L,32215365100800L,3937433507884800L,571715345296972800L,BigInteger.Parse("97295556944518732800"),BigInteger.Parse("19183440644220345292800"),BigInteger.Parse("4338408884154346729728000"),BigInteger.Parse("1115590855925401950302208000"),BigInteger.Parse("323670093665823262135185408000"),BigInteger.Parse("105233239203100787701553799168000") };
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
public class A262601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262601Inst Instance=new A262601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262602
{
public static readonly long[] Value={ 1L,1L,3L,5L,7L,9L,13L,19L,27L,39L,57L,83L,119L,171L,247L,357L,515L,743L,1073L,1549L,2235L,3225L,4655L,6719L,9697L,13995L,20199L,29153L,42075L,60725L,87643L,126493L,182563L,263487L,380283L,548851L,792139L,1143269L,1650045L,2381459L,3437085L,4960637L,7159533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262602Inst : IEnumerable<long>
{
public static readonly long[] Value=A262602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262602.Bytes);
public long this[int i]=>Value[i];

public static A262602Inst Instance=new A262602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262603
{
public static readonly long[] Value={ 2L,1L,6L,3L,12L,4L,18L,5L,7L,8L,22L,10L,42L,9L,30L,15L,60L,14L,54L,16L,13L,11L,46L,20L,66L,21L,19L,26L,58L,24L,62L,17L,25L,32L,90L,28L,126L,27L,35L,34L,150L,36L,98L,33L,39L,23L,94L,40L,43L,44L,120L,45L,106L,38L,41L,52L,37L,29L,118L,48L,198L,31L,57L,51L,210L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262603Inst : IEnumerable<long>
{
public static readonly long[] Value=A262603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262603.Bytes);
public long this[int i]=>Value[i];

public static A262603Inst Instance=new A262603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262604
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,-4L,5L,-4L,5L,1L,1L,1L,5L,-12L,13L,-5L,6L,-5L,13L,-21L,31L,-22L,13L,-8L,1L,1L,7L,-6L,7L,1L,1L,6L,-14L,15L,-6L,7L,1L,1L,5L,-31L,41L,-32L,23L,-14L,15L,-6L,7L,47L,-71L,41L,31L,-63L,23L,41L,-55L,63L,-71L,81L,-72L,63L,-57L,49L,-48L,49L,-42L,43L,-42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262604Inst : IEnumerable<long>
{
public static readonly long[] Value=A262604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262604.Bytes);
public long this[int i]=>Value[i];

public static A262604Inst Instance=new A262604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262605
{
public static readonly long[] Value={ 3L,0L,6L,0L,1L,8L,0L,5L,9L,9L,8L,4L,3L,5L,8L,5L,5L,6L,2L,5L,5L,6L,9L,3L,3L,4L,3L,6L,8L,5L,0L,4L,9L,6L,4L,0L,0L,3L,2L,1L,2L,7L,6L,1L,2L,9L,0L,5L,4L,0L,5L,3L,6L,0L,9L,4L,4L,3L,4L,0L,4L,3L,0L,5L,7L,6L,3L,0L,8L,6L,4L,7L,6L,2L,0L,9L,7L,2L,0L,7L,1L,9L,5L,9L,8L,3L,0L,4L,5L,1L,5L,4L,1L,8L,1L,2L,0L,7L,3L,0L,9L,9L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262605Inst : IEnumerable<long>
{
public static readonly long[] Value=A262605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262605.Bytes);
public long this[int i]=>Value[i];

public static A262605Inst Instance=new A262605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262606
{
public static readonly long[] Value={ 1L,4L,1L,7L,4L,9L,0L,0L,6L,2L,2L,6L,2L,9L,6L,0L,3L,3L,5L,0L,6L,7L,6L,9L,6L,7L,8L,1L,9L,9L,0L,3L,0L,6L,5L,7L,3L,5L,3L,7L,5L,9L,4L,9L,9L,7L,0L,2L,8L,9L,4L,5L,3L,6L,0L,9L,4L,3L,8L,5L,5L,0L,6L,8L,6L,1L,1L,1L,3L,9L,7L,4L,2L,9L,6L,9L,1L,9L,4L,4L,1L,2L,8L,2L,4L,1L,2L,1L,7L,0L,2L,2L,5L,5L,4L,8L,3L,7L,5L,1L,6L,5L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262606Inst : IEnumerable<long>
{
public static readonly long[] Value=A262606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262606.Bytes);
public long this[int i]=>Value[i];

public static A262606Inst Instance=new A262606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262607
{
public static readonly long[] Value={ 1L,3L,11L,47L,219L,1075L,5459L,28383L,150131L,804515L,4355163L,23768079L,130572363L,721247571L,4002344355L,22296869823L,124633584099L,698707769923L,3927060020651L,22121780745711L,124865811262139L,706065855417203L,3998950848888051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262607Inst : IEnumerable<long>
{
public static readonly long[] Value=A262607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262607.Bytes);
public long this[int i]=>Value[i];

public static A262607Inst Instance=new A262607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262608
{
public static readonly long[] Value={ 19L,41L,107L,151L,173L,239L,283L,349L,421L,443L,487L,509L,619L,641L,751L,773L,839L,883L,971L,1087L,1103L,1109L,1153L,1307L,1373L,1439L,1483L,1549L,1571L,1637L,1747L,1907L,1951L,1973L,2017L,2039L,2083L,2237L,2281L,2347L,2551L,2617L,2683L,2749L,2837L,2903L,2969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262608Inst : IEnumerable<long>
{
public static readonly long[] Value=A262608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262608.Bytes);
public long this[int i]=>Value[i];

public static A262608Inst Instance=new A262608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262609
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,12L,16L,18L,24L,27L,32L,36L,48L,54L,64L,72L,96L,108L,144L,192L,216L,288L,432L,576L,864L,1728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262609Inst : IEnumerable<long>
{
public static readonly long[] Value=A262609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262609.Bytes);
public long this[int i]=>Value[i];

public static A262609Inst Instance=new A262609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262610
{
public static readonly long[] Value={ 1L,1L,3L,2L,4L,3L,7L,4L,6L,5L,12L,5L,8L,7L,15L,8L,13L,9L,18L,10L,12L,11L,28L,12L,14L,13L,24L,14L,24L,15L,31L,16L,18L,17L,39L,18L,20L,19L,42L,20L,32L,21L,36L,22L,24L,23L,60L,24L,31L,25L,42L,26L,40L,27L,56L,28L,30L,29L,72L,30L,32L,31L,63L,32L,48L,33L,54L,34L,48L,35L,91L,36L,38L,37L,60L,38L,56L,39L,90L,40L,42L,41L,96L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262610Inst : IEnumerable<long>
{
public static readonly long[] Value=A262610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262610.Bytes);
public long this[int i]=>Value[i];

public static A262610Inst Instance=new A262610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262611
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,2L,3L,3L,3L,2L,1L,1L,2L,3L,3L,3L,3L,3L,2L,1L,1L,2L,3L,4L,4L,5L,4L,4L,3L,2L,1L,1L,2L,3L,4L,4L,4L,5L,4L,4L,4L,3L,2L,1L,1L,2L,3L,4L,5L,5L,5L,6L,5L,5L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,5L,5L,6L,7L,6L,5L,5L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,6L,6L,6L,7L,7L,7L,6L,6L,6L,5L,4L,3L,2L,1L,1L,2L,3L,4L,5L,6L,6L,6L,6L,7L,7L,7L,6L,6L,6L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262611Inst : IEnumerable<long>
{
public static readonly long[] Value=A262611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262611.Bytes);
public long this[int i]=>Value[i];

public static A262611Inst Instance=new A262611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262612
{
public static readonly long[] Value={ 1L,5L,14L,1L,30L,2L,55L,6L,91L,10L,1L,140L,19L,2L,204L,28L,3L,285L,44L,7L,385L,60L,11L,1L,506L,85L,15L,2L,650L,110L,24L,3L,819L,146L,33L,4L,1015L,182L,42L,8L,1240L,231L,58L,12L,1L,1496L,280L,74L,16L,2L,1785L,344L,90L,20L,3L,2109L,408L,115L,29L,4L,2470L,489L,140L,38L,5L,2870L,570L,165L,47L,9L,3311L,670L,201L,56L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262612Inst : IEnumerable<long>
{
public static readonly long[] Value=A262612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262612.Bytes);
public long this[int i]=>Value[i];

public static A262612Inst Instance=new A262612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262613
{
public static readonly long[] Value={ 1L,3L,6L,8L,28L,24L,36L,42L,48L,90L,72L,80L,144L,96L,168L,217L,182L,312L,180L,192L,372L,216L,576L,456L,280L,588L,336L,352L,864L,576L,720L,855L,558L,756L,702L,936L,1120L,600L,1080L,1116L,1024L,2016L,1008L,816L,1296L,1152L,2016L,2072L,1178L,1860L,1344L,1120L,3600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262613Inst : IEnumerable<long>
{
public static readonly long[] Value=A262613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262613.Bytes);
public long this[int i]=>Value[i];

public static A262613Inst Instance=new A262613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262614
{
public static readonly long[] Value={ 1L,-2L,2L,-5L,9L,-12L,16L,-23L,36L,-47L,60L,-84L,115L,-149L,188L,-245L,321L,-406L,505L,-641L,813L,-1007L,1237L,-1533L,1901L,-2321L,2816L,-3437L,4191L,-5055L,6068L,-7307L,8792L,-10501L,12490L,-14886L,17720L,-20975L,24755L,-29236L,34492L,-40522L,47486L,-55666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262614Inst : IEnumerable<long>
{
public static readonly long[] Value=A262614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262614.Bytes);
public long this[int i]=>Value[i];

public static A262614Inst Instance=new A262614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262615
{
public static readonly BigInteger[] Value={ 136L,244L,919L,1459L,2178L,6514L,58618L,76438L,89883L,157596L,63804L,313625L,2755907L,6586433L,8139850L,9057586L,144839908L,1043820406L,277668893L,756738746L,304162700L,344050075L,4370652168L,11346057072L,21914086555935085L,37878721692554416L,187864919457180831L,375609204308055082L,13397885590701080090UL,BigInteger.Parse("40091536165423401387") };
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
public class A262615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262615Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262615.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262615.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262615Inst Instance=new A262615Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262616
{
public static readonly long[] Value={ 1L,4L,1L,16L,4L,1L,64L,16L,4L,1L,256L,64L,16L,4L,1L,1024L,256L,64L,16L,4L,1L,4096L,1024L,256L,64L,16L,4L,1L,16384L,4096L,1024L,256L,64L,16L,4L,1L,65536L,16384L,4096L,1024L,256L,64L,16L,4L,1L,262144L,65536L,16384L,4096L,1024L,256L,64L,16L,4L,1L,1048576L,262144L,65536L,16384L,4096L,1024L,256L,64L,16L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262616Inst : IEnumerable<long>
{
public static readonly long[] Value=A262616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262616.Bytes);
public long this[int i]=>Value[i];

public static A262616Inst Instance=new A262616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262617
{
public static readonly long[] Value={ 0L,6L,12L,6L,24L,18L,12L,6L,48L,42L,36L,30L,24L,18L,12L,6L,96L,90L,84L,78L,72L,66L,60L,54L,48L,42L,36L,30L,24L,18L,12L,6L,192L,186L,180L,174L,168L,162L,156L,150L,144L,138L,132L,126L,120L,114L,108L,102L,96L,90L,84L,78L,72L,66L,60L,54L,48L,42L,36L,30L,24L,18L,12L,6L,384L,378L,372L,366L,360L,354L,348L,342L,336L,330L,324L,318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262617Inst : IEnumerable<long>
{
public static readonly long[] Value=A262617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262617.Bytes);
public long this[int i]=>Value[i];

public static A262617Inst Instance=new A262617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262618
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,3L,1L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262618Inst : IEnumerable<long>
{
public static readonly long[] Value=A262618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262618.Bytes);
public long this[int i]=>Value[i];

public static A262618Inst Instance=new A262618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262619
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,1L,1L,5L,1L,3L,1L,1L,1L,3L,3L,1L,1L,1L,1L,3L,1L,3L,1L,1L,1L,5L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,3L,1L,3L,1L,1L,3L,5L,1L,1L,1L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262619Inst : IEnumerable<long>
{
public static readonly long[] Value=A262619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262619.Bytes);
public long this[int i]=>Value[i];

public static A262619Inst Instance=new A262619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262620
{
public static readonly long[] Value={ 1L,5L,17L,21L,49L,69L,81L,85L,145L,197L,241L,277L,305L,325L,337L,341L,465L,581L,689L,789L,881L,965L,1041L,1109L,1169L,1221L,1265L,1301L,1329L,1349L,1361L,1365L,1617L,1861L,2097L,2325L,2545L,2757L,2961L,3157L,3345L,3525L,3697L,3861L,4017L,4165L,4305L,4437L,4561L,4677L,4785L,4885L,4977L,5061L,5137L,5205L,5265L,5317L,5361L,5397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262620Inst : IEnumerable<long>
{
public static readonly long[] Value=A262620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262620.Bytes);
public long this[int i]=>Value[i];

public static A262620Inst Instance=new A262620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262621
{
public static readonly long[] Value={ 1L,4L,12L,4L,28L,20L,12L,4L,60L,52L,44L,36L,28L,20L,12L,4L,124L,116L,108L,100L,92L,84L,76L,68L,60L,52L,44L,36L,28L,20L,12L,4L,252L,244L,236L,228L,220L,212L,204L,196L,188L,180L,172L,164L,156L,148L,140L,132L,124L,116L,108L,100L,92L,84L,76L,68L,60L,52L,44L,36L,28L,20L,12L,4L,508L,500L,492L,484L,476L,468L,460L,452L,444L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262621Inst : IEnumerable<long>
{
public static readonly long[] Value=A262621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262621.Bytes);
public long this[int i]=>Value[i];

public static A262621Inst Instance=new A262621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262622
{
public static readonly long[] Value={ 220L,284L,1184L,1210L,2620L,2924L,5020L,5564L,6232L,6368L,10744L,10856L,17296L,18416L,63020L,76084L,66928L,66992L,79750L,88730L,122368L,123152L,141664L,153176L,142310L,168730L,171856L,176336L,176272L,180848L,185368L,203432L,196724L,202444L,280540L,365084L,308620L,389924L,319550L,430402L,356408L,399592L,437456L,455344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262622Inst : IEnumerable<long>
{
public static readonly long[] Value=A262622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262622.Bytes);
public long this[int i]=>Value[i];

public static A262622Inst Instance=new A262622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262623
{
public static readonly long[] Value={ 12285L,14595L,67095L,71145L,69615L,87633L,100485L,124155L,122265L,139815L,522405L,525915L,802725L,863835L,947835L,1125765L,1175265L,1438983L,1280565L,1340235L,1358595L,1486845L,1798875L,1870245L,4482765L,5120595L,5357625L,5684679L,5730615L,6088905L,6377175L,6680025L,8619765L,9627915L,9071685L,9498555L,9206925L,10791795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262623Inst : IEnumerable<long>
{
public static readonly long[] Value=A262623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262623.Bytes);
public long this[int i]=>Value[i];

public static A262623Inst Instance=new A262623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262624
{
public static readonly long[] Value={ 220L,284L,1184L,1210L,2620L,2924L,5020L,5564L,6232L,6368L,10744L,10856L,17296L,18416L,63020L,66928L,66992L,76084L,79750L,88730L,122368L,123152L,141664L,142310L,153176L,168730L,171856L,176272L,176336L,180848L,185368L,196724L,202444L,203432L,280540L,308620L,319550L,356408L,365084L,389924L,399592L,430402L,437456L,455344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262624Inst : IEnumerable<long>
{
public static readonly long[] Value=A262624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262624.Bytes);
public long this[int i]=>Value[i];

public static A262624Inst Instance=new A262624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262625
{
public static readonly long[] Value={ 12285L,14595L,67095L,69615L,71145L,87633L,100485L,122265L,124155L,139815L,522405L,525915L,802725L,863835L,947835L,1125765L,1175265L,1280565L,1340235L,1358595L,1438983L,1486845L,1798875L,1870245L,4482765L,5120595L,5357625L,5684679L,5730615L,6088905L,6377175L,6680025L,8619765L,9071685L,9206925L,9491625L,9498555L,9627915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262625Inst : IEnumerable<long>
{
public static readonly long[] Value=A262625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262625.Bytes);
public long this[int i]=>Value[i];

public static A262625Inst Instance=new A262625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262626
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,2L,2L,2L,2L,1L,1L,2L,7L,3L,1L,1L,3L,3L,3L,3L,2L,2L,3L,12L,4L,1L,1L,1L,1L,4L,4L,4L,4L,2L,1L,1L,2L,4L,15L,5L,2L,1L,1L,2L,5L,5L,3L,5L,5L,2L,2L,2L,2L,5L,9L,9L,6L,2L,1L,1L,1L,1L,2L,6L,6L,6L,6L,3L,1L,1L,1L,1L,3L,6L,28L,7L,2L,2L,1L,1L,2L,2L,7L,7L,7L,7L,3L,2L,1L,1L,2L,3L,7L,12L,12L,8L,3L,1L,2L,2L,1L,3L,8L,8L,8L,8L,8L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262626Inst : IEnumerable<long>
{
public static readonly long[] Value=A262626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262626.Bytes);
public long this[int i]=>Value[i];

public static A262626Inst Instance=new A262626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262627
{
public static readonly BigInteger[] Value={ 0L,101L,11001010011L,101100101001101L,BigInteger.Parse("10101011001010011010101"),BigInteger.Parse("111010101100101001101010111"),BigInteger.Parse("1111101010110010100110101011111"),BigInteger.Parse("101111111010101100101001101010111111101"),BigInteger.Parse("110101111111010101100101001101010111111101011") };
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
public class A262627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262627.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262627Inst Instance=new A262627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262628
{
public static readonly BigInteger[] Value={ 0L,5L,1619L,22861L,5608661L,123097943L,2103004511L,411605194237L,29681120620523L,8356197277826743L,141511180168198879L,BigInteger.Parse("23016765965614427641"),BigInteger.Parse("30251327028834944270131"),BigInteger.Parse("371385619022538141977254297"),BigInteger.Parse("124784413675757116661951994259") };
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
public class A262628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262628Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262628.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262628.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262628Inst Instance=new A262628Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262629
{
public static readonly BigInteger[] Value={ 1L,111L,11111L,1111111L,1001111111001L,1001001111111001001L,BigInteger.Parse("111110010011111110010011111"),BigInteger.Parse("111111110010011111110010011111111"),BigInteger.Parse("100111111110010011111110010011111111001"),BigInteger.Parse("1011010011111111001001111111001001111111100101101") };
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
public class A262629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262629Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262629.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262629.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262629Inst Instance=new A262629Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262630
{
public static readonly BigInteger[] Value={ 1L,7L,31L,127L,5113L,303049L,130677919L,8561616127L,343370835961L,398015959727917L,6536129506258687661L,BigInteger.Parse("136824982467292060343"),BigInteger.Parse("1727891550586579544797"),BigInteger.Parse("518772379027828374941147"),BigInteger.Parse("33164398702973727192477403"),BigInteger.Parse("91254204345537698333055497929") };
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
public class A262630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262630Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262630.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262630.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262630Inst Instance=new A262630Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262631
{
public static readonly BigInteger[] Value={ 1L,111L,1111111L,22111111122L,1221111111221L,112211111112211L,2111221111111221112L,BigInteger.Parse("2102111221111111221112012"),BigInteger.Parse("1212102111221111111221112012121"),BigInteger.Parse("20121210211122111111122111201212102"),BigInteger.Parse("2002201212102111221111111221112012121022002") };
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
public class A262631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262631Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262631.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262631.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262631Inst Instance=new A262631Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262632
{
public static readonly BigInteger[] Value={ 1L,13L,1093L,167309L,1033369L,7883077L,974928839L,685325330447L,384532463201461L,36815155568146289L,BigInteger.Parse("229925116170082520417"),BigInteger.Parse("148014988051032245586139"),BigInteger.Parse("12100604707837079041828993"),BigInteger.Parse("1155600708425254785803483981"),BigInteger.Parse("1006197859457454560045466031133") };
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
public class A262632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262632Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262632.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262632.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262632Inst Instance=new A262632Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262633
{
public static readonly BigInteger[] Value={ 0L,101L,31013L,3310133L,1023310133201L,3331023310133201333L,BigInteger.Parse("3223331023310133201333223"),BigInteger.Parse("1133223331023310133201333223311"),BigInteger.Parse("100311332233310233101332013332233113001"),BigInteger.Parse("10231003113322333102331013320133322331130013201") };
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
public class A262633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262633.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262633Inst Instance=new A262633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262634
{
public static readonly BigInteger[] Value={ 0L,17L,839L,15647L,19875809L,271854991487L,1037745510031339L,1723740375514348277L,BigInteger.Parse("79540916124198230488513"),BigInteger.Parse("5823206408678014785594704353"),BigInteger.Parse("331079896899961216174255077712193"),BigInteger.Parse("5255024346804703767393892624827437183"),BigInteger.Parse("679574531660517571339207845002833364989") };
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
public class A262634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262634.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262634Inst Instance=new A262634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262635
{
public static readonly BigInteger[] Value={ 1L,12121L,111212111L,31112121113L,133111212111331L,BigInteger.Parse("123133111212111331321"),BigInteger.Parse("303123133111212111331321303"),BigInteger.Parse("3030312313311121211133132130303"),BigInteger.Parse("30303031231331112121113313213030303"),BigInteger.Parse("3303030312313311121211133132130303033"),BigInteger.Parse("11330303031231331112121113313213030303311") };
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
public class A262635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262635.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262635Inst Instance=new A262635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262636
{
public static readonly BigInteger[] Value={ 1L,409L,88469L,3499607L,525755773L,1889074241401L,14476124563693171L,3690382506839631667L,BigInteger.Parse("944489835647492584243"),BigInteger.Parse("17945058791198905978063"),BigInteger.Parse("1798278215177468964031733"),BigInteger.Parse("17136765345945336793560989047"),BigInteger.Parse("39126270988987383599688999460333") };
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
public class A262636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262636Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262636.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262636.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262636Inst Instance=new A262636Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262637
{
public static readonly BigInteger[] Value={ 2L,323L,3332333L,333323333L,33333233333L,103333323333301L,1210333332333330121L,BigInteger.Parse("100212103333323333301212001"),BigInteger.Parse("3310021210333332333330121200133"),BigInteger.Parse("3303310021210333332333330121200133033"),BigInteger.Parse("11330331002121033333233333012120013303311") };
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
public class A262637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262637Inst Instance=new A262637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262638
{
public static readonly BigInteger[] Value={ 2L,59L,16319L,261887L,4193279L,335527921L,108447661849L,4672099717159297L,4398209237750224927L,BigInteger.Parse("17990359701977183946703"),BigInteger.Parse("1799003029749921411529973"),BigInteger.Parse("5066896351045516069934415169"),BigInteger.Parse("4834760092472588512731587662879"),BigInteger.Parse("16859870882498008730755778659813363") };
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
public class A262638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262638.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262638Inst Instance=new A262638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262639
{
public static readonly BigInteger[] Value={ 3L,131L,11311L,121131121L,1212113112121L,312121131121213L,BigInteger.Parse("101312121131121213101"),BigInteger.Parse("11131013121211311212131013111"),BigInteger.Parse("31311131013121211311212131013111313"),BigInteger.Parse("1011313111310131212113112121310131113131101"),BigInteger.Parse("310113131113101312121131121213101311131311013") };
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
public class A262639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262639.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262639Inst Instance=new A262639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262640
{
public static readonly BigInteger[] Value={ 3L,29L,373L,104281L,26834329L,912643687L,1226640300497L,98267311812235733L,BigInteger.Parse("1020860032010008425847"),BigInteger.Parse("21115310556546915420698449"),BigInteger.Parse("1012916271690222867857136967"),BigInteger.Parse("26879969170345514485602194376469"),BigInteger.Parse("19901192726231131838758996344598879") };
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
public class A262640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262640.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262640Inst Instance=new A262640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262641
{
public static readonly BigInteger[] Value={ 1L,111L,41114L,1411141L,20141114102L,12120141114102121L,BigInteger.Parse("24012120141114102121042"),BigInteger.Parse("142401212014111410212104241"),BigInteger.Parse("41424012120141114102121042414"),BigInteger.Parse("314142401212014111410212104241413"),BigInteger.Parse("4131414240121201411141021210424141314"),BigInteger.Parse("30413141424012120141114102121042414131403") };
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
public class A262641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262641Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262641.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262641.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262641Inst Instance=new A262641Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262642
{
public static readonly BigInteger[] Value={ 1L,31L,2659L,28921L,20254277L,222258347161L,6703502508238897L,2849796577598550571L,BigInteger.Parse("163260594826469315359"),BigInteger.Parse("78587320839900014133983"),BigInteger.Parse("63082726980138277941240209"),BigInteger.Parse("28861909227691304085982177103"),BigInteger.Parse("17774573388934687063056536849453") };
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
public class A262642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262642Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262642.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262642.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262642Inst Instance=new A262642Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262643
{
public static readonly BigInteger[] Value={ 3L,131L,31313L,1313131L,413131314L,2341313131432L,40234131313143204L,BigInteger.Parse("144023413131314320441"),BigInteger.Parse("2314402341313131432044132"),BigInteger.Parse("2202314402341313131432044132022"),BigInteger.Parse("14220231440234131313143204413202241"),BigInteger.Parse("20114220231440234131313143204413202241102") };
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
public class A262643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262643Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262643.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262643.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262643Inst Instance=new A262643Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262644
{
public static readonly BigInteger[] Value={ 3L,41L,2083L,26041L,1692709L,677083367L,627278646679L,187343343120121L,159655659994018667L,BigInteger.Parse("2255131136576400770887"),BigInteger.Parse("1104116174856823349350321"),BigInteger.Parse("18691706438024838972135587027"),BigInteger.Parse("241078822520146767324214702284691"),BigInteger.Parse("396825475231058771412223714725086039") };
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
public class A262644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262644.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262644Inst Instance=new A262644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262645
{
public static readonly BigInteger[] Value={ 0L,101L,5110115L,13511011531L,1135110115311L,111351101153111L,BigInteger.Parse("152111351101153111251"),BigInteger.Parse("5215211135110115311125125"),BigInteger.Parse("1025215211135110115311125125201"),BigInteger.Parse("1431025215211135110115311125125201341"),BigInteger.Parse("1111431025215211135110115311125125201341111") };
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
public class A262645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262645.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262645Inst Instance=new A262645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262646
{
public static readonly BigInteger[] Value={ 0L,37L,242399L,99425647L,2773336219L,95004181411L,6926597956637167L,BigInteger.Parse("25520724664154228141"),BigInteger.Parse("238868280677120302172737"),BigInteger.Parse("18101838945984695191070222173"),BigInteger.Parse("578712262382613259078341544982179"),BigInteger.Parse("20796546496637158906389193655535571") };
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
public class A262646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262646Inst Instance=new A262646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262647
{
public static readonly BigInteger[] Value={ 1L,111L,1111111L,14111111141L,111411111114111L,BigInteger.Parse("103111411111114111301"),BigInteger.Parse("5510311141111111411130155"),BigInteger.Parse("10551031114111111141113015501"),BigInteger.Parse("501055103111411111114111301550105"),BigInteger.Parse("102501055103111411111114111301550105201"),BigInteger.Parse("5110250105510311141111111411130155010520115") };
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
public class A262647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262647.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262647Inst Instance=new A262647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262648
{
public static readonly BigInteger[] Value={ 1L,43L,55987L,102792517L,95125388731L,3981385394034229L,BigInteger.Parse("27783887681061330839"),BigInteger.Parse("7141162170983023407421"),BigInteger.Parse("40050387387887393264626841"),BigInteger.Parse("400599026018424027699693461857"),BigInteger.Parse("2500775549161597801615214316269999"),BigInteger.Parse("35465901730059327498617881373769591811") };
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
public class A262648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262648.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262648Inst Instance=new A262648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262649
{
public static readonly BigInteger[] Value={ 2L,525L,1252521L,512525215L,102512525215201L,5110251252521520115L,BigInteger.Parse("151102512525215201151"),BigInteger.Parse("5515110251252521520115155"),BigInteger.Parse("50551511025125252152011515505"),BigInteger.Parse("525055151102512525215201151550525"),BigInteger.Parse("1152505515110251252521520115155052511") };
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
public class A262649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262649.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262649Inst Instance=new A262649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262650
{
public static readonly BigInteger[] Value={ 2L,197L,69313L,8813963L,84621544849L,527772818401391L,6822795350471323L,BigInteger.Parse("27886178439493066223"),BigInteger.Parse("31708613496145827870113"),BigInteger.Parse("43587702672242054520081077"),BigInteger.Parse("13602652894439672099923526011"),BigInteger.Parse("22768853068939384975328656897381"),BigInteger.Parse("715213262078891560583355909701176813") };
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
public class A262650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262650Inst Instance=new A262650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262651
{
public static readonly BigInteger[] Value={ 3L,11311L,121131121L,5312113112135L,14531211311213541L,1145312113112135411L,BigInteger.Parse("51114531211311213541115"),BigInteger.Parse("5511145312113112135411155"),BigInteger.Parse("50551114531211311213541115505"),BigInteger.Parse("115055111453121131121354111550511"),BigInteger.Parse("51150551114531211311213541115505115") };
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
public class A262651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262651.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262651Inst Instance=new A262651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262652
{
public static readonly BigInteger[] Value={ 3L,1627L,2298073L,12055033499L,5135831051749L,132374942978911L,684810967798954343L,BigInteger.Parse("27800772498401810543"),BigInteger.Parse("31705538882266542665633"),BigInteger.Parse("10426504028032396567753387"),BigInteger.Parse("1495118023958546538597068807"),BigInteger.Parse("425143541608166955051684643069"),BigInteger.Parse("15918355788492735798148953834991") };
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
public class A262652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262652Inst Instance=new A262652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262653
{
public static readonly BigInteger[] Value={ 4L,141L,11411L,5114115L,551141155L,1455114115541L,1111455114115541111L,BigInteger.Parse("55111145511411554111155"),BigInteger.Parse("1021551111455114115541111551201"),BigInteger.Parse("12102155111145511411554111155120121"),BigInteger.Parse("531210215511114551141155411115512012135"),BigInteger.Parse("101531210215511114551141155411115512012135101") };
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
public class A262653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262653Inst Instance=new A262653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262654
{
public static readonly BigInteger[] Value={ 4L,61L,1663L,243263L,9857663L,3982846453L,122168020854499L,772191321163986959L,BigInteger.Parse("235380054470968985242897"),BigInteger.Parse("390489415238382125919557233"),BigInteger.Parse("2056313729049707794675149973499"),BigInteger.Parse("18249666491214590662011175235075053"),BigInteger.Parse("4157609603822695440999128471752421052593") };
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
public class A262654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262654Inst Instance=new A262654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262655
{
public static readonly BigInteger[] Value={ 5L,151L,11511L,5115115L,13511511531L,5135115115315L,15513511511531551L,1155135115115315511L,BigInteger.Parse("14115513511511531551141"),BigInteger.Parse("131411551351151153155114131"),BigInteger.Parse("51314115513511511531551141315"),BigInteger.Parse("11551314115513511511531551141315511"),BigInteger.Parse("11511551314115513511511531551141315511511") };
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
public class A262655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262655Inst Instance=new A262655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262656
{
public static readonly BigInteger[] Value={ 5L,67L,1699L,243479L,99464527L,11480698847L,5585339988859L,135071996601571L,224232098281435141L,BigInteger.Parse("263944947807498977479"),BigInteger.Parse("32288380759169071350959"),BigInteger.Parse("381031362411461360978228323"),BigInteger.Parse("17534309533326861798094235120707"),BigInteger.Parse("93027357395687656901633495854438781") };
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
public class A262656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262656Inst Instance=new A262656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262657
{
public static readonly BigInteger[] Value={ 1L,212L,42124L,204212402L,2220421240222L,222204212402222L,2222220421240222222L,BigInteger.Parse("12222222042124022222221"),BigInteger.Parse("3122222220421240222222213"),BigInteger.Parse("331222222204212402222222133"),BigInteger.Parse("53312222222042124022222221335"),BigInteger.Parse("165331222222204212402222222133561") };
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
public class A262657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262657.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262657Inst Instance=new A262657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262658
{
public static readonly BigInteger[] Value={ 1L,107L,10357L,12037097L,32227045657L,1582035465299L,3799607961594979L,5213093566867710049L,BigInteger.Parse("611235349109773213549"),BigInteger.Parse("32441088456711675411793"),BigInteger.Parse("2527020301920681532766561"),BigInteger.Parse("2174903961247108881101117191"),BigInteger.Parse("7682944139414403968828307261263") };
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
public class A262658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262658.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262658Inst Instance=new A262658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262659
{
public static readonly BigInteger[] Value={ 0L,13031L,511303115L,3351130311533L,333511303115333L,1033351130311533301L,BigInteger.Parse("1051033351130311533301501"),BigInteger.Parse("35105103335113031153330150153"),BigInteger.Parse("12135105103335113031153330150153121"),BigInteger.Parse("12012135105103335113031153330150153121021"),BigInteger.Parse("331201213510510333511303115333015015312102133") };
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
public class A262659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262659.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262659Inst Instance=new A262659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262660
{
public static readonly BigInteger[] Value={ 0L,5657L,86345293L,237454332763L,15093774195419L,18980400057988801L,BigInteger.Parse("5101019329173526512449"),BigInteger.Parse("70444162774715597829754987"),BigInteger.Parse("6453548574996065731165894530641"),BigInteger.Parse("1664839211601542826784115763350118929"),BigInteger.Parse("18481797523273175767936412210169891030107") };
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
public class A262660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262660Inst Instance=new A262660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262661
{
public static readonly BigInteger[] Value={ 1L,111L,1411141L,12141114121L,10412141114121401L,BigInteger.Parse("11610412141114121401611"),BigInteger.Parse("171161041214111412140161171"),BigInteger.Parse("303171161041214111412140161171303"),BigInteger.Parse("3230317116104121411141214016117130323"),BigInteger.Parse("71323031711610412141114121401611713032317") };
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
public class A262661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262661Inst Instance=new A262661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262662
{
public static readonly BigInteger[] Value={ 1L,73L,397921L,1367644241L,299767396606721L,BigInteger.Parse("90081358266396705673"),BigInteger.Parse("572449184873406814806649"),BigInteger.Parse("241691401643304337894510228163"),BigInteger.Parse("1070153549095058339670505721475283"),BigInteger.Parse("9539239297109609328178537670671873231"),BigInteger.Parse("582002984818031754009910745491662885723817") };
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
public class A262662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A262662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A262662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A262662Inst Instance=new A262662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262663
{
public static readonly long[] Value={ 2L,1L,4L,3L,5L,7L,8L,9L,6L,10L,11L,12L,13L,14L,16L,17L,15L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,29L,30L,31L,32L,28L,33L,34L,35L,37L,36L,38L,39L,40L,41L,42L,43L,44L,46L,47L,48L,49L,50L,45L,51L,52L,53L,54L,56L,57L,58L,55L,59L,60L,61L,62L,63L,64L,65L,67L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262663Inst : IEnumerable<long>
{
public static readonly long[] Value=A262663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262663.Bytes);
public long this[int i]=>Value[i];

public static A262663Inst Instance=new A262663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262664
{
public static readonly long[] Value={ 1L,1L,3L,13L,59L,271L,1257L,5881L,27715L,131395L,626033L,2995147L,14380181L,69249337L,334345091L,1617924973L,7844900339L,38105139907L,185380469961L,903147125143L,4405621159969L,21515837558557L,105188202097091L,514747668977263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262664Inst : IEnumerable<long>
{
public static readonly long[] Value=A262664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262664.Bytes);
public long this[int i]=>Value[i];

public static A262664Inst Instance=new A262664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262665
{
public static readonly long[] Value={ 5L,10L,11L,12L,13L,14L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,33L,34L,35L,38L,39L,40L,41L,42L,43L,44L,51L,52L,53L,54L,59L,60L,61L,62L,63L,64L,65L,72L,73L,74L,75L,76L,77L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,108L,109L,110L,111L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262665Inst : IEnumerable<long>
{
public static readonly long[] Value=A262665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262665.Bytes);
public long this[int i]=>Value[i];

public static A262665Inst Instance=new A262665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262666
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,0L,4L,0L,8L,0L,12L,0L,14L,0L,12L,0L,8L,0L,4L,0L,1L,1L,1L,4L,4L,10L,10L,20L,20L,31L,31L,40L,40L,44L,44L,40L,40L,31L,31L,20L,20L,10L,10L,4L,4L,1L,1L,1L,0L,6L,0L,21L,0L,56L,0L,120L,0L,216L,0L,336L,0L,456L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262666Inst : IEnumerable<long>
{
public static readonly long[] Value=A262666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262666.Bytes);
public long this[int i]=>Value[i];

public static A262666Inst Instance=new A262666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262667
{
public static readonly long[] Value={ 1L,2L,5L,12L,25L,52L,103L,198L,370L,680L,1221L,2158L,3757L,6448L,10931L,18322L,30382L,49894L,81206L,131044L,209818L,333466L,526294L,825182L,1285807L,1991754L,3068074L,4700910L,7166216L,10871534L,16416358L,24679224L,36943232L,55075758L,81785488L,120989244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262667Inst : IEnumerable<long>
{
public static readonly long[] Value=A262667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262667.Bytes);
public long this[int i]=>Value[i];

public static A262667Inst Instance=new A262667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262668
{
public static readonly long[] Value={ 20982L,28182L,51768L,57222L,76422L,87720L,90678L,104850L,108108L,110730L,141180L,199602L,227112L,248118L,264600L,268842L,304392L,304458L,320082L,322920L,330018L,382728L,401670L,414432L,429972L,450258L,467082L,489408L,520548L,535608L,540120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262668Inst : IEnumerable<long>
{
public static readonly long[] Value=A262668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262668.Bytes);
public long this[int i]=>Value[i];

public static A262668Inst Instance=new A262668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262669
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,2L,4L,6L,8L,8L,12L,14L,18L,18L,20L,26L,28L,32L,32L,40L,42L,46L,48L,58L,58L,66L,76L,78L,84L,88L,94L,100L,106L,114L,120L,126L,128L,142L,150L,162L,166L,178L,178L,194L,200L,206L,214L,230L,236L,246L,250L,266L,274L,292L,296L,312L,322L,338L,344L,360L,360L,388L,400L,408L,416L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262669Inst : IEnumerable<long>
{
public static readonly long[] Value=A262669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262669.Bytes);
public long this[int i]=>Value[i];

public static A262669Inst Instance=new A262669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262670
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,2L,2L,0L,0L,2L,0L,2L,0L,0L,0L,2L,2L,0L,2L,2L,0L,2L,0L,0L,2L,2L,0L,2L,0L,2L,0L,2L,0L,0L,0L,0L,2L,2L,2L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,2L,2L,2L,0L,2L,2L,2L,0L,0L,0L,0L,4L,0L,0L,0L,6L,0L,0L,2L,4L,2L,0L,2L,0L,0L,2L,2L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,2L,0L,2L,0L,2L,2L,2L,2L,0L,2L,2L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262670Inst : IEnumerable<long>
{
public static readonly long[] Value=A262670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262670.Bytes);
public long this[int i]=>Value[i];

public static A262670Inst Instance=new A262670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262671
{
public static readonly long[] Value={ 1L,6L,42L,335L,2956L,28468L,296540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262671Inst : IEnumerable<long>
{
public static readonly long[] Value=A262671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262671.Bytes);
public long this[int i]=>Value[i];

public static A262671Inst Instance=new A262671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262672
{
public static readonly long[] Value={ 3L,2L,2L,1L,4L,3L,3L,2L,5L,4L,4L,3L,6L,5L,5L,4L,7L,6L,6L,5L,8L,7L,7L,6L,9L,8L,8L,7L,10L,9L,9L,8L,11L,10L,10L,9L,12L,11L,11L,10L,13L,12L,12L,11L,14L,13L,13L,12L,15L,14L,14L,13L,16L,15L,15L,14L,17L,16L,16L,15L,18L,17L,17L,16L,19L,18L,18L,17L,20L,19L,19L,18L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262672Inst : IEnumerable<long>
{
public static readonly long[] Value=A262672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262672.Bytes);
public long this[int i]=>Value[i];

public static A262672Inst Instance=new A262672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262673
{
public static readonly long[] Value={ 1L,3L,34L,615L,15410L,494018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262673Inst : IEnumerable<long>
{
public static readonly long[] Value=A262673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262673.Bytes);
public long this[int i]=>Value[i];

public static A262673Inst Instance=new A262673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262674
{
public static readonly long[] Value={ 5L,3L,1L,8L,6L,2L,8L,2L,1L,7L,7L,5L,0L,1L,8L,5L,6L,5L,9L,1L,0L,9L,6L,8L,0L,1L,5L,3L,3L,1L,8L,0L,2L,2L,4L,6L,7L,7L,2L,1L,9L,1L,9L,8L,0L,8L,8L,3L,6L,9L,0L,0L,2L,6L,0L,2L,2L,8L,0L,9L,1L,9L,9L,5L,8L,4L,0L,1L,9L,5L,8L,9L,7L,4L,5L,7L,3L,2L,1L,8L,7L,4L,3L,6L,6L,5L,3L,4L,5L,9L,1L,0L,7L,4L,8L,7L,1L,5L,4L,0L,0L,4L,5L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262674Inst : IEnumerable<long>
{
public static readonly long[] Value=A262674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262674.Bytes);
public long this[int i]=>Value[i];

public static A262674Inst Instance=new A262674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262675
{
public static readonly long[] Value={ 1L,8L,27L,32L,64L,125L,216L,243L,343L,512L,729L,864L,1000L,1024L,1331L,1728L,1944L,2197L,2744L,3125L,3375L,4000L,4096L,4913L,5832L,6859L,7776L,8000L,9261L,10648L,10976L,12167L,13824L,15552L,15625L,16807L,17576L,19683L,21952L,23328L,24389L,25000L,27000L,27648L,29791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262675Inst : IEnumerable<long>
{
public static readonly long[] Value=A262675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262675.Bytes);
public long this[int i]=>Value[i];

public static A262675Inst Instance=new A262675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262676
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,2L,0L,2L,2L,3L,2L,3L,2L,4L,2L,3L,2L,4L,2L,5L,2L,5L,2L,4L,5L,6L,2L,6L,2L,6L,2L,7L,2L,7L,2L,3L,2L,8L,2L,8L,2L,8L,2L,9L,2L,9L,2L,9L,9L,10L,2L,10L,2L,10L,2L,10L,2L,11L,2L,10L,2L,12L,2L,3L,2L,12L,2L,13L,2L,13L,2L,11L,2L,14L,2L,14L,2L,14L,2L,14L,14L,15L,14L,12L,14L,16L,14L,15L,14L,15L,14L,17L,14L,16L,14L,13L,14L,18L,14L,15L,14L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262676Inst : IEnumerable<long>
{
public static readonly long[] Value=A262676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262676.Bytes);
public long this[int i]=>Value[i];

public static A262676Inst Instance=new A262676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262677
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,4L,1L,1L,0L,2L,0L,3L,0L,3L,2L,4L,0L,5L,0L,5L,0L,6L,2L,1L,0L,7L,0L,8L,0L,9L,0L,9L,0L,10L,7L,11L,0L,11L,0L,12L,0L,13L,0L,12L,0L,13L,0L,1L,0L,14L,0L,15L,0L,15L,0L,16L,0L,17L,0L,18L,0L,17L,16L,19L,0L,20L,0L,20L,0L,21L,0L,22L,0L,21L,0L,23L,0L,24L,0L,1L,0L,2L,0L,2L,0L,3L,0L,4L,0L,4L,0L,5L,0L,5L,0L,6L,0L,6L,4L,7L,0L,8L,0L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262677Inst : IEnumerable<long>
{
public static readonly long[] Value=A262677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262677.Bytes);
public long this[int i]=>Value[i];

public static A262677Inst Instance=new A262677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262678
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,1L,2L,3L,4L,0L,1L,2L,8L,4L,5L,6L,0L,1L,9L,10L,4L,5L,13L,14L,8L,0L,1L,2L,3L,4L,5L,6L,16L,8L,9L,10L,0L,1L,2L,3L,4L,16L,17L,18L,8L,9L,10L,11L,32L,0L,1L,2L,16L,4L,5L,6L,20L,8L,9L,10L,11L,25L,13L,14L,0L,1L,2L,18L,4L,5L,34L,22L,36L,9L,25L,26L,40L,13L,29L,30L,16L,0L,1L,2L,20L,4L,5L,6L,52L,25L,9L,10L,11L,29L,13L,14L,32L,16L,49L,18L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262678Inst : IEnumerable<long>
{
public static readonly long[] Value=A262678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262678.Bytes);
public long this[int i]=>Value[i];

public static A262678Inst Instance=new A262678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262679
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,0L,6L,0L,0L,6L,6L,6L,12L,6L,6L,6L,6L,6L,18L,6L,6L,6L,22L,6L,6L,22L,22L,6L,22L,6L,30L,6L,22L,6L,34L,6L,6L,6L,34L,6L,22L,6L,42L,6L,34L,6L,46L,6L,34L,46L,34L,6L,46L,6L,54L,6L,34L,6L,58L,6L,34L,6L,62L,6L,6L,6L,58L,6L,62L,6L,70L,6L,34L,6L,70L,6L,70L,6L,78L,6L,70L,70L,78L,70L,34L,70L,78L,70L,70L,70L,90L,70L,78L,70L,94L,70L,34L,70L,78L,70L,70L,70L,102L,70L,34L,70L,106L,70L,34L,70L,102L,70L,102L,70L,114L,70L,102L,70L,118L,70L,34L,121L,118L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262679Inst : IEnumerable<long>
{
public static readonly long[] Value=A262679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262679.Bytes);
public long this[int i]=>Value[i];

public static A262679Inst Instance=new A262679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262680
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,2L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262680Inst : IEnumerable<long>
{
public static readonly long[] Value=A262680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262680.Bytes);
public long this[int i]=>Value[i];

public static A262680Inst Instance=new A262680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A262681
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A262681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A262681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A262681Inst : IEnumerable<long>
{
public static readonly long[] Value=A262681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A262681.Bytes);
public long this[int i]=>Value[i];

public static A262681Inst Instance=new A262681Inst();

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