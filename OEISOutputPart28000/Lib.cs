using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A022045
{
public static readonly long[] Value={ 1L,364L,16044L,200928L,1089452L,4196920L,12547808L,31553344L,70439852L,142487436L,268594872L,476105504L,800698080L,1296257144L,2022013760L,3056208064L,4507001772L,6481076056L,9123064524L,12637846368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022045Inst : IEnumerable<long>
{
public static readonly long[] Value=A022045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022045.Bytes);
public long this[int i]=>Value[i];

public static A022045Inst Instance=new A022045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022044
{
public static readonly long[] Value={ 1L,312L,11466L,116688L,535704L,1899664L,5043376L,12066912L,24443978L,48210760L,83323344L,145532816L,227110416L,363737712L,531517376L,800145632L,1104376728L,1594656544L,2114015514L,2931991920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022044Inst : IEnumerable<long>
{
public static readonly long[] Value=A022044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022044.Bytes);
public long this[int i]=>Value[i];

public static A022044Inst Instance=new A022044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022043
{
public static readonly long[] Value={ 1L,264L,7944L,64416L,253704L,825264L,1938336L,4437312L,8118024L,15653352L,24832944L,42517728L,61903776L,98021616L,133522752L,201364416L,259776264L,374842512L,471023592L,653690400L,793078704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022043Inst : IEnumerable<long>
{
public static readonly long[] Value=A022043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022043.Bytes);
public long this[int i]=>Value[i];

public static A022043Inst Instance=new A022043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022042
{
public static readonly long[] Value={ 1L,220L,5302L,33528L,116380L,339064L,719400L,1538416L,2624182L,4763220L,7217144L,11676280L,16317048L,25022184L,32503680L,47430768L,59759260L,82927856L,101189550L,137904360L,161928184L,215389680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022042Inst : IEnumerable<long>
{
public static readonly long[] Value=A022042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022042.Bytes);
public long this[int i]=>Value[i];

public static A022042Inst Instance=new A022042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022041
{
public static readonly long[] Value={ 2L,6L,19L,61L,196L,630L,2026L,6516L,20957L,67403L,216786L,697242L,2242518L,7212542L,23197478L,74609338L,239963729L,771787993L,2482278087L,7983674995L,25677649398L,82586237418L,265619586324L,854304141280L,2747672247776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022041Inst : IEnumerable<long>
{
public static readonly long[] Value=A022041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022041.Bytes);
public long this[int i]=>Value[i];

public static A022041Inst Instance=new A022041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022040
{
public static readonly long[] Value={ 16L,36L,80L,177L,391L,863L,1904L,4200L,9264L,20433L,45067L,99399L,219232L,483532L,1066464L,2352161L,5187855L,11442175L,25236512L,55660880L,122763936L,270764385L,597189651L,1317143239L,2905050864L,6407291380L,14131726000L,31168502865L,68744297111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022040Inst : IEnumerable<long>
{
public static readonly long[] Value=A022040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022040.Bytes);
public long this[int i]=>Value[i];

public static A022040Inst Instance=new A022040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022039
{
public static readonly long[] Value={ 8L,65L,528L,4288L,34823L,282798L,2296605L,18650749L,151462893L,1230031456L,9989096027L,81121534697L,658788680558L,5350028537458L,43447627739097L,352838558325161L,2865404964997647L,23269978350457597L,188975694202166613L,1534673236964508227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022039Inst : IEnumerable<long>
{
public static readonly long[] Value=A022039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022039.Bytes);
public long this[int i]=>Value[i];

public static A022039Inst Instance=new A022039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022038
{
public static readonly long[] Value={ 8L,57L,406L,2891L,20585L,146572L,1043641L,7431068L,52911654L,376748420L,2682572954L,19100803803L,136004020087L,968393459804L,6895280686492L,49096671672207L,349584488128334L,2489156803863966L,17723617050044085L,126197996385357735L,898571338272012057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022038Inst : IEnumerable<long>
{
public static readonly long[] Value=A022038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022038.Bytes);
public long this[int i]=>Value[i];

public static A022038Inst Instance=new A022038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022037
{
public static readonly long[] Value={ 7L,50L,357L,2548L,18185L,129785L,926265L,6610678L,47179871L,336718900L,2403135388L,17150981703L,122405160710L,873595670959L,6234781212586L,44497126143199L,317572368218278L,2266488148722385L,16175741476249015L,115444950574278036L,823921217624950245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022037Inst : IEnumerable<long>
{
public static readonly long[] Value=A022037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022037.Bytes);
public long this[int i]=>Value[i];

public static A022037Inst Instance=new A022037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022036
{
public static readonly long[] Value={ 7L,43L,264L,1620L,9940L,60989L,374211L,2296051L,14087908L,86439348L,530366956L,3254178965L,19966705347L,122509956183L,751685824132L,4612127828672L,28298688661016L,173632607265289L,1065359694467895L,6536740399587511L,40107557356899000L,246088426157852600L,1509927741297161799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022036Inst : IEnumerable<long>
{
public static readonly long[] Value=A022036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022036.Bytes);
public long this[int i]=>Value[i];

public static A022036Inst Instance=new A022036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022035
{
public static readonly long[] Value={ 6L,37L,228L,1404L,8645L,53230L,327753L,2018073L,12425877L,76509828L,471093813L,2900665005L,17860258910L,109970936934L,677123832923L,4169253239949L,25671334745061L,158066058755653L,973259831585207L,5992650839998179L,36898537188819414L,227195290202341077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022035Inst : IEnumerable<long>
{
public static readonly long[] Value=A022035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022035.Bytes);
public long this[int i]=>Value[i];

public static A022035Inst Instance=new A022035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022034
{
public static readonly long[] Value={ 6L,31L,160L,825L,4253L,21924L,113017L,582596L,3003248L,15481566L,79806558L,411398091L,2120732851L,10932252540L,56355115894L,290507292601L,1497547928268L,7719771085196L,39794963809107L,205140687086569L,1057488120864155L,5451288779669969L,28101071561042234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022034Inst : IEnumerable<long>
{
public static readonly long[] Value=A022034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022034.Bytes);
public long this[int i]=>Value[i];

public static A022034Inst Instance=new A022034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022033
{
public static readonly long[] Value={ 1L,19L,236L,2426L,22407L,193305L,1591402L,12667072L,98321333L,748601711L,5614533288L,41608696038L,305407826179L,2224262385637L,16095911708294L,115865978983724L,830420169903345L,5930044765743483L,42217703190306820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022033Inst : IEnumerable<long>
{
public static readonly long[] Value=A022033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022033.Bytes);
public long this[int i]=>Value[i];

public static A022033Inst Instance=new A022033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022032
{
public static readonly long[] Value={ 5L,26L,135L,700L,3629L,18813L,97527L,505582L,2620947L,13587040L,70435478L,365138879L,1892887004L,9812762803L,50869551972L,263708740319L,1367071205166L,7086923541985L,36738748574433L,190454382472052L,987319198674433L,5118281802804775L,26533271760636405L,137548993480193164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022032Inst : IEnumerable<long>
{
public static readonly long[] Value=A022032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022032.Bytes);
public long this[int i]=>Value[i];

public static A022032Inst Instance=new A022032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022031
{
public static readonly long[] Value={ 4L,17L,72L,304L,1283L,5414L,22845L,96397L,406757L,1716352L,7242319L,30559689L,128949662L,544115986L,2295951781L,9687997993L,40879475731L,172495033261L,727860031657L,3071278144467L,12959565068034L,54684179957837L,230745362360740L,973653116715681L,4108426630946045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022031Inst : IEnumerable<long>
{
public static readonly long[] Value=A022031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022031.Bytes);
public long this[int i]=>Value[i];

public static A022031Inst Instance=new A022031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022030
{
public static readonly long[] Value={ 4L,16L,63L,249L,984L,3889L,15370L,60745L,240075L,948819L,3749901L,14820274L,58572352L,231488326L,914882931L,3615779646L,14290202610L,56477415835L,223208766625L,882160643536L,3486455360919L,13779090092886L,54457408494633L,215225339261149L,850608722312629L,3361756570848769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022030Inst : IEnumerable<long>
{
public static readonly long[] Value=A022030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022030.Bytes);
public long this[int i]=>Value[i];

public static A022030Inst Instance=new A022030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022013
{
public static readonly long[] Value={ 88793L,284723L,855713L,1146773L,6560993L,69156533L,74266253L,218033723L,261672773L,302542763L,964669613L,1340301863L,1400533223L,1422475913L,1837160183L,1962038783L,2117861723L,2249363093L,2272018733L,2558211563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022013Inst : IEnumerable<long>
{
public static readonly long[] Value=A022013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022013.Bytes);
public long this[int i]=>Value[i];

public static A022013Inst Instance=new A022013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022012
{
public static readonly long[] Value={ 17L,1277L,113147L,2580647L,20737877L,58208387L,73373537L,76170527L,100658627L,134764997L,137943347L,165531257L,171958667L,224008217L,252277007L,294536147L,309740987L,311725847L,364154027L,408936947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022012Inst : IEnumerable<long>
{
public static readonly long[] Value=A022012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022012.Bytes);
public long this[int i]=>Value[i];

public static A022012Inst Instance=new A022012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022011
{
public static readonly long[] Value={ 11L,15760091L,25658441L,93625991L,182403491L,226449521L,661972301L,910935911L,1042090781L,1071322781L,1170221861L,1394025161L,1459270271L,1712750771L,1742638811L,1935587651L,2048038451L,2397437501L,2799645461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022011Inst : IEnumerable<long>
{
public static readonly long[] Value=A022011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022011.Bytes);
public long this[int i]=>Value[i];

public static A022011Inst Instance=new A022011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022010
{
public static readonly long[] Value={ 5639L,88799L,284729L,626609L,855719L,1146779L,6560999L,7540439L,8573429L,17843459L,19089599L,24001709L,42981929L,43534019L,69156539L,74266259L,79208399L,80427029L,84104549L,87988709L,124066079L,128469149L,144214319L,157131419L,208729049L,218033729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022010Inst : IEnumerable<long>
{
public static readonly long[] Value=A022010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022010.Bytes);
public long this[int i]=>Value[i];

public static A022010Inst Instance=new A022010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022009
{
public static readonly long[] Value={ 11L,165701L,1068701L,11900501L,15760091L,18504371L,21036131L,25658441L,39431921L,45002591L,67816361L,86818211L,93625991L,124716071L,136261241L,140117051L,154635191L,162189101L,182403491L,186484211L,187029371L,190514321L,198453371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022009Inst : IEnumerable<long>
{
public static readonly long[] Value=A022009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022009.Bytes);
public long this[int i]=>Value[i];

public static A022009Inst Instance=new A022009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022008
{
public static readonly long[] Value={ 7L,97L,16057L,19417L,43777L,1091257L,1615837L,1954357L,2822707L,2839927L,3243337L,3400207L,6005887L,6503587L,7187767L,7641367L,8061997L,8741137L,10526557L,11086837L,11664547L,14520547L,14812867L,14834707L,14856757L,16025827L,16094707L,18916477L,19197247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022008Inst : IEnumerable<long>
{
public static readonly long[] Value=A022008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022008.Bytes);
public long this[int i]=>Value[i];

public static A022008Inst Instance=new A022008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022007
{
public static readonly long[] Value={ 7L,97L,1867L,3457L,5647L,15727L,16057L,19417L,43777L,79687L,88807L,101107L,257857L,266677L,276037L,284737L,340927L,354247L,375247L,402757L,419047L,427237L,463447L,470077L,626617L,666427L,736357L,823717L,855727L,959467L,978067L,1022377L,1043587L,1068247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022007Inst : IEnumerable<long>
{
public static readonly long[] Value=A022007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022007.Bytes);
public long this[int i]=>Value[i];

public static A022007Inst Instance=new A022007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022006
{
public static readonly long[] Value={ 5L,11L,101L,1481L,16061L,19421L,21011L,22271L,43781L,55331L,144161L,165701L,166841L,195731L,201821L,225341L,247601L,268811L,326141L,347981L,361211L,397751L,465161L,518801L,536441L,633461L,633791L,661091L,768191L,795791L,829721L,857951L,876011L,958541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022006Inst : IEnumerable<long>
{
public static readonly long[] Value=A022006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022006.Bytes);
public long this[int i]=>Value[i];

public static A022006Inst Instance=new A022006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022005
{
public static readonly long[] Value={ 7L,13L,37L,67L,97L,103L,193L,223L,277L,307L,457L,613L,823L,853L,877L,1087L,1297L,1423L,1447L,1483L,1663L,1693L,1783L,1867L,1873L,1993L,2083L,2137L,2377L,2683L,2707L,2797L,3163L,3253L,3457L,3463L,3847L,4153L,4513L,4783L,5227L,5413L,5437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022005Inst : IEnumerable<long>
{
public static readonly long[] Value=A022005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022005.Bytes);
public long this[int i]=>Value[i];

public static A022005Inst Instance=new A022005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022004
{
public static readonly long[] Value={ 5L,11L,17L,41L,101L,107L,191L,227L,311L,347L,461L,641L,821L,857L,881L,1091L,1277L,1301L,1427L,1481L,1487L,1607L,1871L,1997L,2081L,2237L,2267L,2657L,2687L,3251L,3461L,3527L,3671L,3917L,4001L,4127L,4517L,4637L,4787L,4931L,4967L,5231L,5477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022004Inst : IEnumerable<long>
{
public static readonly long[] Value=A022004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022004.Bytes);
public long this[int i]=>Value[i];

public static A022004Inst Instance=new A022004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022003
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022003Inst : IEnumerable<long>
{
public static readonly long[] Value=A022003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022003.Bytes);
public long this[int i]=>Value[i];

public static A022003Inst Instance=new A022003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022002
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,0L,0L,4L,0L,0L,8L,0L,1L,6L,0L,3L,2L,0L,6L,4L,1L,2L,8L,2L,5L,6L,5L,1L,3L,0L,2L,6L,0L,5L,2L,1L,0L,4L,2L,0L,8L,4L,1L,6L,8L,3L,3L,6L,6L,7L,3L,3L,4L,6L,6L,9L,3L,3L,8L,6L,7L,7L,3L,5L,4L,7L,0L,9L,4L,1L,8L,8L,3L,7L,6L,7L,5L,3L,5L,0L,7L,0L,1L,4L,0L,2L,8L,0L,5L,6L,1L,1L,2L,2L,2L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022002Inst : IEnumerable<long>
{
public static readonly long[] Value=A022002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022002.Bytes);
public long this[int i]=>Value[i];

public static A022002Inst Instance=new A022002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022001
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,3L,0L,0L,9L,0L,2L,7L,0L,8L,1L,2L,4L,3L,7L,3L,1L,1L,9L,3L,5L,8L,0L,7L,4L,2L,2L,2L,6L,6L,8L,0L,0L,4L,0L,1L,2L,0L,3L,6L,1L,0L,8L,3L,2L,4L,9L,7L,4L,9L,2L,4L,7L,7L,4L,3L,2L,2L,9L,6L,8L,9L,0L,6L,7L,2L,0L,1L,6L,0L,4L,8L,1L,4L,4L,4L,3L,3L,2L,9L,9L,8L,9L,9L,6L,9L,9L,0L,9L,7L,2L,9L,1L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022001Inst : IEnumerable<long>
{
public static readonly long[] Value=A022001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022001.Bytes);
public long this[int i]=>Value[i];

public static A022001Inst Instance=new A022001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022000
{
public static readonly long[] Value={ 1L,28L,533L,8648L,128889L,1824276L,24950461L,333078016L,4367420897L,56484732044L,722650676709L,9164986526904L,115404823162825L,1444532800672132L,17990818115880077L,223110488408176112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022000Inst : IEnumerable<long>
{
public static readonly long[] Value=A022000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022000.Bytes);
public long this[int i]=>Value[i];

public static A022000Inst Instance=new A022000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021999
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,5L,0L,2L,5L,1L,2L,5L,6L,2L,8L,1L,4L,0L,7L,0L,3L,5L,1L,7L,5L,8L,7L,9L,3L,9L,6L,9L,8L,4L,9L,2L,4L,6L,2L,3L,1L,1L,5L,5L,7L,7L,8L,8L,9L,4L,4L,7L,2L,3L,6L,1L,8L,0L,9L,0L,4L,5L,2L,2L,6L,1L,3L,0L,6L,5L,3L,2L,6L,6L,3L,3L,1L,6L,5L,8L,2L,9L,1L,4L,5L,7L,2L,8L,6L,4L,3L,2L,1L,6L,0L,8L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021999Inst : IEnumerable<long>
{
public static readonly long[] Value=A021999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021999.Bytes);
public long this[int i]=>Value[i];

public static A021999Inst Instance=new A021999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021998
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,6L,0L,3L,6L,2L,1L,7L,3L,0L,3L,8L,2L,2L,9L,3L,7L,6L,2L,5L,7L,5L,4L,5L,2L,7L,1L,6L,2L,9L,7L,7L,8L,6L,7L,2L,0L,3L,2L,1L,9L,3L,1L,5L,8L,9L,5L,3L,7L,2L,2L,3L,3L,4L,0L,0L,4L,0L,2L,4L,1L,4L,4L,8L,6L,9L,2L,1L,5L,2L,9L,1L,7L,5L,0L,5L,0L,3L,0L,1L,8L,1L,0L,8L,6L,5L,1L,9L,1L,1L,4L,6L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021998Inst : IEnumerable<long>
{
public static readonly long[] Value=A021998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021998.Bytes);
public long this[int i]=>Value[i];

public static A021998Inst Instance=new A021998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021981
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,3L,5L,4L,1L,4L,5L,3L,4L,2L,8L,8L,6L,3L,8L,6L,8L,9L,8L,6L,6L,9L,3L,9L,6L,1L,1L,0L,5L,4L,2L,4L,7L,6L,9L,7L,0L,3L,1L,7L,2L,9L,7L,8L,5L,0L,5L,6L,2L,9L,4L,7L,7L,9L,9L,3L,8L,5L,8L,7L,5L,1L,2L,7L,9L,4L,2L,6L,8L,1L,6L,7L,8L,6L,0L,7L,9L,8L,3L,6L,2L,3L,3L,3L,6L,7L,4L,5L,1L,3L,8L,1L,7L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021981Inst : IEnumerable<long>
{
public static readonly long[] Value=A021981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021981.Bytes);
public long this[int i]=>Value[i];

public static A021981Inst Instance=new A021981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021980
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021980Inst : IEnumerable<long>
{
public static readonly long[] Value=A021980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021980.Bytes);
public long this[int i]=>Value[i];

public static A021980Inst Instance=new A021980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021979
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021979Inst : IEnumerable<long>
{
public static readonly long[] Value=A021979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021979.Bytes);
public long this[int i]=>Value[i];

public static A021979Inst Instance=new A021979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021978
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,6L,6L,9L,4L,0L,4L,5L,1L,7L,4L,5L,3L,7L,9L,8L,7L,6L,7L,9L,6L,7L,1L,4L,5L,7L,9L,0L,5L,5L,4L,4L,1L,4L,7L,8L,4L,3L,9L,4L,2L,5L,0L,5L,1L,3L,3L,4L,7L,0L,2L,2L,5L,8L,7L,2L,6L,8L,9L,9L,3L,8L,3L,9L,8L,3L,5L,7L,2L,8L,9L,5L,2L,7L,7L,2L,0L,7L,3L,9L,2L,1L,9L,7L,1L,2L,5L,2L,5L,6L,6L,7L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021978Inst : IEnumerable<long>
{
public static readonly long[] Value=A021978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021978.Bytes);
public long this[int i]=>Value[i];

public static A021978Inst Instance=new A021978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021977
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,7L,7L,4L,9L,2L,2L,9L,1L,8L,8L,0L,7L,8L,1L,0L,8L,9L,4L,1L,4L,1L,8L,2L,9L,3L,9L,3L,6L,2L,7L,9L,5L,4L,7L,7L,9L,0L,3L,3L,9L,1L,5L,7L,2L,4L,5L,6L,3L,2L,0L,6L,5L,7L,7L,5L,9L,5L,0L,6L,6L,8L,0L,3L,6L,9L,9L,8L,9L,7L,2L,2L,5L,0L,7L,7L,0L,8L,1L,1L,9L,2L,1L,8L,9L,1L,0L,5L,8L,5L,8L,1L,7L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021977Inst : IEnumerable<long>
{
public static readonly long[] Value=A021977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021977.Bytes);
public long this[int i]=>Value[i];

public static A021977Inst Instance=new A021977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021976
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,8L,8L,0L,6L,5L,8L,4L,3L,6L,2L,1L,3L,9L,9L,1L,7L,6L,9L,5L,4L,7L,3L,2L,5L,1L,0L,2L,8L,8L,0L,6L,5L,8L,4L,3L,6L,2L,1L,3L,9L,9L,1L,7L,6L,9L,5L,4L,7L,3L,2L,5L,1L,0L,2L,8L,8L,0L,6L,5L,8L,4L,3L,6L,2L,1L,3L,9L,9L,1L,7L,6L,9L,5L,4L,7L,3L,2L,5L,1L,0L,2L,8L,8L,0L,6L,5L,8L,4L,3L,6L,2L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021976Inst : IEnumerable<long>
{
public static readonly long[] Value=A021976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021976.Bytes);
public long this[int i]=>Value[i];

public static A021976Inst Instance=new A021976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021975
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,9L,8L,6L,6L,1L,1L,7L,4L,0L,4L,7L,3L,7L,3L,8L,4L,1L,4L,0L,0L,6L,1L,7L,9L,1L,9L,6L,7L,0L,4L,4L,2L,8L,4L,2L,4L,3L,0L,4L,8L,4L,0L,3L,7L,0L,7L,5L,1L,8L,0L,2L,2L,6L,5L,7L,0L,5L,4L,5L,8L,2L,9L,0L,4L,2L,2L,2L,4L,5L,1L,0L,8L,1L,3L,5L,9L,4L,2L,3L,2L,7L,4L,9L,7L,4L,2L,5L,3L,3L,4L,7L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021975Inst : IEnumerable<long>
{
public static readonly long[] Value=A021975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021975.Bytes);
public long this[int i]=>Value[i];

public static A021975Inst Instance=new A021975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021974
{
public static readonly long[] Value={ 1L,26L,459L,6916L,96005L,1270542L,16318303L,205487672L,2552951769L,31419668098L,384095637107L,4672689817068L,56644179720493L,684877363365494L,8264853578776071L,99595171342479904L,1198894417410885377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021974Inst : IEnumerable<long>
{
public static readonly long[] Value=A021974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021974.Bytes);
public long this[int i]=>Value[i];

public static A021974Inst Instance=new A021974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021973
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,1L,9L,9L,1L,7L,4L,4L,0L,6L,6L,0L,4L,7L,4L,7L,1L,6L,2L,0L,2L,2L,7L,0L,3L,8L,1L,8L,3L,6L,9L,4L,5L,3L,0L,4L,4L,3L,7L,5L,6L,4L,4L,9L,9L,4L,8L,4L,0L,0L,4L,1L,2L,7L,9L,6L,6L,9L,7L,6L,2L,6L,4L,1L,8L,9L,8L,8L,6L,4L,8L,0L,9L,0L,8L,1L,5L,2L,7L,3L,4L,7L,7L,8L,1L,2L,1L,7L,7L,5L,0L,2L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021973Inst : IEnumerable<long>
{
public static readonly long[] Value=A021973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021973.Bytes);
public long this[int i]=>Value[i];

public static A021973Inst Instance=new A021973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021972
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,3L,0L,5L,7L,8L,5L,1L,2L,3L,9L,6L,6L,9L,4L,2L,1L,4L,8L,7L,6L,0L,3L,3L,0L,5L,7L,8L,5L,1L,2L,3L,9L,6L,6L,9L,4L,2L,1L,4L,8L,7L,6L,0L,3L,3L,0L,5L,7L,8L,5L,1L,2L,3L,9L,6L,6L,9L,4L,2L,1L,4L,8L,7L,6L,0L,3L,3L,0L,5L,7L,8L,5L,1L,2L,3L,9L,6L,6L,9L,4L,2L,1L,4L,8L,7L,6L,0L,3L,3L,0L,5L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021972Inst : IEnumerable<long>
{
public static readonly long[] Value=A021972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021972.Bytes);
public long this[int i]=>Value[i];

public static A021972Inst Instance=new A021972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021971
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,4L,1L,2L,6L,1L,6L,3L,3L,9L,1L,9L,3L,3L,8L,1L,5L,9L,2L,5L,5L,4L,2L,9L,1L,6L,2L,3L,5L,7L,8L,0L,7L,6L,5L,2L,5L,3L,3L,6L,0L,9L,1L,0L,0L,3L,1L,0L,2L,3L,7L,8L,4L,9L,0L,1L,7L,5L,8L,0L,1L,4L,4L,7L,7L,7L,6L,6L,2L,8L,7L,4L,8L,7L,0L,7L,3L,4L,2L,2L,9L,5L,7L,6L,0L,0L,8L,2L,7L,3L,0L,0L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021971Inst : IEnumerable<long>
{
public static readonly long[] Value=A021971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021971.Bytes);
public long this[int i]=>Value[i];

public static A021971Inst Instance=new A021971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021970
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,5L,1L,9L,6L,6L,8L,7L,3L,7L,0L,6L,0L,0L,4L,1L,4L,0L,7L,8L,6L,7L,4L,9L,4L,8L,2L,4L,0L,1L,6L,5L,6L,3L,1L,4L,6L,9L,9L,7L,9L,2L,9L,6L,0L,6L,6L,2L,5L,2L,5L,8L,7L,9L,9L,1L,7L,1L,8L,4L,2L,6L,5L,0L,1L,0L,3L,5L,1L,9L,6L,6L,8L,7L,3L,7L,0L,6L,0L,0L,4L,1L,4L,0L,7L,8L,6L,7L,4L,9L,4L,8L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021970Inst : IEnumerable<long>
{
public static readonly long[] Value=A021970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021970.Bytes);
public long this[int i]=>Value[i];

public static A021970Inst Instance=new A021970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021969
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,6L,2L,6L,9L,4L,3L,0L,0L,5L,1L,8L,1L,3L,4L,7L,1L,5L,0L,2L,5L,9L,0L,6L,7L,3L,5L,7L,5L,1L,2L,9L,5L,3L,3L,6L,7L,8L,7L,5L,6L,4L,7L,6L,6L,8L,3L,9L,3L,7L,8L,2L,3L,8L,3L,4L,1L,9L,6L,8L,9L,1L,1L,9L,1L,7L,0L,9L,8L,4L,4L,5L,5L,9L,5L,8L,5L,4L,9L,2L,2L,2L,7L,9L,7L,9L,2L,7L,4L,6L,1L,1L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021969Inst : IEnumerable<long>
{
public static readonly long[] Value=A021969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021969.Bytes);
public long this[int i]=>Value[i];

public static A021969Inst Instance=new A021969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021968
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,7L,3L,4L,4L,3L,9L,8L,3L,4L,0L,2L,4L,8L,9L,6L,2L,6L,5L,5L,6L,0L,1L,6L,5L,9L,7L,5L,1L,0L,3L,7L,3L,4L,4L,3L,9L,8L,3L,4L,0L,2L,4L,8L,9L,6L,2L,6L,5L,5L,6L,0L,1L,6L,5L,9L,7L,5L,1L,0L,3L,7L,3L,4L,4L,3L,9L,8L,3L,4L,0L,2L,4L,8L,9L,6L,2L,6L,5L,5L,6L,0L,1L,6L,5L,9L,7L,5L,1L,0L,3L,7L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021968Inst : IEnumerable<long>
{
public static readonly long[] Value=A021968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021968.Bytes);
public long this[int i]=>Value[i];

public static A021968Inst Instance=new A021968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021967
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,8L,4L,2L,1L,5L,9L,9L,1L,6L,9L,2L,6L,2L,7L,2L,0L,6L,6L,4L,5L,8L,9L,8L,2L,3L,4L,6L,8L,3L,2L,8L,1L,4L,1L,2L,2L,5L,3L,3L,7L,4L,8L,7L,0L,1L,9L,7L,3L,0L,0L,1L,0L,3L,8L,4L,2L,1L,5L,9L,9L,1L,6L,9L,2L,6L,2L,7L,2L,0L,6L,6L,4L,5L,8L,9L,8L,2L,3L,4L,6L,8L,3L,2L,8L,1L,4L,1L,2L,2L,5L,3L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021967Inst : IEnumerable<long>
{
public static readonly long[] Value=A021967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021967.Bytes);
public long this[int i]=>Value[i];

public static A021967Inst Instance=new A021967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021966
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L,0L,3L,9L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021966Inst : IEnumerable<long>
{
public static readonly long[] Value=A021966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021966.Bytes);
public long this[int i]=>Value[i];

public static A021966Inst Instance=new A021966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021949
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L,0L,5L,8L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021949Inst : IEnumerable<long>
{
public static readonly long[] Value=A021949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021949.Bytes);
public long this[int i]=>Value[i];

public static A021949Inst Instance=new A021949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021948
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021948Inst : IEnumerable<long>
{
public static readonly long[] Value=A021948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021948.Bytes);
public long this[int i]=>Value[i];

public static A021948Inst Instance=new A021948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021947
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,0L,4L,4L,5L,3L,8L,7L,0L,6L,2L,5L,6L,6L,2L,7L,7L,8L,3L,6L,6L,9L,1L,4L,1L,0L,3L,9L,2L,3L,6L,4L,7L,9L,3L,2L,1L,3L,1L,4L,9L,5L,2L,2L,7L,9L,9L,5L,7L,5L,8L,2L,1L,8L,4L,5L,1L,7L,4L,9L,7L,3L,4L,8L,8L,8L,6L,5L,3L,2L,3L,4L,3L,5L,8L,4L,3L,0L,5L,4L,0L,8L,2L,7L,1L,4L,7L,4L,0L,1L,9L,0L,8L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021947Inst : IEnumerable<long>
{
public static readonly long[] Value=A021947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021947.Bytes);
public long this[int i]=>Value[i];

public static A021947Inst Instance=new A021947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021946
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,1L,5L,7L,1L,1L,2L,5L,2L,6L,5L,3L,9L,2L,7L,8L,1L,3L,1L,6L,3L,4L,8L,1L,9L,5L,3L,2L,9L,0L,8L,7L,0L,4L,8L,8L,3L,2L,2L,7L,1L,7L,6L,2L,2L,0L,8L,0L,6L,7L,9L,4L,0L,5L,5L,2L,0L,1L,6L,9L,8L,5L,1L,3L,8L,0L,0L,4L,2L,4L,6L,2L,8L,4L,5L,0L,1L,0L,6L,1L,5L,7L,1L,1L,2L,5L,2L,6L,5L,3L,9L,2L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021946Inst : IEnumerable<long>
{
public static readonly long[] Value=A021946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021946.Bytes);
public long this[int i]=>Value[i];

public static A021946Inst Instance=new A021946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021945
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,2L,6L,9L,9L,2L,5L,6L,1L,1L,0L,5L,2L,0L,7L,2L,2L,6L,3L,5L,4L,9L,4L,1L,5L,5L,1L,5L,4L,0L,9L,1L,3L,9L,2L,1L,3L,6L,0L,2L,5L,5L,0L,4L,7L,8L,2L,1L,4L,6L,6L,5L,2L,4L,9L,7L,3L,4L,3L,2L,5L,1L,8L,5L,9L,7L,2L,3L,6L,9L,8L,1L,9L,3L,4L,1L,1L,2L,6L,4L,6L,1L,2L,1L,1L,4L,7L,7L,1L,5L,1L,9L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021945Inst : IEnumerable<long>
{
public static readonly long[] Value=A021945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021945.Bytes);
public long this[int i]=>Value[i];

public static A021945Inst Instance=new A021945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021944
{
public static readonly long[] Value={ 1L,25L,425L,6185L,83241L,1072425L,13462825L,166325545L,2034167081L,24716438825L,299050134825L,3608230161705L,43455812660521L,522726247165225L,6282767285808425L,75473627419962665L,906326894688267561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021944Inst : IEnumerable<long>
{
public static readonly long[] Value=A021944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021944.Bytes);
public long this[int i]=>Value[i];

public static A021944Inst Instance=new A021944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021943
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,4L,9L,6L,2L,7L,2L,6L,3L,0L,4L,5L,7L,9L,3L,3L,9L,7L,2L,3L,1L,0L,9L,6L,9L,1L,1L,6L,0L,8L,0L,9L,3L,7L,1L,6L,7L,1L,9L,9L,1L,4L,8L,0L,2L,9L,8L,1L,8L,9L,5L,6L,3L,3L,6L,5L,2L,8L,2L,2L,1L,5L,1L,2L,2L,4L,7L,0L,7L,1L,3L,5L,2L,5L,0L,2L,6L,6L,2L,4L,0L,6L,8L,1L,5L,7L,6L,1L,4L,4L,8L,3L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021943Inst : IEnumerable<long>
{
public static readonly long[] Value=A021943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021943.Bytes);
public long this[int i]=>Value[i];

public static A021943Inst Instance=new A021943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021942
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,6L,0L,9L,8L,0L,8L,1L,0L,2L,3L,4L,5L,4L,1L,5L,7L,7L,8L,2L,5L,1L,5L,9L,9L,1L,4L,7L,1L,2L,1L,5L,3L,5L,1L,8L,1L,2L,3L,6L,6L,7L,3L,7L,7L,3L,9L,8L,7L,2L,0L,6L,8L,2L,3L,0L,2L,7L,7L,1L,8L,5L,5L,0L,1L,0L,6L,6L,0L,9L,8L,0L,8L,1L,0L,2L,3L,4L,5L,4L,1L,5L,7L,7L,8L,2L,5L,1L,5L,9L,9L,1L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021942Inst : IEnumerable<long>
{
public static readonly long[] Value=A021942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021942.Bytes);
public long this[int i]=>Value[i];

public static A021942Inst Instance=new A021942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021941
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,7L,2L,3L,5L,8L,5L,9L,1L,2L,4L,8L,6L,6L,5L,9L,5L,5L,1L,7L,6L,0L,9L,3L,9L,1L,6L,7L,5L,5L,6L,0L,2L,9L,8L,8L,2L,6L,0L,4L,0L,5L,5L,4L,9L,6L,2L,6L,4L,6L,7L,4L,4L,9L,3L,0L,6L,2L,9L,6L,6L,9L,1L,5L,6L,8L,8L,3L,6L,7L,1L,2L,9L,1L,3L,5L,5L,3L,8L,9L,5L,4L,1L,0L,8L,8L,5L,8L,0L,5L,7L,6L,3L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021941Inst : IEnumerable<long>
{
public static readonly long[] Value=A021941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021941.Bytes);
public long this[int i]=>Value[i];

public static A021941Inst Instance=new A021941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021940
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L,0L,6L,8L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021940Inst : IEnumerable<long>
{
public static readonly long[] Value=A021940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021940.Bytes);
public long this[int i]=>Value[i];

public static A021940Inst Instance=new A021940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021939
{
public static readonly long[] Value={ 0L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L,0L,6L,9L,5L,1L,8L,7L,1L,6L,5L,7L,7L,5L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021939Inst : IEnumerable<long>
{
public static readonly long[] Value=A021939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021939.Bytes);
public long this[int i]=>Value[i];

public static A021939Inst Instance=new A021939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021938
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,0L,6L,6L,3L,8L,1L,1L,5L,6L,3L,1L,6L,9L,1L,6L,4L,8L,8L,2L,2L,2L,6L,9L,8L,0L,7L,2L,8L,0L,5L,1L,3L,9L,1L,8L,6L,2L,9L,5L,5L,0L,3L,2L,1L,1L,9L,9L,1L,4L,3L,4L,6L,8L,9L,5L,0L,7L,4L,9L,4L,6L,4L,6L,6L,8L,0L,9L,4L,2L,1L,8L,4L,1L,5L,4L,1L,7L,5L,5L,8L,8L,8L,6L,5L,0L,9L,6L,3L,5L,9L,7L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021938Inst : IEnumerable<long>
{
public static readonly long[] Value=A021938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021938.Bytes);
public long this[int i]=>Value[i];

public static A021938Inst Instance=new A021938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021937
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,1L,8L,1L,1L,3L,6L,1L,2L,0L,0L,4L,2L,8L,7L,2L,4L,5L,4L,4L,4L,8L,0L,1L,7L,1L,4L,8L,9L,8L,1L,7L,7L,9L,2L,0L,6L,8L,5L,9L,5L,9L,2L,7L,1L,1L,6L,8L,2L,7L,4L,3L,8L,3L,7L,0L,8L,4L,6L,7L,3L,0L,9L,7L,5L,3L,4L,8L,3L,3L,8L,6L,9L,2L,3L,9L,0L,1L,3L,9L,3L,3L,5L,4L,7L,6L,9L,5L,6L,0L,5L,5L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021937Inst : IEnumerable<long>
{
public static readonly long[] Value=A021937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021937.Bytes);
public long this[int i]=>Value[i];

public static A021937Inst Instance=new A021937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021936
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,2L,9L,6L,1L,3L,7L,3L,3L,9L,0L,5L,5L,7L,9L,3L,9L,9L,1L,4L,1L,6L,3L,0L,9L,0L,1L,2L,8L,7L,5L,5L,3L,6L,4L,8L,0L,6L,8L,6L,6L,9L,5L,2L,7L,8L,9L,6L,9L,9L,5L,7L,0L,8L,1L,5L,4L,5L,0L,6L,4L,3L,7L,7L,6L,8L,2L,4L,0L,3L,4L,3L,3L,4L,7L,6L,3L,9L,4L,8L,4L,9L,7L,8L,5L,4L,0L,7L,7L,2L,5L,3L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021936Inst : IEnumerable<long>
{
public static readonly long[] Value=A021936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021936.Bytes);
public long this[int i]=>Value[i];

public static A021936Inst Instance=new A021936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021935
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,4L,1L,1L,3L,8L,5L,6L,0L,6L,8L,7L,4L,3L,2L,8L,6L,7L,8L,8L,3L,9L,9L,5L,7L,0L,3L,5L,4L,4L,5L,7L,5L,7L,2L,5L,0L,2L,6L,8L,5L,2L,8L,4L,6L,4L,0L,1L,7L,1L,8L,5L,8L,2L,1L,6L,9L,7L,0L,9L,9L,8L,9L,2L,5L,8L,8L,6L,1L,4L,3L,9L,3L,1L,2L,5L,6L,7L,1L,3L,2L,1L,1L,6L,0L,0L,4L,2L,9L,6L,4L,5L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021935Inst : IEnumerable<long>
{
public static readonly long[] Value=A021935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021935.Bytes);
public long this[int i]=>Value[i];

public static A021935Inst Instance=new A021935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021934
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021934Inst : IEnumerable<long>
{
public static readonly long[] Value=A021934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021934.Bytes);
public long this[int i]=>Value[i];

public static A021934Inst Instance=new A021934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021917
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,5L,2L,9L,0L,2L,5L,1L,9L,1L,6L,7L,5L,7L,9L,4L,0L,8L,5L,4L,3L,2L,6L,3L,9L,6L,4L,9L,5L,0L,7L,1L,1L,9L,3L,8L,6L,6L,3L,7L,4L,5L,8L,9L,2L,6L,6L,1L,5L,5L,5L,3L,1L,2L,1L,5L,7L,7L,2L,1L,7L,9L,6L,2L,7L,6L,0L,1L,3L,1L,4L,3L,4L,8L,3L,0L,2L,3L,0L,0L,1L,0L,9L,5L,2L,9L,0L,2L,5L,1L,9L,1L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021917Inst : IEnumerable<long>
{
public static readonly long[] Value=A021917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021917.Bytes);
public long this[int i]=>Value[i];

public static A021917Inst Instance=new A021917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021916
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021916Inst : IEnumerable<long>
{
public static readonly long[] Value=A021916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021916.Bytes);
public long this[int i]=>Value[i];

public static A021916Inst Instance=new A021916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021915
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,7L,6L,9L,4L,8L,4L,0L,8L,3L,4L,2L,4L,8L,0L,7L,9L,0L,3L,4L,0L,2L,8L,5L,4L,0L,0L,6L,5L,8L,6L,1L,6L,9L,0L,4L,5L,0L,0L,5L,4L,8L,8L,4L,7L,4L,2L,0L,4L,1L,7L,1L,2L,4L,0L,3L,9L,5L,1L,7L,0L,1L,4L,2L,7L,0L,0L,3L,2L,9L,3L,0L,8L,4L,5L,2L,2L,5L,0L,2L,7L,4L,4L,2L,3L,7L,1L,0L,2L,0L,8L,5L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021915Inst : IEnumerable<long>
{
public static readonly long[] Value=A021915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021915.Bytes);
public long this[int i]=>Value[i];

public static A021915Inst Instance=new A021915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021914
{
public static readonly long[] Value={ 1L,23L,355L,4635L,55371L,627243L,6866155L,73433195L,772592491L,8032358763L,82776456555L,847393109355L,8630981813611L,87566313375083L,885715453576555L,8937574526027115L,90019110908986731L,905338057186084203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021914Inst : IEnumerable<long>
{
public static readonly long[] Value=A021914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021914.Bytes);
public long this[int i]=>Value[i];

public static A021914Inst Instance=new A021914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021913
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021913Inst : IEnumerable<long>
{
public static readonly long[] Value=A021913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021913.Bytes);
public long this[int i]=>Value[i];

public static A021913Inst Instance=new A021913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021912
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,3L,2L,1L,5L,8L,5L,9L,0L,3L,0L,8L,3L,7L,0L,0L,4L,4L,0L,5L,2L,8L,6L,3L,4L,3L,6L,1L,2L,3L,3L,4L,8L,0L,1L,7L,6L,2L,1L,1L,4L,5L,3L,7L,4L,4L,4L,9L,3L,3L,9L,2L,0L,7L,0L,4L,8L,4L,5L,8L,1L,4L,9L,7L,7L,9L,7L,3L,5L,6L,8L,2L,8L,1L,9L,3L,8L,3L,2L,5L,9L,9L,1L,1L,8L,9L,4L,2L,7L,3L,1L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021912Inst : IEnumerable<long>
{
public static readonly long[] Value=A021912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021912.Bytes);
public long this[int i]=>Value[i];

public static A021912Inst Instance=new A021912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021911
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,5L,3L,5L,8L,3L,2L,4L,1L,4L,5L,5L,3L,4L,7L,2L,9L,8L,7L,8L,7L,2L,1L,0L,5L,8L,4L,3L,4L,3L,9L,9L,1L,1L,7L,9L,7L,1L,3L,3L,4L,0L,6L,8L,3L,5L,7L,2L,2L,1L,6L,0L,9L,7L,0L,2L,3L,1L,5L,3L,2L,5L,2L,4L,8L,0L,7L,0L,5L,6L,2L,2L,9L,3L,2L,7L,4L,5L,3L,1L,4L,2L,2L,2L,7L,1L,2L,2L,3L,8L,1L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021911Inst : IEnumerable<long>
{
public static readonly long[] Value=A021911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021911.Bytes);
public long this[int i]=>Value[i];

public static A021911Inst Instance=new A021911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021910
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,3L,7L,5L,2L,7L,5L,9L,3L,8L,1L,8L,9L,8L,4L,5L,4L,7L,4L,6L,1L,3L,6L,8L,6L,5L,3L,4L,2L,1L,6L,3L,3L,5L,5L,4L,0L,8L,3L,8L,8L,5L,2L,0L,9L,7L,1L,3L,0L,2L,4L,2L,8L,2L,5L,6L,0L,7L,0L,6L,4L,0L,1L,7L,6L,6L,0L,0L,4L,4L,1L,5L,0L,1L,1L,0L,3L,7L,5L,2L,7L,5L,9L,3L,8L,1L,8L,9L,8L,4L,5L,4L,7L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021910Inst : IEnumerable<long>
{
public static readonly long[] Value=A021910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021910.Bytes);
public long this[int i]=>Value[i];

public static A021910Inst Instance=new A021910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021909
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,4L,9L,7L,2L,3L,7L,5L,6L,9L,0L,6L,0L,7L,7L,3L,4L,8L,0L,6L,6L,2L,9L,8L,3L,4L,2L,5L,4L,1L,4L,3L,6L,4L,6L,4L,0L,8L,8L,3L,9L,7L,7L,9L,0L,0L,5L,5L,2L,4L,8L,6L,1L,8L,7L,8L,4L,5L,3L,0L,3L,8L,6L,7L,4L,0L,3L,3L,1L,4L,9L,1L,7L,1L,2L,7L,0L,7L,1L,8L,2L,3L,2L,0L,4L,4L,1L,9L,8L,8L,9L,5L,0L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021909Inst : IEnumerable<long>
{
public static readonly long[] Value=A021909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021909.Bytes);
public long this[int i]=>Value[i];

public static A021909Inst Instance=new A021909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021908
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,6L,1L,9L,4L,6L,9L,0L,2L,6L,5L,4L,8L,6L,7L,2L,5L,6L,6L,3L,7L,1L,6L,8L,1L,4L,1L,5L,9L,2L,9L,2L,0L,3L,5L,3L,9L,8L,2L,3L,0L,0L,8L,8L,4L,9L,5L,5L,7L,5L,2L,2L,1L,2L,3L,8L,9L,3L,8L,0L,5L,3L,0L,9L,7L,3L,4L,5L,1L,3L,2L,7L,4L,3L,3L,6L,2L,8L,3L,1L,8L,5L,8L,4L,0L,7L,0L,7L,9L,6L,4L,6L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021908Inst : IEnumerable<long>
{
public static readonly long[] Value=A021908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021908.Bytes);
public long this[int i]=>Value[i];

public static A021908Inst Instance=new A021908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021907
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,7L,4L,1L,9L,7L,1L,2L,0L,7L,0L,8L,7L,4L,8L,6L,1L,5L,7L,2L,5L,3L,5L,9L,9L,1L,1L,4L,0L,6L,4L,2L,3L,0L,3L,4L,3L,3L,0L,0L,1L,1L,0L,7L,4L,1L,9L,7L,1L,2L,0L,7L,0L,8L,7L,4L,8L,6L,1L,5L,7L,2L,5L,3L,5L,9L,9L,1L,1L,4L,0L,6L,4L,2L,3L,0L,3L,4L,3L,3L,0L,0L,1L,1L,0L,7L,4L,1L,9L,7L,1L,2L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021907Inst : IEnumerable<long>
{
public static readonly long[] Value=A021907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021907.Bytes);
public long this[int i]=>Value[i];

public static A021907Inst Instance=new A021907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021906
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L,4L,5L,0L,1L,1L,0L,8L,6L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021906Inst : IEnumerable<long>
{
public static readonly long[] Value=A021906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021906.Bytes);
public long this[int i]=>Value[i];

public static A021906Inst Instance=new A021906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021905
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,9L,8L,7L,7L,9L,1L,3L,4L,2L,9L,5L,2L,2L,7L,5L,2L,4L,9L,7L,2L,2L,5L,3L,0L,5L,2L,1L,6L,4L,2L,6L,1L,9L,3L,1L,1L,8L,7L,5L,6L,9L,3L,6L,7L,3L,6L,9L,5L,8L,9L,3L,4L,5L,1L,7L,2L,0L,3L,1L,0L,7L,6L,5L,8L,1L,5L,7L,6L,0L,2L,6L,6L,3L,7L,0L,6L,9L,9L,2L,2L,3L,0L,8L,5L,4L,6L,0L,5L,9L,9L,3L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021905Inst : IEnumerable<long>
{
public static readonly long[] Value=A021905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021905.Bytes);
public long this[int i]=>Value[i];

public static A021905Inst Instance=new A021905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021904
{
public static readonly long[] Value={ 1L,22L,323L,3992L,44949L,478074L,4896391L,48839164L,477813017L,4606751006L,43913627979L,414851195616L,3890711480605L,36272898564418L,336508406905487L,3108995652410948L,28624326520414113L,262765886779943910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021904Inst : IEnumerable<long>
{
public static readonly long[] Value=A021904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021904.Bytes);
public long this[int i]=>Value[i];

public static A021904Inst Instance=new A021904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021903
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,3L,4L,7L,0L,5L,2L,2L,8L,0L,3L,1L,1L,4L,5L,7L,1L,7L,4L,6L,3L,8L,4L,8L,7L,2L,0L,8L,0L,0L,8L,8L,9L,8L,7L,7L,6L,4L,1L,8L,2L,4L,2L,4L,9L,1L,6L,5L,7L,3L,9L,7L,1L,0L,7L,8L,9L,7L,6L,6L,4L,0L,7L,1L,1L,9L,0L,2L,1L,1L,3L,4L,5L,9L,3L,9L,9L,3L,3L,2L,5L,9L,1L,7L,6L,8L,6L,3L,1L,8L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021903Inst : IEnumerable<long>
{
public static readonly long[] Value=A021903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021903.Bytes);
public long this[int i]=>Value[i];

public static A021903Inst Instance=new A021903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021902
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,3L,5L,8L,5L,7L,4L,6L,1L,0L,2L,4L,4L,9L,8L,8L,8L,6L,4L,1L,4L,2L,5L,3L,8L,9L,7L,5L,5L,0L,1L,1L,1L,3L,5L,8L,5L,7L,4L,6L,1L,0L,2L,4L,4L,9L,8L,8L,8L,6L,4L,1L,4L,2L,5L,3L,8L,9L,7L,5L,5L,0L,1L,1L,1L,3L,5L,8L,5L,7L,4L,6L,1L,0L,2L,4L,4L,9L,8L,8L,8L,6L,4L,1L,4L,2L,5L,3L,8L,9L,7L,5L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021902Inst : IEnumerable<long>
{
public static readonly long[] Value=A021902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021902.Bytes);
public long this[int i]=>Value[i];

public static A021902Inst Instance=new A021902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021901
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,4L,8L,2L,7L,2L,0L,1L,7L,8L,3L,7L,2L,3L,5L,2L,2L,8L,5L,3L,9L,5L,7L,6L,3L,6L,5L,6L,6L,3L,3L,2L,2L,1L,8L,5L,0L,6L,1L,3L,1L,5L,4L,9L,6L,0L,9L,8L,1L,0L,4L,7L,9L,3L,7L,5L,6L,9L,6L,7L,6L,7L,0L,0L,1L,1L,1L,4L,8L,2L,7L,2L,0L,1L,7L,8L,3L,7L,2L,3L,5L,2L,2L,8L,5L,3L,9L,5L,7L,6L,3L,6L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021901Inst : IEnumerable<long>
{
public static readonly long[] Value=A021901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021901.Bytes);
public long this[int i]=>Value[i];

public static A021901Inst Instance=new A021901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021900
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,6L,0L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021900Inst : IEnumerable<long>
{
public static readonly long[] Value=A021900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021900.Bytes);
public long this[int i]=>Value[i];

public static A021900Inst Instance=new A021900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021899
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,7L,3L,1L,8L,4L,3L,5L,7L,5L,4L,1L,8L,9L,9L,4L,4L,1L,3L,4L,0L,7L,8L,2L,1L,2L,2L,9L,0L,5L,0L,2L,7L,9L,3L,2L,9L,6L,0L,8L,9L,3L,8L,5L,4L,7L,4L,8L,6L,0L,3L,3L,5L,1L,9L,5L,5L,3L,0L,7L,2L,6L,2L,5L,6L,9L,8L,3L,2L,4L,0L,2L,2L,3L,4L,6L,3L,6L,8L,7L,1L,5L,0L,8L,3L,7L,9L,8L,8L,8L,2L,6L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021899Inst : IEnumerable<long>
{
public static readonly long[] Value=A021899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021899.Bytes);
public long this[int i]=>Value[i];

public static A021899Inst Instance=new A021899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021898
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,8L,5L,6L,8L,2L,3L,2L,6L,6L,2L,1L,9L,2L,3L,9L,3L,7L,3L,6L,0L,1L,7L,8L,9L,7L,0L,9L,1L,7L,2L,2L,5L,9L,5L,0L,7L,8L,2L,9L,9L,7L,7L,6L,2L,8L,6L,3L,5L,3L,4L,6L,7L,5L,6L,1L,5L,2L,1L,2L,5L,2L,7L,9L,6L,4L,2L,0L,5L,8L,1L,6L,5L,5L,4L,8L,0L,9L,8L,4L,3L,4L,0L,0L,4L,4L,7L,4L,2L,7L,2L,9L,3L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021898Inst : IEnumerable<long>
{
public static readonly long[] Value=A021898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021898.Bytes);
public long this[int i]=>Value[i];

public static A021898Inst Instance=new A021898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021897
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,9L,8L,2L,0L,8L,2L,8L,6L,6L,7L,4L,1L,3L,2L,1L,3L,8L,8L,5L,7L,7L,8L,2L,7L,5L,4L,7L,5L,9L,2L,3L,8L,5L,2L,1L,8L,3L,6L,5L,0L,6L,1L,5L,9L,0L,1L,4L,5L,5L,7L,6L,7L,0L,7L,7L,2L,6L,7L,6L,3L,7L,1L,7L,8L,0L,5L,1L,5L,1L,1L,7L,5L,8L,1L,1L,8L,7L,0L,1L,0L,0L,7L,8L,3L,8L,7L,4L,5L,8L,0L,0L,6L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021897Inst : IEnumerable<long>
{
public static readonly long[] Value=A021897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021897.Bytes);
public long this[int i]=>Value[i];

public static A021897Inst Instance=new A021897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021896
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,0L,7L,6L,2L,3L,3L,1L,8L,3L,8L,5L,6L,5L,0L,2L,2L,4L,2L,1L,5L,2L,4L,6L,6L,3L,6L,7L,7L,1L,3L,0L,0L,4L,4L,8L,4L,3L,0L,4L,9L,3L,2L,7L,3L,5L,4L,2L,6L,0L,0L,8L,9L,6L,8L,6L,0L,9L,8L,6L,5L,4L,7L,0L,8L,5L,2L,0L,1L,7L,9L,3L,7L,2L,1L,9L,7L,3L,0L,9L,4L,1L,7L,0L,4L,0L,3L,5L,8L,7L,4L,4L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021896Inst : IEnumerable<long>
{
public static readonly long[] Value=A021896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021896.Bytes);
public long this[int i]=>Value[i];

public static A021896Inst Instance=new A021896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021895
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,0L,0L,1L,1L,2L,2L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021895Inst : IEnumerable<long>
{
public static readonly long[] Value=A021895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021895.Bytes);
public long this[int i]=>Value[i];

public static A021895Inst Instance=new A021895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021894
{
public static readonly long[] Value={ 1L,24L,393L,5536L,72513L,914088L,11282041L,137597232L,1666743345L,20110305592L,242090763369L,2910464426688L,34963222353697L,419822302356936L,5039713424985177L,60489483108391504L,725964257087306769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021894Inst : IEnumerable<long>
{
public static readonly long[] Value=A021894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021894.Bytes);
public long this[int i]=>Value[i];

public static A021894Inst Instance=new A021894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021893
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,8L,5L,9L,3L,9L,2L,5L,7L,5L,9L,2L,8L,0L,0L,8L,9L,9L,8L,8L,7L,5L,1L,4L,0L,6L,0L,7L,4L,2L,4L,0L,7L,1L,9L,9L,1L,0L,0L,1L,1L,2L,4L,8L,5L,9L,3L,9L,2L,5L,7L,5L,9L,2L,8L,0L,0L,8L,9L,9L,8L,8L,7L,5L,1L,4L,0L,6L,0L,7L,4L,2L,4L,0L,7L,1L,9L,9L,1L,0L,0L,1L,1L,2L,4L,8L,5L,9L,3L,9L,2L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021893Inst : IEnumerable<long>
{
public static readonly long[] Value=A021893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021893.Bytes);
public long this[int i]=>Value[i];

public static A021893Inst Instance=new A021893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021892
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021892Inst : IEnumerable<long>
{
public static readonly long[] Value=A021892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021892.Bytes);
public long this[int i]=>Value[i];

public static A021892Inst Instance=new A021892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021891
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,7L,3L,9L,5L,7L,1L,5L,8L,9L,6L,2L,7L,9L,5L,9L,4L,1L,3L,7L,5L,4L,2L,2L,7L,7L,3L,3L,9L,3L,4L,6L,1L,1L,0L,4L,8L,4L,7L,8L,0L,1L,5L,7L,8L,3L,5L,4L,0L,0L,2L,2L,5L,4L,7L,9L,1L,4L,3L,1L,7L,9L,2L,5L,5L,9L,1L,8L,8L,2L,7L,5L,0L,8L,4L,5L,5L,4L,6L,7L,8L,6L,9L,2L,2L,2L,0L,9L,6L,9L,5L,6L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021891Inst : IEnumerable<long>
{
public static readonly long[] Value=A021891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021891.Bytes);
public long this[int i]=>Value[i];

public static A021891Inst Instance=new A021891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021890
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,8L,6L,6L,8L,1L,7L,1L,5L,5L,7L,5L,6L,2L,0L,7L,6L,7L,4L,9L,4L,3L,5L,6L,6L,5L,9L,1L,4L,2L,2L,1L,2L,1L,8L,9L,6L,1L,6L,2L,5L,2L,8L,2L,1L,6L,7L,0L,4L,2L,8L,8L,9L,3L,9L,0L,5L,1L,9L,1L,8L,7L,3L,5L,8L,9L,1L,6L,4L,7L,8L,5L,5L,5L,3L,0L,4L,7L,4L,0L,4L,0L,6L,3L,2L,0L,5L,4L,1L,7L,6L,0L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021890Inst : IEnumerable<long>
{
public static readonly long[] Value=A021890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021890.Bytes);
public long this[int i]=>Value[i];

public static A021890Inst Instance=new A021890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021889
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,9L,9L,4L,3L,5L,0L,2L,8L,2L,4L,8L,5L,8L,7L,5L,7L,0L,6L,2L,1L,4L,6L,8L,9L,2L,6L,5L,5L,3L,6L,7L,2L,3L,1L,6L,3L,8L,4L,1L,8L,0L,7L,9L,0L,9L,6L,0L,4L,5L,1L,9L,7L,7L,4L,0L,1L,1L,2L,9L,9L,4L,3L,5L,0L,2L,8L,2L,4L,8L,5L,8L,7L,5L,7L,0L,6L,2L,1L,4L,6L,8L,9L,2L,6L,5L,5L,3L,6L,7L,2L,3L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021889Inst : IEnumerable<long>
{
public static readonly long[] Value=A021889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021889.Bytes);
public long this[int i]=>Value[i];

public static A021889Inst Instance=new A021889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021888
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,1L,2L,2L,1L,7L,1L,9L,4L,5L,7L,0L,1L,3L,5L,7L,4L,6L,6L,0L,6L,3L,3L,4L,8L,4L,1L,6L,2L,8L,9L,5L,9L,2L,7L,6L,0L,1L,8L,0L,9L,9L,5L,4L,7L,5L,1L,1L,3L,1L,2L,2L,1L,7L,1L,9L,4L,5L,7L,0L,1L,3L,5L,7L,4L,6L,6L,0L,6L,3L,3L,4L,8L,4L,1L,6L,2L,8L,9L,5L,9L,2L,7L,6L,0L,1L,8L,0L,9L,9L,5L,4L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021888Inst : IEnumerable<long>
{
public static readonly long[] Value=A021888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021888.Bytes);
public long this[int i]=>Value[i];

public static A021888Inst Instance=new A021888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021887
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,2L,5L,0L,2L,8L,3L,1L,2L,5L,7L,0L,7L,8L,1L,4L,2L,6L,9L,5L,3L,5L,6L,7L,3L,8L,3L,9L,1L,8L,4L,5L,9L,7L,9L,6L,1L,4L,9L,4L,9L,0L,3L,7L,3L,7L,2L,5L,9L,3L,4L,3L,1L,4L,8L,3L,5L,7L,8L,7L,0L,8L,9L,4L,6L,7L,7L,2L,3L,6L,6L,9L,3L,0L,9L,1L,7L,3L,2L,7L,2L,9L,3L,3L,1L,8L,2L,3L,3L,2L,9L,5L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021887Inst : IEnumerable<long>
{
public static readonly long[] Value=A021887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021887.Bytes);
public long this[int i]=>Value[i];

public static A021887Inst Instance=new A021887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021886
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,3L,7L,8L,6L,8L,4L,8L,0L,7L,2L,5L,6L,2L,3L,5L,8L,2L,7L,6L,6L,4L,3L,9L,9L,0L,9L,2L,9L,7L,0L,5L,2L,1L,5L,4L,1L,9L,5L,0L,1L,1L,3L,3L,7L,8L,6L,8L,4L,8L,0L,7L,2L,5L,6L,2L,3L,5L,8L,2L,7L,6L,6L,4L,3L,9L,9L,0L,9L,2L,9L,7L,0L,5L,2L,1L,5L,4L,1L,9L,5L,0L,1L,1L,3L,3L,7L,8L,6L,8L,4L,8L,0L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021886Inst : IEnumerable<long>
{
public static readonly long[] Value=A021886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021886.Bytes);
public long this[int i]=>Value[i];

public static A021886Inst Instance=new A021886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021869
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,6L,0L,6L,9L,3L,6L,4L,1L,6L,1L,8L,4L,9L,7L,1L,0L,9L,8L,2L,6L,5L,8L,9L,5L,9L,5L,3L,7L,5L,7L,2L,2L,5L,4L,3L,3L,5L,2L,6L,0L,1L,1L,5L,6L,0L,6L,9L,3L,6L,4L,1L,6L,1L,8L,4L,9L,7L,1L,0L,9L,8L,2L,6L,5L,8L,9L,5L,9L,5L,3L,7L,5L,7L,2L,2L,5L,4L,3L,3L,5L,2L,6L,0L,1L,1L,5L,6L,0L,6L,9L,3L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021869Inst : IEnumerable<long>
{
public static readonly long[] Value=A021869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021869.Bytes);
public long this[int i]=>Value[i];

public static A021869Inst Instance=new A021869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021868
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021868Inst : IEnumerable<long>
{
public static readonly long[] Value=A021868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021868.Bytes);
public long this[int i]=>Value[i];

public static A021868Inst Instance=new A021868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021867
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,8L,7L,4L,8L,5L,5L,1L,5L,6L,4L,3L,1L,0L,5L,4L,4L,6L,1L,1L,8L,1L,9L,2L,3L,5L,2L,2L,5L,9L,5L,5L,9L,6L,7L,5L,5L,5L,0L,4L,0L,5L,5L,6L,1L,9L,9L,3L,0L,4L,7L,5L,0L,8L,6L,9L,0L,6L,1L,4L,1L,3L,6L,7L,3L,2L,3L,2L,9L,0L,8L,4L,5L,8L,8L,6L,4L,4L,2L,6L,4L,1L,9L,4L,6L,6L,9L,7L,5L,6L,6L,6L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021867Inst : IEnumerable<long>
{
public static readonly long[] Value=A021867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021867.Bytes);
public long this[int i]=>Value[i];

public static A021867Inst Instance=new A021867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021866
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,0L,0L,9L,2L,8L,0L,7L,4L,2L,4L,5L,9L,3L,9L,6L,7L,5L,1L,7L,4L,0L,1L,3L,9L,2L,1L,1L,1L,3L,6L,8L,9L,0L,9L,5L,1L,2L,7L,6L,1L,0L,2L,0L,8L,8L,1L,6L,7L,0L,5L,3L,3L,6L,4L,2L,6L,9L,1L,4L,1L,5L,3L,1L,3L,2L,2L,5L,0L,5L,8L,0L,0L,4L,6L,4L,0L,3L,7L,1L,2L,2L,9L,6L,9L,8L,3L,7L,5L,8L,7L,0L,0L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021866Inst : IEnumerable<long>
{
public static readonly long[] Value=A021866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021866.Bytes);
public long this[int i]=>Value[i];

public static A021866Inst Instance=new A021866Inst();

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