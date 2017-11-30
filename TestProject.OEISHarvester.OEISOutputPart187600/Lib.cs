using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A218057
{
public static readonly BigInteger[] Value={ 2L,5L,41L,593L,4513L,155593L,1166225L,72873665L,543046721L,53486784401L,397441609945L,56635031066257L,420155471749553L,81721424164605401L,605653678328814113L,BigInteger.Parse("154142360945389303553"),BigInteger.Parse("1141616971745015134465"),BigInteger.Parse("368180757129736563169825"),BigInteger.Parse("2725567350297911241532841") };
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
public class A218057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218057Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218057.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218057Inst Instance=new A218057Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218058
{
public static readonly BigInteger[] Value={ 2L,6L,74L,1664L,99934L,14096488L,4803404048L,3998208473098L,7963043911683306L,BigInteger.Parse("38560364205334572480"),BigInteger.Parse("449439593711854068531514"),BigInteger.Parse("12671283745052415612872263552"),BigInteger.Parse("862325227959961803770298778601380") };
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
public class A218058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218058Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218058.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218058Inst Instance=new A218058Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218059
{
public static readonly long[] Value={ 4L,18L,74L,308L,1282L,5338L,22228L,92562L,385450L,1605108L,6684066L,27834106L,115908116L,482670130L,2009958090L,8369963828L,34854604610L,145143215386L,604412335444L,2516922821842L,10481090672106L,43645860224116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218059Inst : IEnumerable<long>
{
public static readonly long[] Value=A218059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218059.Bytes);
public long this[int i]=>Value[i];

public static A218059Inst Instance=new A218059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218060
{
public static readonly long[] Value={ 6L,42L,260L,1664L,10566L,66978L,424332L,2687866L,17025060L,107835994L,683025864L,4326234664L,27402037744L,173562384900L,1099330676692L,6963075143418L,44103577188722L,279348632561274L,1769372542444278L,11207068261293544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218060Inst : IEnumerable<long>
{
public static readonly long[] Value=A218060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218060.Bytes);
public long this[int i]=>Value[i];

public static A218060Inst Instance=new A218060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218061
{
public static readonly long[] Value={ 10L,108L,1046L,10246L,99934L,975296L,9519284L,92918894L,907013406L,8853740672L,86425318934L,843636853718L,8235125319032L,80386833101166L,784692748485262L,7659745900162448L,74770293910981462L,729867143111233166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218061Inst : IEnumerable<long>
{
public static readonly long[] Value=A218061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218061.Bytes);
public long this[int i]=>Value[i];

public static A218061Inst Instance=new A218061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218062
{
public static readonly ulong[] Value={ 16L,268L,3974L,60804L,925904L,14096488L,214514380L,3263893360L,49658510202L,755518606946L,11494629017172L,174881679122376L,2660685599023984L,40480211800235302L,615874165289837908L,9370034622516193552UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218062Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218062.Bytes);
public ulong this[int i]=>Value[i];

public static A218062Inst Instance=new A218062Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218063
{
public static readonly BigInteger[] Value={ 26L,676L,15578L,368220L,8679594L,204211050L,4803404048L,112984025006L,2657601417086L,62512388662498L,1470427119098160L,34587669928567490L,813578051651191626L,BigInteger.Parse("19137146231249558584"),BigInteger.Parse("450147804547520272046") };
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
public class A218063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218063Inst Instance=new A218063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218064
{
public static readonly long[] Value={ 2L,2L,4L,4L,6L,8L,6L,18L,16L,16L,10L,42L,74L,42L,32L,16L,108L,260L,308L,110L,64L,26L,268L,1046L,1664L,1282L,288L,128L,42L,676L,3974L,10246L,10566L,5338L,754L,256L,68L,1694L,15578L,60804L,99934L,66978L,22228L,1974L,512L,110L,4258L,60242L,368220L,925904L,975296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218064Inst : IEnumerable<long>
{
public static readonly long[] Value=A218064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218064.Bytes);
public long this[int i]=>Value[i];

public static A218064Inst Instance=new A218064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218065
{
public static readonly long[] Value={ 4L,6L,18L,42L,108L,268L,676L,1694L,4258L,10690L,26852L,67436L,169372L,425382L,1068370L,2683258L,6739132L,16925644L,42509556L,106764750L,268144706L,673458066L,1691421684L,4248085292L,10669266476L,26796365718L,67300335730L,169027965834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218065Inst : IEnumerable<long>
{
public static readonly long[] Value=A218065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218065.Bytes);
public long this[int i]=>Value[i];

public static A218065Inst Instance=new A218065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218066
{
public static readonly long[] Value={ 8L,16L,74L,260L,1046L,3974L,15578L,60242L,234468L,910060L,3536762L,13737348L,53371468L,207332364L,805465810L,3129084596L,12156035112L,47224200410L,183458638422L,712707497212L,2768755861210L,10756176540402L,41786039888224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218066Inst : IEnumerable<long>
{
public static readonly long[] Value=A218066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218066.Bytes);
public long this[int i]=>Value[i];

public static A218066Inst Instance=new A218066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218067
{
public static readonly long[] Value={ 16L,42L,308L,1664L,10246L,60804L,368220L,2217012L,13380802L,80716652L,487004728L,2938281242L,17727888682L,106960361186L,645338542928L,3893618011484L,23491925716860L,141737303076720L,855164357481732L,5159588643396442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218067Inst : IEnumerable<long>
{
public static readonly long[] Value=A218067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218067.Bytes);
public long this[int i]=>Value[i];

public static A218067Inst Instance=new A218067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218068
{
public static readonly long[] Value={ 32L,110L,1282L,10566L,99934L,925904L,8679594L,81335528L,762520474L,7151998338L,67068725044L,629057470766L,5899646647922L,55332856437260L,518956048374100L,4867244207768978L,45649230875835138L,428139074698478122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218068Inst : IEnumerable<long>
{
public static readonly long[] Value=A218068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218068.Bytes);
public long this[int i]=>Value[i];

public static A218068Inst Instance=new A218068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218069
{
public static readonly long[] Value={ 64L,288L,5338L,66978L,975296L,14096488L,204211050L,2978543964L,43337429212L,631708431924L,9201998558182L,134096314110712L,1953815660270370L,28469970831713488L,414834864922566790L,6044649160655242312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218069Inst : IEnumerable<long>
{
public static readonly long[] Value=A218069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218069.Bytes);
public long this[int i]=>Value[i];

public static A218069Inst Instance=new A218069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218070
{
public static readonly BigInteger[] Value={ 128L,754L,22228L,424332L,9519284L,214514380L,4803404048L,109134107828L,2464428175794L,55852094761914L,1264209426949652L,28632655998634008L,648354729148697522L,14682760579143673998UL,BigInteger.Parse("332496265279252340092") };
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
public class A218070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218070Inst Instance=new A218070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218071
{
public static readonly long[] Value={ 170L,241L,256L,262L,280L,358L,408L,590L,592L,616L,646L,698L,700L,724L,728L,766L,784L,844L,897L,926L,930L,968L,970L,990L,1026L,1036L,1078L,1098L,1102L,1210L,1222L,1236L,1238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218071Inst : IEnumerable<long>
{
public static readonly long[] Value=A218071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218071.Bytes);
public long this[int i]=>Value[i];

public static A218071Inst Instance=new A218071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218072
{
public static readonly long[] Value={ 1L,4L,9L,6L,10L,18L,36L,24L,8L,1L,2L,16L,54L,54L,20L,60L,144L,24L,18L,4L,16L,128L,90L,210L,60L,252L,126L,224L,32L,9L,54L,8L,72L,30L,20L,108L,162L,64L,10L,6L,48L,168L,288L,162L,20L,12L,36L,24L,8L,10L,12L,56L,144L,108L,30L,54L,216L,216L,96L,18L,42L,384L,1458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218072Inst : IEnumerable<long>
{
public static readonly long[] Value=A218072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218072.Bytes);
public long this[int i]=>Value[i];

public static A218072Inst Instance=new A218072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218073
{
public static readonly long[] Value={ 0L,1L,2L,9L,12L,50L,60L,245L,280L,1134L,1260L,5082L,5544L,22308L,24024L,96525L,102960L,413270L,437580L,1755182L,1847560L,7407036L,7759752L,31097794L,32449872L,130007500L,135207800L,541574100L,561632400L,2249204040L,2326762800L,9316746045L,9617286240L,38504502630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218073Inst : IEnumerable<long>
{
public static readonly long[] Value=A218073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218073.Bytes);
public long this[int i]=>Value[i];

public static A218073Inst Instance=new A218073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218074
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,4L,5L,7L,10L,15L,18L,25L,31L,41L,53L,66L,81L,103L,125L,154L,190L,229L,276L,333L,399L,475L,568L,673L,794L,938L,1102L,1289L,1512L,1760L,2050L,2384L,2760L,3190L,3687L,4246L,4882L,5609L,6427L,7354L,8412L,9592L,10927L,12439L,14130L,16033L,18177L,20573L,23256L,26271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218074Inst : IEnumerable<long>
{
public static readonly long[] Value=A218074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218074.Bytes);
public long this[int i]=>Value[i];

public static A218074Inst Instance=new A218074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218075
{
public static readonly long[] Value={ 2L,4L,4L,16L,4L,16L,4L,16L,64L,4L,64L,16L,4L,16L,64L,64L,4L,64L,16L,4L,64L,16L,64L,256L,16L,4L,16L,4L,16L,16384L,16L,64L,4L,1024L,4L,64L,64L,16L,64L,64L,4L,1024L,4L,16L,4L,4096L,4096L,16L,4L,16L,64L,4L,1024L,64L,64L,64L,4L,64L,16L,4L,1024L,16384L,16L,4L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218075Inst : IEnumerable<long>
{
public static readonly long[] Value=A218075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218075.Bytes);
public long this[int i]=>Value[i];

public static A218075Inst Instance=new A218075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218076
{
public static readonly long[] Value={ 3L,6L,12L,19L,38L,42L,68L,243L,384L,515L,740L,1709L,5151L,11049L,45641L,94729L,185610L,644593L,726681L,2296396L,3098358L,6178778L,15743325L,22436908L,80141430L,84300971L,127495932L,177416979L,198423144L,275354607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218076Inst : IEnumerable<long>
{
public static readonly long[] Value=A218076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218076.Bytes);
public long this[int i]=>Value[i];

public static A218076Inst Instance=new A218076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218077
{
public static readonly BigInteger[] Value={ 2L,4L,26L,342L,9570L,541648L,63539000L,15273379756L,7536355198322L,7638025013662022L,15885925464819479594UL,BigInteger.Parse("67830148307791047786954"),BigInteger.Parse("594506334059654048458398386"),BigInteger.Parse("10695894538923756861560332296188") };
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
public class A218077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218077Inst Instance=new A218077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218078
{
public static readonly long[] Value={ 2L,4L,8L,18L,38L,82L,176L,378L,812L,1744L,3746L,8046L,17282L,37120L,79730L,171252L,367832L,790066L,1696982L,3644946L,7828976L,16815850L,36118748L,77579424L,166632770L,357910366L,768755330L,1651208832L,3546629858L,7617802852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218078Inst : IEnumerable<long>
{
public static readonly long[] Value=A218078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218078.Bytes);
public long this[int i]=>Value[i];

public static A218078Inst Instance=new A218078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218079
{
public static readonly long[] Value={ 4L,8L,26L,78L,246L,762L,2370L,7372L,22916L,71264L,221580L,688986L,2142340L,6661388L,20712972L,64404986L,200261174L,622693012L,1936204472L,6020443090L,18719993212L,58208032550L,180992322576L,562778355430L,1749905592014L,5441164449786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218079Inst : IEnumerable<long>
{
public static readonly long[] Value=A218079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218079.Bytes);
public long this[int i]=>Value[i];

public static A218079Inst Instance=new A218079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218080
{
public static readonly long[] Value={ 6L,18L,78L,342L,1508L,6606L,29136L,128220L,564548L,2485936L,10945378L,48194280L,212204122L,934356836L,4114075516L,18114710104L,79761011640L,351196268466L,1546354739056L,6808765412512L,29979722654490L,132003926897010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218080Inst : IEnumerable<long>
{
public static readonly long[] Value=A218080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218080.Bytes);
public long this[int i]=>Value[i];

public static A218080Inst Instance=new A218080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218081
{
public static readonly long[] Value={ 10L,38L,246L,1508L,9570L,60258L,380952L,2406376L,15206400L,96092194L,607206590L,3837073622L,24247012810L,153220885972L,968228300896L,6118393119702L,38663138411874L,244318751285028L,1543890515080300L,9756099061245452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218081Inst : IEnumerable<long>
{
public static readonly long[] Value=A218081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218081.Bytes);
public long this[int i]=>Value[i];

public static A218081Inst Instance=new A218081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218082
{
public static readonly long[] Value={ 16L,82L,762L,6606L,60258L,541648L,4899478L,44312938L,400643990L,3623411680L,32768022636L,296337070254L,2679938014086L,24236092437176L,219179891622626L,1982160791298878L,17925737389126208L,162112009318616150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218082Inst : IEnumerable<long>
{
public static readonly long[] Value=A218082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218082.Bytes);
public long this[int i]=>Value[i];

public static A218082Inst Instance=new A218082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218083
{
public static readonly long[] Value={ 26L,176L,2370L,29136L,380952L,4899478L,63539000L,823053378L,10661120138L,138149847118L,1789888932316L,23191276369530L,300485634983396L,3893322462118298L,50445039193715888L,653606332192382008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218083Inst : IEnumerable<long>
{
public static readonly long[] Value=A218083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218083.Bytes);
public long this[int i]=>Value[i];

public static A218083Inst Instance=new A218083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218084
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,4L,6L,8L,8L,6L,10L,18L,26L,18L,10L,16L,38L,78L,78L,38L,16L,26L,82L,246L,342L,246L,82L,26L,42L,176L,762L,1508L,1508L,762L,176L,42L,68L,378L,2370L,6606L,9570L,6606L,2370L,378L,68L,110L,812L,7372L,29136L,60258L,60258L,29136L,7372L,812L,110L,178L,1744L,22916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218084Inst : IEnumerable<long>
{
public static readonly long[] Value=A218084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218084.Bytes);
public long this[int i]=>Value[i];

public static A218084Inst Instance=new A218084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218085
{
public static readonly long[] Value={ 0L,-1L,1L,-1L,-1L,1L,-2L,2L,2L,-2L,2L,-3L,-3L,3L,-3L,3L,6L,-6L,6L,-6L,-6L,5L,-5L,5L,5L,-5L,4L,-4L,-4L,4L,-4L,3L,-3L,3L,-3L,3L,4L,-4L,4L,-4L,-4L,3L,-3L,3L,3L,-3L,2L,-2L,2L,-2L,2L,-3L,-3L,3L,-3L,3L,4L,-4L,4L,-4L,-4L,3L,-3L,3L,3L,-3L,2L,-2L,-2L,2L,-2L,1L,1L,-1L,1L,-1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218085Inst : IEnumerable<long>
{
public static readonly long[] Value=A218085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218085.Bytes);
public long this[int i]=>Value[i];

public static A218085Inst Instance=new A218085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218086
{
public static readonly long[] Value={ 2L,3L,5L,17L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218086Inst : IEnumerable<long>
{
public static readonly long[] Value=A218086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218086.Bytes);
public long this[int i]=>Value[i];

public static A218086Inst Instance=new A218086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218087
{
public static readonly long[] Value={ 1L,2L,4L,6L,720L,780L,840L,1008L,1092L,1584L,2016L,2520L,2880L,3168L,3360L,3600L,4368L,5640L,6048L,6720L,7560L,8640L,8820L,9520L,10080L,11088L,12240L,13104L,13440L,13860L,14040L,15840L,17160L,18480L,18720L,19320L,19656L,20736L,21840L,22176L,22680L,23040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218087Inst : IEnumerable<long>
{
public static readonly long[] Value=A218087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218087.Bytes);
public long this[int i]=>Value[i];

public static A218087Inst Instance=new A218087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218088
{
public static readonly long[] Value={ 2L,4L,8L,20L,52L,140L,400L,1204L,3808L,12634L,43772L,157822L,590518L,2287070L,9148286L,37719354L,160029668L,697553152L,3119552536L,14295585636L,67052240164L,321571247090L,1575370942644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218088Inst : IEnumerable<long>
{
public static readonly long[] Value=A218088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218088.Bytes);
public long this[int i]=>Value[i];

public static A218088Inst Instance=new A218088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218089
{
public static readonly BigInteger[] Value={ 1L,14L,165L,2244L,35755L,659238L,13856521L,327596552L,8612579511L,249374246010L,7887780406957L,270660921021516L,10015416945711619L,397588957529910734L,16855928678721845265UL,BigInteger.Parse("760132325936960344080"),BigInteger.Parse("36333256253671504279279") };
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
public class A218089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218089Inst Instance=new A218089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218090
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,8L,17L,63L,224L,1248L,8218L,75992L,906635L,14447433L,303100595L,8415834690L,309390830222L,15105805368214L,982300491033887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218090Inst : IEnumerable<long>
{
public static readonly long[] Value=A218090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218090.Bytes);
public long this[int i]=>Value[i];

public static A218090Inst Instance=new A218090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218091
{
public static readonly BigInteger[] Value={ 102247563L,7972318200L,477859512889L,26234041133443L,1405508547112670L,75638497021149062L,4150321205365373610L,BigInteger.Parse("234104217274598884642"),BigInteger.Parse("13636766011245325587353"),BigInteger.Parse("822369813313954835099742"),BigInteger.Parse("51404873131596488549863350"),BigInteger.Parse("3332014222322664690079709532") };
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
public class A218091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218091Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218091.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218091Inst Instance=new A218091Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218092
{
public static readonly ulong[] Value={ 3L,12L,61L,310L,1821L,11592L,80963L,608832L,4910785L,42159238L,383478987L,3678859158L,37087880753L,391641822540L,4319860660447L,49647399946048L,593217470459313L,7354718987639958L,94445777492433515L,1254196823154143190L,17198114810490326713UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218092Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218092.Bytes);
public ulong this[int i]=>Value[i];

public static A218092Inst Instance=new A218092Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218093
{
public static readonly BigInteger[] Value={ 13L,106L,1105L,12075L,141533L,1812216L,25188019L,378725365L,6135529675L,106586385708L,1976799958367L,38978490654831L,814024466784025L,17943457752971680L,416183933276776375L,10128962147830237953UL,BigInteger.Parse("258021086313431979827"),BigInteger.Parse("6863916836407264864380") };
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
public class A218093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218093Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218093.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218093Inst Instance=new A218093Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218094
{
public static readonly BigInteger[] Value={ 75L,1035L,16025L,267715L,4798983L,92374107L,1913052805L,42483670075L,1008618127825L,25519311555595L,686016182577453L,19536602119711495L,587778832750221385L,BigInteger.Parse("18633924653894097385"),BigInteger.Parse("620967800006345098353"),BigInteger.Parse("21703395396687678061639"),BigInteger.Parse("793901738815689934686095") };
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
public class A218094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218094Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218094.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218094Inst Instance=new A218094Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218095
{
public static readonly BigInteger[] Value={ 541L,11301L,239379L,5287506L,124878033L,3151808478L,84934607175L,2440299822081L,74564772630777L,2416548374532292L,82847673438018762L,2996998457878842144L,BigInteger.Parse("114123931204449050115"),BigInteger.Parse("4564365783126801549858"),BigInteger.Parse("191334572138628994076241"),BigInteger.Parse("8390237730288860299836005") };
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
public class A218095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218095Inst Instance=new A218095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218096
{
public static readonly BigInteger[] Value={ 4683L,137774L,3794378L,105494886L,3068829477L,94494907584L,3085918099231L,106818340013957L,3913397076494906L,151442406160585540L,6177363078563029080L,BigInteger.Parse("265028384609314768260"),BigInteger.Parse("11934799080680963824449"),BigInteger.Parse("563007076962063332175612"),BigInteger.Parse("27770258520873025001499693") };
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
public class A218096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218096Inst Instance=new A218096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218097
{
public static readonly BigInteger[] Value={ 47293L,1863044L,64432638L,2185028130L,75967708311L,2755081426548L,104970367609107L,4210378306984993L,177779119899659850L,7894403946290257968L,BigInteger.Parse("368141001305925742232"),BigInteger.Parse("17999569547430255114096"),BigInteger.Parse("921163485872922579361467"),BigInteger.Parse("49262708358493465135411860") };
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
public class A218097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218097Inst Instance=new A218097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218098
{
public static readonly BigInteger[] Value={ 545835L,27733869L,1173919350L,47488375440L,1933688266686L,81009491387682L,3527548086703069L,160415345420268510L,7631859877504516225L,BigInteger.Parse("379961855272982538127"),BigInteger.Parse("19785139747357478264082"),BigInteger.Parse("1076480694153554931849504"),BigInteger.Parse("61126131119735946242652270") };
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
public class A218098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218098Inst Instance=new A218098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218099
{
public static readonly BigInteger[] Value={ 7087261L,451238935L,22913136730L,1087116745385L,51075201835515L,2437976801668408L,119752042470064290L,6093096859120003590L,BigInteger.Parse("322215964319093498225"),BigInteger.Parse("17735784941946000072572"),BigInteger.Parse("1016521929886047797022408"),BigInteger.Parse("60650840653136697085038930"),BigInteger.Parse("3764766650086543657134295955") };
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
public class A218099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218099Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218099.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218099Inst Instance=new A218099Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218100
{
public static readonly long[] Value={ 2L,3L,7L,19L,23L,103L,271L,349L,91943L,118147L,133447L,165541L,1399399L,6161527L,12740363L,12789323L,20019953L,27793541L,29536943L,92364991L,653778547L,868088981L,988438109L,1274902129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218100Inst : IEnumerable<long>
{
public static readonly long[] Value=A218100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218100.Bytes);
public long this[int i]=>Value[i];

public static A218100Inst Instance=new A218100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218101
{
public static readonly BigInteger[] Value={ 1L,0L,0L,20L,252L,0L,0L,40116600L,9075135300L,0L,0L,7219428434016265740L,BigInteger.Parse("27217014869199032015600"),0L,0L,BigInteger.Parse("96614908840363322603893139521372656"),BigInteger.Parse("5949105755928259715106809205795376486500"),0L,0L,BigInteger.Parse("90717484605833107953850163563674201296374152790550788800"),BigInteger.Parse("90492479540310008180848641429024900729436748166512078795479440"),0L,0L };
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
public class A218101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218101Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218101.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218101Inst Instance=new A218101Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218102
{
public static readonly BigInteger[] Value={ 1L,1L,5L,63L,1319L,40559L,1740041L,102534291L,8332829935L,944126513627L,150312711346533L,33728725902552987L,10685563629182909359UL,BigInteger.Parse("4790986916169721578103"),BigInteger.Parse("3046269113896919000444225"),BigInteger.Parse("2750105392841508250133575939"),BigInteger.Parse("3528869100728541732126472203599") };
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
public class A218102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218102Inst Instance=new A218102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218103
{
public static readonly BigInteger[] Value={ 0L,1L,310L,12075L,267715L,5287506L,105494886L,2185028130L,47488375440L,1087116745385L,26234041133443L,666937354457829L,17839235553096685L,501241620987647540L,14769149279798467900UL,BigInteger.Parse("455566464561064320948"),BigInteger.Parse("14685947990441112405726"),BigInteger.Parse("493969048893703131221475") };
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
public class A218103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218103Inst Instance=new A218103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218104
{
public static readonly BigInteger[] Value={ 0L,1L,1821L,141533L,4798983L,124878033L,3068829477L,75967708311L,1933688266686L,51075201835515L,1405508547112670L,40356644902123914L,1209368372802130814L,BigInteger.Parse("37806870603888974350"),BigInteger.Parse("1231961629420423620918"),BigInteger.Parse("41802174277488971170242"),BigInteger.Parse("1475352032068521550599837") };
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
public class A218104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218104Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218104.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218104Inst Instance=new A218104Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218105
{
public static readonly BigInteger[] Value={ 0L,1L,11592L,1812216L,92374107L,3151808478L,94494907584L,2755081426548L,81009491387682L,2437976801668408L,75638497021149062L,2427804103875438288L,BigInteger.Parse("80751743315656443940"),BigInteger.Parse("2784897386029995089700"),BigInteger.Parse("99580133563729334883624"),BigInteger.Parse("3690405873805797826482120") };
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
public class A218105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218105Inst Instance=new A218105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218106
{
public static readonly BigInteger[] Value={ 0L,1L,80963L,25188019L,1913052805L,84934607175L,3085918099231L,104970367609107L,3527548086703069L,119752042470064290L,4150321205365373610L,BigInteger.Parse("147666165472551221730"),BigInteger.Parse("5409628424337030402002"),BigInteger.Parse("204363410596110256258446"),BigInteger.Parse("7966805463258438079563650") };
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
public class A218106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218106Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218106.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218106Inst Instance=new A218106Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218107
{
public static readonly BigInteger[] Value={ 0L,1L,608832L,378725365L,42483670075L,2440299822081L,106818340013957L,4210378306984993L,160415345420268510L,6093096859120003590L,BigInteger.Parse("234104217274598884642"),BigInteger.Parse("9167943015777908270142"),BigInteger.Parse("367520396335132750893274"),BigInteger.Parse("15117877192137817244318510"),BigInteger.Parse("638973577773301815522889410") };
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
public class A218107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218107Inst Instance=new A218107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218108
{
public static readonly BigInteger[] Value={ 0L,1L,4910785L,6135529675L,1008618127825L,74564772630777L,3913397076494906L,177779119899659850L,7631859877504516225L,BigInteger.Parse("322215964319093498225"),BigInteger.Parse("13636766011245325587353"),BigInteger.Parse("584294217357391235758011"),BigInteger.Parse("25488316708898114509899955"),BigInteger.Parse("1135731969645865474902932115") };
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
public class A218108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218108Inst Instance=new A218108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218109
{
public static readonly BigInteger[] Value={ 0L,1L,42159238L,106586385708L,25519311555595L,2416548374532292L,151442406160585540L,7894403946290257968L,BigInteger.Parse("379961855272982538127"),BigInteger.Parse("17735784941946000072572"),BigInteger.Parse("822369813313954835099742"),BigInteger.Parse("38353581871007817965010668"),BigInteger.Parse("1811813065380635747237663856") };
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
public class A218109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218109Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218109.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218109Inst Instance=new A218109Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218110
{
public static readonly BigInteger[] Value={ 0L,1L,383478987L,1976799958367L,686016182577453L,82847673438018762L,6177363078563029080L,BigInteger.Parse("368141001305925742232"),BigInteger.Parse("19785139747357478264082"),BigInteger.Parse("1016521929886047797022408"),BigInteger.Parse("51404873131596488549863350"),BigInteger.Parse("2597923441011463423121994276"),BigInteger.Parse("132340384137811145863910654038") };
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
public class A218110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218110Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218110.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218110Inst Instance=new A218110Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218111
{
public static readonly BigInteger[] Value={ 0L,1L,12L,106L,1035L,11301L,137774L,1863044L,27733869L,451238935L,7972318200L,152065270974L,3115418734415L,68245059703289L,1591993733475570L,39406010771574856L,1031649940977825633L,BigInteger.Parse("28483179899706237483"),BigInteger.Parse("827159099070697636124"),BigInteger.Parse("25205610503231757308450") };
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
public class A218111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218111Inst Instance=new A218111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218112
{
public static readonly BigInteger[] Value={ 0L,1L,61L,1105L,16025L,239379L,3794378L,64432638L,1173919350L,22913136730L,477859512889L,10616510910603L,250501631648359L,6259150585043685L,165157651772590340L,4590337237739801932L,BigInteger.Parse("134066099253229461636"),BigInteger.Parse("4105495811166963962292"),BigInteger.Parse("131552972087266209052875") };
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
public class A218112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218112Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218112.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218112Inst Instance=new A218112Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218113
{
public static readonly BigInteger[] Value={ 1L,0L,0L,3L,6L,0L,0L,1646L,34040L,0L,0L,16006173014L,4525920859198L,0L,0L,BigInteger.Parse("4648429222263945620900"),BigInteger.Parse("16788801124652327714275292"),0L,0L,BigInteger.Parse("37312554419836846950126367899458469004"),BigInteger.Parse("1771856721790425759554265832614437952858250"),0L,0L,BigInteger.Parse("9390566673339284963209556300602063088163896933170108347086"),BigInteger.Parse("6044842632698233176498212302295937843763731581533454885103600044") };
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
public class A218113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218113Inst Instance=new A218113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218114
{
public static readonly long[] Value={ 30L,34L,51L,78L,87L,106L,132L,165L,180L,203L,225L,231L,248L,253L,305L,312L,375L,381L,488L,502L,510L,588L,633L,690L,727L,734L,754L,761L,988L,1038L,1070L,1089L,1110L,1140L,1183L,1218L,1299L,1336L,1368L,1408L,1416L,1431L,1437L,1449L,1466L,1504L,1525L,1600L,1632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218114Inst : IEnumerable<long>
{
public static readonly long[] Value=A218114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218114.Bytes);
public long this[int i]=>Value[i];

public static A218114Inst Instance=new A218114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218115
{
public static readonly long[] Value={ 1L,1L,1L,1L,17L,1L,1L,98L,98L,1L,1L,354L,2251L,354L,1L,1L,979L,23803L,23803L,979L,1L,1L,2275L,158367L,617036L,158367L,2275L,1L,1L,4676L,773842L,8763293L,8763293L,773842L,4676L,1L,1L,8772L,3031668L,82498785L,241082026L,82498785L,3031668L,8772L,1L,1L,15333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218115Inst : IEnumerable<long>
{
public static readonly long[] Value=A218115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218115.Bytes);
public long this[int i]=>Value[i];

public static A218115Inst Instance=new A218115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218116
{
public static readonly long[] Value={ 1L,1L,1L,1L,33L,1L,1L,276L,276L,1L,1L,1300L,12695L,1300L,1L,1L,4425L,221495L,221495L,4425L,1L,1L,12201L,2185350L,11534720L,2185350L,12201L,1L,1L,29008L,14794261L,285715550L,285715550L,14794261L,29008L,1L,1L,61776L,76579851L,4276969276L,15781532964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218116Inst : IEnumerable<long>
{
public static readonly long[] Value=A218116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218116.Bytes);
public long this[int i]=>Value[i];

public static A218116Inst Instance=new A218116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218117
{
public static readonly BigInteger[] Value={ 1L,2L,19L,198L,2961L,49566L,938322L,19083624L,412160478L,9305822076L,217855152321L,5251363667622L,129704365956114L,3269927116717728L,83893626609970281L,2185188966488265718L,BigInteger.Parse("57673989852987800966"),BigInteger.Parse("1539973309401567102832"),BigInteger.Parse("41544812360973818992909") };
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
public class A218117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218117Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218117.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218117Inst Instance=new A218117Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218118
{
public static readonly BigInteger[] Value={ 1L,1L,9L,90L,1350L,22623L,430338L,8786367L,190473510L,4314088755L,101271596421L,2446843690671L,60557118315384L,1529356193511525L,39297344717526330L,1024958399339092751L,BigInteger.Parse("27083985050402731646"),BigInteger.Parse("723942169622258974974"),BigInteger.Parse("19548657715769940178730") };
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
public class A218118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218118Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218118.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218118Inst Instance=new A218118Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218119
{
public static readonly BigInteger[] Value={ 1L,2L,35L,554L,15297L,451842L,15929824L,601077640L,24488754772L,1046792248856L,46718718597567L,2155032002133834L,102259392504591235L,4967499746642163574L,BigInteger.Parse("246231868462969357492"),BigInteger.Parse("12419324761881256326288"),BigInteger.Parse("635990044563649443993091"),BigInteger.Parse("33006906229799699591298070") };
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
public class A218119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218119Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218119.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218119Inst Instance=new A218119Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218120
{
public static readonly BigInteger[] Value={ 1L,1L,17L,260L,7244L,214257L,7593707L,287419304L,11745920475L,503237634257L,22503750152879L,1039694201489294L,49401095274561608L,2402478324494963930L,BigInteger.Parse("119201977436336120482"),BigInteger.Parse("6017223412990713126034"),BigInteger.Parse("308361587173800754305214"),BigInteger.Parse("16013543997544827365960598") };
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
public class A218120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218120Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218120.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218120Inst Instance=new A218120Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218121
{
public static readonly long[] Value={ 1L,5L,5L,11L,11L,17L,17L,17L,29L,29L,29L,41L,41L,41L,41L,41L,41L,67L,67L,67L,67L,83L,83L,83L,83L,83L,83L,109L,109L,127L,127L,127L,127L,149L,149L,149L,149L,149L,149L,149L,181L,181L,181L,181L,181L,181L,181L,181L,229L,229L,229L,229L,251L,251L,251L,251L,251L,251L,251L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218121Inst : IEnumerable<long>
{
public static readonly long[] Value=A218121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218121.Bytes);
public long this[int i]=>Value[i];

public static A218121Inst Instance=new A218121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218122
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,2L,5L,34L,BigInteger.Parse("582076609134674072265627") };
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
public class A218122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218122Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218122.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218122Inst Instance=new A218122Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218123
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,3L,3L,5L,5L,5L,7L,7L,7L,7L,7L,7L,11L,11L,11L,11L,13L,13L,13L,13L,13L,13L,17L,17L,17L,17L,17L,17L,19L,19L,19L,19L,19L,19L,19L,23L,23L,23L,23L,23L,23L,23L,23L,29L,29L,29L,29L,31L,31L,31L,31L,31L,31L,31L,31L,31L,37L,37L,37L,37L,37L,37L,41L,41L,41L,41L,43L,43L,43L,43L,43L,43L,43L,47L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218123Inst : IEnumerable<long>
{
public static readonly long[] Value=A218123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218123.Bytes);
public long this[int i]=>Value[i];

public static A218123Inst Instance=new A218123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218124
{
public static readonly long[] Value={ 1L,7L,42L,336L,2352L,16800L,117264L,823536L,5762400L,40353264L,282458400L,1977326736L,13841167200L,96889010400L,678222249264L,4747561492800L,33232924804800L,232630513987200L,1628413557439536L,11398895185373136L,79792266015134400L,558545864082460128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218124Inst : IEnumerable<long>
{
public static readonly long[] Value=A218124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218124.Bytes);
public long this[int i]=>Value[i];

public static A218124Inst Instance=new A218124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218125
{
public static readonly long[] Value={ 1L,8L,56L,504L,4032L,32760L,261576L,2097144L,16773120L,134217216L,1073709000L,8589934584L,68719210560L,549755813880L,4398044413896L,35184372055560L,281474959933440L,2251799813685240L,18014398375002624L,144115188075855864L,1152921503533101120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218125Inst : IEnumerable<long>
{
public static readonly long[] Value=A218125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218125.Bytes);
public long this[int i]=>Value[i];

public static A218125Inst Instance=new A218125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218126
{
public static readonly ulong[] Value={ 1L,9L,72L,720L,6480L,59040L,530640L,4782960L,43040160L,387419760L,3486725280L,31381059600L,282428998560L,2541865828320L,22876787671920L,205891132034880L,1853020145805120L,16677181699666560L,150094634909047920L,1350851717672992080L,12157665455570137920UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218126Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218126.Bytes);
public ulong this[int i]=>Value[i];

public static A218126Inst Instance=new A218126Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218127
{
public static readonly BigInteger[] Value={ 1L,10L,90L,990L,9900L,99990L,998910L,9999990L,99990000L,999999000L,9999899910L,99999999990L,999998990100L,9999999999990L,99999989999910L,999999999899010L,9999999900000000L,99999999999999990L,999999998999001000L,9999999999999999990UL,BigInteger.Parse("99999999989999990100") };
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
public class A218127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218127Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218127.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218127Inst Instance=new A218127Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218128
{
public static readonly long[] Value={ 0L,1L,7L,10L,16L,34L,70L,82L,88L,124L,127L,160L,172L,199L,217L,250L,268L,340L,352L,358L,379L,394L,397L,442L,451L,520L,538L,574L,619L,622L,664L,682L,700L,718L,754L,775L,802L,829L,844L,871L,880L,970L,973L,988L,1027L,1078L,1081L,1117L,1123L,1171L,1240L,1252L,1258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218128Inst : IEnumerable<long>
{
public static readonly long[] Value=A218128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218128.Bytes);
public long this[int i]=>Value[i];

public static A218128Inst Instance=new A218128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218129
{
public static readonly long[] Value={ 1L,2L,4L,11L,1028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218129Inst : IEnumerable<long>
{
public static readonly long[] Value=A218129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218129.Bytes);
public long this[int i]=>Value[i];

public static A218129Inst Instance=new A218129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218130
{
public static readonly long[] Value={ 0L,0L,54L,696L,4020L,15480L,46410L,117264L,261576L,530640L,998910L,1770120L,2984124L,4824456L,7526610L,11387040L,16772880L,24132384L,34006086L,47038680L,63991620L,85756440L,113368794L,148023216L,191088600L,244124400L,308897550L,387400104L,481867596L,594798120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218130Inst : IEnumerable<long>
{
public static readonly long[] Value=A218130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218130.Bytes);
public long this[int i]=>Value[i];

public static A218130Inst Instance=new A218130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218131
{
public static readonly long[] Value={ 0L,0L,240L,6480L,65280L,390000L,1678320L,5762400L,16773120L,43040160L,99990000L,214344240L,429960960L,815702160L,1475750640L,2562840000L,4294901760L,6975673920L,11019855600L,16983432720L,25599840000L,37822664880L,54875639280L,78310705440L,110074982400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218131Inst : IEnumerable<long>
{
public static readonly long[] Value=A218131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218131.Bytes);
public long this[int i]=>Value[i];

public static A218131Inst Instance=new A218131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218132
{
public static readonly long[] Value={ 0L,0L,504L,19656L,262080L,1953000L,10077480L,40353264L,134217216L,387419760L,999999000L,2357946360L,5159778624L,10604497176L,20661044040L,38443356000L,68719472640L,118587871584L,198359284536L,322687690920L,511999992000L,794280037320L,1207269207144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218132Inst : IEnumerable<long>
{
public static readonly long[] Value=A218132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218132.Bytes);
public long this[int i]=>Value[i];

public static A218132Inst Instance=new A218132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218133
{
public static readonly long[] Value={ 0L,0L,990L,58800L,1047540L,9762480L,60458370L,282458400L,1073709000L,3486725280L,9999899910L,25937263440L,61917115260L,137858120400L,289254116970L,576649631040L,1099510578960L,2015992480320L,3570465336750L,6131063781360L,10239996799620L,16679876893680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218133Inst : IEnumerable<long>
{
public static readonly long[] Value=A218133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218133.Bytes);
public long this[int i]=>Value[i];

public static A218133Inst Instance=new A218133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218134
{
public static readonly long[] Value={ 1L,4L,17L,80L,369L,1700L,7841L,36160L,166753L,768996L,3546289L,16354000L,75417809L,347795396L,1603886913L,7396455680L,34109360321L,157298104900L,725393076049L,3345209499600L,15426707209777L,71141522037604L,328074947492321L,1512944453384000L,6977067089461281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218134Inst : IEnumerable<long>
{
public static readonly long[] Value=A218134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218134.Bytes);
public long this[int i]=>Value[i];

public static A218134Inst Instance=new A218134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218135
{
public static readonly long[] Value={ 1L,1L,5L,17L,45L,185L,533L,1921L,6205L,20745L,69541L,229585L,769613L,2552537L,8515125L,28340513L,94357853L,314301865L,1046284741L,3484682865L,11602442605L,38636214649L,128653931093L,428398492865L,1426535718525L,4750159951433L,15817576773605L,52670623373329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218135Inst : IEnumerable<long>
{
public static readonly long[] Value=A218135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218135.Bytes);
public long this[int i]=>Value[i];

public static A218135Inst Instance=new A218135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218136
{
public static readonly BigInteger[] Value={ 1L,9L,85L,873L,8845L,89505L,906373L,9177849L,92932285L,941010705L,9528455221L,96482899305L,976963204333L,9892500250113L,100169136977125L,1014289183762137L,10270454347410973L,103996211523970545L,1053041242918825621L,10662848608027795785UL,BigInteger.Parse("107969503760905131085") };
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
public class A218136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218136Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218136.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218136Inst Instance=new A218136Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218137
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,6L,9L,11L,16L,27L,37L,40L,77L,117L,144L,207L,351L,482L,523L,999L,1522L,1879L,2681L,4560L,6279L,6839L,12960L,19799L,24517L,34722L,59239L,81793L,89424L,168123L,257547L,319880L,449667L,769547L,1065430L,1169193L,2180881L,3350074L,4173363L,5823117L,9996480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218137Inst : IEnumerable<long>
{
public static readonly long[] Value=A218137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218137.Bytes);
public long this[int i]=>Value[i];

public static A218137Inst Instance=new A218137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218138
{
public static readonly long[] Value={ 1L,1L,3L,5L,9L,19L,25L,59L,109L,147L,359L,653L,899L,2205L,3915L,5715L,13545L,23347L,36229L,82923L,138781L,228653L,506215L,822381L,1437267L,3082029L,4856667L,9000947L,18714281L,28578195L,56172277L,113328667L,167517773L,349394765L,684430311L,977894349L,2166392995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218138Inst : IEnumerable<long>
{
public static readonly long[] Value=A218138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218138.Bytes);
public long this[int i]=>Value[i];

public static A218138Inst Instance=new A218138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218139
{
public static readonly BigInteger[] Value={ 1L,5L,85L,2230L,73157L,2748240L,113026865L,4958785285L,228333859874L,10915734783342L,537683100870537L,27139187103865728L,1397889420026942941L,BigInteger.Parse("73245245888401473591"),BigInteger.Parse("3894386042722560634412"),BigInteger.Parse("209696591518450916905784"),BigInteger.Parse("11416666685883303837337577"),BigInteger.Parse("627639029564864592680196915") };
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
public class A218139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218139Inst Instance=new A218139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218140
{
public static readonly BigInteger[] Value={ 1L,9L,419L,35052L,3932898L,525079969L,78585936821L,12747573200724L,2194994259274978L,395736626092691782L,BigInteger.Parse("73998168736285644408"),BigInteger.Parse("14252983638239681717320"),BigInteger.Parse("2813522889710891871593558"),BigInteger.Parse("566979470344349452319862891"),BigInteger.Parse("116289126161824019718614903183") };
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
public class A218140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218140Inst Instance=new A218140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218141
{
public static readonly BigInteger[] Value={ 1L,1L,7L,3025L,171798901L,2436684974110751L,BigInteger.Parse("14204422416132896951197888"),BigInteger.Parse("50789872166903636182659702516635946082"),BigInteger.Parse("155440114706926165785630654089245708839702615196926765"),BigInteger.Parse("541500903058656141876322139677626107784896646583041951351456223689104719") };
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
public class A218141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218141Inst Instance=new A218141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218142
{
public static readonly BigInteger[] Value={ 1L,1L,31L,86526L,45232115901L,7713000216608565075L,BigInteger.Parse("666480349285726891499539272955"),BigInteger.Parse("41929298560838945526242744414099901692285884"),BigInteger.Parse("2610516895723221966171633379256064857587637240616032299710417") };
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
public class A218142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218142Inst Instance=new A218142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218143
{
public static readonly BigInteger[] Value={ 1L,1L,3L,90L,34105L,210766920L,26585679462804L,BigInteger.Parse("82892803728383735268"),BigInteger.Parse("7529580759157036060608585183"),BigInteger.Parse("22982258052528294182955639980819773510"),BigInteger.Parse("2672446997421818663856559987803834697952486978300"),BigInteger.Parse("13239043631590111512460321918828937597837325561187113535696980") };
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
public class A218143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218143Inst Instance=new A218143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218144
{
public static readonly long[] Value={ 1L,2L,4L,12L,40L,184L,1296L,17072L,424992L,20314096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218144Inst : IEnumerable<long>
{
public static readonly long[] Value=A218144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218144.Bytes);
public long this[int i]=>Value[i];

public static A218144Inst Instance=new A218144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218145
{
public static readonly long[] Value={ 1L,8L,14L,24L,10L,12L,36L,10L,126L,1L,9L,112L,126L,224L,315L,216L,108L,240L,2160L,8L,108L,192L,84L,192L,300L,1470L,1296L,180L,1728L,14L,1134L,2016L,2835L,324L,2240L,4320L,450L,2240L,1215L,24L,864L,1792L,2205L,1280L,90L,3402L,144L,90L,1512L,10L,180L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218145Inst : IEnumerable<long>
{
public static readonly long[] Value=A218145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218145.Bytes);
public long this[int i]=>Value[i];

public static A218145Inst Instance=new A218145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218146
{
public static readonly long[] Value={ 1L,7L,13L,19L,31L,37L,43L,55L,61L,91L,97L,109L,121L,127L,139L,151L,163L,169L,217L,229L,241L,253L,265L,271L,283L,295L,307L,319L,331L,343L,355L,367L,379L,391L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218146Inst : IEnumerable<long>
{
public static readonly long[] Value=A218146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218146.Bytes);
public long this[int i]=>Value[i];

public static A218146Inst Instance=new A218146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218147
{
public static readonly long[] Value={ 2L,2L,4L,4L,12L,8L,18L,8L,30L,16L,36L,24L,32L,32L,64L,36L,90L,32L,96L,60L,132L,64L,100L,72L,162L,96L,196L,64L,240L,128L,240L,128L,192L,144L,324L,180L,288L,128L,400L,192L,462L,240L,288L,264L,552L,256L,588L,200L,512L,288L,676L,324L,480L,384L,720L,392L,870L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218147Inst : IEnumerable<long>
{
public static readonly long[] Value=A218147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218147.Bytes);
public long this[int i]=>Value[i];

public static A218147Inst Instance=new A218147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218148
{
public static readonly BigInteger[] Value={ 1L,2L,4L,16L,256L,32768L,67108864L,4398046511104L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("9903520314283042199192993792"),BigInteger.Parse("1361129467683753853853498429727072845824"),BigInteger.Parse("95780971304118053647396689196894323976171195136475136") };
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
public class A218148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218148Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218148.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218148Inst Instance=new A218148Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218149
{
public static readonly BigInteger[] Value={ 1L,3L,9L,81L,6561L,14348907L,2541865828329L,BigInteger.Parse("109418989131512359209"),BigInteger.Parse("3433683820292512484657849089281"),BigInteger.Parse("235655016338368235499067731945871638181119123"),BigInteger.Parse("106111661199647248543687855752712667991103904330482569981872649") };
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
public class A218149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218149Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218149.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218149Inst Instance=new A218149Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218150
{
public static readonly BigInteger[] Value={ 1L,5L,25L,625L,390625L,30517578125L,1490116119384765625L,BigInteger.Parse("227373675443232059478759765625"),BigInteger.Parse("542101086242752217003726400434970855712890625"),BigInteger.Parse("100974195868289511092701256356196637398170423693954944610595703125") };
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
public class A218150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218150Inst Instance=new A218150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218151
{
public static readonly BigInteger[] Value={ 2L,6L,90L,6750L,2531250L,4746093750L,44494628906250L,2085685729980468750L,BigInteger.Parse("488832592964172363281250"),BigInteger.Parse("572850694879889488220214843750"),BigInteger.Parse("3356547040311852470040321350097656250"),BigInteger.Parse("98336339071636302833212539553642272949218750") };
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
public class A218151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218151Inst Instance=new A218151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218152
{
public static readonly long[] Value={ 1L,2L,5L,13L,29L,56L,97L,155L,233L,334L,461L,617L,805L,1028L,1289L,1591L,1937L,2330L,2773L,3269L,3821L,4432L,5105L,5843L,6649L,7526L,8477L,9505L,10613L,11804L,13081L,14447L,15905L,17458L,19109L,20861L,22717L,24680L,26753L,28939L,31241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218152Inst : IEnumerable<long>
{
public static readonly long[] Value=A218152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218152.Bytes);
public long this[int i]=>Value[i];

public static A218152Inst Instance=new A218152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218153
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,16L,25L,42L,65L,105L,162L,256L,391L,605L,918L,1401L,2106L,3176L,4739L,7076L,10482L,15518L,22833L,33556L,49068L,71633L,104153L,151155L,218609L,315562L,454150L,652343L,934559L,1336328L,1906307L,2714409L,3856777L,5470236L,7743437L,10942743L,15435773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218153Inst : IEnumerable<long>
{
public static readonly long[] Value=A218153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218153.Bytes);
public long this[int i]=>Value[i];

public static A218153Inst Instance=new A218153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218154
{
public static readonly long[] Value={ 3L,8L,35L,3L,44L,2L,30L,36L,30L,151L,35L,27L,82L,16L,8L,27L,68L,40L,52L,62L,67L,104L,287L,98L,157L,63L,100L,143L,99L,257L,36L,189L,151L,458L,108L,155L,348L,105L,227L,598L,67L,25L,460L,169L,250L,342L,24L,423L,286L,221L,627L,113L,107L,206L,279L,506L,630L,57L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218154Inst : IEnumerable<long>
{
public static readonly long[] Value=A218154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218154.Bytes);
public long this[int i]=>Value[i];

public static A218154Inst Instance=new A218154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218155
{
public static readonly long[] Value={ 2L,3L,6L,11L,14L,15L,18L,23L,26L,27L,30L,35L,38L,39L,42L,47L,50L,51L,54L,59L,62L,63L,66L,71L,74L,75L,78L,83L,86L,87L,90L,95L,98L,99L,102L,107L,110L,111L,114L,119L,122L,123L,126L,131L,134L,135L,138L,143L,146L,147L,150L,155L,158L,159L,162L,167L,170L,171L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218155Inst : IEnumerable<long>
{
public static readonly long[] Value=A218155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218155.Bytes);
public long this[int i]=>Value[i];

public static A218155Inst Instance=new A218155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218156
{
public static readonly long[] Value={ 697L,785L,940L,985L,1345L,1384L,1708L,1765L,1937L,2024L,2233L,2296L,2505L,2941L,2993L,3021L,3144L,3281L,3305L,3368L,3496L,3576L,3580L,3592L,3596L,3624L,3973L,4065L,4344L,4764L,4765L,4844L,5073L,5353L,5356L,5368L,5369L,5529L,5621L,5624L,5685L,5901L,6108L,6153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218156Inst : IEnumerable<long>
{
public static readonly long[] Value=A218156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218156.Bytes);
public long this[int i]=>Value[i];

public static A218156Inst Instance=new A218156Inst();

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