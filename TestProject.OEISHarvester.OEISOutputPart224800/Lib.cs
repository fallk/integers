using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A263182
{
public static readonly long[] Value={ 1L,3L,13L,17L,1073L,19L,17L,29L,10000117L,73L,17L,3L,1007L,3L,43L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263182Inst : IEnumerable<long>
{
public static readonly long[] Value=A263182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263182.Bytes);
public long this[int i]=>Value[i];

public static A263182Inst Instance=new A263182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263183
{
public static readonly long[] Value={ 6L,3L,9L,5L,7L,7L,6L,8L,9L,9L,9L,4L,7L,2L,0L,1L,3L,3L,1L,1L,2L,8L,9L,9L,8L,7L,0L,5L,6L,5L,7L,3L,1L,3L,8L,4L,1L,1L,5L,2L,7L,6L,4L,8L,1L,9L,1L,4L,4L,1L,9L,6L,2L,2L,5L,8L,2L,7L,4L,2L,3L,5L,5L,8L,3L,6L,1L,3L,2L,3L,5L,3L,1L,8L,5L,8L,8L,1L,6L,7L,7L,3L,6L,8L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263183Inst : IEnumerable<long>
{
public static readonly long[] Value=A263183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263183.Bytes);
public long this[int i]=>Value[i];

public static A263183Inst Instance=new A263183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263184
{
public static readonly BigInteger[] Value={ 1L,1L,-11L,589L,-73079L,16276921L,-5689569731L,2870590000069L,-1974092553870959L,1774769713597881841L,BigInteger.Parse("-2020648226794749619451"),BigInteger.Parse("2841491193407098834197949"),BigInteger.Parse("-4836474745329895366132510439"),BigInteger.Parse("9799325146545425451960283425961"),BigInteger.Parse("-23306183195981226869509072955841971"),BigInteger.Parse("64295665973634629981724639566520575029"),BigInteger.Parse("-203644190177923848088768870897628056746719") };
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
public class A263184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263184Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263184.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263184Inst Instance=new A263184Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263185
{
public static readonly BigInteger[] Value={ 1L,-2L,64L,-5648L,975616L,-278461952L,118706427904L,-70671453390848L,56012750847410176L,BigInteger.Parse("-57020502591712919552"),BigInteger.Parse("72506220900036949049344"),BigInteger.Parse("-112627507642042025532981248"),BigInteger.Parse("209858299334586249702944014336"),BigInteger.Parse("-461985929466656996121846430564352"),BigInteger.Parse("1186250077023681407956558109929897984"),BigInteger.Parse("-3513906471607754874921241344634989314048"),BigInteger.Parse("11894054527075875087089375010293820996714496") };
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
public class A263185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263185Inst Instance=new A263185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263186
{
public static readonly BigInteger[] Value={ 1L,1L,4L,23L,160L,1260L,10861L,100474L,984944L,10142888L,109039530L,1218011097L,14086708075L,168205533546L,2069043383080L,26170130114863L,339856785957307L,4525776548471074L,61735297113781725L,861823700018556599L,12302696382913051859UL,BigInteger.Parse("179461986070686773966"),BigInteger.Parse("2673380518707453159859") };
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
public class A263186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263186Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263186.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263186Inst Instance=new A263186Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263187
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,85L,615L,5038L,45265L,437012L,4472197L,48056889L,538621852L,6265669760L,75369364118L,934809950418L,11928201381716L,156302591148741L,2100191239445909L,28901831807930949L,406933300084065353L,5857010329019250612L,BigInteger.Parse("86111062850900773745"),BigInteger.Parse("1292373792900901543026"),BigInteger.Parse("19788451519046405896069") };
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
public class A263187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263187Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263187.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263187Inst Instance=new A263187Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263188
{
public static readonly long[] Value={ 1L,-6L,3L,6L,12L,-12L,3L,-30L,18L,-48L,63L,-30L,51L,-36L,129L,-168L,147L,-78L,-42L,-120L,279L,-372L,195L,-180L,339L,-294L,351L,-588L,969L,-444L,90L,-840L,1617L,-888L,477L,-2082L,2487L,-1164L,669L,-2136L,2526L,-1926L,1512L,-3402L,7233L,-5790L,765L,-5154L,12258L,-1698L,-5754L,-8496L,14553L,-3444L,9333L,-23886L,18234L,-6330L,4677L,-11544L,15765L,-9456L,7059L,-23730L,42054L,-45486L,23634L,-22452L,59061L,-16626L,-46389L,-48780L,104931L,-6048L,45039L,-136458L,69543L,-62280L,98535L,-29742L,48996L,-93156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263188Inst : IEnumerable<long>
{
public static readonly long[] Value=A263188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263188.Bytes);
public long this[int i]=>Value[i];

public static A263188Inst Instance=new A263188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263189
{
public static readonly long[] Value={ 1L,-12L,18L,20L,24L,-96L,-4L,-120L,138L,-116L,456L,-132L,356L,-540L,900L,-1884L,1440L,-2076L,1546L,-3204L,5772L,-6572L,7860L,-7440L,12240L,-13128L,15828L,-18632L,23916L,-31344L,34008L,-45084L,44118L,-44940L,53748L,-95316L,125500L,-119136L,103632L,-100772L,156048L,-238668L,332896L,-334596L,293616L,-253552L,335352L,-591780L,833340L,-789012L,572634L,-678492L,998508L,-1350228L,1632840L,-1863108L,1749036L,-1538120L,1841244L,-2950512L,3959160L,-3671160L,3113532L,-3879628L,5512488L,-6007836L,6159684L,-7625868L,9420576L,-8502888L,7725780L,-12080952L,16859826L,-14906736L,12391572L,-18666168L,26180532L,-23512824L,18486132L,-29125692L,43754556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263189Inst : IEnumerable<long>
{
public static readonly long[] Value=A263189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263189.Bytes);
public long this[int i]=>Value[i];

public static A263189Inst Instance=new A263189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263190
{
public static readonly BigInteger[] Value={ 1L,1L,0L,1L,46L,1723L,81104L,4793304L,349869074L,31080492631L,3318717525832L,421195540320465L,62871475566985208L,10927921934497456588UL,BigInteger.Parse("2191068343727736627744"),BigInteger.Parse("502384409006686040020572"),BigInteger.Parse("130687814451798554601790746"),BigInteger.Parse("38294333521028379285810681487"),BigInteger.Parse("12557951067433973525611840784048"),BigInteger.Parse("4581888866092825667058378205370595") };
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
public class A263190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263190Inst Instance=new A263190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263191
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,0L,1L,1L,3L,2L,2L,2L,0L,2L,0L,1L,0L,0L,0L,0L,1L,1L,4L,3L,5L,4L,2L,4L,0L,5L,2L,0L,2L,0L,3L,0L,1L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,5L,4L,9L,6L,7L,6L,3L,10L,6L,4L,4L,0L,9L,5L,2L,0L,4L,4L,4L,0L,0L,4L,3L,1L,0L,2L,4L,0L,4L,0L,0L,0L,3L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263191Inst : IEnumerable<long>
{
public static readonly long[] Value=A263191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263191.Bytes);
public long this[int i]=>Value[i];

public static A263191Inst Instance=new A263191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263192
{
public static readonly long[] Value={ 1L,9L,4L,1L,0L,8L,9L,3L,5L,0L,9L,2L,1L,8L,2L,0L,4L,9L,7L,3L,9L,1L,4L,9L,2L,4L,4L,9L,2L,8L,1L,9L,4L,7L,2L,6L,6L,3L,5L,3L,2L,0L,5L,5L,2L,6L,3L,4L,0L,4L,7L,8L,1L,5L,4L,0L,2L,3L,9L,8L,3L,7L,6L,6L,0L,9L,5L,6L,6L,6L,8L,3L,7L,2L,6L,2L,5L,5L,4L,7L,6L,4L,0L,0L,6L,5L,3L,1L,8L,9L,6L,4L,9L,6L,5L,5L,2L,4L,7L,0L,1L,2L,2L,6L,8L,3L,5L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263192Inst : IEnumerable<long>
{
public static readonly long[] Value=A263192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263192.Bytes);
public long this[int i]=>Value[i];

public static A263192Inst Instance=new A263192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263193
{
public static readonly long[] Value={ 1L,0L,4L,3L,9L,8L,2L,1L,0L,2L,8L,4L,9L,1L,6L,1L,5L,2L,7L,4L,5L,3L,2L,9L,4L,8L,7L,2L,5L,8L,6L,7L,5L,0L,4L,5L,9L,7L,9L,0L,9L,0L,7L,1L,4L,4L,7L,2L,2L,6L,1L,2L,2L,0L,3L,7L,4L,8L,9L,5L,2L,8L,5L,8L,7L,7L,0L,6L,6L,9L,0L,8L,5L,8L,6L,0L,0L,3L,2L,4L,2L,1L,5L,7L,2L,9L,0L,1L,0L,9L,2L,4L,7L,7L,2L,2L,0L,1L,2L,7L,5L,5L,7L,3L,7L,1L,9L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263193Inst : IEnumerable<long>
{
public static readonly long[] Value=A263193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263193.Bytes);
public long this[int i]=>Value[i];

public static A263193Inst Instance=new A263193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263194
{
public static readonly long[] Value={ 0L,109L,110L,219L,220L,329L,330L,439L,440L,549L,550L,659L,660L,769L,770L,879L,880L,989L,990L,1208L,1318L,1428L,1538L,1648L,1758L,1868L,1978L,2307L,2417L,2527L,2637L,2747L,2857L,2967L,3406L,3516L,3626L,3736L,3846L,3956L,4505L,4615L,4725L,4835L,4945L,5604L,5714L,5824L,5934L,6703L,6813L,6923L,7802L,7912L,8901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263194Inst : IEnumerable<long>
{
public static readonly long[] Value=A263194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263194.Bytes);
public long this[int i]=>Value[i];

public static A263194Inst Instance=new A263194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263195
{
public static readonly BigInteger[] Value={ 22718L,366629L,5486039L,76647286L,1068732662L,14937290926L,209908668003L,2937919473696L,41102571427488L,575909145559159L,8065820852218665L,112941785153648623L,1581143563815783512L,BigInteger.Parse("22137080151280996895") };
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
public class A263195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263195Inst Instance=new A263195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263196
{
public static readonly BigInteger[] Value={ 366629L,12652497L,398648507L,11542428929L,333834894509L,9669206035811L,281744631338581L,8168432979144243L,236803228434060000L,6872338129370139753L,BigInteger.Parse("199369625571670867675"),BigInteger.Parse("5782741479669647970363"),BigInteger.Parse("167698271515683910798963") };
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
public class A263196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263196Inst Instance=new A263196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263197
{
public static readonly long[] Value={ 5486039L,398648507L,26007537155L,1532722380695L,90272986428673L,5321603354246163L,315848755007977111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263197Inst : IEnumerable<long>
{
public static readonly long[] Value=A263197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263197.Bytes);
public long this[int i]=>Value[i];

public static A263197Inst Instance=new A263197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263198
{
public static readonly long[] Value={ 22718L,366629L,366629L,5486039L,12652497L,5486039L,76647286L,398648507L,398648507L,76647286L,1068732662L,11542428929L,26007537155L,11542428929L,1068732662L,14937290926L,333834894509L,1532722380695L,1532722380695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263198Inst : IEnumerable<long>
{
public static readonly long[] Value=A263198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263198.Bytes);
public long this[int i]=>Value[i];

public static A263198Inst Instance=new A263198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263199
{
public static readonly long[] Value={ 1L,0L,0L,3L,0L,5L,6L,7L,15L,19L,36L,41L,77L,100L,156L,230L,317L,482L,665L,981L,1354L,1967L,2710L,3852L,5363L,7453L,10373L,14287L,19780L,27022L,37220L,50583L,69140L,93693L,127098L,171640L,231469L,311323L,417627L,559577L,747122L,996947L,1325872L,1761900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263199Inst : IEnumerable<long>
{
public static readonly long[] Value=A263199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263199.Bytes);
public long this[int i]=>Value[i];

public static A263199Inst Instance=new A263199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263200
{
public static readonly long[] Value={ 28L,104L,388L,1448L,5404L,20168L,75268L,280904L,1048348L,3912488L,14601604L,54493928L,203374108L,759002504L,2832635908L,10571541128L,39453528604L,147242573288L,549516764548L,2050824484904L,7653781175068L,28564300215368L,106603419686404L,397849378530248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263200Inst : IEnumerable<long>
{
public static readonly long[] Value=A263200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263200.Bytes);
public long this[int i]=>Value[i];

public static A263200Inst Instance=new A263200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263201
{
public static readonly long[] Value={ 11L,37L,71L,252L,539L,1813L,4271L,13519L,34276L,103803L,276119L,813417L,2226851L,6455052L,17965151L,51604017L,144948419L,414258603L,1169523076L,3333192319L,9436433171L,26853404413L,76139155439L,216490730652L,614339685971L,1745997031837L,4956888901511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263201Inst : IEnumerable<long>
{
public static readonly long[] Value=A263201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263201.Bytes);
public long this[int i]=>Value[i];

public static A263201Inst Instance=new A263201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263202
{
public static readonly long[] Value={ 7L,1L,5L,5L,3L,3L,9L,1L,3L,3L,9L,2L,6L,0L,5L,5L,1L,2L,8L,2L,1L,0L,0L,1L,7L,6L,1L,6L,8L,3L,3L,1L,3L,9L,2L,8L,0L,6L,6L,9L,1L,9L,9L,5L,8L,5L,7L,7L,6L,9L,7L,7L,9L,2L,0L,3L,4L,9L,4L,2L,4L,9L,0L,4L,7L,4L,4L,3L,3L,3L,1L,2L,2L,5L,0L,9L,2L,5L,3L,3L,7L,5L,4L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263202Inst : IEnumerable<long>
{
public static readonly long[] Value=A263202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263202.Bytes);
public long this[int i]=>Value[i];

public static A263202Inst Instance=new A263202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263203
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,3L,4L,2L,2L,2L,1L,1L,2L,6L,5L,4L,1L,2L,1L,4L,4L,5L,7L,3L,6L,7L,1L,2L,1L,7L,10L,7L,7L,2L,6L,1L,5L,10L,12L,5L,10L,3L,5L,11L,9L,9L,8L,2L,6L,2L,2L,3L,10L,1L,5L,11L,10L,7L,7L,5L,3L,5L,5L,1L,4L,2L,4L,2L,5L,7L,4L,5L,8L,7L,6L,5L,3L,7L,13L,1L,1L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263203Inst : IEnumerable<long>
{
public static readonly long[] Value=A263203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263203.Bytes);
public long this[int i]=>Value[i];

public static A263203Inst Instance=new A263203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263204
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,2L,1L,2L,3L,2L,3L,3L,3L,4L,3L,2L,1L,2L,3L,2L,2L,3L,4L,2L,0L,3L,5L,2L,1L,4L,5L,2L,3L,5L,3L,4L,3L,3L,5L,3L,4L,5L,6L,6L,4L,5L,3L,2L,4L,6L,4L,2L,3L,2L,6L,9L,8L,5L,3L,5L,7L,7L,8L,7L,4L,5L,5L,6L,5L,3L,4L,5L,7L,7L,3L,3L,6L,5L,6L,9L,7L,4L,5L,7L,5L,3L,5L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263204Inst : IEnumerable<long>
{
public static readonly long[] Value=A263204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263204.Bytes);
public long this[int i]=>Value[i];

public static A263204Inst Instance=new A263204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263205
{
public static readonly long[] Value={ 1107819732821L,3735283249697L,4588646146631L,6340698579419L,8412649748537L,9206359843907L,9667145661911L,10261787848841L,10877306469737L,13792968231041L,17231043159311L,18996369140627L,21471510972419L,21791129807147L,23105869316669L,23224938371519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263205Inst : IEnumerable<long>
{
public static readonly long[] Value=A263205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263205.Bytes);
public long this[int i]=>Value[i];

public static A263205Inst Instance=new A263205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263206
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,2L,3L,2L,2L,3L,3L,3L,2L,3L,5L,3L,1L,3L,3L,3L,3L,3L,5L,4L,4L,3L,1L,3L,5L,5L,4L,4L,5L,4L,1L,4L,4L,2L,5L,5L,3L,4L,6L,5L,4L,4L,4L,5L,5L,5L,4L,3L,4L,4L,5L,5L,5L,6L,5L,5L,6L,5L,4L,4L,5L,6L,6L,4L,4L,7L,5L,5L,7L,4L,4L,5L,5L,6L,6L,5L,6L,7L,6L,7L,7L,5L,5L,5L,5L,7L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263206Inst : IEnumerable<long>
{
public static readonly long[] Value=A263206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263206.Bytes);
public long this[int i]=>Value[i];

public static A263206Inst Instance=new A263206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263207
{
public static readonly long[] Value={ 0L,1L,2L,20L,374L,21313L,5115140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263207Inst : IEnumerable<long>
{
public static readonly long[] Value=A263207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263207.Bytes);
public long this[int i]=>Value[i];

public static A263207Inst Instance=new A263207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263208
{
public static readonly long[] Value={ 4L,5L,8L,2L,0L,2L,3L,4L,1L,3L,7L,8L,3L,5L,0L,2L,8L,0L,6L,0L,1L,5L,8L,3L,1L,2L,8L,8L,9L,3L,5L,6L,8L,8L,8L,6L,3L,6L,3L,8L,3L,0L,9L,6L,0L,9L,5L,5L,7L,8L,0L,6L,1L,6L,6L,3L,4L,3L,5L,3L,2L,7L,5L,8L,1L,3L,6L,7L,5L,4L,3L,7L,3L,7L,6L,8L,2L,3L,3L,5L,0L,2L,5L,6L,4L,5L,6L,4L,5L,5L,4L,4L,7L,6L,9L,2L,8L,9L,6L,4L,5L,6L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263208Inst : IEnumerable<long>
{
public static readonly long[] Value=A263208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263208.Bytes);
public long this[int i]=>Value[i];

public static A263208Inst Instance=new A263208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263209
{
public static readonly long[] Value={ 3L,5L,5L,8L,8L,1L,7L,2L,7L,1L,0L,7L,5L,6L,2L,7L,8L,2L,6L,3L,1L,3L,1L,9L,4L,9L,8L,1L,3L,7L,5L,2L,9L,7L,4L,3L,4L,6L,8L,7L,2L,7L,9L,2L,7L,5L,7L,6L,6L,4L,8L,1L,1L,6L,6L,4L,5L,3L,2L,5L,3L,6L,8L,6L,8L,8L,7L,6L,3L,2L,1L,5L,4L,6L,7L,7L,0L,0L,3L,7L,4L,3L,8L,1L,2L,3L,7L,0L,9L,5L,6L,9L,8L,7L,6L,7L,1L,2L,7L,5L,9L,9L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263209Inst : IEnumerable<long>
{
public static readonly long[] Value=A263209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263209.Bytes);
public long this[int i]=>Value[i];

public static A263209Inst Instance=new A263209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263210
{
public static readonly long[] Value={ 3L,0L,7L,2L,5L,4L,0L,4L,7L,7L,6L,4L,4L,8L,5L,7L,5L,7L,9L,0L,8L,5L,9L,4L,6L,5L,2L,0L,8L,3L,5L,4L,0L,9L,6L,5L,2L,4L,4L,1L,1L,2L,5L,0L,0L,7L,9L,1L,7L,1L,1L,9L,0L,0L,1L,9L,1L,7L,8L,2L,6L,9L,5L,3L,9L,3L,6L,6L,5L,0L,1L,2L,3L,5L,9L,0L,3L,0L,5L,3L,2L,4L,1L,5L,5L,4L,0L,0L,7L,3L,7L,0L,4L,3L,0L,6L,2L,0L,6L,8L,5L,4L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263210Inst : IEnumerable<long>
{
public static readonly long[] Value=A263210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263210.Bytes);
public long this[int i]=>Value[i];

public static A263210Inst Instance=new A263210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263211
{
public static readonly long[] Value={ 3L,1L,2L,2L,0L,3L,0L,6L,9L,2L,0L,8L,0L,7L,2L,0L,0L,4L,9L,4L,7L,8L,9L,3L,2L,6L,0L,5L,9L,5L,6L,8L,8L,2L,6L,8L,1L,9L,3L,9L,2L,3L,3L,0L,0L,9L,6L,6L,1L,0L,3L,5L,8L,7L,0L,4L,4L,8L,6L,3L,0L,0L,0L,8L,0L,8L,1L,7L,5L,2L,1L,6L,5L,2L,7L,8L,9L,9L,1L,7L,7L,5L,1L,8L,1L,0L,6L,2L,5L,9L,7L,7L,7L,9L,2L,4L,5L,0L,6L,5L,7L,8L,8L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263211Inst : IEnumerable<long>
{
public static readonly long[] Value=A263211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263211.Bytes);
public long this[int i]=>Value[i];

public static A263211Inst Instance=new A263211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263212
{
public static readonly BigInteger[] Value={ 22874L,362522L,5416302L,78580226L,1104667450L,15573947878L,218825883910L,3069682860418L,42982240551546L,602035560027786L,8430500381895662L,118042502060139234L,1652614325269962938L,BigInteger.Parse("23137272385725202262") };
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
public class A263212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263212Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263212.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263212Inst Instance=new A263212Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263213
{
public static readonly BigInteger[] Value={ 362522L,12507525L,395174691L,11968129797L,347731730746L,10187306724903L,296916184095679L,8631678680662573L,250309278812584218L,7263508079838204757L,BigInteger.Parse("210703999521562203563"),BigInteger.Parse("6111252370665115370309"),BigInteger.Parse("177225107436637146707162") };
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
public class A263213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263213Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263213.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263213Inst Instance=new A263213Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263214
{
public static readonly BigInteger[] Value={ 5416302L,395174691L,25864201119L,1606472091969L,94851590043422L,5666950847883973L,336423212979882403L,BigInteger.Parse("19908435853180444585"),BigInteger.Parse("1174504708839557685998") };
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
public class A263214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263214Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263214.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263214Inst Instance=new A263214Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263215
{
public static readonly long[] Value={ 22874L,362522L,362522L,5416302L,12507525L,5416302L,78580226L,395174691L,395174691L,78580226L,1104667450L,11968129797L,25864201119L,11968129797L,1104667450L,15573947878L,347731730746L,1606472091969L,1606472091969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263215Inst : IEnumerable<long>
{
public static readonly long[] Value=A263215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263215.Bytes);
public long this[int i]=>Value[i];

public static A263215Inst Instance=new A263215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263216
{
public static readonly long[] Value={ 2L,3L,2L,5L,4L,0L,0L,3L,0L,2L,8L,10L,0L,0L,6L,0L,4L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,2L,13L,20L,0L,4L,15L,0L,10L,0L,0L,0L,0L,0L,0L,10L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263216Inst : IEnumerable<long>
{
public static readonly long[] Value=A263216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263216.Bytes);
public long this[int i]=>Value[i];

public static A263216Inst Instance=new A263216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263217
{
public static readonly BigInteger[] Value={ 1L,14L,1009L,475539L,3126162435L,199878687706434L,BigInteger.Parse("113626071226676220337"),BigInteger.Parse("582273491524766112505402255") };
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
public class A263217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263217Inst Instance=new A263217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263218
{
public static readonly long[] Value={ 2L,14L,72L,343L,1920L,11444L,68112L,405019L,2422502L,14527358L,87130296L,522558079L,3134839248L,18808467356L,112848487824L,677075548723L,4062417593558L,24374464952438L,146246626666296L,877478675492551L,5264869525163232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263218Inst : IEnumerable<long>
{
public static readonly long[] Value=A263218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263218.Bytes);
public long this[int i]=>Value[i];

public static A263218Inst Instance=new A263218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263219
{
public static readonly long[] Value={ 4L,72L,1009L,12601L,198892L,3345984L,56362801L,951167305L,16140651460L,274301213400L,4662032059249L,79241699410777L,1347050532750556L,22899642182348976L,389291621638482865L,6617932860469046761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263219Inst : IEnumerable<long>
{
public static readonly long[] Value=A263219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263219.Bytes);
public long this[int i]=>Value[i];

public static A263219Inst Instance=new A263219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263220
{
public static readonly BigInteger[] Value={ 7L,343L,12601L,475539L,22342751L,1094138875L,53375395657L,2607171566653L,127682197727311L,6256406902789159L,306545703110117209L,15020102223676251147UL,BigInteger.Parse("735979598601461106119"),BigInteger.Parse("36062999023016301797227") };
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
public class A263220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263220Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263220.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263220Inst Instance=new A263220Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263221
{
public static readonly BigInteger[] Value={ 13L,1920L,198892L,22342751L,3126162435L,456363243352L,66317081173996L,9651690803653879L,1408397535551222617L,BigInteger.Parse("205625917583136780312"),BigInteger.Parse("30019612862946349286716"),BigInteger.Parse("4382688566369987885721551") };
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
public class A263221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263221Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263221.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263221Inst Instance=new A263221Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263222
{
public static readonly BigInteger[] Value={ 26L,11444L,3345984L,1094138875L,456363243352L,199878687706434L,87072717791078712L,BigInteger.Parse("37998530090131229539"),BigInteger.Parse("16633155845877772714382"),BigInteger.Parse("7285320640434422479387484"),BigInteger.Parse("3190753333014806396532157872") };
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
public class A263222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263222Inst Instance=new A263222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263223
{
public static readonly BigInteger[] Value={ 52L,68112L,56362801L,53375395657L,66317081173996L,87072717791078712L,BigInteger.Parse("113626071226676220337"),BigInteger.Parse("148577011002706188270265"),BigInteger.Parse("194947288514689323686605300"),BigInteger.Parse("255965788647405918475696491840") };
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
public class A263223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263223Inst Instance=new A263223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263224
{
public static readonly long[] Value={ 1L,2L,2L,4L,14L,4L,7L,72L,72L,7L,13L,343L,1009L,343L,13L,26L,1920L,12601L,12601L,1920L,26L,52L,11444L,198892L,475539L,198892L,11444L,52L,103L,68112L,3345984L,22342751L,22342751L,3345984L,68112L,103L,205L,405019L,56362801L,1094138875L,3126162435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263224Inst : IEnumerable<long>
{
public static readonly long[] Value=A263224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263224.Bytes);
public long this[int i]=>Value[i];

public static A263224Inst Instance=new A263224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263225
{
public static readonly long[] Value={ 1L,60L,240L,600L,660L,768L,1008L,1200L,1320L,1800L,1860L,2160L,2688L,2736L,3000L,3300L,3360L,3888L,4620L,4800L,5280L,5520L,5568L,6120L,6480L,6720L,6840L,7320L,7680L,8208L,8640L,9000L,9600L,9720L,10368L,11160L,12240L,12288L,13200L,13248L,13440L,13680L,13868L,14400L,15120L,15360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263225Inst : IEnumerable<long>
{
public static readonly long[] Value=A263225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263225.Bytes);
public long this[int i]=>Value[i];

public static A263225Inst Instance=new A263225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263226
{
public static readonly long[] Value={ 0L,2L,34L,96L,188L,310L,462L,644L,856L,1098L,1370L,1672L,2004L,2366L,2758L,3180L,3632L,4114L,4626L,5168L,5740L,6342L,6974L,7636L,8328L,9050L,9802L,10584L,11396L,12238L,13110L,14012L,14944L,15906L,16898L,17920L,18972L,20054L,21166L,22308L,23480L,24682L,25914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263226Inst : IEnumerable<long>
{
public static readonly long[] Value=A263226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263226.Bytes);
public long this[int i]=>Value[i];

public static A263226Inst Instance=new A263226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263227
{
public static readonly long[] Value={ 0L,-11L,45L,168L,358L,615L,939L,1330L,1788L,2313L,2905L,3564L,4290L,5083L,5943L,6870L,7864L,8925L,10053L,11248L,12510L,13839L,15235L,16698L,18228L,19825L,21489L,23220L,25018L,26883L,28815L,30814L,32880L,35013L,37213L,39480L,41814L,44215L,46683L,49218L,51820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263227Inst : IEnumerable<long>
{
public static readonly long[] Value=A263227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263227.Bytes);
public long this[int i]=>Value[i];

public static A263227Inst Instance=new A263227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263228
{
public static readonly long[] Value={ 0L,6L,76L,210L,408L,670L,996L,1386L,1840L,2358L,2940L,3586L,4296L,5070L,5908L,6810L,7776L,8806L,9900L,11058L,12280L,13566L,14916L,16330L,17808L,19350L,20956L,22626L,24360L,26158L,28020L,29946L,31936L,33990L,36108L,38290L,40536L,42846L,45220L,47658L,50160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263228Inst : IEnumerable<long>
{
public static readonly long[] Value=A263228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263228.Bytes);
public long this[int i]=>Value[i];

public static A263228Inst Instance=new A263228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263229
{
public static readonly long[] Value={ 0L,-20L,128L,444L,928L,1580L,2400L,3388L,4544L,5868L,7360L,9020L,10848L,12844L,15008L,17340L,19840L,22508L,25344L,28348L,31520L,34860L,38368L,42044L,45888L,49900L,54080L,58428L,62944L,67628L,72480L,77500L,82688L,88044L,93568L,99260L,105120L,111148L,117344L,123708L,130240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263229Inst : IEnumerable<long>
{
public static readonly long[] Value=A263229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263229.Bytes);
public long this[int i]=>Value[i];

public static A263229Inst Instance=new A263229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263230
{
public static readonly long[] Value={ 1L,2L,3L,0L,1L,6L,0L,2L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,10L,0L,6L,2L,1L,0L,0L,3L,1L,0L,1L,1L,0L,0L,0L,2L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263230Inst : IEnumerable<long>
{
public static readonly long[] Value=A263230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263230.Bytes);
public long this[int i]=>Value[i];

public static A263230Inst Instance=new A263230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263231
{
public static readonly long[] Value={ 0L,-7L,11L,54L,122L,215L,333L,476L,644L,837L,1055L,1298L,1566L,1859L,2177L,2520L,2888L,3281L,3699L,4142L,4610L,5103L,5621L,6164L,6732L,7325L,7943L,8586L,9254L,9947L,10665L,11408L,12176L,12969L,13787L,14630L,15498L,16391L,17309L,18252L,19220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263231Inst : IEnumerable<long>
{
public static readonly long[] Value=A263231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263231.Bytes);
public long this[int i]=>Value[i];

public static A263231Inst Instance=new A263231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263232
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,4L,1L,5L,2L,8L,2L,1L,10L,4L,1L,15L,5L,2L,19L,8L,2L,1L,27L,10L,4L,1L,34L,15L,5L,2L,47L,19L,8L,2L,1L,59L,27L,10L,4L,1L,79L,34L,15L,5L,2L,99L,47L,19L,8L,2L,1L,130L,59L,27L,10L,4L,1L,162L,79L,34L,15L,5L,2L,209L,99L,47L,19L,8L,2L,1L,259L,130L,59L,27L,10L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263232Inst : IEnumerable<long>
{
public static readonly long[] Value=A263232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263232.Bytes);
public long this[int i]=>Value[i];

public static A263232Inst Instance=new A263232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263233
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,0L,1L,2L,1L,2L,1L,0L,1L,3L,3L,1L,2L,1L,0L,1L,3L,4L,3L,1L,2L,1L,0L,1L,5L,4L,5L,3L,1L,2L,1L,0L,1L,5L,8L,4L,5L,3L,1L,2L,1L,0L,1L,8L,8L,9L,4L,5L,3L,1L,2L,1L,0L,1L,9L,12L,9L,9L,4L,5L,3L,1L,2L,1L,0L,1L,13L,15L,13L,10L,9L,4L,5L,3L,1L,2L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263233Inst : IEnumerable<long>
{
public static readonly long[] Value=A263233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263233.Bytes);
public long this[int i]=>Value[i];

public static A263233Inst Instance=new A263233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263234
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,2L,0L,2L,0L,1L,1L,3L,0L,2L,0L,1L,2L,2L,4L,0L,2L,0L,1L,2L,4L,2L,4L,0L,2L,0L,1L,4L,4L,5L,2L,4L,0L,2L,0L,1L,4L,6L,5L,6L,2L,4L,0L,2L,0L,1L,5L,9L,8L,5L,6L,2L,4L,0L,2L,0L,1L,6L,10L,11L,9L,5L,6L,2L,4L,0L,2L,0L,1L,9L,13L,13L,12L,10L,5L,6L,2L,4L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263234Inst : IEnumerable<long>
{
public static readonly long[] Value=A263234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263234.Bytes);
public long this[int i]=>Value[i];

public static A263234Inst Instance=new A263234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263235
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,14L,24L,37L,56L,85L,124L,178L,254L,354L,489L,671L,907L,1217L,1624L,2144L,2815L,3675L,4764L,6142L,7885L,10062L,12788L,16183L,20391L,25590L,32013L,39883L,49536L,61326L,75688L,93129L,114296L,139856L,170718L,207857L,252476L,305938L,369946L,446314L,537379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263235Inst : IEnumerable<long>
{
public static readonly long[] Value=A263235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263235.Bytes);
public long this[int i]=>Value[i];

public static A263235Inst Instance=new A263235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263236
{
public static readonly BigInteger[] Value={ 22718L,366629L,5113258L,71543684L,996998308L,14068694499L,196568037780L,2760026763925L,38693975425461L,542073841002361L,7588392160045568L,106256158187883095L,1487570357452520506L,BigInteger.Parse("20825972399331868388") };
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
public class A263236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263236Inst Instance=new A263236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263237
{
public static readonly BigInteger[] Value={ 366629L,12652497L,365832647L,10595045187L,306234039025L,8971344440493L,259877539798060L,7558319565205403L,219503638927712079L,6370066248057714293L,BigInteger.Parse("184726447984445515275"),BigInteger.Parse("5358013099014479637987"),BigInteger.Parse("155381832153450791875837") };
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
public class A263237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263237Inst Instance=new A263237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263238
{
public static readonly long[] Value={ 22718L,366629L,366629L,5113258L,12652497L,5113258L,71543684L,365832647L,365832647L,71543684L,996998308L,10595045187L,21178741484L,10595045187L,996998308L,14068694499L,306234039025L,1227150387696L,1227150387696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263238Inst : IEnumerable<long>
{
public static readonly long[] Value=A263238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263238.Bytes);
public long this[int i]=>Value[i];

public static A263238Inst Instance=new A263238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263239
{
public static readonly long[] Value={ 4L,28L,91L,121L,286L,532L,671L,703L,949L,1036L,1105L,1541L,1729L,1891L,2465L,2665L,2701L,2821L,3281L,3367L,3751L,4636L,4961L,5551L,6364L,6601L,7381L,8401L,8911L,10585L,11011L,11476L,12403L,14383L,15203L,15457L,15841L,16471L,16531L,18721L,19345L,19684L,23521L,24046L,24661L,24727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263239Inst : IEnumerable<long>
{
public static readonly long[] Value=A263239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263239.Bytes);
public long this[int i]=>Value[i];

public static A263239Inst Instance=new A263239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263240
{
public static readonly long[] Value={ 13L,17L,31L,37L,71L,73L,79L,97L,107L,113L,149L,157L,167L,179L,199L,311L,337L,347L,359L,389L,701L,709L,733L,739L,743L,751L,761L,769L,907L,937L,941L,953L,967L,971L,983L,991L,1009L,1223L,1229L,1559L,1669L,3221L,3889L,7229L,9001L,9221L,9227L,9551L,9661L,10007L,10009L,10909L,11717L,11719L,12227L,12323L,12829L,13337L,13933L,14143L,14447L,14449L,14549L,14843L,14947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263240Inst : IEnumerable<long>
{
public static readonly long[] Value=A263240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263240.Bytes);
public long this[int i]=>Value[i];

public static A263240Inst Instance=new A263240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263241
{
public static readonly long[] Value={ 13L,17L,37L,79L,107L,113L,149L,157L,167L,199L,337L,347L,359L,389L,709L,739L,769L,1009L,1223L,1229L,1559L,1669L,3889L,7229L,10007L,10009L,10909L,11717L,11719L,12227L,12323L,12829L,13337L,13933L,14143L,14447L,14449L,14549L,14843L,14947L,15053L,16063L,16267L,16567L,16763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263241Inst : IEnumerable<long>
{
public static readonly long[] Value=A263241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263241.Bytes);
public long this[int i]=>Value[i];

public static A263241Inst Instance=new A263241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263242
{
public static readonly long[] Value={ 31L,71L,73L,97L,311L,701L,733L,743L,751L,761L,907L,937L,941L,953L,967L,971L,983L,991L,3221L,9001L,9221L,9227L,9551L,9661L,9883L,32321L,33931L,34141L,34841L,35051L,36061L,36761L,37571L,39791L,70001L,71711L,72221L,73331L,74143L,74441L,74843L,74941L,75253L,76261L,76463L,76561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263242Inst : IEnumerable<long>
{
public static readonly long[] Value=A263242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263242.Bytes);
public long this[int i]=>Value[i];

public static A263242Inst Instance=new A263242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263243
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263243Inst : IEnumerable<long>
{
public static readonly long[] Value=A263243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263243.Bytes);
public long this[int i]=>Value[i];

public static A263243Inst Instance=new A263243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263244
{
public static readonly BigInteger[] Value={ 1L,101L,10011L,1011111L,100111111L,10111111111L,1001111111111L,101111111111111L,10011111111111111L,1011111111111111111L,BigInteger.Parse("100111111111111111111"),BigInteger.Parse("10111111111111111111111"),BigInteger.Parse("1001111111111111111111111"),BigInteger.Parse("101111111111111111111111111"),BigInteger.Parse("10011111111111111111111111111") };
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
public class A263244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263244Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263244.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263244Inst Instance=new A263244Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263245
{
public static readonly long[] Value={ 1L,5L,19L,95L,319L,1535L,5119L,24575L,81919L,393215L,1310719L,6291455L,20971519L,100663295L,335544319L,1610612735L,5368709119L,25769803775L,85899345919L,412316860415L,1374389534719L,6597069766655L,21990232555519L,105553116266495L,351843720888319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263245Inst : IEnumerable<long>
{
public static readonly long[] Value=A263245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263245.Bytes);
public long this[int i]=>Value[i];

public static A263245Inst Instance=new A263245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263246
{
public static readonly BigInteger[] Value={ 1L,1L,-11L,-491L,-11159L,460681L,103577629L,8160790429L,-624333860399L,-386787409545839L,-68810049201689531L,6999828208693648549L,BigInteger.Parse("9872674440874152431161"),BigInteger.Parse("3255253386897615662908441"),BigInteger.Parse("-346248578699462435167833491"),BigInteger.Parse("-1072454627614122049417452882131"),BigInteger.Parse("-584579592415141205182370782224479"),BigInteger.Parse("47874474639430619859527348515679521") };
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
public class A263246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263246Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263246.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263246Inst Instance=new A263246Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263247
{
public static readonly BigInteger[] Value={ 1L,-1L,-7L,-49L,1457L,148799L,6409193L,-436948849L,-155175606943L,-18245982604801L,1864031151256793L,1627915037217907151L,BigInteger.Parse("390178889220670506257"),BigInteger.Parse("-46784571591411151243201"),BigInteger.Parse("-89306450512551172914577207"),BigInteger.Parse("-37461031331532428265812712049"),BigInteger.Parse("4204976347690709918899169381057"),BigInteger.Parse("17814701962096793952255775890393599") };
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
public class A263247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263247Inst Instance=new A263247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263248
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-71L,-2591L,-23759L,7872481L,1032165289L,34225547329L,-19224419375519L,-5800472581083839L,-474084524873544551L,BigInteger.Parse("353987939065905654049"),BigInteger.Parse("201460031539970745643921"),BigInteger.Parse("32857189444574660214635041"),BigInteger.Parse("-29238884957420392451016521591"),BigInteger.Parse("-28126153570109708198511424386431"),BigInteger.Parse("-8022417111018145463775521643973439"),BigInteger.Parse("7957314358326789159275513256441813121") };
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
public class A263248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263248Inst Instance=new A263248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263249
{
public static readonly BigInteger[] Value={ 1L,-2L,-8L,112L,9088L,310528L,-14701568L,-4554426368L,-458243735552L,37024075153408L,29290212127670272L,6224109737622372352L,BigInteger.Parse("-631398107821314670592"),BigInteger.Parse("-1112417825593218314534912"),BigInteger.Parse("-422420220419591934719295488"),BigInteger.Parse("41942640830461258871206838272"),BigInteger.Parse("165285368668709582104936440659968"),BigInteger.Parse("101410495525765825487306697440493568") };
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
public class A263249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A263249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A263249Inst Instance=new A263249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263250
{
public static readonly long[] Value={ 2L,1L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,1L,1L,0L,2L,1L,1L,1L,1L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,3L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,3L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,2L,0L,0L,0L,1L,0L,2L,0L,0L,1L,0L,0L,1L,1L,2L,1L,1L,0L,2L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263250Inst : IEnumerable<long>
{
public static readonly long[] Value=A263250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263250.Bytes);
public long this[int i]=>Value[i];

public static A263250Inst Instance=new A263250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263251
{
public static readonly long[] Value={ 2L,1L,0L,0L,2L,1L,1L,1L,1L,1L,2L,1L,1L,0L,1L,2L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,2L,0L,1L,1L,1L,1L,1L,0L,1L,0L,2L,1L,0L,1L,1L,1L,0L,3L,1L,1L,1L,1L,1L,1L,1L,1L,3L,0L,0L,1L,2L,2L,0L,2L,1L,0L,1L,1L,1L,2L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,3L,2L,1L,0L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,2L,0L,0L,0L,0L,1L,2L,2L,2L,2L,0L,0L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263251Inst : IEnumerable<long>
{
public static readonly long[] Value=A263251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263251.Bytes);
public long this[int i]=>Value[i];

public static A263251Inst Instance=new A263251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263252
{
public static readonly long[] Value={ 2L,3L,4L,4L,4L,4L,6L,6L,6L,6L,6L,6L,8L,8L,8L,9L,10L,10L,12L,13L,14L,15L,16L,16L,18L,18L,19L,19L,19L,19L,19L,19L,20L,21L,22L,23L,26L,27L,28L,28L,29L,29L,30L,31L,32L,32L,33L,33L,35L,35L,35L,36L,36L,36L,37L,37L,38L,38L,38L,38L,40L,40L,40L,40L,40L,40L,43L,44L,45L,46L,46L,46L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263252Inst : IEnumerable<long>
{
public static readonly long[] Value=A263252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263252.Bytes);
public long this[int i]=>Value[i];

public static A263252Inst Instance=new A263252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263253
{
public static readonly long[] Value={ 2L,3L,3L,3L,5L,6L,7L,8L,9L,10L,12L,13L,14L,14L,15L,17L,18L,18L,18L,19L,20L,21L,22L,22L,23L,24L,25L,26L,27L,27L,28L,29L,30L,30L,31L,33L,33L,34L,35L,36L,37L,38L,38L,39L,39L,41L,42L,42L,43L,44L,45L,45L,48L,49L,50L,51L,52L,53L,54L,55L,56L,59L,59L,59L,60L,62L,64L,64L,66L,67L,67L,68L,69L,70L,72L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263253Inst : IEnumerable<long>
{
public static readonly long[] Value=A263253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263253.Bytes);
public long this[int i]=>Value[i];

public static A263253Inst Instance=new A263253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263254
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,3L,0L,4L,3L,1L,1L,2L,0L,3L,2L,3L,3L,4L,0L,5L,3L,5L,0L,6L,4L,1L,1L,7L,1L,8L,0L,9L,2L,9L,0L,10L,8L,11L,1L,11L,3L,12L,0L,13L,2L,12L,0L,13L,2L,1L,3L,14L,1L,15L,0L,15L,3L,16L,0L,17L,3L,18L,0L,17L,17L,19L,1L,20L,1L,20L,0L,21L,4L,22L,1L,21L,1L,23L,0L,24L,1L,2L,1L,3L,5L,3L,2L,4L,2L,5L,0L,5L,3L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263254Inst : IEnumerable<long>
{
public static readonly long[] Value=A263254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263254.Bytes);
public long this[int i]=>Value[i];

public static A263254Inst Instance=new A263254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263255
{
public static readonly long[] Value={ 0L,2L,1L,6L,9L,3L,12L,10L,4L,5L,18L,25L,11L,8L,7L,22L,26L,14L,13L,17L,19L,30L,28L,32L,15L,24L,21L,23L,34L,38L,44L,16L,72L,84L,93L,27L,42L,49L,48L,20L,87L,89L,95L,97L,29L,46L,52L,81L,40L,98L,91L,96L,99L,36L,31L,54L,66L,86L,50L,139L,143L,100L,104L,101L,33L,35L,58L,68L,88L,56L,141L,145L,149L,108L,105L,103L,109L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263255Inst : IEnumerable<long>
{
public static readonly long[] Value=A263255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263255.Bytes);
public long this[int i]=>Value[i];

public static A263255Inst Instance=new A263255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263256
{
public static readonly long[] Value={ 0L,1L,2L,3L,9L,6L,5L,4L,10L,12L,7L,8L,11L,25L,18L,19L,17L,13L,14L,26L,22L,23L,21L,24L,15L,32L,28L,30L,27L,93L,84L,72L,16L,44L,38L,34L,29L,97L,95L,89L,87L,20L,48L,49L,42L,31L,36L,99L,96L,91L,98L,40L,81L,52L,46L,35L,33L,101L,104L,100L,143L,139L,50L,86L,66L,54L,37L,109L,103L,105L,108L,149L,145L,141L,56L,88L,68L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263256Inst : IEnumerable<long>
{
public static readonly long[] Value=A263256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263256.Bytes);
public long this[int i]=>Value[i];

public static A263256Inst Instance=new A263256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263257
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,19L,23L,27L,29L,31L,35L,37L,41L,43L,51L,53L,57L,59L,61L,65L,67L,71L,73L,77L,79L,223L,231L,233L,237L,239L,241L,249L,251L,263L,267L,269L,271L,277L,285L,291L,293L,299L,303L,315L,317L,321L,327L,331L,335L,337L,341L,347L,349L,357L,359L,369L,857L,859L,1077L,1081L,1087L,1095L,1097L,1101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263257Inst : IEnumerable<long>
{
public static readonly long[] Value=A263257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263257.Bytes);
public long this[int i]=>Value[i];

public static A263257Inst Instance=new A263257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263258
{
public static readonly long[] Value={ 0L,1L,3L,5L,17L,21L,23L,27L,29L,31L,35L,39L,41L,47L,51L,53L,57L,59L,61L,65L,69L,71L,73L,77L,221L,223L,231L,233L,237L,239L,245L,249L,261L,263L,267L,269L,275L,277L,287L,291L,295L,299L,303L,315L,317L,323L,329L,331L,335L,337L,345L,347L,349L,357L,363L,855L,857L,1073L,1077L,1085L,1087L,1095L,1097L,1101L,1111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263258Inst : IEnumerable<long>
{
public static readonly long[] Value=A263258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263258.Bytes);
public long this[int i]=>Value[i];

public static A263258Inst Instance=new A263258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263259
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,1L,2L,3L,4L,2L,5L,1L,3L,2L,3L,1L,4L,1L,4L,2L,5L,1L,2L,3L,4L,1L,5L,1L,6L,1L,3L,2L,4L,1L,2L,1L,2L,2L,3L,1L,4L,1L,2L,2L,3L,2L,4L,3L,4L,1L,5L,1L,6L,2L,7L,1L,3L,1L,8L,1L,2L,2L,3L,1L,3L,1L,3L,2L,4L,1L,4L,1L,3L,2L,4L,1L,5L,1L,6L,3L,4L,2L,4L,3L,4L,3L,5L,2L,6L,3L,4L,4L,5L,5L,5L,2L,4L,3L,6L,2L,5L,3L,7L,3L,5L,4L,8L,3L,6L,4L,7L,2L,7L,3L,8L,4L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263259Inst : IEnumerable<long>
{
public static readonly long[] Value=A263259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263259.Bytes);
public long this[int i]=>Value[i];

public static A263259Inst Instance=new A263259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263260
{
public static readonly long[] Value={ 1L,3L,6L,11L,15L,20L,26L,30L,34L,38L,46L,50L,54L,59L,67L,74L,81L,88L,95L,103L,108L,114L,120L,128L,138L,145L,153L,160L,167L,172L,177L,183L,189L,197L,203L,210L,217L,224L,228L,233L,238L,244L,250L,258L,265L,270L,275L,281L,288L,299L,304L,308L,313L,321L,333L,340L,349L,354L,362L,370L,379L,389L,403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263260Inst : IEnumerable<long>
{
public static readonly long[] Value=A263260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263260.Bytes);
public long this[int i]=>Value[i];

public static A263260Inst Instance=new A263260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263261
{
public static readonly long[] Value={ 1L,9L,10L,25L,26L,28L,38L,49L,52L,66L,68L,74L,76L,80L,82L,110L,112L,122L,124L,126L,127L,131L,133L,156L,168L,169L,170L,172L,176L,178L,180L,188L,218L,226L,234L,238L,258L,278L,288L,290L,300L,304L,306L,316L,318L,322L,334L,361L,362L,368L,398L,414L,422L,448L,452L,470L,478L,496L,514L,518L,526L,586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263261Inst : IEnumerable<long>
{
public static readonly long[] Value=A263261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263261.Bytes);
public long this[int i]=>Value[i];

public static A263261Inst Instance=new A263261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263262
{
public static readonly long[] Value={ 3L,4L,11L,14L,32L,44L,48L,81L,86L,88L,116L,130L,135L,175L,184L,186L,192L,200L,244L,246L,252L,262L,266L,284L,286L,296L,320L,326L,336L,365L,370L,376L,378L,380L,384L,404L,406L,428L,430L,460L,482L,490L,524L,529L,534L,608L,624L,642L,652L,654L,656L,682L,690L,764L,768L,772L,786L,794L,796L,802L,806L,810L,884L,888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263262Inst : IEnumerable<long>
{
public static readonly long[] Value=A263262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263262.Bytes);
public long this[int i]=>Value[i];

public static A263262Inst Instance=new A263262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263263
{
public static readonly long[] Value={ 5L,8L,13L,15L,16L,20L,40L,50L,56L,60L,83L,85L,92L,134L,137L,138L,198L,204L,216L,268L,272L,289L,292L,308L,312L,328L,332L,344L,348L,360L,367L,382L,392L,396L,412L,416L,436L,438L,498L,533L,538L,620L,632L,636L,640L,664L,666L,694L,700L,704L,720L,776L,792L,814L,816L,828L,922L,936L,940L,956L,965L,966L,969L,1032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263263Inst : IEnumerable<long>
{
public static readonly long[] Value=A263263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263263.Bytes);
public long this[int i]=>Value[i];

public static A263263Inst Instance=new A263263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263264
{
public static readonly long[] Value={ 7L,17L,24L,72L,87L,98L,139L,141L,142L,150L,202L,208L,225L,228L,297L,338L,340L,371L,372L,375L,386L,388L,408L,420L,424L,432L,502L,506L,537L,539L,542L,550L,625L,644L,660L,680L,684L,698L,712L,732L,804L,818L,822L,824L,926L,948L,952L,967L,968L,971L,973L,976L,990L,1056L,1062L,1120L,1122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263264Inst : IEnumerable<long>
{
public static readonly long[] Value=A263264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263264.Bytes);
public long this[int i]=>Value[i];

public static A263264Inst Instance=new A263264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263265
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,5L,8L,9L,10L,12L,7L,11L,14L,18L,13L,15L,16L,20L,22L,17L,24L,25L,26L,28L,30L,19L,21L,32L,34L,23L,38L,40L,42L,27L,44L,46L,48L,29L,36L,49L,50L,52L,54L,56L,60L,31L,33L,58L,72L,35L,62L,66L,84L,37L,39L,68L,70L,96L,41L,45L,74L,76L,78L,80L,104L,108L,43L,47L,81L,82L,88L,90L,120L,51L,83L,85L,86L,94L,128L,132L,53L,55L,87L,92L,102L,136L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263265Inst : IEnumerable<long>
{
public static readonly long[] Value=A263265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263265.Bytes);
public long this[int i]=>Value[i];

public static A263265Inst Instance=new A263265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263266
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,5L,11L,7L,8L,9L,12L,10L,15L,13L,16L,17L,20L,14L,26L,18L,27L,19L,30L,21L,22L,23L,34L,24L,38L,25L,46L,28L,47L,29L,50L,39L,54L,31L,55L,32L,59L,33L,67L,35L,60L,36L,68L,37L,40L,41L,74L,42L,81L,43L,82L,44L,88L,48L,95L,45L,103L,51L,96L,97L,108L,52L,114L,56L,115L,57L,120L,49L,128L,61L,121L,62L,138L,63L,145L,64L,69L,70L,75L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263266Inst : IEnumerable<long>
{
public static readonly long[] Value=A263266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263266.Bytes);
public long this[int i]=>Value[i];

public static A263266Inst Instance=new A263266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263267
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,5L,8L,9L,10L,12L,7L,11L,14L,18L,13L,15L,16L,20L,22L,17L,24L,25L,26L,28L,30L,19L,21L,32L,34L,23L,40L,38L,42L,27L,44L,48L,46L,29L,36L,50L,56L,60L,49L,52L,54L,31L,33L,72L,58L,35L,84L,62L,66L,37L,39L,96L,68L,70L,41L,45L,104L,108L,74L,76L,78L,80L,43L,47L,120L,81L,82L,90L,88L,51L,128L,132L,83L,85L,86L,94L,53L,55L,136L,140L,87L,92L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263267Inst : IEnumerable<long>
{
public static readonly long[] Value=A263267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263267.Bytes);
public long this[int i]=>Value[i];

public static A263267Inst Instance=new A263267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263268
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,5L,11L,7L,8L,9L,12L,10L,15L,13L,16L,17L,20L,14L,26L,18L,27L,19L,30L,21L,22L,23L,34L,24L,38L,25L,46L,28L,47L,29L,50L,39L,54L,32L,55L,31L,59L,33L,67L,35L,60L,37L,68L,36L,43L,40L,74L,44L,81L,45L,82L,41L,88L,49L,95L,42L,103L,52L,96L,97L,108L,53L,114L,57L,115L,58L,120L,48L,128L,63L,121L,64L,138L,65L,145L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263268Inst : IEnumerable<long>
{
public static readonly long[] Value=A263268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263268.Bytes);
public long this[int i]=>Value[i];

public static A263268Inst Instance=new A263268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263269
{
public static readonly long[] Value={ 0L,2L,6L,12L,18L,22L,30L,34L,42L,46L,54L,58L,66L,70L,80L,88L,94L,102L,112L,116L,126L,124L,130L,138L,150L,148L,160L,158L,164L,184L,190L,194L,210L,214L,222L,234L,252L,246L,250L,258L,266L,272L,296L,312L,306L,320L,328L,340L,352L,364L,372L,354L,358L,368L,384L,392L,408L,402L,414L,418L,426L,434L,448L,460L,462L,470L,474L,486L,496L,510L,522L,530L,546L,558L,562L,566L,574L,582L,592L,598L,606L,630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263269Inst : IEnumerable<long>
{
public static readonly long[] Value=A263269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263269.Bytes);
public long this[int i]=>Value[i];

public static A263269Inst Instance=new A263269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263270
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263270Inst : IEnumerable<long>
{
public static readonly long[] Value=A263270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263270.Bytes);
public long this[int i]=>Value[i];

public static A263270Inst Instance=new A263270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263271
{
public static readonly long[] Value={ 0L,2L,1L,6L,4L,2L,12L,8L,6L,3L,18L,0L,12L,5L,4L,22L,0L,18L,7L,8L,5L,30L,0L,22L,0L,0L,7L,6L,34L,0L,30L,0L,0L,0L,12L,7L,42L,0L,34L,0L,0L,0L,18L,0L,8L,46L,0L,42L,0L,0L,0L,22L,0L,0L,9L,54L,0L,46L,0L,0L,0L,30L,0L,0L,11L,10L,58L,0L,54L,0L,0L,0L,34L,0L,0L,16L,14L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263271Inst : IEnumerable<long>
{
public static readonly long[] Value=A263271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263271.Bytes);
public long this[int i]=>Value[i];

public static A263271Inst Instance=new A263271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263272
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,8L,9L,10L,7L,12L,13L,14L,15L,32L,23L,18L,29L,20L,33L,38L,17L,24L,35L,26L,27L,28L,19L,30L,37L,16L,21L,34L,25L,36L,31L,22L,39L,40L,41L,42L,95L,68L,45L,86L,59L,96L,113L,50L,69L,104L,77L,54L,83L,56L,87L,110L,47L,60L,101L,74L,99L,92L,65L,114L,119L,44L,51L,98L,71L,72L,89L,62L,105L,116L,53L,78L,107L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263272Inst : IEnumerable<long>
{
public static readonly long[] Value=A263272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263272.Bytes);
public long this[int i]=>Value[i];

public static A263272Inst Instance=new A263272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263273
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,5L,8L,9L,10L,19L,12L,13L,22L,21L,16L,25L,18L,11L,20L,15L,14L,23L,24L,17L,26L,27L,28L,55L,30L,37L,64L,57L,46L,73L,36L,31L,58L,39L,40L,67L,66L,49L,76L,63L,34L,61L,48L,43L,70L,75L,52L,79L,54L,29L,56L,33L,38L,65L,60L,47L,74L,45L,32L,59L,42L,41L,68L,69L,50L,77L,72L,35L,62L,51L,44L,71L,78L,53L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263273Inst : IEnumerable<long>
{
public static readonly long[] Value=A263273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263273.Bytes);
public long this[int i]=>Value[i];

public static A263273Inst Instance=new A263273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263274
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,1L,2L,2L,3L,3L,4L,3L,4L,4L,5L,2L,5L,1L,6L,2L,6L,1L,3L,4L,5L,1L,6L,1L,7L,1L,5L,2L,8L,1L,2L,1L,7L,2L,7L,1L,9L,1L,6L,2L,10L,2L,7L,8L,8L,1L,9L,1L,11L,2L,9L,1L,12L,1L,10L,1L,13L,2L,3L,1L,10L,1L,11L,2L,14L,1L,4L,1L,12L,2L,13L,1L,15L,1L,14L,8L,15L,11L,3L,12L,9L,5L,10L,4L,16L,5L,13L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263274Inst : IEnumerable<long>
{
public static readonly long[] Value=A263274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263274.Bytes);
public long this[int i]=>Value[i];

public static A263274Inst Instance=new A263274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263275
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,4L,1L,5L,4L,2L,2L,3L,1L,4L,3L,4L,4L,5L,1L,6L,4L,6L,1L,7L,5L,2L,2L,8L,2L,9L,1L,10L,3L,10L,1L,11L,9L,12L,2L,12L,4L,13L,1L,14L,3L,13L,1L,14L,3L,2L,4L,15L,2L,16L,1L,16L,4L,17L,1L,18L,4L,19L,1L,18L,18L,20L,2L,21L,2L,21L,1L,22L,5L,23L,2L,22L,2L,24L,1L,25L,2L,3L,2L,4L,6L,4L,3L,5L,3L,6L,1L,6L,4L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263275Inst : IEnumerable<long>
{
public static readonly long[] Value=A263275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263275.Bytes);
public long this[int i]=>Value[i];

public static A263275Inst Instance=new A263275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263276
{
public static readonly long[] Value={ 0L,21L,24L,8504L,9860L,28022L,28171L,106666L,106957L,1301664L,1310231L,2736338L,2740428L,8770047L,8829795L,333863896L,333959486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263276Inst : IEnumerable<long>
{
public static readonly long[] Value=A263276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263276.Bytes);
public long this[int i]=>Value[i];

public static A263276Inst Instance=new A263276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263277
{
public static readonly long[] Value={ 21L,3L,8480L,1356L,18162L,149L,78495L,291L,1194707L,8567L,1426107L,4090L,6029619L,59748L,325034101L,95590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263277Inst : IEnumerable<long>
{
public static readonly long[] Value=A263277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263277.Bytes);
public long this[int i]=>Value[i];

public static A263277Inst Instance=new A263277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263278
{
public static readonly long[] Value={ 21L,8480L,18162L,78495L,1194707L,1426107L,6029619L,325034101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263278Inst : IEnumerable<long>
{
public static readonly long[] Value=A263278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263278.Bytes);
public long this[int i]=>Value[i];

public static A263278Inst Instance=new A263278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263279
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,5L,6L,4L,4L,3L,6L,3L,2L,4L,5L,6L,5L,5L,5L,7L,4L,4L,5L,6L,9L,6L,7L,5L,6L,4L,4L,3L,5L,5L,4L,5L,3L,3L,4L,4L,5L,5L,5L,5L,5L,4L,4L,3L,5L,7L,4L,4L,5L,7L,8L,5L,7L,5L,7L,8L,8L,6L,8L,6L,7L,7L,7L,9L,10L,10L,11L,9L,10L,9L,11L,10L,9L,7L,8L,9L,7L,6L,9L,8L,10L,6L,5L,6L,5L,9L,8L,8L,8L,7L,6L,4L,3L,3L,3L,5L,4L,7L,6L,6L,7L,9L,5L,5L,10L,10L,11L,6L,7L,9L,9L,7L,9L,13L,7L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263279Inst : IEnumerable<long>
{
public static readonly long[] Value=A263279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263279.Bytes);
public long this[int i]=>Value[i];

public static A263279Inst Instance=new A263279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263280
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,1L,2L,1L,3L,1L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,1L,3L,2L,2L,4L,4L,0L,1L,0L,1L,1L,3L,2L,1L,1L,3L,2L,4L,1L,0L,0L,1L,4L,2L,2L,0L,1L,0L,1L,4L,6L,5L,5L,4L,2L,2L,3L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,3L,2L,2L,2L,4L,2L,1L,2L,2L,2L,2L,0L,0L,0L,2L,0L,0L,0L,2L,0L,1L,3L,2L,2L,3L,3L,4L,3L,3L,3L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263280Inst : IEnumerable<long>
{
public static readonly long[] Value=A263280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263280.Bytes);
public long this[int i]=>Value[i];

public static A263280Inst Instance=new A263280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A263281
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,89L,100L,133L,543L,649L,869L,5859L,9295L,9957L,10013L,11333L,19799L,30081L,38273L,59653L,63119L,63143L,66423L,103287L,124795L,124821L,128121L,128133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A263281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A263281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A263281Inst : IEnumerable<long>
{
public static readonly long[] Value=A263281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A263281.Bytes);
public long this[int i]=>Value[i];

public static A263281Inst Instance=new A263281Inst();

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