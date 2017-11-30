using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A218705
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,2L,7L,4L,8L,9L,13L,11L,18L,16L,23L,22L,27L,27L,36L,35L,41L,42L,51L,48L,61L,57L,69L,65L,80L,81L,98L,93L,115L,112L,144L,136L,170L,164L,202L,204L,244L,242L,296L,290L,353L,350L,415L,412L,493L,494L,576L,580L,671L,673L,794L,786L,903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218705Inst : IEnumerable<long>
{
public static readonly long[] Value=A218705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218705.Bytes);
public long this[int i]=>Value[i];

public static A218705Inst Instance=new A218705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218706
{
public static readonly long[] Value={ 1L,2L,5L,9L,12L,19L,27L,33L,42L,54L,66L,77L,91L,105L,120L,138L,156L,175L,197L,218L,240L,263L,287L,314L,339L,367L,398L,430L,459L,493L,526L,556L,595L,637L,670L,709L,752L,794L,833L,878L,921L,965L,1018L,1065L,1112L,1163L,1215L,1266L,1317L,1370L,1433L,1492L,1544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218706Inst : IEnumerable<long>
{
public static readonly long[] Value=A218706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218706.Bytes);
public long this[int i]=>Value[i];

public static A218706Inst Instance=new A218706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218707
{
public static readonly long[] Value={ 2L,4L,4L,6L,304L,680L,1054L,1558L,15904L,41638L,82800L,241898L,241898L,241898L,241898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218707Inst : IEnumerable<long>
{
public static readonly long[] Value=A218707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218707.Bytes);
public long this[int i]=>Value[i];

public static A218707Inst Instance=new A218707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218708
{
public static readonly long[] Value={ 1L,9L,9L,4L,7L,1L,1L,4L,0L,2L,0L,0L,7L,1L,6L,3L,3L,8L,9L,6L,9L,9L,7L,3L,0L,2L,9L,9L,6L,7L,1L,9L,0L,9L,3L,4L,2L,3L,7L,9L,2L,9L,3L,1L,5L,5L,8L,2L,4L,6L,7L,3L,2L,8L,8L,3L,2L,9L,6L,2L,9L,1L,4L,8L,3L,5L,3L,2L,8L,9L,6L,2L,9L,4L,9L,6L,5L,0L,9L,1L,9L,2L,5L,0L,6L,2L,6L,1L,6L,6L,9L,5L,3L,6L,5L,3L,4L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218708Inst : IEnumerable<long>
{
public static readonly long[] Value=A218708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218708.Bytes);
public long this[int i]=>Value[i];

public static A218708Inst Instance=new A218708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218709
{
public static readonly BigInteger[] Value={ 0L,5L,70L,239L,239L,143044L,1999509L,6826318L,6826318L,822557039L,52199939826L,603633907222L,11356596271444L,11356596271444L,1828607235824962L,13920898306972194L,13920898306972194L,2675587335039691558L,BigInteger.Parse("49226908181248336040"),BigInteger.Parse("513050126578538629605") };
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
public class A218709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218709Inst Instance=new A218709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218710
{
public static readonly BigInteger[] Value={ 0L,4L,38L,1985L,27493L,390112L,390112L,96940388L,3379649772L,24306922095L,450044583893L,5597937117454L,28673959190179L,3524407382568745L,13428985415474682L,13428985415474682L,5711417117604156904L,BigInteger.Parse("91610966633729580058"),BigInteger.Parse("6709533061724423693474") };
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
public class A218710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218710Inst Instance=new A218710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218711
{
public static readonly long[] Value={ 0L,1L,8L,23L,51L,90L,157L,230L,341L,471L,639L,835L,1063L,1340L,1671L,2022L,2443L,2893L,3428L,4004L,4653L,5359L,6133L,6977L,7907L,8886L,9991L,11152L,12428L,13724L,15192L,16683L,18358L,20072L,21932L,23880L,25941L,28117L,30397L,32822L,35376L,38013L,40840L,43765L,46880L,50090L,53448L,56911L,60583L,64379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218711Inst : IEnumerable<long>
{
public static readonly long[] Value=A218711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218711.Bytes);
public long this[int i]=>Value[i];

public static A218711Inst Instance=new A218711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218712
{
public static readonly BigInteger[] Value={ 0L,12L,41L,10133L,34522L,7745569L,253879357L,7986582530L,61012922706L,4563230639355L,67972499239990L,1330094199140593L,47471944863682723L,5000878909740249297L,5000878909740249297L,BigInteger.Parse("590115586441858677665"),BigInteger.Parse("77072583141941801290876"),BigInteger.Parse("423420364218752896284166") };
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
public class A218712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218712Inst Instance=new A218712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218713
{
public static readonly BigInteger[] Value={ 0L,6L,117L,9466L,800982L,6423465L,756360062L,24900904028L,1019349744435L,15069267560119L,794839706330581L,71333925879937154L,2419512779032508628L,BigInteger.Parse("116073623326088126430"),BigInteger.Parse("359642847542169431827"),BigInteger.Parse("144552623583462302226851"),BigInteger.Parse("3523356323886506075746572") };
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
public class A218713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218713Inst Instance=new A218713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218714
{
public static readonly BigInteger[] Value={ 0L,9L,378L,11389L,1251967L,46464143L,2363588163L,92615568742L,287369842623L,112076323050317L,2403749863808044L,56094387104417648L,1156752450536914530L,BigInteger.Parse("43970228150195457632"),BigInteger.Parse("10132163897314954464899"),BigInteger.Parse("503212117431217218892992"),BigInteger.Parse("19164391897329672149556204") };
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
public class A218714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218714Inst Instance=new A218714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218715
{
public static readonly BigInteger[] Value={ 0L,23L,500L,27590L,623098L,23048345L,5041394261L,416081467190L,11331029931180L,50928660480181L,6548598523124085L,2441875986594058601L,BigInteger.Parse("76594163421571591377"),BigInteger.Parse("7783548304686046882879"),BigInteger.Parse("252583670951378815076851"),BigInteger.Parse("4392422457122810120236558"),BigInteger.Parse("1165802007767335105471573954") };
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
public class A218715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218715Inst Instance=new A218715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218716
{
public static readonly BigInteger[] Value={ 0L,11L,682L,51412L,6304056L,144762466L,9435321777L,988322434636L,71294762793847L,3138611770750343L,283798117998769727L,15409745938584647495UL,BigInteger.Parse("320007169218635518122"),BigInteger.Parse("45443939732277600209579"),BigInteger.Parse("207359227164430355867160"),BigInteger.Parse("59053635973003478214807486") };
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
public class A218716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218716Inst Instance=new A218716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218717
{
public static readonly BigInteger[] Value={ 0L,27L,776L,153765L,6459524L,404034898L,41865466758L,3219884218827L,239822883201307L,9110883894036198L,991706090146518323L,BigInteger.Parse("142813358470363920740"),BigInteger.Parse("8641533837443707913816"),BigInteger.Parse("586811715371303018585730"),BigInteger.Parse("2756887299416274753296336"),BigInteger.Parse("729513196939063257288876118") };
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
public class A218717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218717Inst Instance=new A218717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218718
{
public static readonly BigInteger[] Value={ 0L,34L,3861L,344464L,20099637L,2153335831L,102666405913L,4867146503697L,923990886302412L,50251663587824641L,5655954122907587985L,BigInteger.Parse("909925832091926912414"),BigInteger.Parse("85120439454684773642745"),BigInteger.Parse("2631773999763198769695986"),BigInteger.Parse("41332517834853462204330752") };
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
public class A218718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218718Inst Instance=new A218718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218719
{
public static readonly BigInteger[] Value={ 0L,22L,4052L,107551L,22709274L,331407850L,197177418061L,26457926739667L,2369608176604944L,76004727767164666L,BigInteger.Parse("25163629663367816827"),BigInteger.Parse("1965881512952938486496"),BigInteger.Parse("191165497320828772935835"),BigInteger.Parse("21700278688179406782082106"),BigInteger.Parse("560121950820639295011033922") };
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
public class A218719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218719Inst Instance=new A218719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218720
{
public static readonly BigInteger[] Value={ 0L,10L,515L,296344L,35764191L,1108900220L,316411915250L,47023298541694L,3156215819652023L,310872228812491206L,BigInteger.Parse("28124944860980892220"),BigInteger.Parse("3783840171259076226254"),BigInteger.Parse("208193145695151069244665"),BigInteger.Parse("19364218657938636320485082"),BigInteger.Parse("663491749602035014400202724") };
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
public class A218720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218720Inst Instance=new A218720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218721
{
public static readonly BigInteger[] Value={ 0L,1L,19L,343L,6175L,111151L,2000719L,36012943L,648232975L,11668193551L,210027483919L,3780494710543L,68048904789775L,1224880286215951L,22047845151887119L,396861212733968143L,7143501829211426575L,BigInteger.Parse("128583032925805678351") };
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
public class A218721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218721Inst Instance=new A218721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218722
{
public static readonly BigInteger[] Value={ 0L,1L,20L,381L,7240L,137561L,2613660L,49659541L,943531280L,17927094321L,340614792100L,6471681049901L,122961939948120L,2336276859014281L,44389260321271340L,843395946104155461L,16024522975978953760UL,BigInteger.Parse("304465936543600121441") };
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
public class A218722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218722Inst Instance=new A218722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218723
{
public static readonly BigInteger[] Value={ 0L,1L,257L,65793L,16843009L,4311810305L,1103823438081L,282578800148737L,72340172838076673L,BigInteger.Parse("18519084246547628289"),BigInteger.Parse("4740885567116192841985"),BigInteger.Parse("1213666705181745367548161"),BigInteger.Parse("310698676526526814092329217"),BigInteger.Parse("79538861190790864407636279553") };
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
public class A218723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218723Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218723.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218723Inst Instance=new A218723Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218724
{
public static readonly BigInteger[] Value={ 0L,1L,22L,463L,9724L,204205L,4288306L,90054427L,1891142968L,39714002329L,833994048910L,17513875027111L,367791375569332L,7723618886955973L,162195996626075434L,3406115929147584115L,BigInteger.Parse("71528434512099266416") };
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
public class A218724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218724Inst Instance=new A218724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218725
{
public static readonly BigInteger[] Value={ 0L,1L,23L,507L,11155L,245411L,5399043L,118778947L,2613136835L,57489010371L,1264758228163L,27824681019587L,612142982430915L,13467145613480131L,296277203496562883L,6518098476924383427L,BigInteger.Parse("143398166492336435395") };
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
public class A218725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218725Inst Instance=new A218725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218726
{
public static readonly BigInteger[] Value={ 0L,1L,24L,553L,12720L,292561L,6728904L,154764793L,3559590240L,81870575521L,1883023236984L,43309534450633L,996119292364560L,22910743724384881L,526947105660852264L,12119783430199602073UL,BigInteger.Parse("278755018894590847680"),BigInteger.Parse("6411365434575589496641") };
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
public class A218726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218726Inst Instance=new A218726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218727
{
public static readonly BigInteger[] Value={ 0L,1L,25L,601L,14425L,346201L,8308825L,199411801L,4785883225L,114861197401L,2756668737625L,66160049703001L,1587841192872025L,38108188628928601L,914596527094286425L,BigInteger.Parse("21950316650262874201"),BigInteger.Parse("526807599606308980825"),BigInteger.Parse("12643382390551415539801") };
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
public class A218727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218727Inst Instance=new A218727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218728
{
public static readonly BigInteger[] Value={ 0L,1L,26L,651L,16276L,406901L,10172526L,254313151L,6357828776L,158945719401L,3973642985026L,99341074625651L,2483526865641276L,62088171641031901L,1552204291025797526L,BigInteger.Parse("38805107275644938151"),BigInteger.Parse("970127681891123453776"),BigInteger.Parse("24253192047278086344401") };
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
public class A218728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218728Inst Instance=new A218728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218729
{
public static readonly BigInteger[] Value={ 0L,1L,27L,703L,18279L,475255L,12356631L,321272407L,8353082583L,217180147159L,5646683826135L,146813779479511L,3817158266467287L,99246114928149463L,2580398988131886039L,BigInteger.Parse("67090373691429037015"),BigInteger.Parse("1744349715977154962391") };
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
public class A218729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218729Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218729.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218729Inst Instance=new A218729Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218730
{
public static readonly BigInteger[] Value={ 0L,1L,28L,757L,20440L,551881L,14900788L,402321277L,10862674480L,293292210961L,7918889695948L,213810021790597L,5772870588346120L,155867505885345241L,4208422658904321508L,BigInteger.Parse("113627411790416680717"),BigInteger.Parse("3067940118341250379360"),BigInteger.Parse("82834383195213760242721") };
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
public class A218730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218730Inst Instance=new A218730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218731
{
public static readonly BigInteger[] Value={ 0L,1L,29L,813L,22765L,637421L,17847789L,499738093L,13992666605L,391794664941L,10970250618349L,307167017313773L,8600676484785645L,240818941573998061L,6742930364071945709L,BigInteger.Parse("188802050194014479853"),BigInteger.Parse("5286457405432405435885"),BigInteger.Parse("148020807352107352204781") };
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
public class A218731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218731Inst Instance=new A218731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218732
{
public static readonly BigInteger[] Value={ 0L,1L,30L,871L,25260L,732541L,21243690L,616067011L,17865943320L,518112356281L,15025258332150L,435732491632351L,12636242257338180L,366451025462807221L,10627079738421409410UL,BigInteger.Parse("308185312414220872891"),BigInteger.Parse("8937374060012405313840"),BigInteger.Parse("259183847740359754101361") };
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
public class A218732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218732Inst Instance=new A218732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218733
{
public static readonly BigInteger[] Value={ 0L,1L,31L,931L,27931L,837931L,25137931L,754137931L,22624137931L,678724137931L,20361724137931L,610851724137931L,18325551724137931L,549766551724137931L,16492996551724137931UL,BigInteger.Parse("494789896551724137931"),BigInteger.Parse("14843696896551724137931") };
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
public class A218733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218733Inst Instance=new A218733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218734
{
public static readonly BigInteger[] Value={ 0L,1L,32L,993L,30784L,954305L,29583456L,917087137L,28429701248L,881320738689L,27320942899360L,846949229880161L,26255426126284992L,813918209914834753L,BigInteger.Parse("25231464507359877344"),BigInteger.Parse("782175399728156197665"),BigInteger.Parse("24247437391572842127616"),BigInteger.Parse("751670559138758105956097") };
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
public class A218734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218734Inst Instance=new A218734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218735
{
public static readonly long[] Value={ 5L,6L,9L,13L,22L,33L,57L,86L,149L,225L,390L,589L,1021L,1542L,2673L,4037L,6998L,10569L,18321L,27670L,47965L,72441L,125574L,189653L,328757L,496518L,860697L,1299901L,2253334L,3403185L,5899305L,8909654L,15444581L,23325777L,40434438L,61067677L,105858733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218735Inst : IEnumerable<long>
{
public static readonly long[] Value=A218735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218735.Bytes);
public long this[int i]=>Value[i];

public static A218735Inst Instance=new A218735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218736
{
public static readonly BigInteger[] Value={ 0L,1L,34L,1123L,37060L,1222981L,40358374L,1331826343L,43950269320L,1450358887561L,47861843289514L,1579440828553963L,52121547342280780L,1720011062295265741L,BigInteger.Parse("56760365055743769454"),BigInteger.Parse("1873092046839544391983") };
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
public class A218736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218736Inst Instance=new A218736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218737
{
public static readonly BigInteger[] Value={ 0L,1L,35L,1191L,40495L,1376831L,46812255L,1591616671L,54114966815L,1839908871711L,62556901638175L,2126934655697951L,72315778293730335L,2458736461986831391L,BigInteger.Parse("83597039707552267295"),BigInteger.Parse("2842299350056777088031") };
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
public class A218737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218737Inst Instance=new A218737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218738
{
public static readonly BigInteger[] Value={ 0L,1L,36L,1261L,44136L,1544761L,54066636L,1892332261L,66231629136L,2318107019761L,81133745691636L,2839681099207261L,99388838472254136L,3478609346528894761L,BigInteger.Parse("121751327128511316636"),BigInteger.Parse("4261296449497896082261") };
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
public class A218738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218738Inst Instance=new A218738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218739
{
public static readonly BigInteger[] Value={ 0L,1L,37L,1333L,47989L,1727605L,62193781L,2238976117L,80603140213L,2901713047669L,104461669716085L,3760620109779061L,135382323952046197L,4873763662273663093L,BigInteger.Parse("175455491841851871349"),BigInteger.Parse("6316397706306667368565") };
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
public class A218739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218739Inst Instance=new A218739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218740
{
public static readonly BigInteger[] Value={ 0L,1L,38L,1407L,52060L,1926221L,71270178L,2636996587L,97568873720L,3610048327641L,133571788122718L,4942156160540567L,182859777940000980L,6765811783780036261L,BigInteger.Parse("250335035999861341658"),BigInteger.Parse("9262396331994869641347") };
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
public class A218740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218740Inst Instance=new A218740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218741
{
public static readonly BigInteger[] Value={ 0L,1L,39L,1483L,56355L,2141491L,81376659L,3092313043L,117507895635L,4465300034131L,169681401296979L,6447893249285203L,245019943472837715L,9310757851967833171UL,BigInteger.Parse("353808798374777660499"),BigInteger.Parse("13444734338241551098963") };
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
public class A218741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218741Inst Instance=new A218741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218742
{
public static readonly BigInteger[] Value={ 0L,1L,40L,1561L,60880L,2374321L,92598520L,3611342281L,140842348960L,5492851609441L,214221212768200L,8354627297959801L,325830464620432240L,12707388120196857361UL,BigInteger.Parse("495588136687677437080"),BigInteger.Parse("19327937330819420046121") };
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
public class A218742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218742Inst Instance=new A218742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218743
{
public static readonly BigInteger[] Value={ 0L,1L,41L,1641L,65641L,2625641L,105025641L,4201025641L,168041025641L,6721641025641L,268865641025641L,10754625641025641L,430185025641025641L,17207401025641025641UL,BigInteger.Parse("688296041025641025641"),BigInteger.Parse("27531841641025641025641") };
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
public class A218743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218743Inst Instance=new A218743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218744
{
public static readonly BigInteger[] Value={ 0L,1L,42L,1723L,70644L,2896405L,118752606L,4868856847L,199623130728L,8184548359849L,335566482753810L,13758225792906211L,564087257509154652L,BigInteger.Parse("23127577557875340733"),BigInteger.Parse("948230679872888970054"),BigInteger.Parse("38877457874788447772215") };
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
public class A218744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218744Inst Instance=new A218744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218745
{
public static readonly BigInteger[] Value={ 0L,1L,43L,1807L,75895L,3187591L,133878823L,5622910567L,236162243815L,9918814240231L,416590198089703L,17496788319767527L,734865109430236135L,BigInteger.Parse("30864334596069917671"),BigInteger.Parse("1296302053034936542183"),BigInteger.Parse("54444686227467334771687") };
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
public class A218745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218745Inst Instance=new A218745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218746
{
public static readonly BigInteger[] Value={ 0L,1L,44L,1893L,81400L,3500201L,150508644L,6471871693L,278290482800L,11966490760401L,514559102697244L,22126041415981493L,951419780887204200L,BigInteger.Parse("40911050578149780601"),BigInteger.Parse("1759175174860440565844"),BigInteger.Parse("75644532518998944331293") };
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
public class A218746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218746Inst Instance=new A218746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218747
{
public static readonly BigInteger[] Value={ 0L,1L,45L,1981L,87165L,3835261L,168751485L,7425065341L,326702875005L,14374926500221L,632496766009725L,27829857704427901L,1224513738994827645L,BigInteger.Parse("53878604515772416381"),BigInteger.Parse("2370658598693986320765"),BigInteger.Parse("104308978342535398113661") };
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
public class A218747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218747Inst Instance=new A218747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218748
{
public static readonly BigInteger[] Value={ 0L,1L,46L,2071L,93196L,4193821L,188721946L,8492487571L,382161940696L,17197287331321L,773877929909446L,34824506845925071L,1567102808066628196L,BigInteger.Parse("70519626362998268821"),BigInteger.Parse("3173383186334922096946"),BigInteger.Parse("142802243385071494362571") };
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
public class A218748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218748Inst Instance=new A218748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218749
{
public static readonly BigInteger[] Value={ 0L,1L,47L,2163L,99499L,4576955L,210539931L,9684836827L,445502494043L,20493114725979L,942683277395035L,43363430760171611L,1994717814967894107L,BigInteger.Parse("91757019488523128923"),BigInteger.Parse("4220822896472063930459"),BigInteger.Parse("194157853237714940801115") };
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
public class A218749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218749Inst Instance=new A218749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218750
{
public static readonly BigInteger[] Value={ 0L,1L,48L,2257L,106080L,4985761L,234330768L,11013546097L,517636666560L,24328923328321L,1143459396431088L,53742591632261137L,2525901806716273440L,BigInteger.Parse("118717384915664851681"),BigInteger.Parse("5579717091036248029008"),BigInteger.Parse("262246703278703657363377") };
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
public class A218750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218750Inst Instance=new A218750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218751
{
public static readonly BigInteger[] Value={ 0L,1L,49L,2353L,112945L,5421361L,260225329L,12490815793L,599559158065L,28778839587121L,1381384300181809L,66306446408726833L,3182709427618887985L,BigInteger.Parse("152770052525706623281"),BigInteger.Parse("7332962521233917917489"),BigInteger.Parse("351982201019228060039473") };
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
public class A218751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218751Inst Instance=new A218751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218752
{
public static readonly BigInteger[] Value={ 0L,1L,51L,2551L,127551L,6377551L,318877551L,15943877551L,797193877551L,39859693877551L,1992984693877551L,99649234693877551L,4982461734693877551L,BigInteger.Parse("249123086734693877551"),BigInteger.Parse("12456154336734693877551"),BigInteger.Parse("622807716836734693877551") };
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
public class A218752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218752Inst Instance=new A218752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218753
{
public static readonly BigInteger[] Value={ 0L,1L,50L,2451L,120100L,5884901L,288360150L,14129647351L,692352720200L,33925283289801L,1662338881200250L,81454605178812251L,3991275653761800300L,BigInteger.Parse("195572507034328214701"),BigInteger.Parse("9583052844682082520350"),BigInteger.Parse("469569589389422043497151") };
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
public class A218753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218753Inst Instance=new A218753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218754
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,2L,2L,1L,3L,1L,3L,1L,1L,2L,1L,0L,3L,3L,2L,3L,3L,0L,3L,0L,3L,2L,1L,1L,4L,1L,2L,2L,1L,2L,0L,2L,2L,2L,3L,0L,4L,1L,1L,2L,0L,1L,2L,3L,5L,0L,2L,1L,3L,4L,1L,1L,2L,2L,6L,2L,2L,4L,1L,2L,3L,2L,3L,3L,3L,2L,4L,1L,2L,5L,0L,3L,4L,2L,3L,4L,3L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218754Inst : IEnumerable<long>
{
public static readonly long[] Value=A218754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218754.Bytes);
public long this[int i]=>Value[i];

public static A218754Inst Instance=new A218754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218755
{
public static readonly long[] Value={ 6L,42L,330L,510L,690L,798L,870L,1410L,1518L,1590L,1770L,1806L,2490L,3102L,3210L,3318L,3894L,4110L,4326L,4470L,4686L,5010L,5190L,5370L,5478L,6486L,6810L,7062L,7890L,8070L,8142L,8646L,8790L,9366L,9510L,10410L,10770L,11022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218755Inst : IEnumerable<long>
{
public static readonly long[] Value=A218755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218755.Bytes);
public long this[int i]=>Value[i];

public static A218755Inst Instance=new A218755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218756
{
public static readonly long[] Value={ 1L,1L,2L,2L,7L,2L,20L,5L,20L,7L,166L,5L,367L,20L,39L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218756Inst : IEnumerable<long>
{
public static readonly long[] Value=A218756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218756.Bytes);
public long this[int i]=>Value[i];

public static A218756Inst Instance=new A218756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218757
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,2L,3L,0L,0L,0L,5L,9L,2L,0L,0L,0L,16L,32L,13L,0L,0L,0L,0L,61L,132L,72L,6L,0L,0L,0L,0L,271L,623L,409L,69L,0L,0L,0L,0L,0L,1372L,3314L,2480L,605L,24L,0L,0L,0L,0L,0L,7795L,19628L,16222L,5016L,432L,0L,0L,0L,0L,0L,0L,49093L,128126L,114594L,41955L,5498L,120L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218757Inst : IEnumerable<long>
{
public static readonly long[] Value=A218757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218757.Bytes);
public long this[int i]=>Value[i];

public static A218757Inst Instance=new A218757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218758
{
public static readonly long[] Value={ 1L,6L,90L,2942L,280850L,70915451L,48186998294L,87678602579068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218758Inst : IEnumerable<long>
{
public static readonly long[] Value=A218758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218758.Bytes);
public long this[int i]=>Value[i];

public static A218758Inst Instance=new A218758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218759
{
public static readonly long[] Value={ 2L,6L,18L,47L,134L,373L,1035L,2889L,8050L,22420L,62477L,174072L,484983L,1351277L,3764915L,10489750L,29226504L,81430659L,226881448L,632135485L,1761251171L,4907184849L,13672362150L,38093833868L,106136756981L,295717444696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218759Inst : IEnumerable<long>
{
public static readonly long[] Value=A218759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218759.Bytes);
public long this[int i]=>Value[i];

public static A218759Inst Instance=new A218759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218760
{
public static readonly long[] Value={ 4L,18L,90L,403L,1876L,8697L,40383L,187413L,869598L,4035492L,18727387L,86907272L,403304737L,1871588753L,8685363409L,40305616278L,187043701224L,868001747571L,4028080274884L,18692855005565L,86746738864403L,402560052640421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218760Inst : IEnumerable<long>
{
public static readonly long[] Value=A218760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218760.Bytes);
public long this[int i]=>Value[i];

public static A218760Inst Instance=new A218760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218761
{
public static readonly long[] Value={ 7L,47L,403L,2942L,22439L,170148L,1291662L,9807350L,74441043L,565067801L,4289417212L,32560993753L,247169557952L,1876254744847L,14242588588406L,108115048685864L,820697944019795L,6229892072413748L,47290913215565827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218761Inst : IEnumerable<long>
{
public static readonly long[] Value=A218761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218761.Bytes);
public long this[int i]=>Value[i];

public static A218761Inst Instance=new A218761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218762
{
public static readonly long[] Value={ 12L,134L,1876L,22439L,280850L,3488015L,43403573L,540089167L,6717643958L,83563261332L,1039486332867L,12930764176074L,160851990999547L,2000913433617465L,24890325913205903L,309622796717628738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218762Inst : IEnumerable<long>
{
public static readonly long[] Value=A218762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218762.Bytes);
public long this[int i]=>Value[i];

public static A218762Inst Instance=new A218762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218763
{
public static readonly BigInteger[] Value={ 21L,373L,8697L,170148L,3488015L,70915451L,1444700004L,29426750811L,599056249102L,12196183065261L,248303130737344L,5055219016095223L,102918285280874701L,2095289674633493599L,BigInteger.Parse("42657543159685926011"),BigInteger.Parse("868455498699347842027") };
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
public class A218763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218763Inst Instance=new A218763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218764
{
public static readonly long[] Value={ 37L,1035L,40383L,1291662L,43403573L,1444700004L,48186998294L,1606766223984L,53537060426191L,1783895392003265L,59439520136317957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218764Inst : IEnumerable<long>
{
public static readonly long[] Value=A218764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218764.Bytes);
public long this[int i]=>Value[i];

public static A218764Inst Instance=new A218764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218765
{
public static readonly long[] Value={ 1L,2L,2L,4L,6L,4L,7L,18L,18L,7L,12L,47L,90L,47L,12L,21L,134L,403L,403L,134L,21L,37L,373L,1876L,2942L,1876L,373L,37L,65L,1035L,8697L,22439L,22439L,8697L,1035L,65L,114L,2889L,40383L,170148L,280850L,170148L,40383L,2889L,114L,200L,8050L,187413L,1291662L,3488015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218765Inst : IEnumerable<long>
{
public static readonly long[] Value=A218765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218765.Bytes);
public long this[int i]=>Value[i];

public static A218765Inst Instance=new A218765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218766
{
public static readonly long[] Value={ 289L,841L,3721L,4913L,9409L,11881L,12769L,22201L,24389L,32761L,37249L,52441L,54289L,66049L,72361L,83521L,97969L,113569L,151321L,187489L,212521L,226981L,259081L,292681L,332929L,351649L,491401L,502681L,674041L,707281L,734449L,877969L,885481L,908209L,912673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218766Inst : IEnumerable<long>
{
public static readonly long[] Value=A218766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218766.Bytes);
public long this[int i]=>Value[i];

public static A218766Inst Instance=new A218766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218767
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,5L,6L,5L,7L,5L,8L,6L,7L,7L,7L,7L,10L,5L,9L,7L,9L,7L,10L,8L,7L,9L,11L,5L,11L,7L,12L,9L,7L,9L,11L,7L,11L,9L,12L,6L,13L,7L,9L,13L,9L,7L,13L,9L,12L,7L,13L,9L,11L,9L,11L,9L,11L,9L,18L,6L,9L,13L,9L,9L,13L,11L,13L,7L,13L,7L,18L,9L,9L,11L,11L,13L,13L,5L,15L,11L,11L,9L,16L,12L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218767Inst : IEnumerable<long>
{
public static readonly long[] Value=A218767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218767.Bytes);
public long this[int i]=>Value[i];

public static A218767Inst Instance=new A218767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218768
{
public static readonly BigInteger[] Value={ 1L,2L,21L,555L,27930L,2297295L,280737765L,47773195470L,10803712844925L,3134455177028175L,1135027918156081950L,BigInteger.Parse("501797959522466381775"),BigInteger.Parse("265999339071854103540825"),BigInteger.Parse("166538120746634232882536250"),BigInteger.Parse("121585839578169857291258983125"),BigInteger.Parse("102384090433785464586295830691875") };
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
public class A218768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218768Inst Instance=new A218768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218769
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,0L,2L,2L,2L,2L,3L,2L,5L,5L,4L,5L,4L,4L,3L,2L,2L,4L,4L,2L,2L,2L,6L,3L,3L,4L,3L,2L,3L,2L,2L,7L,3L,3L,2L,2L,2L,6L,0L,3L,2L,2L,5L,5L,23L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218769Inst : IEnumerable<long>
{
public static readonly long[] Value=A218769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218769.Bytes);
public long this[int i]=>Value[i];

public static A218769Inst Instance=new A218769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218770
{
public static readonly long[] Value={ 1023456789L,511728399L,341152263L,255864474L,204693579L,170576133L,146208114L,127932237L,113717421L,123456789L,93125079L,85288158L,78727446L,73104057L,68231193L,63966123L,60203394L,56858711L,53866251L,61728399L,48736038L,46562544L,44498943L,42644079L,40938759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218770Inst : IEnumerable<long>
{
public static readonly long[] Value=A218770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218770.Bytes);
public long this[int i]=>Value[i];

public static A218770Inst Instance=new A218770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218771
{
public static readonly long[] Value={ 31L,59L,79L,179L,191L,229L,251L,311L,389L,401L,479L,491L,541L,569L,719L,809L,971L,1019L,1061L,1109L,1151L,1249L,1301L,1409L,1451L,1499L,1619L,1931L,1949L,2111L,2141L,2339L,2591L,2609L,2711L,2801L,2939L,3089L,3371L,3389L,3449L,3881L,4021L,4091L,4211L,4391L,4451L,4679L,5039L,5051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218771Inst : IEnumerable<long>
{
public static readonly long[] Value=A218771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218771.Bytes);
public long this[int i]=>Value[i];

public static A218771Inst Instance=new A218771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218772
{
public static readonly long[] Value={ 2L,4L,7L,10L,12L,15L,16L,21L,24L,25L,29L,32L,34L,35L,36L,38L,41L,42L,46L,49L,51L,52L,53L,54L,57L,64L,65L,68L,71L,72L,76L,79L,81L,82L,83L,84L,87L,94L,95L,97L,100L,107L,108L,109L,113L,114L,115L,116L,117L,120L,122L,125L,126L,130L,133L,135L,136L,137L,138L,141L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218772Inst : IEnumerable<long>
{
public static readonly long[] Value=A218772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218772.Bytes);
public long this[int i]=>Value[i];

public static A218772Inst Instance=new A218772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218773
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,8L,9L,11L,13L,14L,17L,18L,19L,20L,22L,23L,26L,27L,28L,30L,31L,33L,37L,39L,40L,43L,44L,45L,47L,48L,50L,55L,56L,58L,59L,60L,61L,62L,63L,66L,67L,69L,70L,73L,74L,75L,77L,78L,80L,85L,86L,88L,89L,90L,91L,92L,93L,96L,98L,99L,101L,102L,103L,104L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218773Inst : IEnumerable<long>
{
public static readonly long[] Value=A218773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218773.Bytes);
public long this[int i]=>Value[i];

public static A218773Inst Instance=new A218773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218774
{
public static readonly long[] Value={ 2L,3L,3L,2L,3L,1L,5L,3L,1L,4L,3L,2L,1L,1L,2L,3L,1L,4L,3L,2L,1L,1L,1L,3L,7L,1L,3L,3L,1L,4L,3L,2L,1L,1L,1L,3L,7L,1L,2L,3L,7L,1L,1L,4L,1L,1L,1L,1L,3L,2L,3L,1L,4L,3L,2L,1L,1L,1L,3L,7L,1L,2L,3L,7L,1L,1L,4L,1L,1L,1L,1L,3L,1L,3L,7L,1L,1L,4L,1L,1L,1L,1L,2L,5L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218774Inst : IEnumerable<long>
{
public static readonly long[] Value=A218774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218774.Bytes);
public long this[int i]=>Value[i];

public static A218774Inst Instance=new A218774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218775
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,1L,2L,2L,1L,3L,1L,1L,1L,2L,1L,3L,1L,1L,2L,1L,2L,4L,2L,1L,3L,1L,1L,2L,1L,2L,5L,1L,2L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,2L,1L,2L,5L,1L,2L,1L,1L,1L,1L,1L,3L,2L,1L,2L,1L,1L,1L,1L,1L,4L,1L,1L,6L,1L,2L,2L,1L,3L,1L,1L,2L,1L,2L,5L,1L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218775Inst : IEnumerable<long>
{
public static readonly long[] Value=A218775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218775.Bytes);
public long this[int i]=>Value[i];

public static A218775Inst Instance=new A218775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218776
{
public static readonly long[] Value={ 2L,12L,50L,204L,818L,3298L,13202L,52834L,211346L,845586L,3382418L,13531282L,54125714L,216503058L,866012306L,3464049426L,13856197778L,55424792722L,221699171474L,886796698770L,3547186799762L,14188747200658L,56754988803218L,227019955225746L,908079820907666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218776Inst : IEnumerable<long>
{
public static readonly long[] Value=A218776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218776.Bytes);
public long this[int i]=>Value[i];

public static A218776Inst Instance=new A218776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218777
{
public static readonly long[] Value={ 1L,3L,6L,15L,39L,117L,359L,1149L,3780L,12752L,43740L,152346L,536655L,1909411L,6852153L,24772328L,90137210L,329838392L,1213048022L,4481262944L,16621500330L,61875433940L,231099456721L,865736972546L,3252139562356L,12247622197965L,46232602224402L,174897265479074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218777Inst : IEnumerable<long>
{
public static readonly long[] Value=A218777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218777.Bytes);
public long this[int i]=>Value[i];

public static A218777Inst Instance=new A218777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218778
{
public static readonly long[] Value={ 2L,10L,50L,210L,914L,3666L,14738L,59026L,236690L,946834L,3787922L,15151762L,60607634L,242437266L,969821330L,3879357586L,15518026898L,62072179858L,248289315986L,993157336210L,3972629941394L,15890526653586L,63562180611218L,254248729332882L,1016994991328402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218778Inst : IEnumerable<long>
{
public static readonly long[] Value=A218778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218778.Bytes);
public long this[int i]=>Value[i];

public static A218778Inst Instance=new A218778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218779
{
public static readonly long[] Value={ 1L,2L,6L,16L,53L,156L,491L,1584L,5286L,17855L,61405L,214012L,754731L,2688307L,9659023L,34947356L,127260566L,465920651L,1714294995L,6335423798L,23506865260L,87534068725L,327024845325L,1225395355165L,4604242172697L,17343284212635L,65480496260109L,247755060623522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218779Inst : IEnumerable<long>
{
public static readonly long[] Value=A218779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218779.Bytes);
public long this[int i]=>Value[i];

public static A218779Inst Instance=new A218779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218780
{
public static readonly long[] Value={ 2L,10L,44L,180L,728L,2928L,11720L,46888L,187568L,750304L,3001232L,12004960L,48019856L,192079504L,768318048L,3073272224L,12293088960L,49172355968L,196689423936L,786757695872L,3147030783552L,12588123134528L,50352492538240L,201409970153216L,805639880612992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218780Inst : IEnumerable<long>
{
public static readonly long[] Value=A218780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218780.Bytes);
public long this[int i]=>Value[i];

public static A218780Inst Instance=new A218780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218781
{
public static readonly long[] Value={ 1L,2L,5L,12L,32L,92L,278L,877L,2861L,9572L,32656L,113164L,397190L,1409006L,5043617L,18194197L,66075777L,241385044L,886422017L,3270283189L,12115355601L,45052126049L,168100964161L,629171367473L,2361546968519L,8886942571534L,33523357596518L,126736969302857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218781Inst : IEnumerable<long>
{
public static readonly long[] Value=A218781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218781.Bytes);
public long this[int i]=>Value[i];

public static A218781Inst Instance=new A218781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218782
{
public static readonly long[] Value={ 2L,12L,52L,216L,872L,3496L,14024L,56200L,224904L,899720L,3599496L,14398600L,57599112L,230398088L,921606280L,3686471816L,14745933960L,58983782536L,235935438984L,943742064776L,3774970665096L,15099883493512L,60399541098632L,241598171519112L,966392760309896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218782Inst : IEnumerable<long>
{
public static readonly long[] Value=A218782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218782.Bytes);
public long this[int i]=>Value[i];

public static A218782Inst Instance=new A218782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218783
{
public static readonly long[] Value={ 1L,3L,7L,18L,49L,142L,438L,1405L,4630L,15595L,53493L,186112L,655421L,2331057L,8362451L,30222369L,109930284L,402134685L,1478480102L,5460253675L,20247271086L,75353895375L,281374686795L,1053846512655L,3957966801068L,14902939174394L,56245902561309L,212741751056939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218783Inst : IEnumerable<long>
{
public static readonly long[] Value=A218783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218783.Bytes);
public long this[int i]=>Value[i];

public static A218783Inst Instance=new A218783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218784
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,9L,11L,12L,13L,14L,16L,18L,22L,23L,25L,27L,30L,31L,33L,34L,35L,38L,39L,40L,42L,44L,47L,48L,50L,51L,52L,56L,58L,59L,65L,67L,69L,70L,72L,74L,77L,78L,80L,81L,82L,86L,88L,89L,95L,97L,98L,99L,101L,102L,108L,111L,114L,119L,121L,122L,123L,124L,126L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218784Inst : IEnumerable<long>
{
public static readonly long[] Value=A218784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218784.Bytes);
public long this[int i]=>Value[i];

public static A218784Inst Instance=new A218784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218785
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,8L,9L,12L,17L,18L,19L,20L,23L,28L,29L,36L,37L,38L,41L,42L,43L,46L,51L,52L,59L,60L,61L,64L,71L,72L,73L,78L,79L,84L,87L,88L,89L,90L,93L,98L,99L,106L,107L,108L,111L,118L,119L,120L,125L,126L,131L,134L,135L,142L,143L,144L,149L,150L,161L,162L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218785Inst : IEnumerable<long>
{
public static readonly long[] Value=A218785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218785.Bytes);
public long this[int i]=>Value[i];

public static A218785Inst Instance=new A218785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218786
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,0L,1L,2L,0L,3L,0L,0L,1L,3L,0L,0L,2L,0L,2L,1L,0L,0L,0L,1L,2L,0L,3L,0L,0L,1L,3L,0L,0L,2L,0L,2L,1L,0L,3L,0L,0L,2L,0L,5L,0L,0L,6L,0L,2L,0L,1L,0L,0L,1L,2L,0L,3L,0L,0L,1L,3L,0L,0L,2L,0L,2L,1L,0L,3L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218786Inst : IEnumerable<long>
{
public static readonly long[] Value=A218786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218786.Bytes);
public long this[int i]=>Value[i];

public static A218786Inst Instance=new A218786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218787
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,0L,0L,1L,2L,0L,8L,0L,0L,1L,0L,0L,1L,2L,0L,8L,0L,0L,1L,8L,0L,0L,3L,0L,2L,1L,0L,0L,0L,1L,2L,0L,8L,0L,0L,1L,8L,0L,0L,3L,0L,2L,1L,0L,8L,0L,0L,3L,0L,60L,0L,0L,172L,0L,2L,0L,1L,0L,0L,1L,2L,0L,8L,0L,0L,1L,8L,0L,0L,3L,0L,2L,1L,0L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218787Inst : IEnumerable<long>
{
public static readonly long[] Value=A218787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218787.Bytes);
public long this[int i]=>Value[i];

public static A218787Inst Instance=new A218787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218788
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,3L,0L,0L,0L,1L,3L,0L,4L,0L,0L,1L,0L,0L,1L,3L,0L,4L,0L,0L,1L,4L,0L,0L,2L,0L,3L,1L,0L,0L,0L,1L,3L,0L,4L,0L,0L,1L,4L,0L,0L,2L,0L,3L,1L,0L,4L,0L,0L,2L,0L,37L,0L,0L,110L,0L,3L,0L,1L,0L,0L,1L,3L,0L,4L,0L,0L,1L,4L,0L,0L,2L,0L,3L,1L,0L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218788Inst : IEnumerable<long>
{
public static readonly long[] Value=A218788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218788.Bytes);
public long this[int i]=>Value[i];

public static A218788Inst Instance=new A218788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218789
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,3L,4L,3L,6L,11L,10L,11L,10L,13L,18L,17L,10L,11L,12L,15L,16L,15L,18L,23L,22L,15L,16L,17L,20L,13L,14L,15L,10L,11L,6L,3L,2L,3L,2L,5L,10L,9L,2L,3L,4L,7L,0L,1L,2L,-3L,-2L,-7L,-10L,-11L,-18L,-17L,-16L,-21L,-20L,-9L,-8L,-7L,6L,7L,2L,1L,4L,5L,4L,7L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218789Inst : IEnumerable<long>
{
public static readonly long[] Value=A218789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218789.Bytes);
public long this[int i]=>Value[i];

public static A218789Inst Instance=new A218789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218790
{
public static readonly long[] Value={ 1L,3L,5L,13L,21L,37L,53L,117L,181L,309L,437L,693L,949L,1717L,1461L,3509L,5557L,9653L,13749L,21941L,30133L,54709L,46517L,79285L,112053L,210357L,177589L,472501L,308661L,734645L,996789L,2045365L,3093941L,5191093L,7288245L,11482549L,15676853L,28259765L,24065461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218790Inst : IEnumerable<long>
{
public static readonly long[] Value=A218790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218790.Bytes);
public long this[int i]=>Value[i];

public static A218790Inst Instance=new A218790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218791
{
public static readonly long[] Value={ 1L,2L,6L,10L,26L,58L,42L,74L,202L,458L,330L,842L,586L,1354L,1610L,2634L,6730L,14922L,10826L,27210L,19018L,43594L,51786L,117322L,84554L,182858L,215626L,313930L,477770L,838218L,576074L,1100362L,3197514L,7391818L,5294666L,13683274L,9488970L,22071882L,26266186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218791Inst : IEnumerable<long>
{
public static readonly long[] Value=A218791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218791.Bytes);
public long this[int i]=>Value[i];

public static A218791Inst Instance=new A218791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218792
{
public static readonly long[] Value={ 1L,2L,7L,1L,3L,4L,1L,5L,2L,2L,1L,8L,9L,0L,1L,5L,2L,2L,5L,2L,2L,2L,3L,8L,2L,5L,7L,8L,7L,9L,0L,9L,3L,5L,6L,2L,4L,9L,7L,6L,8L,6L,4L,9L,8L,7L,7L,1L,7L,6L,2L,6L,7L,0L,1L,1L,6L,4L,4L,1L,0L,8L,0L,1L,6L,9L,7L,4L,7L,7L,5L,8L,5L,6L,6L,5L,5L,3L,0L,7L,5L,0L,6L,2L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218792Inst : IEnumerable<long>
{
public static readonly long[] Value=A218792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218792.Bytes);
public long this[int i]=>Value[i];

public static A218792Inst Instance=new A218792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218793
{
public static readonly long[] Value={ 20L,31L,45L,59L,79L,95L,121L,125L,179L,191L,229L,245L,251L,295L,311L,389L,395L,401L,451L,479L,491L,541L,569L,605L,671L,695L,719L,745L,809L,845L,899L,971L,1019L,1061L,1109L,1111L,1121L,1151L,1249L,1271L,1301L,1409L,1445L,1451L,1499L,1595L,1619L,1661L,1711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218793Inst : IEnumerable<long>
{
public static readonly long[] Value=A218793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218793.Bytes);
public long this[int i]=>Value[i];

public static A218793Inst Instance=new A218793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218794
{
public static readonly long[] Value={ 31L,59L,79L,95L,121L,179L,191L,229L,251L,295L,311L,389L,395L,401L,451L,479L,491L,541L,569L,671L,695L,719L,745L,809L,899L,971L,1019L,1061L,1109L,1111L,1121L,1151L,1249L,1271L,1301L,1409L,1451L,1499L,1595L,1619L,1661L,1711L,1919L,1931L,1949L,1991L,2059L,2105L,2111L,2141L,2195L,2201L,2245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218794Inst : IEnumerable<long>
{
public static readonly long[] Value=A218794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218794.Bytes);
public long this[int i]=>Value[i];

public static A218794Inst Instance=new A218794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218795
{
public static readonly long[] Value={ 671L,1595L,3629L,3839L,4661L,4895L,5771L,8459L,11495L,13079L,17951L,19829L,21251L,22895L,23411L,34751L,40211L,40799L,43829L,45791L,46031L,47795L,49001L,53009L,57209L,57959L,60119L,60491L,64829L,67595L,70661L,78755L,83201L,89249L,98879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218795Inst : IEnumerable<long>
{
public static readonly long[] Value=A218795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218795.Bytes);
public long this[int i]=>Value[i];

public static A218795Inst Instance=new A218795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218796
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,6L,2L,11L,5L,21L,10L,1L,39L,22L,3L,73L,46L,9L,136L,97L,22L,1L,254L,200L,54L,4L,474L,410L,126L,14L,885L,832L,290L,40L,1L,1652L,1679L,651L,109L,5L,3084L,3368L,1440L,280L,20L,5757L,6725L,3138L,698L,65L,1L,10747L,13370L,6762L,1688L,195L,6L,20062L,26483L,14424L,3994L,546L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218796Inst : IEnumerable<long>
{
public static readonly long[] Value=A218796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218796.Bytes);
public long this[int i]=>Value[i];

public static A218796Inst Instance=new A218796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218797
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,1L,2L,0L,1L,2L,2L,1L,3L,2L,3L,1L,2L,1L,1L,2L,2L,2L,1L,2L,1L,2L,4L,1L,3L,2L,2L,2L,2L,2L,2L,4L,3L,3L,3L,2L,4L,4L,3L,0L,2L,1L,1L,1L,1L,2L,2L,3L,2L,4L,4L,3L,3L,2L,3L,4L,2L,2L,3L,2L,1L,3L,3L,1L,2L,2L,5L,1L,4L,2L,2L,1L,1L,6L,3L,1L,5L,1L,1L,5L,4L,1L,4L,1L,2L,6L,2L,4L,2L,2L,2L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218797Inst : IEnumerable<long>
{
public static readonly long[] Value=A218797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218797.Bytes);
public long this[int i]=>Value[i];

public static A218797Inst Instance=new A218797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218798
{
public static readonly BigInteger[] Value={ 1L,1L,2L,15L,224L,5665L,215136L,11466903L,815542272L,74626924833L,8539305740800L,1194616544819423L,200588161750990848L,BigInteger.Parse("39810821495648979009"),BigInteger.Parse("9219256372209251966976"),BigInteger.Parse("2463653490073311266825895"),BigInteger.Parse("752468103154551980520636416"),BigInteger.Parse("260483894045203867466646001345") };
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
public class A218798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218798Inst Instance=new A218798Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218799
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,3L,1L,2L,2L,1L,1L,2L,1L,2L,3L,2L,1L,2L,2L,1L,2L,1L,1L,4L,1L,1L,2L,1L,1L,5L,2L,1L,3L,1L,2L,2L,1L,2L,2L,2L,2L,3L,1L,1L,2L,1L,1L,5L,1L,1L,4L,2L,1L,5L,1L,2L,2L,1L,1L,3L,1L,1L,5L,2L,2L,2L,1L,1L,3L,2L,1L,2L,2L,2L,2L,1L,1L,5L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218799Inst : IEnumerable<long>
{
public static readonly long[] Value=A218799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218799.Bytes);
public long this[int i]=>Value[i];

public static A218799Inst Instance=new A218799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218800
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,3L,2L,2L,4L,2L,5L,3L,2L,2L,3L,2L,5L,4L,5L,2L,3L,5L,2L,3L,2L,2L,5L,2L,2L,3L,2L,2L,8L,5L,2L,4L,2L,5L,3L,2L,5L,3L,5L,5L,4L,2L,2L,3L,2L,2L,8L,2L,2L,5L,5L,2L,8L,2L,5L,3L,2L,2L,4L,2L,2L,8L,5L,5L,3L,2L,2L,4L,5L,2L,3L,5L,5L,3L,2L,2L,6L,5L,5L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218800Inst : IEnumerable<long>
{
public static readonly long[] Value=A218800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218800.Bytes);
public long this[int i]=>Value[i];

public static A218800Inst Instance=new A218800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218801
{
public static readonly BigInteger[] Value={ 1L,1L,5L,60L,1539L,82539L,9208086L,2123763546L,1005501106845L,971130952310487L,1903911554135421599L,BigInteger.Parse("7548458861108146087406"),BigInteger.Parse("60351476147380872012216644"),BigInteger.Parse("971005203586845989294297793744"),BigInteger.Parse("31389082794561063490845804374258994"),BigInteger.Parse("2036350822333032259401319084453988921002") };
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
public class A218801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218801Inst Instance=new A218801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218802
{
public static readonly long[] Value={ 3L,5L,6L,2L,3L,8L,2L,2L,8L,5L,3L,9L,0L,8L,9L,7L,6L,9L,1L,4L,1L,5L,6L,4L,4L,3L,4L,2L,7L,4L,7L,6L,1L,0L,3L,1L,1L,7L,8L,1L,1L,0L,6L,4L,7L,5L,0L,9L,7L,2L,1L,6L,1L,9L,4L,3L,3L,7L,9L,2L,0L,3L,1L,1L,7L,0L,0L,5L,4L,1L,6L,7L,6L,5L,0L,8L,5L,5L,6L,5L,6L,0L,2L,6L,5L,4L,7L,6L,3L,8L,8L,6L,4L,5L,0L,9L,2L,4L,0L,2L,3L,6L,0L,2L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218802Inst : IEnumerable<long>
{
public static readonly long[] Value=A218802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218802.Bytes);
public long this[int i]=>Value[i];

public static A218802Inst Instance=new A218802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218803
{
public static readonly BigInteger[] Value={ 1L,15L,481L,63499L,32496361L,66531801953L,544920898689805L,17853080088569676529UL,BigInteger.Parse("2339690141788794554403313"),BigInteger.Parse("1226489723856405899902679483839") };
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
public class A218803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218803Inst Instance=new A218803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218804
{
public static readonly long[] Value={ 3L,15L,57L,225L,895L,3551L,14089L,55905L,221827L,880191L,3492529L,13858081L,54987775L,218187167L,865749521L,3435226017L,13630706691L,54085572239L,214607297385L,851544879425L,3378863116543L,13407063134527L,53198172193817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218804Inst : IEnumerable<long>
{
public static readonly long[] Value=A218804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218804.Bytes);
public long this[int i]=>Value[i];

public static A218804Inst Instance=new A218804Inst();

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